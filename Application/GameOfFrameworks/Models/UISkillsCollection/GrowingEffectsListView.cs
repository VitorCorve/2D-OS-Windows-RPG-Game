using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GameOfFrameworks.Models.UISkillsCollection
{
    public class GrowingEffectsListView : IGrowingEffectsListView, INotifyPropertyChanged
    {
        private SkillEffectView EffectToRemove;
        private Visibility _Statement;
        public Visibility Statement { get => _Statement; set { _Statement = value; OnPropertyChanged(); } }
        public ObservableCollection<SkillEffectView> EffectsList { get; set; } = new();
        public event PropertyChangedEventHandler PropertyChanged;
        public GrowingEffectsListView()
        {
            Statement = Visibility.Hidden;
        }
        public void AddNew(SkillEffectView skillEffectView)
        {
            foreach (var item in EffectsList)
            {
                if (item.ID == skillEffectView.ID)
                {
                    return;
                }
            }
            EffectsList.Add(skillEffectView);
            if (Statement == Visibility.Hidden) Statement = Visibility.Visible;
        }
        public void RemoveFrom(int ID)
        {
            foreach (var item in EffectsList)
            {
                if (item.ID == ID)
                {
                    EffectToRemove = item;
                }
            }
            EffectsList.Remove(EffectToRemove);
            EffectToRemove = null;

            if (EffectsList.Count == 0) Statement = Visibility.Hidden;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
