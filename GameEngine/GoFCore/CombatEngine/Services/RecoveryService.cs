using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.Services;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.ConditionResources;
using GameEngine.SpecializationMechanics.UniversalSkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class RecoveryService : IRecoveryService
    {
        public RecoverResource HealthPoints { get; private set; }
        public RecoverResource ManaPoints { get; private set; }
        public RecoverResource EnergyPoints { get; private set; }
        public List<IRecoveryResourceSkill> ResourcesList { get; private set; } = new List<IRecoveryResourceSkill> { };
        public RecoveryService(params IConditionResourceType[] resources)
        {
            foreach (var resource in resources)
            {
                if (resource is Health)
                {
                    HealthPoints = new RecoverResource(resource);
                    ResourcesList.Add(HealthPoints);
                    continue;
                }

                if (resource is Mana)
                {
                    ManaPoints = new RecoverResource(resource);
                    ResourcesList.Add(ManaPoints);
                    continue;
                }

                if (resource is Energy)
                {
                    EnergyPoints = new RecoverResource(resource);
                    ResourcesList.Add(EnergyPoints);
                    continue;
                }
            }
        }
        public void StopRecover(IResourceType resourceType)
        {
            foreach (var resourceRecovery in ResourcesList)
            {
                if (resourceRecovery.ResourceType.GetType() == resourceType.GetType())
                    resourceRecovery.StopRecover();
            }
        }

        public void ContinueRecover(IResourceType resourceType)
        {
            foreach (var resourceRecovery in ResourcesList)
            {
                if (resourceRecovery.ResourceType.GetType() == resourceType.GetType())
                    resourceRecovery.ContinueRecover();
            }
        }
    }
}
