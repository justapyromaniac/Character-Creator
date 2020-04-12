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

        //definitely make a class features
        private string featuresJson;

        public string FeaturesJson { get { return featuresJson; } set { featuresJson = SetFeatures(); } }

        public string ClassName { get; protected set; }

        public Dice HitDice { get; protected set; }

        public int BaseHP { get; protected set; }

        public List<Dictionaries.ArmourTypes> ArmourProficiencies { get; }

        public List<Dictionaries.WeaponTypes> WeaponProficiencies { get; }

        public List<Dictionaries.SkillTypes> SkillProficiencies { get; }

        public List<Dictionaries.Attributes> SavingThrows { get; }

        public List<string> ToolProficiencies { get; }

        public List<Equipment> EquipmentList { get; }

        public int ProficiencyBonus { get; protected set; }

        public double Money { get; protected set; }

        #endregion "Properties and fields"


        /*
         * This section is essentially done as far 
         * as I know, the constructors have no further need of editing here
        */
        #region "Constructors"

        //Basic constructor for a class
        protected CharacterClass(string className, Dice hitDice, int proficiencyBonus, double money)
        {
            ClassName = className;
            HitDice = hitDice;
            BaseHP = HitDice.DiceSides();
            ProficiencyBonus = proficiencyBonus;
            Money = money;
            ArmourProficiencies = new List<Dictionaries.ArmourTypes>();
            WeaponProficiencies = new List<Dictionaries.WeaponTypes>();
            SkillProficiencies = new List<Dictionaries.SkillTypes>();
            SavingThrows = new List<Dictionaries.Attributes>();
            ToolProficiencies = new List<string>();
            EquipmentList = new List<Equipment>();
        }

        //Constructor without money, for testing
        protected CharacterClass(string className, Dice hitDice, int proficiencyBonus) : this(className, hitDice, proficiencyBonus, 0)
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
            StringBuilder output = new StringBuilder();
            if (WeaponProficiencies.Count != 0)
            {
                output.AppendLine("Weapon Proficiencies: ");
                foreach (Dictionaries.WeaponTypes WeaponProficiency in WeaponProficiencies)
                {
                    output.AppendLine($"\t{Dictionaries.WeaponProficiencies[WeaponProficiency]}");
                }
            }
            else
            {
                output.AppendLine("The list of weapon proficiencies is empty");
            }
            return output.ToString();
        }

        public string FindWeaponProficiency(Dictionaries.WeaponTypes input)
        {
            StringBuilder output = new StringBuilder();
            if (WeaponProficiencies.Count != 0)
            {
                if (WeaponProficiencies.Contains(input))
                {
                    foreach (Dictionaries.WeaponTypes WeaponProficiency in WeaponProficiencies)
                    {
                        if (input == WeaponProficiency)
                        {
                            output.AppendLine($"{WeaponProficiency}");
                        }
                    }
                }
                else
                {
                    output.AppendLine("This weapon proficiency is not in this list");
                }
            }
            else
            {
                output.AppendLine("The list of weapon proficiencies is empty");
            }
            return output.ToString();
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
            StringBuilder output = new StringBuilder();
            if (SkillProficiencies.Count != 0)
            {
                output.AppendLine("Skill Proficiencies: ");
                foreach (Dictionaries.SkillTypes SkillProficiency in SkillProficiencies)
                {
                    output.AppendLine($"\n\t{Dictionaries.SkillProficiencies[SkillProficiency]}");
                }
            }
            else
            {
                output.AppendLine("The list of skill proficiencies is empty");
            }
            return output.ToString();
        }

        public string FindSkillProficiency(Dictionaries.SkillTypes input)
        {
            StringBuilder output = new StringBuilder();
            if (SkillProficiencies.Count != 0)
            {
                if (SkillProficiencies.Contains(input))
                {
                    foreach (Dictionaries.SkillTypes SkillProficiency in SkillProficiencies)
                    {
                        if (input == SkillProficiency)
                        {
                            output.AppendLine($"{SkillProficiency}");
                        }
                    }
                }
                else
                {
                    output.AppendLine("This skill proficiency is not in this list");
                }
            }
            else
            {
                output.AppendLine("The list of skill proficiencies is empty");
            }
            return output.ToString();
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
            StringBuilder output = new StringBuilder();
            if (SavingThrows.Count != 0)
            {
                output.AppendLine("Saving throws: ");
                foreach (Dictionaries.Attributes SavingThrow in SavingThrows)
                {
                    output.AppendLine($"\t{Dictionaries.AttributesDictionary[SavingThrow].Name}");
                }
            }
            else
            {
                output.AppendLine("The list of saving throws is empty");
            }
            return output.ToString();
        }

        public string FindSavingThrow(Dictionaries.Attributes input)
        {
            StringBuilder output = new StringBuilder();
            if (SavingThrows.Count != 0)
            {
                if (SavingThrows.Contains(input))
                {
                    foreach (Dictionaries.Attributes SavingThrow in SavingThrows)
                    {
                        if (input == SavingThrow)
                        {
                            output.AppendLine($"{SavingThrow}");
                        }
                    }
                }
                else
                {
                    output.AppendLine("This saving throw is not in this list");
                }
            }
            else
            {
                output.AppendLine("The list of saving throws is empty");
            }
            return output.ToString();
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
            StringBuilder output = new StringBuilder();
            if (ToolProficiencies.Count != 0)
            {
                output.AppendLine("Tool Proficiencies: ");
                foreach (string ToolProficiency in ToolProficiencies)
                {
                    output.AppendLine($"\t{ToolProficiency}");
                }
            }
            else
            {
                output.AppendLine("The list of tool proficiencies is empty");
            }
            return output.ToString();
        }

        public string FindToolProficiency(string input)
        {
            StringBuilder output = new StringBuilder();
            if (ToolProficiencies.Count != 0)
            {
                if (ToolProficiencies.Contains(input))
                {
                    foreach (string ToolProficiency in ToolProficiencies)
                    {
                        if (input == ToolProficiency)
                        {
                            output.AppendLine($"{ToolProficiency}");
                        }
                    }
                }
                else
                {
                    output.AppendLine("This tool proficiency is not in this list");
                }
            }
            else
            {
                output.AppendLine("The list of tool proficiencies is empty");
            }
            return output.ToString();
        }

        public bool AddToolProficiency(string input)
        {
            if (ToolProficiencies.Contains(input))
            {
                return false;
            }
            else
            {
                if (input == null)
                {
                    return false;
                }
                else
                {
                    ToolProficiencies.Add(input);
                    return true;
                }
            }
        }

        public bool RemoveToolProficiency(string input)
        {
            if (ToolProficiencies.Contains(input))
            {
                if (input == null)
                {
                    return false;
                }
                else
                {
                    ToolProficiencies.Remove(input);
                    return true;
                }
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
            StringBuilder output = new StringBuilder();
            if (EquipmentList.Count != 0)
            {
                output.AppendLine("Equipment: ");
                foreach (Equipment Equipment in EquipmentList)
                {
                    output.AppendLine($"\t{Equipment.Name}");
                }
            }
            else
            {
                output.AppendLine("The list of equipment is empty");
            }
            return output.ToString();
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
            if (EquipmentList.Contains(input))
            {
                return false;
            }
            else
            {
                if (input == null)
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
            if (EquipmentList.Contains(input))
            {
                if (input == null)
                {
                    return false;
                }
                else
                {
                    EquipmentList.Remove(input);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods EquipmentList"

        #endregion "Methods lists"

        #region "Abstract methods"

        public abstract string SetFeatures();

        public abstract string GetInfo();

        public abstract object[] Rows();

        public abstract List<string> GetSkills();

        #endregion "Abstract methods"

        #region "ToString method"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();


            output.AppendLine($"Class: {ClassName}\nHit points: \n\tHit die: {HitDice}\n\tBase HP: {BaseHP}\nProficiency bonus: {ProficiencyBonus}");

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
