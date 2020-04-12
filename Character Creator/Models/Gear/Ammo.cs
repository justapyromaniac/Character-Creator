using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Ammo : Equipment
    {
        public int AmmoCount { get; protected set; }

        public string AmmoType { get; protected set; }

        protected Ammo(string name, double cost, double weight, string ammoType, int ammouCount, int amount = 1) : base(name, cost, weight, amount)
        {
            AmmoCount = ammouCount * amount;
            AmmoType = ammoType;
        }
        public Ammo()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> AmmoList = new List<Equipment>
            {
                    new Ammo("Bundle of arrows", 1, 1, "Bow Ammunition", 20),
                    new Ammo("Bundle of blowgun needles", 10, 10, "Blowgun Ammunition", 50),
                    new Ammo("Bundle of crossbow bolts", 45, 13, "Crossbow Ammunition", 20),
                    new Ammo("Bundle of sling bullets", 10, 12, "Sling Ammunition", 20)
            };
            return AmmoList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = null;
            foreach (Ammo ammo in FillEquipmentList())
            {
                if (name == ammo.Name)
                {
                    output = new Ammo(ammo.Name, ammo.Cost, ammo.Weight, ammo.AmmoType, ammo.AmmoCount, amount);
                }
            }
            return output;
        }

        #endregion "Overriden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Ammo type: {AmmoType}");
            output.AppendLine($"Ammo count: {AmmoCount}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
