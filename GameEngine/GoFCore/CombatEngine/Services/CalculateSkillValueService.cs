using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class CalculateSkillValueService
    {
        public int SkillValue { get; private set; }
        public CalculateSkillValueService(double criticalHitChance, int basicSkillValue)
        {
            Random randomize = new Random();

            if (randomize.Next(0, 100) < criticalHitChance)
                basicSkillValue *= 3;

            SkillValue = basicSkillValue * 10 / randomize.Next(6, 13);
        }
    }
}
