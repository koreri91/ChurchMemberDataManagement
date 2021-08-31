using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class Category
    {

        private int id;
        private string category_name;
        private string description;

        public Category(string category_name, string description)
        {
            this.Id = id;
            this.CategoryName = category_name;
            this.Description = description;
        }
        public Category(int id, string category_name, string description)
        {
            this.Id = id;
            this.CategoryName = category_name;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string CategoryName { get => category_name; set => category_name = value; }
        public string Description { get => description; set => description = value; }
    }


}
