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
            Health = 20;
            AttackDamage = 3;
            AttackVariance = 1;
        }
    }
}
