using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Armour : Equipment
    {
        public Dictionaries.ArmourTypes ArmourType { get; private set; }

        public string Extra { get; private set; }

        public string Info { get; private set; }

        public ArmourProficiency ArmourProficiency { get; private set; }

        private Armour(string name, double cost, double weight, Dictionaries.ArmourTypes armourType, string extra, string info) : base(name, cost, weight)
        {
            ArmourType = armourType;
            Extra = extra;
            Info = info;
            ArmourProficiency = Dictionaries.ArmourProficiencies[ArmourType];
        }

        public Armour()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> ArmourList = new List<Equipment>
            {
                new Armour("Padded armour", 5, 8, Dictionaries.ArmourTypes.Light, "11 + Dex mod", "Disadvantage in stealth"),
                new Armour("Leather armour", 10, 10, Dictionaries.ArmourTypes.Light, "11 + Dex mod", null),
                new Armour("Studded Leather", 45, 13, Dictionaries.ArmourTypes.Light, "12 + Dex mod", null),
                new Armour("Hide armour", 10, 12, Dictionaries.ArmourTypes.Medium, "12 + Dex mod (max +2)", null),
                new Armour("Chain Shirt", 50, 20, Dictionaries.ArmourTypes.Medium, "13 + Dex mod (max +2)", null),
                new Armour("Scale Mail", 50, 45, Dictionaries.ArmourTypes.Medium, "14 + Dex mod (max +2)", "Disadvantage in stealth"),
                new Armour("Breastplate", 400, 20, Dictionaries.ArmourTypes.Medium, "14 + Dex mod (max +2)", "Disadvantage in stealth"),
                new Armour("Half plate", 750, 40, Dictionaries.ArmourTypes.Medium, "15 + Dex mod (max +2)", "Disadvantage in stealth"),
                new Armour("Ring Mail", 30, 40, Dictionaries.ArmourTypes.Heavy, "14", "Disadvantage in stealth"),
                new Armour("Chain Mail", 75, 55, Dictionaries.ArmourTypes.Heavy, "16", "Disadvantage in stealth, Requires 13 strength"),
                new Armour("Splint mail", 200, 60, Dictionaries.ArmourTypes.Heavy, "17", "Disadvantage in stealth, Requires 15 strength"),
                new Armour("Plate armour", 1500, 65, Dictionaries.ArmourTypes.Heavy, "18", "Disadvantage in stealth, Requires 15 strength"),
                new Armour("Shield", 10, 6, Dictionaries.ArmourTypes.Shield, "+2", null)
            };
            return ArmourList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = null;
            foreach (Armour armour in FillEquipmentList())
            {
                if (name == armour.Name)
                {
                    output = new Armour(armour.Name, armour.Cost, armour.Weight, armour.ArmourType, armour.Extra, armour.Info);
                }
            }
            return output;
        }

        #endregion "Overriden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type/Required proficiency: {ArmourProficiency.Name}");
            output.AppendLine($"Armour class: {Extra}");
            output.AppendLine($"{Info}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
