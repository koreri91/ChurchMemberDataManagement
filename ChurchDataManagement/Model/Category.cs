using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class Category
    {

        private int id;
        private string categoryName;
        private string description;

        public Category(string categoryName, string description)
        {
            this.Id = id;
            this.CategoryName = categoryName;
            this.Description = description;
        }
        public Category(int id, string categoryName, string description)
        {
            this.Id = id;
            this.CategoryName = categoryName;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
    }


}
