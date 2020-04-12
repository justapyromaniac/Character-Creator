using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class ItemContainer : Equipment
    {
        public string Capacity { get; private set; }

        public string Info { get; private set; }

        public string ContainerType { get; set; }

        private ItemContainer(string name, double cost, double weight, string containerType, string capacity, string info, int amount = 1) : base(name, cost, weight, amount)
        {
            ContainerType = containerType;
            Capacity = capacity;
            Info = info;
        }

        public ItemContainer()
        {

        }

        #region "Methods"

        #region "Overridden methods"

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> ContainerList = new List<Equipment>
            {
                    new ItemContainer("Backpack", 2, 5, "Inventory item", "20 Kg", "can strap items to bottom, sides or back"),
                    new ItemContainer("Barrel", 2, 70, "Inventory item", "158,99 L", null),
                    new ItemContainer("Basket", 0.4, 2, "Inventory item", "20 Kg", null),
                    new ItemContainer("Bottle, glass", 2, 2, "Liquid container", "330 mL", null),
                    new ItemContainer("Bucket", 0.05, 2, "Liquid container", "10 L", null),
                    new ItemContainer("Chest", 5, 25, "Liquid container", "136 Kg", null),
                    new ItemContainer("Flask or tankard", 0.02, 1, "Liquid container", "330 mL", null),
                    new ItemContainer("Jug or pitcher", 0.02, 4, "Liquid container", "1 L", null),
                    new ItemContainer("Pouch", 0.5, 1, "Inventory item", "5 Kg", null),
                    new ItemContainer("Sack", 0.01, 0.5, "Inventory item", "15 Kg", null),
                    new ItemContainer("Vial", 1, 0, "Liquid container", "10 mL", null),
                    new ItemContainer("Waterskin", 0.2, 0, "Liquid container", "4 L", null)
                };
            return ContainerList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = null;
            foreach (ItemContainer itemContainer in FillEquipmentList())
            {
                if (name == itemContainer.Name)
                {
                    output = new ItemContainer(itemContainer.Name, itemContainer.Cost, itemContainer.Weight, itemContainer.ContainerType, itemContainer.Capacity, itemContainer.Info, amount);
                }
            }
            return output;
        }

        #endregion "Overridden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Capacity (for one): {Capacity}");
            output.AppendLine($"{Info}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
