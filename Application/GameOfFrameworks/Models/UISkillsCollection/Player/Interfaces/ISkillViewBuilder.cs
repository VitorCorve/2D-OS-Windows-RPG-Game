using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillViewBuilder
    {
        List<ISkillView> SkillCollection { get; }
        List<ISkill> PlayerSkillList { get; }
        SPECIALIZATION PlayerSpecialization { get; }
        List<ISkillView> Build();
    }
}
