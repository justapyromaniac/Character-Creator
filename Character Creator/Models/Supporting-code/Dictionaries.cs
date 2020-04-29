using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Supporting_code
{
    public static class Dictionaries
    {
        //Most <enum, string> dictionaries are placeholders for <enum, object> dictionaries
        public enum Attributes { Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma }

        public static Dictionary<Attributes, CharacterAttribute> AttributesDictionary = new Dictionary<Attributes, CharacterAttribute>
        {
            { Attributes.Strength, new CharacterAttribute("Strength", "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.", 1) },
            { Attributes.Dexterity, new CharacterAttribute("Dexterity", "Dexterity measures agility, reflexes, and balance.", 1) },
            { Attributes.Constitution, new CharacterAttribute("Constitution", "Constitution measures health, stamina, and vital force.", 1) },
            { Attributes.Intelligence, new CharacterAttribute("Intelligence", "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.", 1) },
            { Attributes.Wisdom, new CharacterAttribute("Wisdom", "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.", 1 ) },
            { Attributes.Charisma, new CharacterAttribute("Charisma", "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.", 1) }
        };

        public enum ArmourTypes { Light, Medium, Heavy, Shield }

        public static Dictionary<ArmourTypes, ArmourProficiency> ArmourProficiencies = new Dictionary<ArmourTypes, ArmourProficiency>
        {
            { ArmourTypes.Light, new ArmourProficiency("Light Armour", "Made from supple and thin materials, light armor favors agile adventurers since it offers some protection without sacrificing mobility. If you wear light armor, you add your Dexterity modifier to the base number from your armor type to determine your Armor Class.")  },
            { ArmourTypes.Medium, new ArmourProficiency("Medium Armour", "Medium armor offers more protection than light armor, but it also impairs movement more. If you wear medium armor, you add your Dexterity modifier, to a maximum of +2, to the base number from your armor type to determine your Armor Class." ) },
            { ArmourTypes.Heavy, new ArmourProficiency("Heavy Armour", "Of all the armor categories, heavy armor offers the best protection. These suits of armor cover the entire body and are designed to stop a wide range of attacks. Only proficient warriors can manage their weight and bulk. Heavy armor doesn't let you add your Dexterity modifier to your Armor Class, but it also doesn't penalize you if your Dexterity modifier is negative.") },
            { ArmourTypes.Shield, new ArmourProficiency("Shield", "A shield is made from wood or metal and is carried in one hand. Wielding a shield increases your Armor Class by 2. You can benefit from only one shield at a time.") }
        };

        public enum WeaponTypes { Martial, Simple,}

        public static Dictionary<WeaponTypes, WeaponProficiency> WeaponProficiencies = new Dictionary<WeaponTypes, WeaponProficiency>
        {
            { WeaponTypes.Martial, new WeaponProficiency("Martial weapon", "Martial weapons, including swords, axes, and polearms, require more specialized training to use effectively. Most warriors use martial weapons because these weapons put their fighting style and training to best use.") },
            { WeaponTypes.Simple, new WeaponProficiency("Simple weapon", "Most people can use simple weapons with proficiency. These weapons include clubs, maces, and other weapons often found in the hands of commoners.") }
        };

        public enum SkillTypes 
        { 
            Athletics, 
            Acrobatics, SleightofHand, Stealth, 
            Arcana, History, Investigation, Nature, Religion, 
            AnimalHandling, Insight, Medicine, Perception, Survival,
            Deception, Intimidation, Performance, Persuasion
        }

        public static Dictionary<SkillTypes, SkillProficiency> SkillProficiencies = new Dictionary<SkillTypes, SkillProficiency>
        {
            { SkillTypes.Athletics, new SkillProficiency("Athletics", "Your Athletics skill covers your ability to deal with difficult situations you encounter while climbing, jumping, or swimming.") },
            { SkillTypes.Acrobatics, new SkillProficiency("Acrobatics", "Your Acrobatics skill covers your ability to attempt to stay on your feet in a tricky situation.") },
            { SkillTypes.SleightofHand, new SkillProficiency("Sleight of Hand", "Your Sleight of Hand skill shows your proficiency in manual trickery and sleek, swift hand movements.") },
            { SkillTypes.Stealth, new SkillProficiency("Stealth", "Stealth is the measure of how inconspicuous you are capable of being in any given situation.") },
            { SkillTypes.Arcana, new SkillProficiency("Arcana", "Your Arcana skill measures your ability to recall lore about spells, magic items, eldritch symbols, magical traditions, the planes of existence, and the inhabitants of those planes.") },
            { SkillTypes.History, new SkillProficiency("History", "Your History skill measures your ability to recall lore about historical events, legendary people, ancient kingdoms, past disputes, recent wars, and lost civilizations.")},
            { SkillTypes.Investigation, new SkillProficiency("Investigation", "Investigation is the measure of your ability to deduce and learn new information.") },
            { SkillTypes.Nature, new SkillProficiency("Nature", "Your Nature skill measures your ability to recall lore about terrain, plants and animals, the weather, and natural cycles." ) },
            { SkillTypes.Religion, new SkillProficiency("Religion", "Your Religion skill measures your ability to recall lore about deities, rites and prayers, religious hierarchies, holy symbols, and the practices of secret cults." )},
            { SkillTypes.AnimalHandling, new SkillProficiency("Animal Handling", "Animal handling shows your skill in taking care of animals, being able to calm them down and even tame them along being able to command them." ) },
            { SkillTypes.Insight, new SkillProficiency("Insight", "Your Insight skill decides whether you can determine the true intentions of a creature, such as when searching out a lie or predicting someone's next move." ) },
            { SkillTypes.Medicine, new SkillProficiency("Medicine", "The Medicine skill lets you try to stabilize a dying companion or diagnose an illness." ) },
            { SkillTypes.Perception, new SkillProficiency("Perception", "Your Perception skill lets you spot, hear, or otherwise detect the presence of something." ) },
            { SkillTypes.Survival, new SkillProficiency("Survival", "The Survival skill allows you to follow tracks, hunt wild game, guide your group through frozen wastelands, identify signs that owlbears live nearby, predict the weather, or avoid quicksand and other natural hazards." ) },
            { SkillTypes.Deception, new SkillProficiency("Deception", "Your Deception skill determines whether you can convincingly hide the truth, either verbally or through your actions." ) },
            { SkillTypes.Intimidation, new SkillProficiency("Intimidation", "Intimidation is your capacity to influence someone through overt threats, hostile actions, and physical violence or just sheer impression on others." ) },
            { SkillTypes.Performance, new SkillProficiency("Performance", "Your Performance skill determines how well you can delight an audience with music, dance, acting, storytelling, or some other form of entertainment." ) },
            { SkillTypes.Persuasion, new SkillProficiency("Persuasion", "Persuasion is your ability to influence someone or a group of people with tact, social graces, or good nature." ) }
        };

        public enum ToolTypes { ArtisansTools, DisguiseKit, ForgeryKit, GamingSet, HerbalismKit, MusicalInstrument, NavigatorsTools, PoisonersKit, ThievesTools }

        public static Dictionary<ToolTypes, ToolProficiency> ToolProficiencies = new Dictionary<ToolTypes, ToolProficiency>
        {
            { ToolTypes.ArtisansTools, new ToolProficiency("Artisan’s tools", "These special tools include the items needed to pursue a craft or trade. The table shows examples of the most common types of tools, each providing items related to a single craft.") },
            { ToolTypes.DisguiseKit, new ToolProficiency("Disguise kit", "The perfect tool for anyone who wants to engage in trickery, a disguise kit enables its owner to adopt a false identity. ") },
            { ToolTypes.ForgeryKit, new ToolProficiency("Forgery kit", "A forgery kit is designed to duplicate documents and to make it easier to copy a person's seal or signature.") },
            { ToolTypes.GamingSet, new ToolProficiency("Gaming set", "This item encompasses a wide range of game pieces, including dice and decks of cards.") },
            { ToolTypes.HerbalismKit, new ToolProficiency("Herbalism kit", "Proficiency with an herbalism kit allows you to identify plants and safely collect their useful elements. ") },
            { ToolTypes.MusicalInstrument, new ToolProficiency("Musical instrument", "Several of the most common types of musical instruments found within the world.") },
            { ToolTypes.NavigatorsTools, new ToolProficiency("Navigator’s tools", "Proficiency with navigator's tools helps you determine a true course based on observing the stars. It also grants you insight into charts and maps while developing your sense of direction.") },
            { ToolTypes.PoisonersKit, new ToolProficiency("Poisoner’s kit", "A poisoner's kit is a favored resource for thieves, assassins, and others who engage in skulduggery. It allows you to apply poisons and create them from various materials. Your knowledge of poisons also helps you treat them.") },
            { ToolTypes.ThievesTools, new ToolProficiency("Thieves’ tools", "Perhaps the most common tools used by adventurers, thieves' tools are designed for picking locks and foiling traps. Proficiency with the tools also grants you a general knowledge of traps and locks.") }
        };
    }
}
