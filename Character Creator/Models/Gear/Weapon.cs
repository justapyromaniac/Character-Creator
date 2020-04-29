using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Weapon : Equipment
    {

        public enum WeaponRanges { Melee, Ranged }

        public Dictionary<WeaponRanges, string> RangeExplanation = new Dictionary<WeaponRanges, string>
        {
            { WeaponRanges.Melee, "Used to attack a target within 1 meter of you" },
            { WeaponRanges.Ranged, "Used to attack a target from further away" }
        };

        private Dictionaries.WeaponTypes WeaponType { get; set; }

        public WeaponRanges Range { get; private set; }

        public Dice Damage { get; private set; }

        public string DamageType { get; private set; }

        public string Info { get; private set; }

        public WeaponProficiency WeaponProficiency { get; set; }

        private Weapon(string name, double cost, double weight, Dictionaries.WeaponTypes weaponType, WeaponRanges range, Dice damage, string damagetype, string info, int amount = 1) : base(name, cost, weight, amount)
        {
            WeaponType = weaponType;
            Range = range;
            Damage = damage;
            DamageType = damagetype;
            Info = info;
            WeaponProficiency = Dictionaries.WeaponProficiencies[WeaponType];
        }

        public Weapon()
        {

        }

        #region "Methods"

        #region "Overridden methods" 

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> WeaponList = new List<Equipment>
            {
                    new Weapon("Club", 0.1, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 4), "bludgeoning", "Light"),
                    new Weapon("Dagger", 2, 1, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 4), "piercing", "Finesse, light, thrown (range 4/13)"),
                    new Weapon("Greatclub", 0.2, 10, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 8), "bludgeoning", "Two-handed"),
                    new Weapon("Handaxe", 5, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 6), "slashing", "Light, thrown (range 4/12)"),
                    new Weapon("Javelin", 0.5, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 6), "piercing", "Thrown (range 6/24)"),
                    new Weapon("Light hammer", 2, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 4), "bludgeoning", "Light, thrown (range 4/12)"),
                    new Weapon("Mace", 5, 4, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 6), "bludgeoning", ""),
                    new Weapon("Quarterstaff", 0.2, 4, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 6), "bludgeoning", "Versatile (1d8)"),
                    new Weapon("Sickle", 1, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 4), "slashing", "Light"),
                    new Weapon("Spear", 1, 3, Dictionaries.WeaponTypes.Simple, WeaponRanges.Melee, new Dice(1, 6), "piercing", "Thrown (range 4/12), versatile (1d8)"),
                    new Weapon("Crossbow, light", 25, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Ranged, new Dice(1, 8), "piercing", "Ammunition (range 16/64), loading, two-handed"),
                    new Weapon("Dart", 0.05, 0.25, Dictionaries.WeaponTypes.Simple, WeaponRanges.Ranged, new Dice(1, 4), "piercing", "Finesse, thrown (range 4/12)"),
                    new Weapon("Shortbow", 25, 2, Dictionaries.WeaponTypes.Simple, WeaponRanges.Ranged, new Dice(1, 6), "piercing", "Ammunition (range 16/64), two-handed"),
                    new Weapon("Sling", 0.1, 0, Dictionaries.WeaponTypes.Simple, WeaponRanges.Ranged, new Dice(1, 4), "bludgeoning", "Ammunition (range 6/24)"),
                    new Weapon("Battleaxe", 10, 4, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "slashing", "Versatile (1d10)"),
                    new Weapon("Flail", 10, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "bludgeoning", ""),
                    new Weapon("Glaive", 20, 6, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 10), "slashing", "Heavy, reach, two-handed"),
                    new Weapon("Greataxe", 30, 7, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 12), "slashing", "Heavy, two-handed"),
                    new Weapon("Greatsword", 50, 6, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(2, 6), "slashing", "Heavy, two-handed"),
                    new Weapon("Halberd", 20, 6, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 10), "slashing", "Heavy, reach, two-handed"),
                    new Weapon("Lance", 10, 6, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 12), "piercing", "Reach, special"),
                    new Weapon("Longsword", 15, 3, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "slashing", "Versatile (1d10)"),
                    new Weapon("Maul", 10, 10, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(2, 6), "bludgeoning", "Heavy, two-handed"),
                    new Weapon("Morningstar", 15, 4, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "piercing", ""),
                    new Weapon("Pike", 5, 18, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 10), "piercing", "Heavy, reach, two-handed"),
                    new Weapon("Rapier", 25, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "piercing", "Finesse"),
                    new Weapon("Scimitar", 25, 3,Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 6), "slashing", "Finesse, light"),
                    new Weapon("Shortsword", 10, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 6), "piercing", "Finesse, light"),
                    new Weapon("Trident", 5, 4, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 6), "piercing", "Thrown (range 4/12), versatile (1d8)"),
                    new Weapon("War pick", 5, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "piercing", ""),
                    new Weapon("Warhammer", 15, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 8), "bludgeoning", "Versatile (1d10)"),
                    new Weapon("Whip", 2, 3, Dictionaries.WeaponTypes.Martial, WeaponRanges.Melee, new Dice(1, 4), "slashing", "Finesse, reach"),
                    new Weapon("Blowgun", 10, 1, Dictionaries.WeaponTypes.Martial, WeaponRanges.Ranged, new Dice(1, 4), "piercing", "Ammunition (range 5/20), loading"),
                    new Weapon("Crossbow, hand", 75, 3, Dictionaries.WeaponTypes.Martial, WeaponRanges.Ranged, new Dice(1, 6), "piercing", "Ammunition (range 6/24), light, loading"),
                    new Weapon("Crossbow, heavy", 50, 18, Dictionaries.WeaponTypes.Martial, WeaponRanges.Ranged, new Dice(1, 10), "piercing", "Ammunition (range 20/80), heavy, loading, two-handed"),
                    new Weapon("Longbow", 50, 2, Dictionaries.WeaponTypes.Martial, WeaponRanges.Ranged, new Dice(1, 8), "piercing", "Ammunition (range 30/120), heavy, two-handed"),
                    new Weapon("Net", 1, 3, Dictionaries.WeaponTypes.Martial, WeaponRanges.Ranged, null, null, "Special, thrown (range 1/3)")
                };
            return WeaponList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = new Weapon();
            foreach (Weapon weapon in FillEquipmentList())
            {
                if (name == weapon.Name)
                {
                    output = new Weapon(weapon.Name, weapon.Cost, weapon.Weight, weapon.WeaponType, weapon.Range, weapon.Damage, weapon.DamageType, weapon.Info, amount);
                }
            }
            return output;
        }

        #endregion "Overridden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Attacking distance: {RangeExplanation[Range]}");
            output.AppendLine($"Weapon type/Required proficiency: {WeaponProficiency.Name}");
            output.AppendLine($"Weapon damage (for one): {Damage} {DamageType}");
            output.AppendLine($"Weapon info: {Info}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
