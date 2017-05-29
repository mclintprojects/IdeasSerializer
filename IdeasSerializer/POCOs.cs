using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasSerializer
{
    public class Category
    {
        public string categoryLbl { get; set; }
        public int categoryCount { get; set; }
        public string description { get; set; }
        public List<CategoryItem> items { get; set; }
    }

    public class CategoryItem
    {
        public string category { get; set; }
        public string title { get; set; }
        public string difficulty { get; set; }
        public int id { get; set; }
        public string description { get; set; }
    }
}