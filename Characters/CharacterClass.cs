using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class CharacterClass : Entity
    {
        public int Mana { get; set; }
        public int Armor { get; set; }
        public int Gold { get; set; }
    }
}
