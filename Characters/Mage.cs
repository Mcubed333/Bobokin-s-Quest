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

            Gold = 0;

            Strength = 3;
            AttackVariance = 1;

            Intellect = 7;
            Mana = Intellect;

            Dexterity = 0;

            Vitality = 10;
            Health = MaxHealth;

            Portrait = Properties.Resources.mage;
        }
    }
}
