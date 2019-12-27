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
            MaxHealth = 10;
            Health = 10;
            MaxMana = 10;
            Mana = 10;
            Gold = 0;
            AttackDamage = 3;
            AttackVariance = 1;
            Portrait = Properties.Resources.mage;
        }
    }
}
