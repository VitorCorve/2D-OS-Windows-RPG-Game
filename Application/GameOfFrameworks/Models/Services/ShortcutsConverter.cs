using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameEngine.SpecializationMechanics.UniversalSkills;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.UISkillsCollection.Player.Services;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.Services
{
    public class ShortcutsConverter
    {
        public static List<ISkill> ConvertToList(ShortcutsListModel shortcutsListModel)
        {
            var skillList = new List<ISkill>();
            foreach (var item in shortcutsListModel.SkillViewList)
            {
                if (item.Skill == null)
                {
                    var skillTemplate = new SkillTemplate();
                    skillList.Add(skillTemplate);
                }
                else
                {
                    skillList.Add(item.Skill);
                }
            }
            return skillList;
        }
        public static ShortcutsListModel ConvertToShortcuts(List<ISkill> skillList, SPECIALIZATION playerSpecialization)
        {
            var skillToSkillViewConverter = new SkillToSkillViewConverter(playerSpecialization);
            var shortcutsListModel = new ShortcutsListModel();

            var skillViewList = skillToSkillViewConverter.ConvertRangeToObservableCollection(skillList);

            int count = 0;
            foreach (var item in skillViewList)
            {
                if (item.Skill is SkillTemplate)
                {
                    count++;
                    continue;
                }
                else
                {
                    shortcutsListModel.SkillViewList[count] = item;
                    count++;
                }
            }
            return shortcutsListModel;
        }
    }
}
