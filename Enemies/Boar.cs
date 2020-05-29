using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Boar : Enemy
    {
        public Boar()
        {
            Title = "Boar";
            Vitality = 12;
            Health = MaxHealth;
            Strength = 3;
            Intellect = 0;
            Dexterity = 1;
            AttackVariance = 1;
            Portrait = Properties.Resources.boar;
            GoldRewarded = 3;
            ExperienceRewarded = 5;
        }
    }
}
