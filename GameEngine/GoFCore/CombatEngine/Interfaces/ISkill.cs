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
        int SkillLevel { get; }
        Timer CoolDownTimer { get; }
        int Duration { get; }
        int CoolDown { get; }
        bool ReadyToUse { get; }
        bool SkillAffectedOnEnemy { get; }
        int Cost { get; }
        int SkillDamageValue { get; }
        IResourceType ResourceType { get; set; }
        IAttackType Type { get; set; }
        IValueType ValueType { get; set; }
        void Use(int dealerAttackPower, PlayerEntity target);
    }
}
