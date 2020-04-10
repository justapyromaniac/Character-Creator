using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public static class CustomConvert
    {
        static string applicationCulture = "nl - BE";
        //displays weight as # kg # g
        //weight must be measured in pounds
        public static string ConvertWeight(double weightLb)
        {
            double weightKg = Math.Round(weightLb * (453.5924 / 1000), 3);

            string convertedWeight = "";
            string weightString = weightKg.ToString(CultureInfo.CreateSpecificCulture(applicationCulture));
            if (weightString.Contains(',') == true)
            {
                string[] splitString = weightString.Split(',');

                string wholeString = splitString[0];
                string decimalsString = splitString[1];
                convertedWeight = $"{wholeString} kg {decimalsString} g";
            }
            else
            {
                convertedWeight = $"{weightString} kg";
            }
            return convertedWeight;
        }

        //displays money as # gp # sp # cp
        public static string ConvertMoney(double money)
        {
            string convertedMoney = "";
            if (Math.Floor(money) == money)
            {
                string[] splitString = money.ToString(CultureInfo.CreateSpecificCulture(applicationCulture)).Split(',');

                string wholeString = splitString[0];
                string decimalsString = splitString[1];

                if (decimalsString.Length == 2)
                {
                    string silverString = decimalsString.Substring(0, 1);
                    string copperString = decimalsString.Substring(decimalsString.Length - 1, 1);
                    convertedMoney = $"{wholeString} gp {silverString} sp {copperString} cp";
                }
                else if (decimalsString.Length == 1)
                {
                    string silverString = decimalsString.Substring(decimalsString.Length - 1, 1);
                    convertedMoney = $"{wholeString} gp {silverString} sp 0 cp";
                }
            }
            else
            {
                convertedMoney = $"{money.ToString(CultureInfo.CreateSpecificCulture(applicationCulture))} gp 0 sp 0 cp";
            }
            return convertedMoney;
        }
    }
}
