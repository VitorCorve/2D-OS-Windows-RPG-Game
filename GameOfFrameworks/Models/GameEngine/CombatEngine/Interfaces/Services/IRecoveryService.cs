using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.SpecializationMechanics.UniversalSkills;
using System.Collections.Generic;

namespace GameEngine.CombatEngine.Interfaces.Services
{
    public interface IRecoveryService
    {
        RecoverResource HealthPoints { get; }
        RecoverResource ManaPoints { get; }
        RecoverResource EnergyPoints { get; }
        List<IRecoveryResourceSkill> ResourcesList { get; }
        void StopRecover(IResourceType resourceType);
        void ContinueRecover(IResourceType resourceType);
    }
}
