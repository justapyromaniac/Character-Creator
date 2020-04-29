using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public class BarbarianLevel : Level
    {
        public int Rages { get; protected set; }

        public int RageDamage { get; protected set; }

        public BarbarianLevel(int levelNumber, int proficiencyBonus, int rages, int rageDamage) : base(levelNumber, proficiencyBonus)
        {
            Rages = rages;
            RageDamage = rageDamage;
        }

        public static List<Specialization> GetSpecializations()
        {
            #region "Berserker"

            Specialization berserker = new Specialization("Berserker",
                    "For some barbarians, rage is a means to an end - that end being violence. " +
                    "The Path of the Berserker is a path of untrammelled fury, slick with blood. " +
                    "As you enter the berserker's rage, you thrill in the chaos of battle, heedless of your own health or well-being.");

            berserker.AddFeature(new KeyValuePair<int, Feature>(3, 
                    new Feature("Frenzy", "Rage even harder than you could before to attack even more enemies.",
                    "You can go into a frenzy when you rage.\n" +
                    "If you do so, for the duration of your rage you can make a single melee weapon attack as a bonus action on each of your turns after this one. " +
                    "When your rage ends, you suffer one level of exhaustion.")));

            berserker.AddFeature(new KeyValuePair<int, Feature>(6, 
                new Feature("Mindless rage", "As you rage, it consumes your mind. Nothing else can occupy your thoughts but anger.",
                "You can't be charmed or frightened while raging. If you are charmed or frightened when you enter your rage. the effect is suspended for the duration of the rage.")));

            berserker.AddFeature(new KeyValuePair<int, Feature>(10,
                new Feature("Intimidating presence", "Your sheer presence on the battlefield is able to terrify your enemies.", 
                "You can use your action to frighten someone with your menacing presence.\n" +
                "When you do so, choose one creature that you can see within 30 feet of you.\n" +
                "If the creature can see or hear you, it must succeed on a Wisdom saving throw (DC equal to 8 + your proficiency bonus + your Charisma modifier) or be frightened of you until the end of your next turn.\n" +
                "On subsequent turns, you can use your action to extend the duration of this effect on the frightened creature until the end of your next turn.\n" +
                "This effect ends if the creature ends its turn out of line of sight or more than 60 feet away from you.\n\n" +
                "If the creature succeeds on its saving throw. you can't use this feature on that creature again for 24 hours.")));

            berserker.AddFeature(new KeyValuePair<int, Feature>(14,
                new Feature("Retaliation", "Do not let anyone who harms you remain unpunished",
                "When you take damage from a creature that is within 5 feet of you, you can use your reaction to make a melee weapon attack against that creature.")));

            #endregion "Berserker"

            List<Specialization> output = new List<Specialization>
            {
                berserker
            };
            return output;
        }

        public static List<Level> Levels(string pathName)
        {
            Specialization chosenPath = ChooseSpecialization(pathName, Classes.Barbarian);
            Level level1 = new BarbarianLevel(1, 2, 2, 2);
            level1.AddFeature(new Feature("Rage", "Give in to your anger and rip through your enemies while their weapons become nothing but inconveniences",
                "You can enter a rage on your turn as a bonus action, if you aren't wearing heavy armour you:\n" +
                "Have advantage on strenght checks and strenght saving throws.\n" +
                "Add a rage damage bonus when you make a melee attack using strenght according to your level.\n" +
                "Have resistance to bludgeoning, piercing and slashing damage.\n" +
                "Cannot cast spells.\n\n" +
                "Your rage lasts for 10 rounds. Your rage ends if you:\n" +
                "Are knocked unconscious.\n" +
                "Haven't attacked a creature or taken damage since your last turn when your turn ends.\n" +
                "End it with a bonus action on your turn.\n\n" +
                "You have a maximum amount of times you can rage corresponding with your level, once you reached this limit you need a long rest before you can rage again."));
            level1.AddFeature(new Feature("Unarmoured defence", "There is no armour stronger than your own skin.", "If you are not wearing armour, your armour class is 10 + your dexterity modifier + your constitution modifier\nYou can use a shield and still gain this benefit"));

            Level level2 = new BarbarianLevel(2, 2, 2, 2);
            level2.AddFeature(new Feature("Reckless attack", "Throw aside all concern for defence to attack with fierce desperation.", "When you make your first attack on your turn, you can decide to attack recklessly.\nDoing so gives you advantage on melee weapon attack rolls using Strength during this turn, but attack rolls against you have advantage until your next turn."));
            level2.AddFeature(new Feature("Danger sense", "You gain an uncanny sense of when things nearby aren't as they should be, giving you an edge when you dodge away from danger.", "You have advantage on Dexterity saving throws against effects that you can see, such as traps and spells. To gain this benefit, you can't be blinded, deafened, or incapacitated."));

            Level level3 = new BarbarianLevel(3, 2, 3, 2);
            level3.AddFeature(chosenPath.FindFeature(level3.LevelNumber));


            List<Level> Levels = new List<Level>
                {
                    level1,
                    level2,
                    level3
                };


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
            return Levels;
        }
    }
}
