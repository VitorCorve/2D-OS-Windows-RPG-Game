using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class ReadyToAttackService : IReadyToAttack
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
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
            if (OutOfControl)
            {
                Log("Out of control");
                return false;
            }

            if (skill?.CoolDown > 0)
            {
                Log($"{skill.SkillName} on cooldown. Cooldown {skill.CoolDown}");
                return false;
            }

            foreach (var resource in Resources)
            {
                if (resource.GetType() == (skill.ResourceType.GetType()))
                {
                    if (skill?.Cost > resource.Value)
                    {
                        Log($"Not enought {resource.Name}");
                        return false;
                    }
                    break;
                }
            }
            return true;
        }
    }
}
