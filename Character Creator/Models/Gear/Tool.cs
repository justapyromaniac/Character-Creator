using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Tool : Equipment
    {
        private Tool(string name, double cost, double weight, string type) : base(name, cost, weight, type)
        {

        }

        public Tool()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public override List<Equipment> FillEquipmentList()
        {
            List<Equipment> ToolList = new List<Equipment>
            {
                    new Tool("Alchemist’s supplies", 50, 8, "Artisan’s tools"),
                    new Tool("Brewer’s supplies", 20, 9, "Artisan’s tools"),
                    new Tool("Calligrapher’s supplies", 10, 5, "Artisan’s tools"),
                    new Tool("Carpenter’s tools", 8, 6, "Artisan’s tools"),
                    new Tool("Cartographer’s tools", 15, 6, "Artisan’s tools"),
                    new Tool("Cobbler’s tools", 5, 5, "Artisan’s tools"),
                    new Tool("Cook’s utensils", 1, 8, "Artisan’s tools"),
                    new Tool("Glassblower’s tools", 30, 5, "Artisan’s tools"),
                    new Tool("Jeweler’s tools", 25, 2, "Artisan’s tools"),
                    new Tool("Leatherworker’s tools", 5, 5, "Artisan’s tools"),
                    new Tool("Mason’s tools", 10, 8, "Artisan’s tools"),
                    new Tool("Painter’s supplies", 10, 5, "Artisan’s tools"),
                    new Tool("Potter’s tools", 10, 3, "Artisan’s tools"),
                    new Tool("Smith’s tools", 20, 8, "Artisan’s tools"),
                    new Tool("Tinker’s tools", 50, 10, "Artisan’s tools"),
                    new Tool("Weaver’s tools", 1, 5, "Artisan’s tools"),
                    new Tool("Woodcarver’s tools", 1, 5, "Artisan’s tools"),
                    new Tool("Disguise kit", 25, 3, "Disguise kit"),
                    new Tool("Forgery kit", 15, 5, "Forgery kit"),
                    new Tool("Dice set", 0.1, 0, "Gaming set"),
                    new Tool("Dragonchess set", 1, 1.5, "Gaming set"),
                    new Tool("Playing card set", 0.5, 0, "Gaming set"),
                    new Tool("Three-Dragon Ante set", 1, 0, "Gaming set"),
                    new Tool("Herbalism kit", 5, 3, "Herbalism kit"),
                    new Tool("Bagpipes", 30, 6, "Musical instrument"),
                    new Tool("Drum", 6, 3, "Musical instrument"),
                    new Tool("Dulcimer", 25, 10, "Musical instrument"),
                    new Tool("Flute", 2, 1, "Musical instrument"),
                    new Tool("Lute", 35, 2, "Musical instrument"),
                    new Tool("Lyre", 30, 2, "Musical instrument"),
                    new Tool("Horn", 3, 2, "Musical instrument"),
                    new Tool("Pan Flute", 12, 2, "Musical instrument"),
                    new Tool("Shawm", 2, 1, "Musical instrument"),
                    new Tool("Viol", 30, 1, "Musical instrument"),
                    new Tool("Navigator’s tools", 25, 2, "Navigator’s tools"),
                    new Tool("Poisoner’s kit", 52, 2, "Poisoner’s kit"),
                    new Tool("Thieves’ tools", 25, 1, "Thieves’ tools")
                };
            return ToolList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = new Tool();
            foreach (Tool tool in FillEquipmentList())
            {
                if (name == tool.Name)
                {
                    output = new Tool(tool.Name, tool.Cost, tool.Weight, tool.Type);
                }
            }
            return output;
        }

        #endregion "Overridden methods"

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion "Methods"
    }
}
