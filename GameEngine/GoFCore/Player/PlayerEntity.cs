using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using GameEngine.Player.DefenseResources;
using System.Collections.Generic;

namespace GameEngine.CombatEngine
{
    public class PlayerEntity : IReceiveDamage, IReceiveHeal, IOutOfControl
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster LogDotDamage;
        public event NotifyMaster LogSpecialDamage;
        public Health HealthPoints { get; set; }
        public Mana ManaPoints { get; set; }
        public Energy EnergyPoints { get; set; }
        public int AttackPower { get; set; }
        public Armor ArmorPoints { get; set; }
        public double CriticalHitChance { get; set; }
        public Dodge DodgeChance { get; set; }
        public Block BlockChance { get; set; }
        public Parry ParryChance { get; set; }
        public Resist ResistChance { get; set; }
        public PlayerControl OutOfControl { get; set; } = new PlayerControl();
        public List<PlayerDebuff> Debuffs = new() { };
        public void ReceiveDamage(int incomingDamage)
        {
            HealthPoints.Value -= incomingDamage;
        }

        public void ReceiveHeal(int healAmount)
        {
            HealthPoints.Value += healAmount;
        }

        public void IncreaseValue(IResourceType valueType, int value)
        {
            switch (valueType)
            {
                case Armor:
                    ArmorPoints.Value += value;
                    return;
                case Dodge:
                    DodgeChance.Value += value;
                    return;
                case Block:
                    BlockChance.Value += value;
                    return;
                case Parry:
                    ParryChance.Value += value;
                    return;
                case Resist:
                    ResistChance.Value += value;
                    return;
                default:
                    break;
            }
        }

        public void DecreaseValue(IResourceType valueType, int value)
        {
            switch (valueType)
            {
                case Armor:
                    ArmorPoints.Value -= value;
                    return;
                case Dodge:
                    DodgeChance.Value -= value;
                    return;
                case Block:
                    BlockChance.Value -= value;
                    return;
                case Parry:
                    ParryChance.Value -= value;
                    return;
                case Resist:
                    ResistChance.Value -= value;
                    return;
                default:
                    break;
            }
        }

        public void ReduceResource(ISkill skill)
        {
            switch (skill.ResourceType)
            {
                case Mana:
                    ManaPoints.Value -= skill.Cost;
                    return;
                case Energy:
                    EnergyPoints.Value -= skill.Cost;
                    return;
                default:
                    break;
            }
        }

        public void LoseControl()
        {
            OutOfControl.Value = true;
        }

        public void ReturnControl()
        {
            OutOfControl.Value = false;
        }

        public void ReceiveDamgeOverTime(ISkill skill, int incomingDamage)
        {
            LogDotDamage($"{skill.SkillName} deals {incomingDamage} damage");
            HealthPoints.Value -= incomingDamage;
        }

        public void ReceiveDebuff(PlayerDebuff debuff)
        {
            Debuffs.Add(debuff);
        }

        public void RemoveDebuff(PlayerDebuff debuff)
        {
            Debuffs.Remove(debuff);
        }

        public void ReceivePercentOfDamage(int percent, string skillName)
        {
            LogSpecialDamage($"{skillName} mutilates");

            double health = HealthPoints.Value;
            health -= (health / 100 * percent);
            HealthPoints.Value = (int)health;
        }
    }
}
