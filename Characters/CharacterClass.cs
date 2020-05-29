using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class CharacterClass : Entity
    {
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;
        public int TotalExperienceToNextLevel { get { return ExperiencePerLevel[Level]; } }
        public int Gold { get; set; }
        

        private Dictionary<int, int> ExperiencePerLevel { get; set; } = new Dictionary<int, int>
            {
                { 1, 5},
                {2, 10 },
                {3, 20 },
                {4, 40 },
                {5, 80 },
                {6, 160 },
                {7, 320 },
                {8, 640 },
                {9, 1280 },
                {10, 2560 }
            };
    }
}
