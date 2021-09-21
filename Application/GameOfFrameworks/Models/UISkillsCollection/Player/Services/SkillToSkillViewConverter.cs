using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Services
{
    public class SkillToSkillViewConverter : ISkillToSkillViewConverter
    {
        private ISkillViewListBuilder SkillBuilder;
        private readonly SPECIALIZATION PlayerSpecialization;
        public SkillToSkillViewConverter(SPECIALIZATION specialization) => PlayerSpecialization = specialization;
        public ISkillView Convert(ISkill skill)
        {
            switch (PlayerSpecialization)
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
            return FindSkillViewTemplate(skill);
        }
        public List<ISkillView> ConvertRangeToList(List<ISkill> skillList)
        {
            switch (PlayerSpecialization)
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
            return new List<ISkillView>(FindRange(skillList));
        }
        public ObservableCollection<ISkillView> ConvertRangeToObservableCollection(List<ISkill> skillList)
        {
            switch (PlayerSpecialization)
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
            return new ObservableCollection<ISkillView>(FindRange(skillList));
 
        }
        private ISkillView FindSkillViewTemplate(ISkill skill)
        {
            var skillList = SkillBuilder.Get();
            foreach (var item in skillList)
            {
                if (item.Skill.SkillName == skill.SkillName)
                    item.Skill.SkillLevel = skill.SkillLevel;
                return item;
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
