using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.ObjectModel;


namespace GameOfFrameworks.Models.Armory.Interfaces
{
    public interface ISkillListViewModel
    {
        ObservableCollection<ISkillView> AvailableSkills { get; set; }
    }
}
