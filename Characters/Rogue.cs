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

            Vitality = 6;
            Health = MaxHealth;

            Gold = 5;

            Strength = 4;
            AttackVariance = 2;

            Intellect = 1;
            Mana = MaxMana;

            Dexterity = 4;
            

            Portrait = Properties.Resources.rog;
        }
    }
}
