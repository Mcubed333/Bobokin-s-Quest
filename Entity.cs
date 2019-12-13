using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class Entity
    {
        public string Title { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int AttackVariance { get; set; }
        public bool IsAlive { get; set; }

        public Entity()
        {
            IsAlive = true;
        }

        // Returns the amount of dmg inflicted
        public int Attack(Entity e)
        {
            Random random = new Random();

            int damage = random.Next(this.AttackDamage - this.AttackVariance, this.AttackDamage + this.AttackVariance);
            e.Health -= damage;
            e.CheckIfDead();

            return damage;
        }

        public void CheckIfDead()
        {
            if (this.Health <= 0)
            {
                IsAlive = false;
            }
            else
            {
                IsAlive = true;
            }
        }
    }
}
