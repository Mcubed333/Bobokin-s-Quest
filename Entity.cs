using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TestProject.Battles;

namespace TestProject
{
    public abstract class Entity
    {
        public string Title { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int MaxMana { get { return Intellect *2; } }
        public int Mana { get; set; }
        public int Armor { get; set; }
        public int MaxHealth { get { return Vitality *2; } }
        public int Health { get; set; }
        public int AttackDamage { get { return Strength; } }
        public int AttackVariance { get; set; }
        public int CritChance { get { return Dexterity * 5; } }
        public bool IsAlive { get { if (this.Health <= 0) return false; else return true; }}
        public Image Portrait { get; set; }

        public Entity()
        {
            
        }

        // Returns instance of Damage to reflect damage inflicted and if was crit
        public Damage Attack(Entity e)
        {
            Random random = new Random();
            Damage damage = new Damage();

            damage.IsCrit = false;
            damage.DamageInflicted = random.Next(this.AttackDamage - this.AttackVariance, this.AttackDamage + this.AttackVariance);
            

            int crit = random.Next(1, 100);
            if (crit <= CritChance)
            {
                damage.DamageInflicted *= 2;
                damage.IsCrit = true;
            }

            e.Health -= damage.DamageInflicted;
            if (e.Health <= 0)
            {
                e.Health = 0;
            }
                


            return damage;
        }
    }
}
