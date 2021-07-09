using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.PlayerConditions;
using System.Collections.Generic;

namespace GameEngine.CombatEngine
{
    public class ReadyToAttackService : IReadyToAttack
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public PlayerControl OutOfControl { get; set; } = new PlayerControl();
        public bool IsAlive { get; private set; } = true;
        public List<IResourceType> Resources { get; private set; } = new List<IResourceType> { };
        public ReadyToAttackService(PlayerEntity dealer)
        {
            OutOfControl = dealer.OutOfControl;
            dealer.HealthPoints.StopCombat += ValidateAliveStatus;

            Resources.Add(dealer.ManaPoints);
            Resources.Add(dealer.EnergyPoints);
        }



        public bool CheckStatement(ISkill skill)
        {
            if (IsAlive == false)
            {
                Log("is dead");
                return false;
            }
            if (OutOfControl.Value)
            {
                Log("is out of control");
                return false;
            }

            if (skill?.CoolDown > 0)
            {
                Log($"{skill.SkillName} on cooldown. Cooldown: {skill.CoolDown} s.");
                return false;
            }

            foreach (var resource in Resources)
            {
                if (resource.GetType() == (skill.ResourceType.GetType()))
                {
                    if (skill?.Cost > resource.Value)
                    {
                        Log($"has not enought {resource.Name}");
                        return false;
                    }
                    break;
                }
            }
            return true;
        }

        private void ValidateAliveStatus()
        {
            IsAlive = false;
        }
    }
}
