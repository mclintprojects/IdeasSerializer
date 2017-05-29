using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeasSerializer
{
    public partial class Homepage : MetroForm
    {
        private string prevDescription;
        private List<Category> allCategories = new List<Category>();
        private readonly string jsonPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.json");
        private readonly string newideasPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "newideastxt");

        public Homepage()
        {
            InitializeComponent();
            categoryCbox.SelectedIndex = 0;
            difficultyCbox.SelectedIndex = 0;
            SetupUI();
        }

        #region Event Handlers

        private void AddIdeaBtn_Click(object sender, EventArgs e)
        {
            AddIdea();
        }

        private void App_Closing(object sender, FormClosingEventArgs e)
        {
            if (allCategories != null)
                SerializeDB();
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                //removing a category
                allIdeasTreeView.Nodes.Remove(e.Node);
                allCategories.RemoveAt(e.Node.Index);
            }
            else
            {
                //removing a category item
                var parent = e.Node.Parent.Index;
                allCategories[parent].items.RemoveAt(e.Node.Index);
                if (e.Node.Parent.Nodes.Count == 0)
                    allIdeasTreeView.Nodes.Remove(e.Node.Parent);
                allIdeasTreeView.Nodes.Remove(e.Node);
                titleTb.Text = "";
                descriptionTb.Text = "";
            }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Checking if the clicked node is a category node or category idea node
            if (e.Node.Parent == null)
                HandleCategoryNodeClick(e);
            else
                HandleCategoryIdeaNodeClick(e);
        }

        #endregion Event Handlers

        private async Task SetupUI()
        {
            allCategories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText(jsonPath));
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            allIdeasTreeView.Nodes.Clear();
            for (var i = 0; i < allCategories.Count; i++)
            {
                allIdeasTreeView.Nodes.Add(allCategories[i].categoryLbl);
                foreach (var categoryIdea in allCategories[i].items)
                    allIdeasTreeView.Nodes[i].Nodes.Add(categoryIdea.title);
            }
        }

        private void SerializeDB()
        {
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(allCategories));
            File.WriteAllText(newideasPath, newIdeasTb.Text);
        }

        private void AddIdea()
        {
            var existingCategory = allCategories.FirstOrDefault(x => x.categoryLbl == categoryCbox.Text);
            if (existingCategory == null) // No existing category exists
                CreateNewCategoryAndAddIdea();
            else
                AddNewIdeaToExistingCategory();

            Task.Run(() => SerializeDB());
        }

        private void AddNewIdeaToExistingCategory()
        {
            var existingCategoryNode = allIdeasTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Text == categoryCbox.Text);
            var existingCategory = allCategories.FirstOrDefault(x => x.categoryLbl == categoryCbox.Text);
            var existingIdea = existingCategory.items.FirstOrDefault(x => x.title == titleTb.Text);

            if (existingIdea == null)
            {
                var newIdea = new CategoryItem()
                {
                    title = titleTb.Text,
                    description = descriptionTb.Text,
                    difficulty = difficultyCbox.Text,
                    category = categoryCbox.Text,
                    id = existingCategory.items.Count + 1
                };

                existingCategory.items.Add(newIdea);
                existingCategoryNode.Nodes.Add(newIdea.title);
                ++existingCategory.categoryCount;

                titleTb.Text = string.Empty;
                descriptionTb.Text = string.Empty;

                AddEntryToNewIdeasDB(existingCategory, newIdea);
            }
            else
            {
                var existingIdeaNode = existingCategoryNode.Nodes.OfType<TreeNode>().FirstOrDefault(node => node.Text == existingIdea.title);

                existingIdea.category = categoryCbox.Text;
                existingIdea.description = descriptionTb.Text;
                existingIdea.title = titleTb.Text;
                existingIdea.difficulty = difficultyCbox.Text;

                existingIdeaNode.Text = existingIdea.title;
            }
        }

        private void AddEntryToNewIdeasDB(Category existingCategory, CategoryItem newIdea)
        {
            var categoryIndex = allCategories.IndexOf(existingCategory);
            var ideaIndex = allCategories[categoryIndex].items.IndexOf(newIdea);
            newIdeasTb.AppendText($"{categoryIndex + 1}-{ideaIndex + 1},");
        }

        private void CreateNewCategoryAndAddIdea()
        {
            var newCategory = new Category() { categoryLbl = categoryCbox.Text };
            var newIdea = new CategoryItem()
            {
                title = titleTb.Text,
                description = descriptionTb.Text,
                difficulty = difficultyCbox.Text,
                category = categoryCbox.Text,
                id = 0
            };

            newCategory.items.Add(newIdea);
            newCategory.categoryCount = 1;
            allCategories.Add(newCategory);

            allIdeasTreeView.Nodes.Add(newCategory.categoryLbl);
            allIdeasTreeView.Nodes.OfType<TreeNode>().FirstOrDefault(x => x.Text == newCategory.categoryLbl).Nodes.Add(newIdea.title);

            AddEntryToNewIdeasDB(newCategory, newIdea);
        }

        private void HandleCategoryIdeaNodeClick(TreeNodeMouseClickEventArgs e)
        {
            var category = allCategories[e.Node.Parent.Index];

            // Set the category combo-box to the correct category
            categoryCbox.SelectedIndex = categoryCbox.Items.IndexOf(category.categoryLbl);
            var itemIndex = e.Node.Index;
            ideasCountLb.Text = $"This is idea {itemIndex + 1} in Category {e.Node.Parent.Index + 1}";
            var item = category.items[itemIndex];
            titleTb.Text = item.title;
            descriptionTb.Text = item.description;
            prevDescription = item.description;
            difficultyCbox.SelectedIndex = difficultyCbox.Items.IndexOf(item.difficulty);
        }

        private void HandleCategoryNodeClick(TreeNodeMouseClickEventArgs e)
        {
            var category = allCategories[e.Node.Index];
            categoryCbox.SelectedIndex = categoryCbox.Items.IndexOf(category.categoryLbl);
            titleTb.Text = "";
            descriptionTb.Text = "";
            ideasCountLb.Text = $"There are {category.items.Count()} ideas in this category.";
        }
    }
}