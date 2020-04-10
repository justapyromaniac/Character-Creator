using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public abstract class Equipment
    {
        #region "Properties"

        public string Name { get; protected set; }

        public double Cost { get; protected set; }

        public double Weight { get; protected set; }

        public string Type { get; protected set; }

        public int Amount { get; protected set; }

        #endregion "Properties"

        #region "Constructor"

        public Equipment(string name, double cost, double weight, string type, int amount = 1)
        {
            Name = name;
            Amount = amount;
            Cost = cost * amount;
            Weight = weight * amount;
            Type = type;
        }
        public Equipment()
        {

        }

        #endregion "Constructor"

        #region "Methods"

        #region "Methods GetProperty"

        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            foreach (Equipment Equipment in FillEquipmentList())
            {
                names.Add(Equipment.Name);
            }
            return names;
        }

        public static List<string> GetEquipmentTypes()
        {
            List<string> types = new List<string>
            {
                    "Armour",
                    "Ammo",
                    "Foci",
                    "Containers",
                    "Tools",
                    "Utilities",
                    "Weapons"
            };
            return types;
        }

        public static Equipment ToEquipment(string type)
        {
            Equipment output = null;
            switch (type)
            {
                case "Ammo":
                    {
                        output = new Ammo();
                    }
                    break;
                case "Armour":
                    {
                        output = new Armour();
                    }
                    break;
                case "Foci":
                    {
                        output = new Focus();
                    }
                    break;
                case "Containers":
                    {
                        output = new ItemContainer();
                    }
                    break;
                case "Tools":
                    {
                        output = new Tool();
                    }
                    break;
                case "Utilities":
                    {
                        output = new Utility();
                    }
                    break;
                case "Weapons":
                    {
                        output = new Weapon();
                    }
                    break;
                default:
                    throw new Exception("Please input a valid type of gear");
            }
            return output;
        }

        #endregion "Methods GetProperty"

        #region "Abstract methods"

        public abstract List<Equipment> FillEquipmentList();

        public abstract Equipment GetEquipment(string name, int amount = 1);

        #endregion "Abstract methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Type: {Type}");
            output.AppendLine($"Amount: {Amount}");
            output.AppendLine($"Cost: {CustomConvert.ConvertMoney(Cost)}");
            output.AppendLine($"Weight: {CustomConvert.ConvertWeight(Weight)}");
            return output.ToString();
        }

        #endregion "Methods"
    }
}
