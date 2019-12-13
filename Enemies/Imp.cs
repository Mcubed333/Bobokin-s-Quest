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
            Health = 15;
            AttackDamage = 2;
            AttackVariance = 1;
        }
    }
}
