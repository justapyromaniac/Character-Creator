using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public class Specialization
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public Dictionary<int, Feature> Features { get; }

        public Specialization(string name, string description)
        {
            Name = name;
            Description = description;
            Features = new Dictionary<int, Feature>();
        }

        public string ListFeatures()
        {
            if (Features.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                foreach (KeyValuePair<int, Feature> item in Features)
                {
                    output.AppendLine(item.Value.Name);
                }
                return output.ToString();
            }
            else
            {
                return "This specialization has no features";
            }
        }

        public Feature FindFeature(int index)
        {
            Feature output = null;
            {
                if (Features.Count != 0)
                {
                    if(Features.ContainsKey(index))
                    {
                        output = Features[index];
                    }
                    else
                    {
                        throw new Exception("This key has no associated value!");
                    }
                }
                else
                {
                    throw new Exception("This specialization has no features");
                }
            }
            return output;
        }

        public bool AddFeature(KeyValuePair<int, Feature> input)
        {
            if (input.Value == null)
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
                    Features.Add(input.Key, input.Value);
                    return true;
                }
            }
        }

        public bool RemoveFeature(KeyValuePair<int, Feature> input)
        {
            if (input.Value == null)
            {
                return false;
            }
            else
            {
                if (Features.Contains(input))
                {
                    Features.Remove(input.Key);
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
