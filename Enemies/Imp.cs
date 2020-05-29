using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Imp : Enemy
    { 
        public Imp()
        {
            Title = "Imp";
            Vitality = 5;
            Health = MaxHealth;
            Strength = 2;
            Intellect = 0;
            Dexterity = 1;
            AttackVariance = 1;
            Portrait = Properties.Resources.imp;
            GoldRewarded = 2;
            ExperienceRewarded = 3;
        }
    }
}
