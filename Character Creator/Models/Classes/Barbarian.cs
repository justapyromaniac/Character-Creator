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
        public Barbarian(double money) : base("Barbarian", new Dice(1, 12), money)
        {
            InitializeBarbarian();
        }

        public Barbarian() : base("Barbarian", new Dice(1, 12))
        {

        }

        public void InitializeBarbarian()
        {
            List<Dictionaries.Attributes> SavingThrows = new List<Dictionaries.Attributes>
            {
                Dictionaries.Attributes.Strength,
                Dictionaries.Attributes.Constitution
            };
            foreach (Dictionaries.Attributes SavingThrow in SavingThrows)
            {
                AddSavingThrow(SavingThrow);
            }

            List<Dictionaries.ArmourTypes> ArmourProf = new List<Dictionaries.ArmourTypes>
            {
                Dictionaries.ArmourTypes.Light,
                Dictionaries.ArmourTypes.Medium,
                Dictionaries.ArmourTypes.Shield
            };
            foreach (Dictionaries.ArmourTypes Proficiency in ArmourProf)
            {
                AddArmourProficiency(Proficiency);
            }

            List<Dictionaries.WeaponTypes> WeaponProf = new List<Dictionaries.WeaponTypes>
            {
                Dictionaries.WeaponTypes.Martial,
                Dictionaries.WeaponTypes.Simple
            };
            foreach (Dictionaries.WeaponTypes Proficiency in WeaponProf)
            {
                AddWeaponProficiency(Proficiency);
            }
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

        public override List<Dictionaries.SkillTypes> GetSkills()
        {
            List<Dictionaries.SkillTypes> skills =
                new List<Dictionaries.SkillTypes>
                {
                    Dictionaries.SkillTypes.AnimalHandling,
                    Dictionaries.SkillTypes.Athletics,
                    Dictionaries.SkillTypes.Intimidation,
                    Dictionaries.SkillTypes.Nature,
                    Dictionaries.SkillTypes.Perception,
                    Dictionaries.SkillTypes.Survival
                };
            return skills;
        }

        //public override string ToString()
        //{
        //    return base.ToString() + $"\nRages: {ClassLevel.Rages}\nRage damage: +{RageDamage}";
        //}
    }
}
