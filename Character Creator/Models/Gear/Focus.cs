using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Focus : Equipment
    {
        public string Description { get; private set; }

        public string Info { get; private set; }

        public string FocusType { get; set; }

        private Focus(string name, double cost, double weight, string focusType, string info) : base(name, cost, weight)
        {
            Description = "replaces one item for spellcasting that doesn’t have a cost and if the item isn’t consumed by the spell, only one focus can be used";
            Info = info;
            FocusType = focusType;
        }

        public Focus()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> FocusList = new List<Equipment>
            {
                    new Focus("Crystal", 10, 1, "Arcane Focus", "Usable by Warlock, Wizard, Sorcerer"),
                    new Focus("Orb", 20, 3, "Arcane Focus", "Usable by Warlock, Wizard, Sorcerer"),
                    new Focus("Rod", 10, 2, "Arcane Focus", "Usable by Warlock, Wizard, Sorcerer"),
                    new Focus("Staff", 5, 4, "Arcane Focus", "Usable by Warlock, Wizard, Sorcererr"),
                    new Focus("Wand", 10, 1, "Arcane Focus", "Usable by Warlock, Wizard, Sorcerer"),
                    new Focus("Sprig of mistletoe", 1, 0, "Druidic Focus", "Usable by Druid"),
                    new Focus("Totem", 1, 0, "Druidic Focus", "Usable by Druid"),
                    new Focus("Wooden staff", 5, 4, "Druidic Focus", "Usable by Druid"),
                    new Focus("Yew wand", 10, 1, "Druidic Focus", "Usable by Druid"),
                    new Focus("Amulet", 5, 1, "Holy Symbol", "Usable by Cleric, Paladin"),
                    new Focus("Emblem", 5, 0, "Holy Symbol", "Usable by Cleric, Paladin"),
                    new Focus("Reliquary", 5, 2, "Holy Symbol", "Usable by Cleric, Paladin")
                };
            return FocusList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = null;
            foreach (Focus focus in FillEquipmentList())
            {
                if (name == focus.Name)
                {
                    output = new Focus(focus.Name, focus.Cost, focus.Weight, focus.FocusType, focus.Info);
                }
            }
            return output;
        }

        #endregion "Overriden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type: {FocusType}");
            output.AppendLine($"Focus class: {Info}");
            output.AppendLine($"{Description}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
