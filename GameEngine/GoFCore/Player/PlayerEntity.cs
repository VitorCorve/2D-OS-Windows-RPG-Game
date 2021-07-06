using System;
using GameEngine.Player.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.EquipmentManagement;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Actions;
using GameEngine.Player.ConditionResources;

namespace GameEngine.CombatEngine
{
    public class PlayerEntity : IReceiveDamage, IReceiveHeal
    {
        public uint HealthPoints { get; set; }
        public Mana ManaPoints { get; set; }
        public Energy EnergyPoints { get; set; }
        public uint AttackPower { get; set; }
        public Armor ArmorPoints { get; set; }
        public double CriticalHitChance { get; set; }
        public double DodgeChance { get; set; }
        public double BlockChance { get; set; }
        public double ParryChange { get; set; }
        public double ResistChance { get; set; }
        public bool OutOfControl { get; set; } = false;
        public void ReceiveDamage(uint incomingDamage)
        {
            HealthPoints -= incomingDamage;
        }

        public void ReceiveHeal(uint healAmount)
        {
            HealthPoints += healAmount;
        }

        public void IncreaseValue(IValueType valueType, uint value)
        {
            switch (valueType)
            {
                case Armor:
                    ArmorPoints.Value += value;
                    return;
                default:
                    break;
            }
        }

        public void DecreaseValue(IValueType valueType, uint value)
        {
            switch (valueType)
            {
                case Armor:
                    ArmorPoints.Value -= value;
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

    }
}
