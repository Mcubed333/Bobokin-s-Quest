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
            MaxHealth = 12;
            Health = 12;
            AttackDamage = 2;
            AttackVariance = 1;
            Portrait = Properties.Resources.boar;
            GoldRewarded = 3;
            ExperienceRewarded = 4;
        }
    }
}
