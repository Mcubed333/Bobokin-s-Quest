using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Rogue : CharacterClass
    {
        public Rogue()
        {
            Title = "Rogue";
            MaxHealth = 12;
            Health = 12;
            MaxMana = 6;
            Mana = 6;
            Gold = 0;
            AttackDamage = 4;
            AttackVariance = 2;
            Portrait = Properties.Resources.rog;
        }
    }
}
