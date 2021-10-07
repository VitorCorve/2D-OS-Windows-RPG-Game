using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Linq;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Attributes
{
    public class SortSkillsCommand : Command
    {
        private ISkillListViewModel ViewModel;
        public SortSkillsCommand(ISkillListViewModel attributesControlViewModel) => ViewModel = attributesControlViewModel;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var availableSkills = ViewModel.AvailableSkills;

            var orderedByAvailabilityLevel = from i in availableSkills
                                             orderby i.Skill.AvailableAtLevel
                                             select i;

            ViewModel.AvailableSkills = ConvertResult(orderedByAvailabilityLevel);
            ((ViewModel)ViewModel).OnPropertyChanged(nameof(ViewModel.AvailableSkills));
        }
        private ObservableCollection<ISkillView> ConvertResult(IOrderedEnumerable<ISkillView> orderedList)
        {
            var skillViewList = new ObservableCollection<ISkillView>();
            foreach (var item in orderedList) skillViewList.Add(item);
            return skillViewList;
        }
    }
}
