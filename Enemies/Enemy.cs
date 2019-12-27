using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public abstract class Enemy : Entity
    {
        public int ExperienceRewarded { get; set; }
        public int GoldRewarded { get; set; }
    }
}
