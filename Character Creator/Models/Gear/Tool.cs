using Character_Creator.Models.Supporting_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Models.Gear
{
    public class Tool : Equipment
    {
        private Dictionaries.ToolTypes ToolType { get; set; }

        public ToolProficiency ToolProficiency { get; private set; }

        private Tool(string name, double cost, double weight, Dictionaries.ToolTypes toolType) : base(name, cost, weight)
        {
            ToolType = toolType;
            ToolProficiency = SetToolProficiency();
        }

        public Tool()
        {

        }

        #region "Methods"

        private ToolProficiency SetToolProficiency()
        {
            ToolProficiency output = null;
            switch (ToolType)
            {
                case Dictionaries.ToolTypes.ArtisansTools:
                    switch (Name)
                    {
                        case "Alchemist’s supplies":
                            output = new ToolProficiency("Alchemist’s supplies", "Alchemist's supplies allow you to produce useful concoctions, such as acid or alchemist's fire.");
                            break;
                        case "Brewer’s supplies":
                            output = new ToolProficiency("Brewer’s supplies", "Brewing is the art of producing beer. Not only does beer serve as an alcoholic beverage, but the process of brewing purifies water. Crafting beer takes weeks of fermentation, but only a few hours of work.");
                            break;
                        case "Calligrapher’s supplies":
                            output = new ToolProficiency("Calligrapher’s supplies", "Calligraphy treats writing as a delicate, beautiful art. Calligraphers produce text that is pleasing to the eye, using a style that is difficult to forge. Their supplies also give them some ability to examine scripts and determine if they are legitimate, since a calligrapher's training involves long hours of studying writing and attempting to replicate its style and design.");
                            break;
                        case "Carpenter’s tools":
                            output = new ToolProficiency("Carpenter’s tools", "Skill at carpentry enables a character to construct wooden structures. A carpenter can build a house, a shack, a wooden cabinet, or similar items.");
                            break;
                        case "Cartographer’s tools":
                            output = new ToolProficiency("Cartographer’s tools", "Using cartographer's tools, you can create accurate maps to make travel easier for yourself and those who come after you. These maps can range from large-scale depictions of mountain ranges to diagrams that show the layout of a dungeon level.");
                            break;
                        case "Cobbler’s tools":
                            output = new ToolProficiency("Cobbler’s tools", "Although the cobbler's trade might seem too humble for an adventurer, a good pair of boots will see a character across rugged wilderness and through deadly dungeons.");
                            break;
                        case "Cook’s utensils":
                            output = new ToolProficiency("Cook’s utensils", "Adventuring is a hard life. With a cook along on the journey, your meals will be much better than the typical mix of hardtack and dried fruit.");
                            break;
                        case "Glassblower’s tools":
                            output = new ToolProficiency("Glassblower’s tools", "Someone proficient with glassblower's tools has not only the ability to shape glass but also specialized knowledge of the methods used to produce glass objects.");
                            break;
                        case "Jeweler’s tools":
                            output = new ToolProficiency("Jeweler’s tools", "Training with jeweler's tools includes the basic techniques needed to beautify gems. It also gives you expertise in identifying precious stones.");
                            break;
                        case "Leatherworker’s tools":
                            output = new ToolProficiency("Leatherworker’s tools", "Knowledge of leatherworking extends to lore concerning animal hides and their properties. It also confers knowledge of leather armor and similar goods.");
                            break;
                        case "Mason’s tools":
                            output = new ToolProficiency("Mason’s tools", "Mason's tools allow you to craft stone structures, including walls and buildings crafted from brick.");
                            break;
                        case "Painter’s supplies":
                            output = new ToolProficiency("Painter’s supplies", "Proficiency with painter's supplies represents your ability to paint and draw. You also acquire an understanding of art history, which can aid you in examining works of art.");
                            break;
                        case "Potter’s tools":
                            output = new ToolProficiency("Potter’s tools", "Potter's tools are used to create a variety of ceramic objects, most typically pots and similar vessels.");
                            break;
                        case "Smith’s tools":
                            output = new ToolProficiency("Smith’s tools", "Smith's tools allow you to work metal, beating it to alter its shape, repair damage, or work raw ingots into useful items.");
                            break;
                        case "Tinker’s tools":
                            output = new ToolProficiency("Tinker’s tools", "A set of tinker's tools is designed to enable you to repair many mundane objects. Though you can't manufacture much with tinker's tools, you can mend torn clothes, sharpen a worn sword, and patch a tattered suit of chain mail.");
                            break;
                        case "Weaver’s tools":
                            output = new ToolProficiency("Weaver’s tools", "Weaver's tools allow you to create cloth and tailor it into articles of clothing.");
                            break;
                        case "Woodcarver’s tools":
                            output = new ToolProficiency("Woodcarver’s tools", "Woodcarver's tools allow you to craft intricate objects from wood, such as wooden tokens or arrows.");
                            break;
                    }
                    break;
                case Dictionaries.ToolTypes.GamingSet:
                    switch (Name)
                    {
                        case "Dice set":
                            output = new ToolProficiency("Dice set", "Proficiency with this game set allows you to more accurately predict a roll and cheat less conspicuously.");
                            break;
                        case "Dragonchess set":
                            output = new ToolProficiency("Dragonchess set", "Proficiency with this set means you're more accustomed to the rules of the game and some more advanced tactics used to play.");
                            break;
                        case "Playing card set":
                            output = new ToolProficiency("Playing card set", "A normal set of 52 playing cards, used to play and card based game");
                            break;
                        case "Three-Dragon Ante set":
                            output = new ToolProficiency("Three-Dragon Ante set", "A game set consisting of 70 cards. Each card represents either a dragon or a mortal, with a power of 1 to 13.");
                            break;
                    }
                    break;
                case Dictionaries.ToolTypes.MusicalInstrument:
                    switch (Name)
                    {
                        case "Bagpipes":
                            output = new ToolProficiency("Bagpipes", "A woodwind instrument consisting of pipes made from reeds attached to a bag which acts as an air supply");
                            break;
                        case "Drum":
                            output = new ToolProficiency("Drum", "A percussion instrument consisting of a skin stretched over a shell.");
                            break;
                        case "Dulcimer":
                            output = new ToolProficiency("Dulcimer", "A percussion instrument based on a number of strings strecthed over a resonant board.");
                            break;
                        case "Flute":
                            output = new ToolProficiency("Flute", "An instrument that makes it's sound by blowing air through several openings in the instrument");
                            break;
                        case "Lute":
                            output = new ToolProficiency("Lute", "A stringed instrument where the strings are spun over a wooden board covering a hollow cavity.");
                            break;
                        case "Lyre":
                            output = new ToolProficiency("Lyre", "A stringed instrument where the strings are spun over a crossbar at the top without any other support");
                            break;
                        case "Horn":
                            output = new ToolProficiency("Horn", "A brass instrument which lets out simple loud sound when blown into");
                            break;
                        case "Pan Flute":
                            output = new ToolProficiency("Pan Flute", "A series of wooden pipes of varying length leading to varying sounds when blown into");
                            break;
                        case "Shawm":
                            output = new ToolProficiency("Shawm", "A simple woodwind instrument that is capable of a very select range of notes based on it's size, but the variety of sizes allow it to have a massive range");
                            break;
                        case "Viol":
                            output = new ToolProficiency("Viol", "A large stringed instrument held between the leg when played, usually played using a bow to stroke the strings instead of your fingers");
                            break;
                    }
                    break;
                default:
                    output = Dictionaries.ToolProficiencies[ToolType];
                    break;
            }
            return output;
        }

        #region "Overridden methods"

        public static List<Equipment> FillEquipmentList()
        {
            List<Equipment> ToolList = new List<Equipment>
            {
                    //Artisan's tools
                    new Tool("Alchemist’s supplies", 50, 8, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Brewer’s supplies", 20, 9, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Calligrapher’s supplies", 10, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Carpenter’s tools", 8, 6, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Cartographer’s tools", 15, 6, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Cobbler’s tools", 5, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Cook’s utensils", 1, 8, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Glassblower’s tools", 30, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Jeweler’s tools", 25, 2, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Leatherworker’s tools", 5, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Mason’s tools", 10, 8, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Painter’s supplies", 10, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Potter’s tools", 10, 3, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Smith’s tools", 20, 8, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Tinker’s tools", 50, 10, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Weaver’s tools", 1, 5, Dictionaries.ToolTypes.ArtisansTools),
                    new Tool("Woodcarver’s tools", 1, 5, Dictionaries.ToolTypes.ArtisansTools),
                    //Artisan's tools

                    new Tool("Disguise kit", 25, 3, Dictionaries.ToolTypes.DisguiseKit),
                    new Tool("Forgery kit", 15, 5, Dictionaries.ToolTypes.ForgeryKit),

                    //Gaming sets
                    new Tool("Dice set", 0.1, 0, Dictionaries.ToolTypes.GamingSet),
                    new Tool("Dragonchess set", 1, 1.5, Dictionaries.ToolTypes.GamingSet),
                    new Tool("Playing card set", 0.5, 0, Dictionaries.ToolTypes.GamingSet),
                    new Tool("Three-Dragon Ante set", 1, 0, Dictionaries.ToolTypes.GamingSet),
                    //Gaming sets


                    new Tool("Herbalism kit", 5, 3, Dictionaries.ToolTypes.HerbalismKit),

                    //Musical instruments
                    new Tool("Bagpipes", 30, 6, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Drum", 6, 3, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Dulcimer", 25, 10, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Flute", 2, 1, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Lute", 35, 2, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Lyre", 30, 2, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Horn", 3, 2, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Pan Flute", 12, 2, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Shawm", 2, 1, Dictionaries.ToolTypes.MusicalInstrument),
                    new Tool("Viol", 30, 1, Dictionaries.ToolTypes.MusicalInstrument),
                    //Musical instruments

                    new Tool("Navigator’s tools", 25, 2, Dictionaries.ToolTypes.NavigatorsTools),
                    new Tool("Poisoner’s kit", 52, 2, Dictionaries.ToolTypes.PoisonersKit),
                    new Tool("Thieves’ tools", 25, 1, Dictionaries.ToolTypes.ThievesTools)
                };
            return ToolList;
        }

        public override Equipment GetEquipment(string name, int amount = 1)
        {
            Equipment output = new Tool();
            foreach (Tool tool in FillEquipmentList())
            {
                if (name == tool.Name)
                {
                    output = tool;
                }
            }
            return output;
        }

        #endregion "Overridden methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type: {ToolType}");
            output.AppendLine($"Required proficiency: {ToolProficiency.Name}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
