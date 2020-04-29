using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public class Feature
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Info { get; set; }

        public Feature(string name, string description, string info)
        {
            Name = name;
            Description = description;
            Info = info;
        }

        public enum BarbarianFeatureKeys { Frenzy }

        public static Dictionary<BarbarianFeatureKeys, Feature> BarbarianFeatures = new Dictionary<BarbarianFeatureKeys, Feature>
        {
            //Path of the Berserker
            { BarbarianFeatureKeys.Frenzy, new Feature("Frenzy", "Rage even harder than you could before to attack even more enemies.",
                "You can go into a frenzy when you rage. " +
                "If you do so, for the duration of your rage you can make a single melee weapon attack as a bonus action on each of your turns after this one. " +
                "When your rage ends, you suffer one level of exhaustion.")}
        };

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name {Name}");
            output.AppendLine($"Description: {Description}");
            output.AppendLine($"Info: {Info}");
            return output.ToString();
        }
    }
}
