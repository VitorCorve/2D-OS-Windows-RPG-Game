using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using GameEngine.Player.PlayerConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IPlayerEntity
    {
        Health HealthPoints { get; }
        Mana ManaPoints { get; }
        Energy EnergyPoints { get; }
        AttackPower Attack { get; }
        DefensePower Defense { get; } 
        Armor ArmorPoints { get; }
        CriticalHitChance CriticalChance { get; }
        Dodge DodgeChance { get; }
        Block BlockChance { get; }
        Parry ParryChance { get; }
        Resist ResistChance { get; }
        PlayerControl OutOfControl { get; }
        List<PlayerDebuff> Debuffs { get; }
        RecoveryService RecoverResources { get; }
        void ReceiveDamage(int incomingDamage);
        void ReceiveHeal(int healAmount);
        void SetValue(IResourceType valueType, double value);
        void ReduceResource(ISkill skill);
        void LoseControl();
        void ReturnControl();
        void ReceiveDamgeOverTime(ISkill skill, int incomingDamage);
        void ReceiveDebuff(PlayerDebuff debuff);
        void RemoveDebuff(PlayerDebuff debuff);
        void ReceivePercentOfDamage(int percent, string skillName);
    }
}
