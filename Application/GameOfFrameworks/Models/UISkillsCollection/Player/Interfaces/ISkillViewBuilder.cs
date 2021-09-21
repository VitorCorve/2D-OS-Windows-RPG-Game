using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface ISkillViewBuilder
    {
        List<ISkillView> SkillCollection { get; }
        List<ISkill> PlayerSkillList { get; }
        SPECIALIZATION PlayerSpecialization { get; }
        List<ISkillView> BuildList();
        ObservableCollection<ISkillView> BuildObservableCollection();
    }
}
