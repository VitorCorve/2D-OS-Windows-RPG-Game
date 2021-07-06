using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
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
        public delegate void ExecuteAction();
        public delegate bool CheckAction();
        public uint DamageValue { get; private set; }
        public bool OutOfControl { get; set; } = false;
        public CombatServiсe(PlayerEntity dealer)
        {
            DamageValue = dealer.AttackPower;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue - target.ArmorPoints.Value);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            skill.Use(DamageValue, target);
        }


/*        public void Prepare(CheckAction readyFunc, ExecuteAction reduceResourceFunc, CheckAction defenseFunc, ExecuteAction executeFunc)
        {
            switch (readyFunc?.Invoke())
            {
                case true:
                    reduceResourceFunc?.Invoke();
                    break;
                default:
                    return;
            }

            switch (defenseFunc?.Invoke())
            {
                case true:
                    executeFunc?.Invoke();
                    break;
                default:
                    break;
            }

        }*/
       
    }
}
