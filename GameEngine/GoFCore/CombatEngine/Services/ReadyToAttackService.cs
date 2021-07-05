using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Managers
{
    public class ReadyToAttackService : IReadyToAttack
    {
        public delegate void Notifications(string message);

        public event Notifications Log;
        public bool OutOfControl { get; set; }
        public ISkill SkillToUse { get; private set; }
        public List<IResourceType> Resources { get; private set; } = new List<IResourceType> { };

        public ReadyToAttackService(PlayerEntity dealer)
        {
            Resources.Add(dealer.ManaPoints);
            Resources.Add(dealer.EnergyPoints);
        }
        public bool CheckStatement(ISkill skill)
        {
            // Check caller's Out of control statement
            if (OutOfControl)
            {
                Log("Out of control");
                return false;
            }

            // Check skill cooldown
            if (skill?.CoolDown > 0)
            {
                Log($"{skill.SkillName} cooldown {skill.CoolDown} sec.");
                return false;
            }

            // Сheck the sufficiency of caller resources
            foreach (var resource in Resources)
            {
                if (resource.GetType() == (skill.ResourceType.GetType()))
                {
                    if (skill?.Cost > resource.Value)
                    {
                        Log("Not enough mana");
                        return false;
                    }
                    break;
                }
            }
            return true;
        }
    }
}
