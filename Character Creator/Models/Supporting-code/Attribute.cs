using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public class Attribute
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        private double attributeValue;
        public double Value 
        { 
            get { return attributeValue; }
            private set
            {
                if (value > 20 || value <= 0)
                {
                    throw new Exception("Please input a value from 1 to 20");
                }
                else
                {
                    attributeValue = value;
                    Modifier = Math.Floor((value - 10) / 2);
                }
            }
        }

        public double Modifier { get; private set; }

        internal Attribute(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Description: {Description}");
            output.AppendLine($"Modifier: {Modifier}");
            output.AppendLine($"Value: {Value}");
            return output.ToString();
        }
    }
}
