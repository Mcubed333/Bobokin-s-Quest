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
            
            Gold = 0;

            Strength = 5;
            AttackVariance = 1;

            Intellect = 0;
            Mana = Intellect;

            Dexterity = 1;
            
            Vitality = 14;
            Health = MaxHealth;

            Portrait = Properties.Resources.barb;
        }
    }
}
