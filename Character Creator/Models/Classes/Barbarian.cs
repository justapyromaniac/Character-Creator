using Character_Creator.Models.Supporting_code;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Classes
{
    public class Barbarian : CharacterClass
    {
        public int Rages { get; protected set; }

        public int RageDamage { get; protected set; }

        public Barbarian(double money) : base("Barbarian", new Dice(1, 12), 2, money)
        {
            Rages = 2;
            RageDamage = 2;
            InitializeBarbarian();
        }

        public Barbarian() : this(0)
        {

        }

        public void InitializeBarbarian()
        {
            List<Attribute> SavingThrows = new List<Attribute>
            {
                Attribute.Strength,
                Attribute.Constitution
            };
            foreach (Attribute SavingThrow in SavingThrows)
            {
                AddSavingThrow(SavingThrow);
            }

            List<string> ArmourProf = new List<string>
            {
                "Light armour",
                "Medium armour",
                "Shields"
            };
            foreach (string Proficiency in ArmourProf)
            {
                AddArmourProficiency(Proficiency);
            }

            List<string> WeaponProf = new List<string>
            {
                "Martial",
                "Simple"
            };
            foreach (string Proficiency in WeaponProf)
            {
                AddWeaponProficiency(Proficiency);
            }
        }

        public override string SetFeatures()
        {
            var features = new
            {
                Features = new[]
                {
                    new
                    {
                        Name = "Rage",
                        Description = "Give in to your anger and rip through your enemies while their weapons become nothing but inconveniences",
                        Info = new[]
                        {
                            "You can enter a rage on your turn as a bonus action, if you aren't wearing heavy armour you:",
                            "Have advantage on strenght checks and strenght saving throws.",
                            "Add a rage damage bonus when you make a melee attack using strenght according to your level.",
                            "Have resistance to bludgeoning, piercing and slashing damage.",
                            "Cannot cast spells.",
                            "",
                            "Your rage lasts for 10 rounds. Your rage ends if you:",
                            "Are knocked unconscious.",
                            "Haven't attacked a creature or taken damage since your last turn when your turn ends.",
                            "End it with a bonus action on your turn.",
                            "",
                            "You have a maximum amount of times you can rage corresponding with your level, once you reached this limit you need a long rest before you can rage again."
                        }
                    },
                    new
                    {
                        Name = "Unarmoured defence",
                        Description = "There is no armour stronger than your own skin.",
                        Info = new[]
                        {
                            "If you are not wearing armour, your armour class is 10 + your dexterity modifier + your constitution modifier",
                            "You can use a shield and still gain this benefit"
                        }
                    }
                }

            };
            string json = JsonConvert.SerializeObject(features);
            return json;
        }

        public override string GetInfo()
        {
            var info = new
            {
                Data = new[]
                {
                    new
                    {
                        Item = "Proficiencies",
                        Info = new[]
                        {
                            new
                            {
                                Name = "Armour proficiencies",
                                List = new []
                                {
                                    "Light Armour",
                                    "Medium Armour",
                                    "Shields"
                                }
                            },
                            new
                            {
                                Name = "Weapon proficiencies",
                                List = new []
                                {
                                    "Martial weapons",
                                    "Simple weapons"
                                }
                            }
                        }
                    },
                    new
                    {
                        Item = "Attributes",
                        Info = new[]
                        {
                            new
                            {
                                Name = "Primary attributes",
                                List = new []
                                {
                                    "Strength",
                                    "Constitution"
                                }
                            },
                            new
                            {
                                Name = "Saving Throws",
                                List = new []
                                {
                                    "Strength",
                                    "Constitution"
                                }
                            }
                        }
                    },
                    new
                    {
                        Item = "HP",
                        Info = new[]
                        {
                            new
                            {
                                Name = "Hit die",
                                List = new []
                                {
                                    "1D12 per barbarian level"
                                }
                            },
                            new
                            {
                                Name = "Base HP",
                                List = new []
                                {
                                    "12 + your constitution modifier"
                                }
                            },
                            new
                            {
                                Name = "HP growth",
                                List = new []
                                {
                                    "one roll of your hit die (or 7 if not rolling) + your consitution modifier",
                                    "If your constitution modifier improves, your HP increases as if that was your contsitution modifier from level 1"
                                }
                            }
                        }
                    },
                    new
                    {
                        Item = "Background",
                        Info = new[]
                        {
                            new
                            {
                                Name = "Home",
                                List = new []
                                {
                                    "People of towns and cities take pride in how their civilized ways set them apart from animals, as if denying one's own nature was a mark of superiority.",
                                    "To a barbarian, though, civilization is no virtue, but a sign of weakness.The strong embrace their animal nature keen instincts, primal physicality, and ferocious rage.",
                                    "Barbarians are uncomfortable when hedged in by walls and crowds.They thrive in the wilds of their homelands: the tundra, jungle, or grasslands where their tribes live and hunt."
                                }
                            },
                            new
                            {
                                Name = "Combat",
                                List = new []
                                {

                                    "Barbarians come alive in the chaos of combat The most powerful and trained warriors among them can enter a state of ferocious and blind rage.",
                                    "Their primal lifestyle allows them to tap into the raw energy of anger allowing them to reach their peak physical prowess.",
                                    "This rage can come from any source: the loss of loved ones, hatred for the complacency of society or the communion with fierce animal spirits.",
                                    "This energy, however, doesn't last forever and a barbarian requires rest after using it all."
                                }
                            },
                            new
                            {
                                Name = "Nature",
                                List = new []
                                {
                                    "The most trained warriors are leading figures among their tribe and charge headfirst into the dangers of their homelands, rival tribes, terrifying monsters and “civilized” people so that their tribe doesn’t have to.",
                                    "A barbarian can grow accustomed to this energy and eventually they can use it without ever depleting their reservoir.",
                                    "To barbarians blood ties are second to close knit structures of friends and allies, to the point they call anyone they who they get along with family, allowing them to easily become adventurers when they find a party they cooperate with so that they don’t miss that structure from their home tribe.",
                                    "Barbarians may leave their tribe for various reasons: to commune with the wild and the various animal spirits, to train their battle prowess, to find a greater source of their rage, to hunt for glory and honour, to find a new tribe after their old one was wiped out,  to find a new homeland after their old one became too hostile or simply to find friends to share the thrill of adventure with"
                                }
                            }
                        }
                    }

                }
            };
            string json = JsonConvert.SerializeObject(info);
            return json;
        }




        public override List<string> GetSkills()
        {
            List<string> skills =
                new List<string>
                {
                    "Animal Handling",
                    "Athletics",
                    "Intimidation",
                    "Nature",
                    "Perception",
                    "Survival"
                };
            return skills;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRages: {Rages}\nRage damage: +{RageDamage}";
        }

        public override object[] Rows()
        {
            string[] row1 = new string[] { "1", "+2", "Rage, Unarmored Defense", "2", "+2" };
            string[] row2 = new string[] { "2", "+2", "Reckless Attack, Danger Sense", "2", "+2" };
            string[] row3 = new string[] { "3", "+2", "Primal Path", "3", "+2" };
            string[] row4 = new string[] { "4", "+2", "Ability Score Improvement", "3", "+2" };
            string[] row5 = new string[] { "5", "+3", "Extra Attack, Fast Movement", "3", "+2" };
            string[] row6 = new string[] { "6", "+3", "Path feature", "4", "+2" };
            string[] row7 = new string[] { "7", "+3", "Feral instinct", "4", "+2" };
            string[] row8 = new string[] { "8", "+3", "Ability Score Improvement", "4", "+2" };
            string[] row9 = new string[] { "9", "+4", "Brutal critical (one use)", "4", "+3" };
            string[] row10 = new string[] { "10", "+4", "Path feature", "4", "+3" };
            string[] row11 = new string[] { "11", "+4", "Relentless Rage", "4", "+3" };
            string[] row12 = new string[] { "12", "+4", "Ability Score Improvement", "5", "+3" };
            string[] row13 = new string[] { "13", "+5", "Brutal critical (two uses)", "5", "+3" };
            string[] row14 = new string[] { "14", "+5", "Path feature", "5", "+3" };
            string[] row15 = new string[] { "15", "+5", "Persistent Rage", "5", "+3" };
            string[] row16 = new string[] { "16", "+5", "Ability Score Improvement", "5", "+4" };
            string[] row17 = new string[] { "17", "+6", "Brutal critical (three uses)", "6", "+4" };
            string[] row18 = new string[] { "18", "+6", "Indomitable Might", "6", "+4" };
            string[] row19 = new string[] { "19", "+6", "Ability Score Improvement", "6", "+4" };
            string[] row20 = new string[] { "20", "+6", "Primal Champion", "unlimited", "+4" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15, row16, row17, row18, row19, row20 };
            return rows;
        }
    }
}
