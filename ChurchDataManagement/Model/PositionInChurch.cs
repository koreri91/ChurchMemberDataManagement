using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDataManagement.Model
{
    public class PositionInChurch
    {

        private int id;
        private string positionName;
        private string description;

        public PositionInChurch()
        {
        }

        public PositionInChurch(string positionName, string description)
        {
            this.PositionName = positionName;
            this.Description = description;
        }

        public PositionInChurch(int id, string positionName, string description)
        {
            this.Id = id;
            this.PositionName = positionName;
            this.Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string PositionName { get => positionName; set => positionName = value; }
        public string Description { get => description; set => description = value; }
    }


}
