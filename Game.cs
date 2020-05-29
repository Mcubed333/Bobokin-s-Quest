using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.NPCs;

namespace TestProject
{
    public class Game
    {
        public CharacterClass Character;
        public List<Enemy> Enemies;
        public Enemy CurrentEnemy;
        public Merchant Merchant;
        private Random random;

        public bool IsInBattle { get; set; }

        public Game(CharacterClass characterClass)
        {
            this.Character = characterClass;

            Merchant = new Merchant();
            random = new Random();
        }

        public void GetRandomEnemy()
        {
            refreshEnemies();
            int index = random.Next(0, Enemies.Count);
            CurrentEnemy = Enemies[index];
        }

        private void refreshEnemies()
        {
            Enemies = new List<Enemy>
            {
                new Imp(),
                new Boar()
            };
        }

        public void Rest()
        {
            Character.Health += Character.MaxHealth / 3;
            if (Character.Health > Character.MaxHealth)
                Character.Health = Character.MaxHealth;

            int encounterChance = random.Next(1, 4);
            if (encounterChance == 3)
            {
                GetRandomEnemy();
                this.IsInBattle = true;
            }
        }

        public bool RunFromFight()
        {
            int minChance = 1;
            int maxChance = 3;

            

            int success = random.Next(minChance, maxChance);
            if (success <= minChance)
            {
                this.CurrentEnemy = null;
                this.IsInBattle = false;
                return true;
            }
            else
            {
                this.IsInBattle = true;
                return false;
            }
        }

        public bool AddExperience(int experienceRewarded)
        {
            this.Character.Experience += experienceRewarded;
            if (this.Character.Experience >= this.Character.TotalExperienceToNextLevel)
            {
                this.Character.Experience = this.Character.Experience -= this.Character.TotalExperienceToNextLevel;
                this.Character.Level += 1;
                return true;
            }

            return false;
        }
    }
}

