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
        public delegate void PrepareAction();

        public delegate void Notifications(string message);

        public event Notifications Message;
        public uint DamageValue { get; private set; }
        public bool OutOfControl { get; set; } = false;

        public List<IResourceType> Resources = new() { };

        public CombatServiсe(PlayerEntity dealer)
        {
            Resources.Add(dealer.ManaPoints);
            Resources.Add(dealer.EnergyPoints);
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

        public void Prepare(ISkill skill, PrepareAction action)
        {
            if (OutOfControl)
            {
                Message("Out of control");
                return;
            }

            if (skill?.CoolDown > 0)
            {
                Message($"{skill.SkillName} cooldown {skill.CoolDown} sec.");
                return;
            }

            foreach (var resource in Resources)
            {
                if (resource.GetType() == (skill.ResourceType.GetType()))
                {
                    if (skill?.Cost > resource.Value)
                    {
                        Message("Not enough mana");
                        return;
                    }
                }
            }

            action?.Invoke();
        }
    }
}
