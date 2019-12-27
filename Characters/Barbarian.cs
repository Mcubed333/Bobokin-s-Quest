using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Barbarian : CharacterClass
    {
        public Barbarian()
        {
            Title = "Barbarian";
            MaxHealth = 14;
            Health = 14;
            MaxMana = 4;
            Mana = 4;
            Gold = 0;
            AttackDamage = 4;
            AttackVariance = 1;
            Portrait = Properties.Resources.barb;
        }
    }
}
