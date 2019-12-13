using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Mage : CharacterClass
    {
        public Mage()
        {
            Title = "Mage";
            Health = 80;
            Mana = 100;
            Gold = 0;
            AttackDamage = 3;
            AttackVariance = 2;
            Armor = 2;
        }
    }
}
