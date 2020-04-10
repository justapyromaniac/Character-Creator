using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Pack
    {
        public string Name { get; private set; }

        public double Cost { get; private set; }

        public double Weight { get; private set; }

        public List<Equipment> Contents { get; }

        //private because gear cannot be made outside of the class
        private Pack(string name, double cost, List<Equipment> equipment)
        {
            Name = name;
            Cost = cost;
            Contents = new List<Equipment>();
            foreach (Equipment item in equipment)
            {
                AddEquipment(item);
                Weight += item.Weight;
            }
        }

        #region "Methods"

        #region "Methods EquipmentList"

        public string GiveContentsString()
        {
            StringBuilder output = new StringBuilder();
            if (Contents.Count != 0)
            {
                output.AppendLine("Contents: ");
                foreach (Equipment equipment in Contents)
                {
                    output.AppendLine($"{equipment.Name}");
                }
            }
            else
            {
                output.AppendLine("This pack has no contents");
            }
            return output.ToString();
        }

        public List<Equipment> GiveContentsList()
        {
            return Contents;
        }

        public Equipment FindContent(string name)
        {
            Equipment output = null;
            if (Contents.Count != 0)
            {
                foreach (Equipment equipment in Contents)
                {
                    if (name == equipment.Name)
                    {
                        output = equipment;
                    }
                }
            }
            return output;
        }

        //private because the list of contents should NOT be edited outside of the class
        private bool AddEquipment(Equipment input)
        {
            if (Contents.Contains(input))
            {
                return false;
            }
            else
            {
                if (input != null)
                {
                    Contents.Add(input);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //in case it becomes needed at some point
        private bool RemoveEquipment(Equipment input)
        {
            if (Contents.Contains(input))
            {
                if (input != null)
                {
                    Contents.Remove(input);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods EquipmentList"

        public static List<Pack> FillPackList()
        {
            Equipment container = new ItemContainer();
            Equipment utility = new Utility();
            Equipment tool = new Tool();
            Equipment weapon = new Weapon();

            List<Pack> PackList = new List<Pack>
            {
                    new Pack("Burglar's Pack", 16, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Ball bearings (bag of 1.000)", 1),
                        utility.GetEquipment("String (2 meters)", 1),
                        utility.GetEquipment("Bell", 1),
                        utility.GetEquipment("Candle", 5),
                        utility.GetEquipment("Crowbar", 1),
                        utility.GetEquipment("Hammer", 1),
                        utility.GetEquipment("Piton", 10),
                        utility.GetEquipment("Lantern, hooded", 1),
                        utility.GetEquipment("Oil (flask)", 2),
                        utility.GetEquipment("Rations (1 day)", 5),
                        utility.GetEquipment("Tinderbox", 1),
                        container.GetEquipment("Waterskin"),
                        utility.GetEquipment("Rope, hempen (10 meters)", 1)
                    }),
                    new Pack("Diplomat's Pack", 39, new List<Equipment>
                    {
                        container.GetEquipment("Chest"),
                        utility.GetEquipment("Case (map or scroll)", 2),
                        utility.GetEquipment("Clothes, fine", 1),
                        utility.GetEquipment("Ink (30 mililiters bottle)", 1),
                        utility.GetEquipment("Ink pen", 1),
                        utility.GetEquipment("Lamp", 1),
                        utility.GetEquipment("Oil (flask)", 2),
                        utility.GetEquipment("Paper (one sheet)", 5),
                        utility.GetEquipment("Perfume (vial)", 1),
                        utility.GetEquipment("Sealing wax", 1),
                        utility.GetEquipment("Soap", 1)
                    }),
                    new Pack("Dungeoneer's Pack", 12, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Crowbar", 1),
                        utility.GetEquipment("Hammer", 1),
                        utility.GetEquipment("Piton", 10),
                        utility.GetEquipment("Torch", 10),
                        utility.GetEquipment("Tinderbox", 1),
                        utility.GetEquipment("Rations (1 day)", 10),
                        container.GetEquipment("Waterskin"),
                        utility.GetEquipment("Rope, hempen (10 meters)", 1)
                    }),
                    new Pack("Entertainer's Pack", 40, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Bedroll", 1),
                        utility.GetEquipment("Clothes, costume", 2),
                        utility.GetEquipment("Candle", 5),
                        utility.GetEquipment("Rations (1 day)", 5),
                        container.GetEquipment("Waterskin"),
                        tool.GetEquipment("Disguise kit")
                    }),
                    new Pack("Explorer's Pack", 10, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Bedroll", 1),
                        utility.GetEquipment("Mess kit", 1),
                        utility.GetEquipment("Tinderbox", 1),
                        utility.GetEquipment("Torch", 10),
                        utility.GetEquipment("Rations (1 day)", 10),
                        container.GetEquipment("Waterskin"),
                        utility.GetEquipment("Rope, hempen (10 meters)", 1)
                    }),
                    new Pack("Priest's Pack", 19, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Blanket", 1),
                        utility.GetEquipment("Candle", 10),
                        utility.GetEquipment("Tinderbox", 1),
                        container.GetEquipment("Basket"),
                        utility.GetEquipment("Incense (1 block)", 2),
                        utility.GetEquipment("Censer", 1),
                        utility.GetEquipment("Clothes, common", 1),
                        utility.GetEquipment("Rations (1 day)", 2),
                        container.GetEquipment("Waterskin"),
                    }),
                    new Pack("Scholar's Pack", 40, new List<Equipment>
                    {
                        container.GetEquipment("Backpack"),
                        utility.GetEquipment("Book", 1),
                        utility.GetEquipment("Ink (30 mililiters bottle)", 1),
                        utility.GetEquipment("Ink pen", 1),
                        utility.GetEquipment("Parchment (one sheet)", 10),
                        container.GetEquipment("Pouch"),
                        utility.GetEquipment("Knife")
                    })
                };
            return PackList;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Cost: {CustomConvert.ConvertMoney(Cost)}");
            output.AppendLine("Contents: ");
            foreach (Equipment equipment in Contents)
            {
                output.AppendLine($"{equipment.Name}");
            }
            output.AppendLine($"Total weight: {CustomConvert.ConvertWeight(Weight)}");
            return output.ToString();
        }

        #endregion "Methods"
    }
}
