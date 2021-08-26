using GameEngine.CombatEngine.Interfaces;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Interfaces.Services
{
    public interface ICharacterCreationSkillListBuilder
    {
        List<ISkill> Build(CharacterCreationData characterCreationData);
    }
}
