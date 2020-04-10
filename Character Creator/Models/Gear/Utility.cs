using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Utility : Equipment
    {
        private Utility(string name, double cost, double weight, string type, int amount = 1) : base(name, cost, weight, type, amount)
        {

        }

        public Utility()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public override List<Equipment> FillEquipmentList()
        {
            List<Equipment> UtilityList = new List<Equipment>
            {
                    new Utility("Abacus", 2, 2, "Utility item"),
                    new Utility("Acid (vial)", 25, 1, "Single use combat item"),
                    new Utility("Alchemist’s fire (flask)", 50, 10, "Single use combat item"),
                    new Utility("Antitoxin (vial)", 50, 0, "Single use restoration item"),
                    new Utility("Ball bearings (bag of 1.000)", 1, 2, "Trap"),
                    new Utility("Bedroll", 1, 7, "Survival item"),
                    new Utility("Bell", 1, 0, "Survival item"),
                    new Utility("Blanket", 0.5, 3, "Survival item"),
                    new Utility("Block and tackle", 1, 5, "Kit"),
                    new Utility("Book", 25, 5, "Utility item"),
                    new Utility("Caltrops (bag of 20)", 1, 2, "Trap"),
                    new Utility("Candle", 0.01, 0, "Utility item"),
                    new Utility("Case, crossbow bolt", 1, 1, "Utility item"),
                    new Utility("Case (map or scroll)", 1, 1, "Utility item"),
                    new Utility("Censer", 0.1, 0.25, "Utility item"),
                    new Utility("Chain (2 meters)", 5, 10, "Utility item"),
                    new Utility("Chalk", 0.01, 0, "Utility item"),
                    new Utility("Climber’s kit", 25, 12, "kit"),
                    new Utility("Clothes, common", 0.5, 3, "Clothing"),
                    new Utility("Clothes, costume", 5, 4, "Clothing"),
                    new Utility("Clothes, fine", 15, 6, "Clothing"),
                    new Utility("Clothes, traveler’s", 2, 4, "Clothing"),
                    new Utility("Component pouch", 25, 2, "Utility item"),
                    new Utility("Crowbar", 2, 5, "Utility item"),
                    new Utility("Fishing tackle", 1, 4, "Kit"),
                    new Utility("Grappling hook", 2, 4, "Utility item"),
                    new Utility("Hammer", 1, 3, "Utility item"),
                    new Utility("Hammer, sledge", 2, 10, "Utility item"),
                    new Utility("Healer’s kit", 5, 3, "Kit"),
                    new Utility("Holy water (flask)", 25, 1, "Single use combat item"),
                    new Utility("Hourglass", 25, 1, "Utility item"),
                    new Utility("Hunting trap", 5, 25, "Trap"),
                    new Utility("Incense (1 block)", 4, 1, "Utility item"),
                    new Utility("Ink (30 mililiters bottle)", 10, 0, "Utility item"),
                    new Utility("Ink pen", 0.02, 0, "Utility item"),
                    new Utility("Ladder (10 foot)", 0.1, 25, "Utility item"),
                    new Utility("Lamp", 0.5, 1, "Utility item"),
                    new Utility("Lantern, bullseye", 10, 2, "Utility item"),
                    new Utility("Lantern, hooded", 2, 2, "Utility item"),
                    new Utility("Lock", 10, 1, "Utility item"),
                    new Utility("Magnifying glass", 100, 0, "Utility item"),
                    new Utility("Manacles", 2, 6, "Utility item"),
                    new Utility("Mess kit", 0.2, 1, "kit"),
                    new Utility("Mirror, steel", 5, 0.5, "Utility item"),
                    new Utility("Oil (flask)", 0.1, 1, "Utility item"),
                    new Utility("Paper (one sheet)", 0.2, 0, "Utility item"),
                    new Utility("Parchment (one sheet)", 0.1, 0, "Utility item"),
                    new Utility("Perfume (vial)", 5, 0, "Utility item"),
                    new Utility("Pick, miner’s", 2, 10, "Utility item"),
                    new Utility("Poison, basic (vial)", 100, 0, "Single use combat item"),
                    new Utility("Pole (2 meters)", 0.05, 7, "Utility item"),
                    new Utility("Piton", 0.05, 0.25, "Utility item"),
                    new Utility("Potion of healing", 50, 0.5, "Single use restoration item"),
                    new Utility("Quiver", 1, 1, "Utility item"),
                    new Utility("Ram, portable", 4, 35, "Utility item"),
                    new Utility("Rations (1 day)", 0.5, 2, "Utility item"),
                    new Utility("Robes", 1, 4, "Clothing"),
                    new Utility("Rope, hempen (10 meters)", 1, 10, "Utility item"),
                    new Utility("Rope, silk (10 meters)", 10, 5, "Utility item"),
                    new Utility("Scale, mercant’s", 5, 3, "Utility item"),
                    new Utility("Sealing wax", 0.5, 0, "Utility item"),
                    new Utility("Shovel", 2, 5, "Utility item"),
                    new Utility("Signal whistle", 0.05, 0, "Utility item"),
                    new Utility("Signet ring", 5, 0, "Utility item"),
                    new Utility("Soap", 0.02, 0, "Utility item"),
                    new Utility("Spellbook", 50, 3, "Utility item"),
                    new Utility("Spikes, iron (10)", 1, 5, "Utility item"),
                    new Utility("String (2 meters)", 0.1, 1, "Utility item"),
                    new Utility("Tent, two person", 2, 20, "Survival item"),
                    new Utility("Tinderbox", 0.5, 1, "Kit"),
                    new Utility("Torch", 0.01, 1, "Utility item"),
                    new Utility("Whetstone", 0.01, 1, "Utility item"),
                    new Utility("Knife", 0.01, 0, "Utility item")
                };
            return UtilityList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = new Utility();
            foreach (Utility utility in FillEquipmentList())
            {
                if (name == utility.Name)
                {
                    output = new Utility(utility.Name, utility.Cost, utility.Weight, utility.Type, amount);
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
