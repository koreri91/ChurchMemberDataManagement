using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class Education
    {
        private int id;
        private string educationLevel;
        private string description;

        public Education(string educationLevel, string description)
        {
            this.educationLevel = educationLevel;
            this.description = description;
        }

        public Education(int id, string educationLevel, string description)
        {
            this.id = id;
            this.educationLevel = educationLevel;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string EducationLevel { get => educationLevel; set => educationLevel = value; }
        public string Description { get => description; set => description = value; }
    }
}
