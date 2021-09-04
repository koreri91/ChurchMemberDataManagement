using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class StatusInFamily
    {

        private int id;
        private string statusName;
        private string description;
        public StatusInFamily()
        {
        }
        public StatusInFamily(string statusName, string description)
        {
            this.statusName = statusName;
            this.description = description;
        }
        public StatusInFamily(int id, string statusName, string description)
        {
            this.id = id;
            this.statusName = statusName;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string StatusName { get => statusName; set => statusName = value; }
        public string Description { get => description; set => description = value; }
    }


}
