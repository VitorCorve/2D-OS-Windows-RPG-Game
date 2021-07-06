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
        uint Duration { get; }
        uint CoolDown { get; }
        bool ReadyToUse { get; }
        bool SkillAffectedOnEnemy { get; }
        uint Cost { get; }
        uint SkillDamageValue { get; }
        IResourceType ResourceType { get; set; }
        IAttackType Type { get; set; }
        IValueType ValueType { get; set; }
        void Use(uint dealerAttackPower, PlayerEntity target);
    }
}
