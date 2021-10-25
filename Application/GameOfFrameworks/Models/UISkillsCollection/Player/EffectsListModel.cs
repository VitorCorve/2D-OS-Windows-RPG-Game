using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class EffectsListModel : INotifyPropertyChanged
    {
        private ObservableCollection<ISkillEffectView> _SkillEffectViewList;
        public ObservableCollection<ISkillEffectView> SkillEffectViewList { get => _SkillEffectViewList; set => Set(ref _SkillEffectViewList, value); }
        public event PropertyChangedEventHandler PropertyChanged;
        public GrowingEffectsListView BuffsList { get; set; } = new();
        public GrowingEffectsListView DebuffsList { get; set; } = new();
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public EffectsListModel()
        {
            SkillEffectViewList = new ObservableCollection<ISkillEffectView>();
            for (int i = 0; i < 10; i++)
            {
                var skillView = new SkillEffectView();
                SkillEffectViewList.Add(skillView);
            }
        }
        public void Initialize(ObservableCollection<ISkillView> playerSkills)
        {
            for (int i = 0; i < playerSkills.Count; i++)
            {
                SkillEffectViewList[i] = new SkillEffectView(playerSkills[i], BuffsList, DebuffsList);
                SkillEffectViewList[i].Hide();
            }
        }
    }
}
