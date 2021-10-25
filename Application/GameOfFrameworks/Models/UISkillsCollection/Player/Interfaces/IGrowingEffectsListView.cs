using System.Collections.ObjectModel;
using System.Windows;

namespace GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces
{
    public interface IGrowingEffectsListView
    {
        Visibility Statement { get; }
        ObservableCollection<SkillEffectView> EffectsList { get; }
        void AddNew(SkillEffectView skillEffectView);
        void RemoveFrom(int ID);
    }
}
