using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.NPCs
{
    public class Merchant : Entity
    {
        public Merchant()
        {
            Title = "Merchant";
            Vitality = 1000;
            Health = MaxHealth;
            Strength = 1000;
            AttackVariance = 0;
            Portrait = Properties.Resources.Merchant;
        }
    }
}
