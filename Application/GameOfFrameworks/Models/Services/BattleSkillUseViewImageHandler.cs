using GameEngine.CombatEngine.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.Services
{
    public class BattleSkillUseViewImageHandler
    {
        public List<ISkillView> BattleSceneSkills { get; set; } = new();
        public string GetImagePath(ISkill skill)
        {
            if (skill is null) return null;

            foreach (var item in BattleSceneSkills)
            {
                if (item.Skill.Skill_ID == skill.Skill_ID)
                {
                    return item.ImagePath;
                }
            }
            return null;
        }
    }
}
