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
        public enum EquipmentTypes { Armour, Ammo, Focus, ItemContainer, Tool, Utility, Weapon }

        #region "Properties"

        public string Name { get; protected set; }

        public double Cost { get; protected set; }

        public double Weight { get; protected set; }

        public int Amount { get; protected set; }

        #endregion "Properties"

        #region "Constructor"

        public Equipment(string name, double cost, double weight, int amount = 1)
        {
            Name = name;
            Amount = amount;
            Cost = cost * amount;
            Weight = weight * amount;
        }
        public Equipment()
        {

        }

        #endregion "Constructor"

        #region "Methods"

        #region "Methods GetProperty"

        public List<string> GetNames(EquipmentTypes type)
        {
            List<string> names = new List<string>();
            foreach (Equipment Equipment in GetEquipmentList(type))
            {
                names.Add(Equipment.Name);
            }
            return names;
        }

        public static List<Equipment> GetEquipmentList(EquipmentTypes type)
        {
            List<Equipment> output = null;
            switch (type)
            {
                case EquipmentTypes.Armour:
                    output = Armour.FillEquipmentList();
                    break;
                case EquipmentTypes.Ammo:
                    output = Ammo.FillEquipmentList();
                    break;
                case EquipmentTypes.Focus:
                    output = Focus.FillEquipmentList();
                    break;
                case EquipmentTypes.ItemContainer:
                    output = ItemContainer.FillEquipmentList();
                    break;
                case EquipmentTypes.Tool:
                    output = Tool.FillEquipmentList();
                    break;
                case EquipmentTypes.Utility:
                    output = Utility.FillEquipmentList();
                    break;
                case EquipmentTypes.Weapon:
                    output = Weapon.FillEquipmentList();
                    break;
            }
            return output;
        }

        #endregion "Methods GetProperty"

        #region "Abstract methods"

        public abstract Equipment GetEquipment(string name, int amount = 1);

        #endregion "Abstract methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Amount: {Amount}");
            output.AppendLine($"Cost: {CustomConvert.ConvertMoney(Cost)}");
            output.AppendLine($"Weight: {CustomConvert.ConvertWeight(Weight)}");
            return output.ToString();
        }

        #endregion "Methods"
    }
}
