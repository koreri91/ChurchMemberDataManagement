using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class Profession
    {
        private int id;
        private string title;
        private string description;
        public Profession() { 
        }

        public Profession(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        public Profession(int id, string title, string description)
        {
            this.id = id;
            this.title = title;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }
}
