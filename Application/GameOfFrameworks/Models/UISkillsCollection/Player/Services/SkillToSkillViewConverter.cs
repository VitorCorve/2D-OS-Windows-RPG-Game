using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class SkillToSkillViewConverter : ISkillToSkillViewConverter
    {
        private List<ISkillView> SkillList;
        private ISkillViewListBuilder SkillBuilder;
        public SkillToSkillViewConverter(SPECIALIZATION specialization)
        {
            switch (specialization)
            {
                case SPECIALIZATION.Rogue:
                    SkillBuilder = new RogueSkillViewListBuilder();
                    break;
                case SPECIALIZATION.Mage:
                    SkillBuilder = new MageSkillViewListBuilder();
                    break;
                default:
                    SkillBuilder = new WarriorSkillViewListBuilder();
                    break;
            }
            SkillList = SkillBuilder.Get();
        }
        public ISkillView Convert(ISkill skill) => FindSkillViewTemplate(skill);
        public List<ISkillView> ConvertRangeToList(List<ISkill> skillList) => new List<ISkillView>(FindRange(skillList));
        public ObservableCollection<ISkillView> ConvertRangeToObservableCollection(List<ISkill> skillList) => new ObservableCollection<ISkillView>(FindRange(skillList));
        private ISkillView FindSkillViewTemplate(ISkill skill)
        {
            foreach (var item in SkillList)
            {
                if (item.Skill.SkillName == skill.SkillName)
                {
                    item.Skill.SkillLevel = skill.SkillLevel;
                    return item;
                }
            }
            return new SkillView();
        }
        private ICollection<ISkillView> FindRange(List<ISkill> skillList)
        {
            var skillViewList = new List<ISkillView>();
            foreach (var item in skillList)
                skillViewList.Add(FindSkillViewTemplate(item));
            return skillViewList;
        }
    }
}
