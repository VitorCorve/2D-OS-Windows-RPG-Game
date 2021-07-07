using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class CombatServiсe : IWeaponAttack, ILooseControl
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public delegate void ExecuteAction();
        public delegate bool CheckAction();
        public int DamageValue { get; private set; }
        public bool OutOfControl { get; set; } = false;
        public double CriticalChance { get; private set; }
        public CombatServiсe(PlayerEntity dealer)
        {
            CriticalChance = dealer.CriticalHitChance;
            DamageValue = dealer.AttackPower;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue - target.ArmorPoints.Value);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            if (new CriticalHitService(CriticalChance).Critical)
            {
                DamageValue *= 3;
                Log("Critical hit");
            }
            skill.Use(DamageValue, target);
        }
    }
}
