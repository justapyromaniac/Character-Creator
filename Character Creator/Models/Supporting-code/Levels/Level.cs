using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public abstract class Level
    {
        public enum Classes { Barbarian }

        public int LevelNumber { get; protected set; }

        public int ProficiencyBonus { get; protected set; }

        public List<Feature> Features { get; }

        public Specialization Specialization { get; protected set; }

        protected Level(int levelNumber, int proficiencyBonus)
        {
            LevelNumber = levelNumber;
            ProficiencyBonus = proficiencyBonus;
            Features = new List<Feature>();
        }

        public static List<Specialization> GetSpecializationList(Classes characterClass)
        {
            List<Specialization> output = null;
            switch (characterClass)
            {
                case Classes.Barbarian:
                    output = BarbarianLevel.GetSpecializations();
                    break;
            }
            return output;
        }

        public static Specialization ChooseSpecialization(string pathName, Classes characterClass)
        {
            Specialization output = null;
            foreach (Specialization specialization in GetSpecializationList(characterClass))
            {
                if(specialization.Name == pathName)
                {
                    output = specialization;
                }
            }
            return output;
        }

        public string ListFeatures()
        {
            if(Features.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                foreach (Feature feature in Features)
                {
                    output.AppendLine($"{feature.Name}");
                }
                return output.ToString();
            }
            else
            {
                return "This level has no features";
            }
        }

        public Feature FindFeature(string name)
        {
            Feature output = null;
            {
                if(Features.Count != 0)
                {
                    foreach (Feature feature in Features)
                    {
                        if(feature.Name == name)
                        {
                            output = feature;
                        }
                    }
                }
            }
            return output;
        }

        public bool AddFeature(Feature input)
        {
            if(input == null)
            {
                return false;
            }
            else
            {
                if (Features.Contains(input))
                {
                    return false;
                }
                else
                {
                    Features.Add(input);
                    return true;
                }
            }
        }

        public bool RemoveFeature(Feature input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                if (Features.Contains(input))
                {
                    Features.Remove(input);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
