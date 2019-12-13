using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Warrior : CharacterClass
    {
        public Warrior()
        {
            Title = "Warrior";
            MaxHealth = 14;
            Health = 14;
            MaxMana = 4;
            Mana = 4;
            Gold = 0;
            AttackDamage = 4;
            AttackVariance = 1;
        }
    }
}
