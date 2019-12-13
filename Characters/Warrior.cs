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
            Health = 120;
            Mana = 60;
            Gold = 0;
            AttackDamage = 5;
            AttackVariance = 2;
            Armor = 4;
        }
    }
}
