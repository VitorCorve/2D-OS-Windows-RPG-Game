using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class CombatServiсe : IWeaponAttack, ISkillAttack, ILooseControl
    {
        public delegate void CombatAction(PlayerEntity player);

        public delegate void PrepareAction();
        public uint DamageValue { get; private set; }
        public bool OutOfControl { get; set; } = false;

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
        public void Execute(PlayerEntity target, ISkillAttack.CombatAction func)
        {
            func(target);
        }

        public void Prepare(PrepareAction action)
        {
            if (OutOfControl)
                return;
            action.Invoke();
        }
    }
}
