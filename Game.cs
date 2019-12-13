using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Game
    {
        public CharacterClass character;
        public List<Enemy> enemies;
        public Enemy currentEnemy;
        private Random random = new Random();
        public Game(CharacterClass characterClass)
        {
            this.character = characterClass;
            enemies = new List<Enemy> 
            {
                new Imp(),
                new Boar()
            };
        }

        public void getRandomEnemy()
        {
            currentEnemy = enemies[random.Next(0, enemies.Count)];
        }
    }
}
