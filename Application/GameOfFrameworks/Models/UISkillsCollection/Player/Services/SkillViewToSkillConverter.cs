using GameEngine.CombatEngine.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class SkillViewToSkillConverter : ISkillViewToSkillConverter
    {
        public ISkill Convert(ISkillView skillView) => skillView.Skill;
        public List<ISkill> ConvertRange(ICollection<ISkillView> skillViewList)
        {
            var skillList = new List<ISkill>();
            foreach (var item in skillViewList)
            {
                skillList.Add(item.Skill);
            }
            return skillList;
        }
    }
}
