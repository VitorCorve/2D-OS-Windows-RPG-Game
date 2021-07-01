using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ISkill
    {
        string SkillName { get; set; }
        uint SkillLevel { get; set; }
        Timer CoolDownTimer { get; set; }
        Timer DurationTimer { get; set; }
        uint Duration { get; set; }
        uint CoolDown { get; set; }
        bool ReadyToUse { get; set; }
        bool SkillAffectedOnEnemy { get; set; }
        uint Cost { get; set; }
        void Use(PlayerEntity target);
    }
}
