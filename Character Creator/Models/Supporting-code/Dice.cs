using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public class Dice
    {
        static Random Generator = new Random();

        public int Sides { get; set; }

        public int Amount { get; set; }


        public Dice(int amount, int sides)
        {
            Amount = amount;
            Sides = sides;
        }

        public Dice()
        {

        }

        public int DiceSides()
        {
            int DiceSide = 0;
            switch (Sides)
            {
                case 4:
                    DiceSide = 4;
                    break;
                case 6:
                    DiceSide = 6;
                    break;
                case 8:
                    DiceSide = 8;
                    break;
                case 10:
                    DiceSide = 10;
                    break;
                case 12:
                    DiceSide = 12;
                    break;
                case 20:
                    DiceSide = 20;
                    break;
                default:
                    DiceSide = Sides;
                    break;
            }
            return DiceSide;
        }

        private List<int> values = new List<int>();
        public string TossRemoveMin()
        {
            {
                for (int index = 0; index <= Amount - 1; index++)
                {
                    values.Add(Generator.Next(1, (Sides + 1)));
                }

                values.Remove(values.Min());
                string OutputString = string.Join(" + ", values.ToArray());
                int AddedValues = 0;
                for (int index = 0; index <= (Amount - 1); index++)
                {
                    AddedValues = values.Sum();
                }
                values.Clear();
                return $"{AddedValues}";
            }
        }

        public string Toss()
        {
            for (int index = 0; index <= Amount - 1; index++)
            {
                values.Add(Generator.Next(1, (Sides + 1)));
            }

            string OutputString = (values.Sum()).ToString();
            values.Clear();
            return OutputString;
        }


        public override string ToString()
        {
            return $"{Amount}D{Sides}";
        }
    }
}
