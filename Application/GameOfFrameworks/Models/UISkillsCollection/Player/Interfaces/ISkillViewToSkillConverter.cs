using GameEngine.CombatEngine.Interfaces;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillViewToSkillConverter
    {
        List<ISkill> ConvertRange(ICollection<ISkillView> skillViewList);
        ISkill Convert(ISkillView skillView);
    }
}
