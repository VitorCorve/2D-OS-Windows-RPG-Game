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
        string SkillName { get; }
        uint SkillLevel { get; }
        Timer CoolDownTimer { get; }
        Timer DurationTimer { get; }
        uint Duration { get; }
        uint CoolDown { get; }
        bool ReadyToUse { get; }
        bool SkillAffectedOnEnemy { get; }
        uint Cost { get; }
        uint DamageValue { get; }
        IResourceType ResourceType { get; set; }
        void Use(PlayerEntity target);
    }
}
