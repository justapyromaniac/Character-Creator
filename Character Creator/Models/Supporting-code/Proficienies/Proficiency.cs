using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public abstract class Proficiency
    {
        public string Name { get; set; }

        public string Description { get; protected set; }

        protected Proficiency(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Description: {Description}");
            return output.ToString();
        }
    }
}
