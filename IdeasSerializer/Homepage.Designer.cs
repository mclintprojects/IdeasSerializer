namespace IdeasSerializer
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryCbox = new System.Windows.Forms.ComboBox();
            this.difficultyCbox = new System.Windows.Forms.ComboBox();
            this.allIdeasTreeView = new System.Windows.Forms.TreeView();
            this.ideasCountLb = new System.Windows.Forms.Label();
            this.titleTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.descriptionTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.serializeBtn = new MetroFramework.Controls.MetroButton();
            this.newIdeasTb = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // categoryCbox
            // 
            this.categoryCbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCbox.FormattingEnabled = true;
            this.categoryCbox.Items.AddRange(new object[] {
            "Files",
            "Graphics and Multimedia",
            "Web",
            "Games",
            "Text",
            "Numbers",
            "Enterprise Applications",
            "Threading",
            "Networking",
            "Databases",
            ""});
            this.categoryCbox.Location = new System.Drawing.Point(440, 103);
            this.categoryCbox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCbox.Name = "categoryCbox";
            this.categoryCbox.Size = new System.Drawing.Size(288, 24);
            this.categoryCbox.TabIndex = 0;
            // 
            // difficultyCbox
            // 
            this.difficultyCbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficultyCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyCbox.FormattingEnabled = true;
            this.difficultyCbox.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Expert"});
            this.difficultyCbox.Location = new System.Drawing.Point(440, 189);
            this.difficultyCbox.Margin = new System.Windows.Forms.Padding(4);
            this.difficultyCbox.Name = "difficultyCbox";
            this.difficultyCbox.Size = new System.Drawing.Size(288, 24);
            this.difficultyCbox.TabIndex = 3;
            // 
            // allIdeasTreeView
            // 
            this.allIdeasTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.allIdeasTreeView.Location = new System.Drawing.Point(20, 81);
            this.allIdeasTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.allIdeasTreeView.Name = "allIdeasTreeView";
            this.allIdeasTreeView.Size = new System.Drawing.Size(409, 546);
            this.allIdeasTreeView.TabIndex = 12;
            this.allIdeasTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            this.allIdeasTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            // 
            // ideasCountLb
            // 
            this.ideasCountLb.AutoSize = true;
            this.ideasCountLb.Location = new System.Drawing.Point(16, 635);
            this.ideasCountLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ideasCountLb.Name = "ideasCountLb";
            this.ideasCountLb.Size = new System.Drawing.Size(122, 17);
            this.ideasCountLb.TabIndex = 16;
            this.ideasCountLb.Text = "Serialization index";
            // 
            // titleTb
            // 
            this.titleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.titleTb.CustomButton.Image = null;
            this.titleTb.CustomButton.Location = new System.Drawing.Point(263, 2);
            this.titleTb.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.titleTb.CustomButton.Name = "";
            this.titleTb.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.titleTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleTb.CustomButton.TabIndex = 1;
            this.titleTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleTb.CustomButton.UseSelectable = true;
            this.titleTb.CustomButton.Visible = false;
            this.titleTb.Lines = new string[0];
            this.titleTb.Location = new System.Drawing.Point(440, 135);
            this.titleTb.Margin = new System.Windows.Forms.Padding(4);
            this.titleTb.MaxLength = 32767;
            this.titleTb.Name = "titleTb";
            this.titleTb.PasswordChar = '\0';
            this.titleTb.PromptText = "Idea title";
            this.titleTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleTb.SelectedText = "";
            this.titleTb.SelectionLength = 0;
            this.titleTb.SelectionStart = 0;
            this.titleTb.ShortcutsEnabled = true;
            this.titleTb.Size = new System.Drawing.Size(289, 28);
            this.titleTb.TabIndex = 2;
            this.titleTb.UseSelectable = true;
            this.titleTb.WaterMark = "Idea title";
            this.titleTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(441, 167);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 17);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Difficulty";
            // 
            // descriptionTb
            // 
            this.descriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionTb.CustomButton.Image = null;
            this.descriptionTb.CustomButton.Location = new System.Drawing.Point(-37, 1);
            this.descriptionTb.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTb.CustomButton.Name = "";
            this.descriptionTb.CustomButton.Size = new System.Drawing.Size(325, 325);
            this.descriptionTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTb.CustomButton.TabIndex = 1;
            this.descriptionTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTb.CustomButton.UseSelectable = true;
            this.descriptionTb.CustomButton.Visible = false;
            this.descriptionTb.Lines = new string[0];
            this.descriptionTb.Location = new System.Drawing.Point(439, 301);
            this.descriptionTb.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTb.MaxLength = 32767;
            this.descriptionTb.Multiline = true;
            this.descriptionTb.Name = "descriptionTb";
            this.descriptionTb.PasswordChar = '\0';
            this.descriptionTb.PromptText = "Idea description";
            this.descriptionTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTb.SelectedText = "";
            this.descriptionTb.SelectionLength = 0;
            this.descriptionTb.SelectionStart = 0;
            this.descriptionTb.ShortcutsEnabled = true;
            this.descriptionTb.ShowClearButton = true;
            this.descriptionTb.Size = new System.Drawing.Size(289, 327);
            this.descriptionTb.TabIndex = 4;
            this.descriptionTb.UseSelectable = true;
            this.descriptionTb.WaterMark = "Idea description";
            this.descriptionTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(440, 81);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 17);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Category";
            // 
            // serializeBtn
            // 
            this.serializeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serializeBtn.BackColor = System.Drawing.Color.Salmon;
            this.serializeBtn.ForeColor = System.Drawing.Color.Silver;
            this.serializeBtn.Location = new System.Drawing.Point(440, 635);
            this.serializeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.serializeBtn.Name = "serializeBtn";
            this.serializeBtn.Size = new System.Drawing.Size(288, 28);
            this.serializeBtn.TabIndex = 24;
            this.serializeBtn.Text = "Add";
            this.serializeBtn.UseSelectable = true;
            this.serializeBtn.Click += new System.EventHandler(this.AddIdeaBtn_Click);
            // 
            // newIdeasTb
            // 
            this.newIdeasTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.newIdeasTb.CustomButton.Image = null;
            this.newIdeasTb.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.newIdeasTb.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.newIdeasTb.CustomButton.Name = "";
            this.newIdeasTb.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.newIdeasTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newIdeasTb.CustomButton.TabIndex = 1;
            this.newIdeasTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newIdeasTb.CustomButton.UseSelectable = true;
            this.newIdeasTb.CustomButton.Visible = false;
            this.newIdeasTb.Lines = new string[0];
            this.newIdeasTb.Location = new System.Drawing.Point(437, 221);
            this.newIdeasTb.Margin = new System.Windows.Forms.Padding(4);
            this.newIdeasTb.MaxLength = 32767;
            this.newIdeasTb.Multiline = true;
            this.newIdeasTb.Name = "newIdeasTb";
            this.newIdeasTb.PasswordChar = '\0';
            this.newIdeasTb.PromptText = "New ideas index";
            this.newIdeasTb.ReadOnly = true;
            this.newIdeasTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newIdeasTb.SelectedText = "";
            this.newIdeasTb.SelectionLength = 0;
            this.newIdeasTb.SelectionStart = 0;
            this.newIdeasTb.ShortcutsEnabled = true;
            this.newIdeasTb.ShowClearButton = true;
            this.newIdeasTb.Size = new System.Drawing.Size(289, 72);
            this.newIdeasTb.TabIndex = 25;
            this.newIdeasTb.UseSelectable = true;
            this.newIdeasTb.WaterMark = "New ideas index";
            this.newIdeasTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newIdeasTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 678);
            this.Controls.Add(this.newIdeasTb);
            this.Controls.Add(this.serializeBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.descriptionTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.ideasCountLb);
            this.Controls.Add(this.allIdeasTreeView);
            this.Controls.Add(this.difficultyCbox);
            this.Controls.Add(this.categoryCbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homepage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Ideas Serializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoryCbox;
        private System.Windows.Forms.ComboBox difficultyCbox;
        private System.Windows.Forms.TreeView allIdeasTreeView;
        private System.Windows.Forms.Label ideasCountLb;
        private MetroFramework.Controls.MetroTextBox titleTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox descriptionTb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton serializeBtn;
        private MetroFramework.Controls.MetroTextBox newIdeasTb;
    }
}

