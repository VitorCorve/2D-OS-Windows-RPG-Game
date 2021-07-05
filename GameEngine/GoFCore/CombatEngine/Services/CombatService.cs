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

        public List<Action> ActionList;
        public CombatServiсe(PlayerEntity dealer)
        {
            DamageValue = dealer.AttackPower;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue - target.ArmorPoints);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            skill.Use(target);
        }


        public void Prepare(CheckAction readyToAttackFunction, ExecuteAction reduceResourceFunction, CheckAction defenseFunction, ExecuteAction executeFunction)
        {
            switch (readyToAttackFunction?.Invoke())
            {
                case true:
                    reduceResourceFunction?.Invoke();
                    break;
                default:
                    return;
            }

            switch (defenseFunction?.Invoke())
            {
                case true:
                    executeFunction?.Invoke();
                    break;
                default:
                    break;
            }

        }
       

    }
}
