using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours_work_PDD
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public string FullName { get; set; } 
        public string Description { get; set; }
        public Vehicle(string type, string mark, string model, string number, string fullName)
        {
            Type = type;
            Mark = mark;
            Model = model;
            Number = number;
            FullName = fullName;
            if (Mark != null && Model != null && Number != null) { Description = $"{Mark}, {Model}, {Number}"; }
        }
    }
}
