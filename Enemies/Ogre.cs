using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Enemies
{
    public class Ogre : Enemy
    {
        public Ogre()
        {
            Title = "Ogre";
            Vitality = 10;
            Health = MaxHealth;
            Strength = 6;
            Intellect = 0;
            Dexterity = 2;
            AttackVariance = 2;
            Portrait = Properties.Resources.ogre;
        }
    }
}
