using Character_Creator.Models.Gear;
using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Classes
{
    public abstract class CharacterClass
    {
        /*
         * This section contains every property
         * note that these might change still as I'm far from finished adding child classes
        */
        #region "Properties and fields"

        public Level ClassLevel { get; protected set; }

        public List<Feature> Features { get; }

        public string ClassName { get; protected set; }

        public Dice HitDice { get; protected set; }

        public int BaseHP { get; protected set; }

        public List<Dictionaries.ArmourTypes> ArmourProficiencies { get; }

        public List<Dictionaries.WeaponTypes> WeaponProficiencies { get; }

        public List<Dictionaries.SkillTypes> SkillProficiencies { get; }

        public List<Dictionaries.Attributes> SavingThrows { get; }

        public List<Dictionaries.ToolTypes> ToolProficiencies { get; }

        public List<Equipment> EquipmentList { get; }

        public double Money { get; protected set; }

        #endregion "Properties and fields"


        /*
         * This section is essentially done as far 
         * as I know, the constructors have no further need of editing here
        */
        #region "Constructors"

        //Basic constructor for a class
        protected CharacterClass(string className, Dice hitDice, double money)
        {
            ClassName = className;
            HitDice = hitDice;
            BaseHP = HitDice.DiceSides();
            Money = money;
            ArmourProficiencies = new List<Dictionaries.ArmourTypes>();
            WeaponProficiencies = new List<Dictionaries.WeaponTypes>();
            SkillProficiencies = new List<Dictionaries.SkillTypes>();
            SavingThrows = new List<Dictionaries.Attributes>();
            ToolProficiencies = new List<Dictionaries.ToolTypes>();
            EquipmentList = new List<Equipment>();
        }

        //Constructor without money, for testing
        protected CharacterClass(string className, Dice hitDice) : this(className, hitDice, 0)
        {

        }

        #endregion "Constructors"

        /*
         * All the methods of this class are written here 
         * The methods are subdivided in groups of their functionality or type
         * This section can still get edited
        */
        #region "Methods"

        /* 
         * add custom exceptions for each of these methods
         * and implement them later
        */
        #region "Methods lists"

        #region "Methods ArmourProficiencies"

        public string ListArmourProficiencies()
        {
            StringBuilder output = new StringBuilder();
            if (ArmourProficiencies.Count != 0)
            {
                output.AppendLine("Armour Proficiencies: ");
                foreach (Dictionaries.ArmourTypes ArmourProficiency in ArmourProficiencies)
                {
                    output.AppendLine($"\t{Dictionaries.ArmourProficiencies[ArmourProficiency].Name}");
                }
            }
            else
            {
                output.AppendLine("The list of armour proficiencies is empty");
            }
            return output.ToString();
        }

        public string FindArmourProficiency(Dictionaries.ArmourTypes input)
        {
            StringBuilder output = new StringBuilder();
            if (ArmourProficiencies.Count != 0)
            {
                if (ArmourProficiencies.Contains(input))
                {
                    foreach (Dictionaries.ArmourTypes ArmourProficiency in ArmourProficiencies)
                    {
                        if (input == ArmourProficiency)
                        {
                            output.AppendLine($"{ArmourProficiency}");
                        }
                    }
                }
                else
                {
                    output.AppendLine("This armour proficiency is not in this list");
                }
            }
            else
            {
                output.AppendLine("The list of armour proficiencies is empty");
            }
            return output.ToString();
        }

        public bool AddArmourProficiency(Dictionaries.ArmourTypes input)
        {
            if (ArmourProficiencies.Contains(input))
            {
                return false;
            }
            else
            {
                ArmourProficiencies.Add(input);
                return true;
            }
        }

        public bool RemoveArmourProficiency(Dictionaries.ArmourTypes input)
        {
            if (ArmourProficiencies.Contains(input))
            {
                ArmourProficiencies.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods ArmourProficiencies"

        #region "Methods WeaponProficiencies"

        public string ListWeaponProficiencies()
        {
            if (WeaponProficiencies.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Weapon Proficiencies: ");
                foreach (Dictionaries.WeaponTypes WeaponProficiency in WeaponProficiencies)
                {
                    output.AppendLine($"\t{Dictionaries.WeaponProficiencies[WeaponProficiency]}");
                }
                return output.ToString();
            }
            else
            {
                return "The list of weapon proficiencies is empty";
            }
        }

        public string FindWeaponProficiency(Dictionaries.WeaponTypes input)
        {
           
            if (WeaponProficiencies.Count != 0)
            {
                if (WeaponProficiencies.Contains(input))
                {
                    StringBuilder output = new StringBuilder();
                    foreach (Dictionaries.WeaponTypes WeaponProficiency in WeaponProficiencies)
                    {
                        if (input == WeaponProficiency)
                        {
                            output.AppendLine($"{WeaponProficiency}");
                        }
                    }
                    return output.ToString();
                }
                else
                {
                    return "This weapon proficiency is not in this list";
                }
            }
            else
            {
                return "The list of weapon proficiencies is empty";
            }
        }

        public bool AddWeaponProficiency(Dictionaries.WeaponTypes input)
        {
            if (WeaponProficiencies.Contains(input))
            {
                return false;
            }
            else
            {
                WeaponProficiencies.Add(input);
                return true;
            }
        }

        public bool RemoveWeaponProficiency(Dictionaries.WeaponTypes input)
        {
            if (WeaponProficiencies.Contains(input))
            {
                WeaponProficiencies.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods WeaponProficiencies"

        #region "Methods SkillProficiencies"

        public string ListSkillProficiencies()
        {
            if (SkillProficiencies.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Skill Proficiencies: ");
                foreach (Dictionaries.SkillTypes SkillProficiency in SkillProficiencies)
                {
                    output.AppendLine($"\n\t{Dictionaries.SkillProficiencies[SkillProficiency]}");
                }
                return output.ToString();
            }
            else
            {
                return "The list of skill proficiencies is empty";
            }
        }

        public string FindSkillProficiency(Dictionaries.SkillTypes input)
        {
            if (SkillProficiencies.Count != 0)
            {
                if (SkillProficiencies.Contains(input))
                {
                    StringBuilder output = new StringBuilder();
                    foreach (Dictionaries.SkillTypes SkillProficiency in SkillProficiencies)
                    {
                        if (input == SkillProficiency)
                        {
                            output.AppendLine($"{SkillProficiency}");
                        }
                    }
                    return output.ToString();
                }
                else
                {
                    return "This skill proficiency is not in this list";
                }
            }
            else
            {
                return "The list of skill proficiencies is empty";
            }
        }

        public bool AddSkillProficiency(Dictionaries.SkillTypes input)
        {
            if (SkillProficiencies.Contains(input))
            {
                return false;
            }
            else
            {
                SkillProficiencies.Add(input);
                return true;
            }
        }

        public bool RemoveSkillProficiency(Dictionaries.SkillTypes input)
        {
            if (SkillProficiencies.Contains(input))
            {
                SkillProficiencies.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods SkillProficiencies"

        #region "Methods SavingThrows"

        public string ListSavingThrows()
        {
            if (SavingThrows.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Saving throws: ");
                foreach (Dictionaries.Attributes SavingThrow in SavingThrows)
                {
                    output.AppendLine($"\t{Dictionaries.AttributesDictionary[SavingThrow].Name}");
                }
                return output.ToString();
            }
            else
            {
                return "The list of saving throws is empty";
            }
        }

        public string FindSavingThrow(Dictionaries.Attributes input)
        {
            if (SavingThrows.Count != 0)
            {
                if (SavingThrows.Contains(input))
                {
                    StringBuilder output = new StringBuilder();
                    foreach (Dictionaries.Attributes SavingThrow in SavingThrows)
                    {
                        if (input == SavingThrow)
                        {
                            output.AppendLine($"{SavingThrow}");
                        }
                    }
                    return output.ToString();
                }
                else
                {
                    return "This saving throw is not in this list";
                }
            }
            else
            {
                return "The list of saving throws is empty";
            }
        }

        public bool AddSavingThrow(Dictionaries.Attributes input)
        {
            if (SavingThrows.Contains(input))
            {
                return false;
            }
            else
            {
                SavingThrows.Add(input);
                return true;
            }
        }

        public bool RemoveSavingThrow(Dictionaries.Attributes input)
        {
            if (SavingThrows.Contains(input))
            {
                SavingThrows.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods SavingThrows"

        #region "Methods ToolProficiencies"

        public string ListToolProficiencies()
        {
            if (ToolProficiencies.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Tool Proficiencies: ");
                foreach (Dictionaries.ToolTypes ToolProficiency in ToolProficiencies)
                {
                    output.AppendLine($"\t{Dictionaries.ToolProficiencies[ToolProficiency].Name}");
                }
                return output.ToString();
            }
            else
            {
                return "The list of tool proficiencies is empty";
            }
        }

        public string FindToolProficiency(Dictionaries.ToolTypes input)
        {
            if (ToolProficiencies.Count != 0)
            {
                if (ToolProficiencies.Contains(input))
                {
                    StringBuilder output = new StringBuilder();
                    foreach (Dictionaries.ToolTypes ToolProficiency in ToolProficiencies)
                    {
                        if (input == ToolProficiency)
                        {
                            output.AppendLine($"{ToolProficiency}");
                        }
                    }
                    return output.ToString();
                }
                else
                {
                    return "This tool proficiency is not in this list";
                }
            }
            else
            {
                return "The list of tool proficiencies is empty";
            }
        }

        public bool AddToolProficiency(Dictionaries.ToolTypes input)
        {
            if (ToolProficiencies.Contains(input))
            {
                return false;
            }
            else
            {
                ToolProficiencies.Add(input);
                return true;
            }
        }

        public bool RemoveToolProficiency(Dictionaries.ToolTypes input)
        {
            if (ToolProficiencies.Contains(input))
            {
                ToolProficiencies.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods ToolProficiencies"

        #region "Methods EquipmentList"

        public string ListEquipment()
        {
            if (EquipmentList.Count != 0)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("Equipment: ");
                foreach (Equipment Equipment in EquipmentList)
                {
                    output.AppendLine($"\t{Equipment.Name}");
                }
                return output.ToString();
            }
            else
            {
                return "The list of equipment is empty";
            }
        }

        public Equipment FindEquipment(string name)
        {
            Equipment output = null;
            if (EquipmentList.Count != 0)
            {
                foreach (Equipment Equipment in EquipmentList)
                {
                    if (Equipment.Name == name)
                    {
                        output = Equipment;
                    }
                }
            }
            return output;
        }

        public bool AddEquipment(Equipment input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                if(EquipmentList.Contains(input))
                {
                    return false;
                }
                else
                {
                    EquipmentList.Add(input);
                    return true;
                }
            }
        }

        public bool RemoveEquipment(Equipment input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                if (EquipmentList.Contains(input))
                {
                    EquipmentList.Remove(input);
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        #endregion "Methods EquipmentList"

        #endregion "Methods lists"

        #region "Abstract methods"

        public abstract string GetInfo();

        public abstract List<Dictionaries.SkillTypes> GetSkills();

        #endregion "Abstract methods"

        #region "ToString method"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();


            output.AppendLine($"Class: {ClassName}\nHit points: \n\tHit die: {HitDice}\n\tBase HP: {BaseHP}");

            if (SkillProficiencies.Count != 0)
            {
                output.AppendLine(ListSkillProficiencies());
            }

            if (ArmourProficiencies.Count != 0)
            {
                output.AppendLine(ListArmourProficiencies());
            }

            if (WeaponProficiencies.Count != 0)
            {
                output.AppendLine(ListWeaponProficiencies());
            }

            if (ToolProficiencies.Count != 0)
            {
                output.AppendLine(ListToolProficiencies());
            }

            if (SavingThrows.Count != 0)
            {
                output.AppendLine(ListSavingThrows());
            }

            if (EquipmentList.Count != 0)
            {
                output.AppendLine(ListEquipment());
            }

            if (Money != 0)
            {
                output.Append($"Money: {CustomConvert.ConvertMoney(Money)}");
            }
            return output.ToString();
        }

        #endregion "ToString method"

        #endregion "Methods"
    }
}
