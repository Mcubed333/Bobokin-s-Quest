using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class CharacterClass : Entity
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public int TotalExperienceToNextLevel { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int Armor { get; set; }
        public int Gold { get; set; }
    }
}
