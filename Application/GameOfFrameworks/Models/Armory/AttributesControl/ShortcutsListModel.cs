using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.AttributesControl
{
    public class ShortcutsListModel : INotifyPropertyChanged
    {
        private ObservableCollection<ISkillView> _SkillViewList;
        public ObservableCollection<ISkillView> SkillViewList { get => _SkillViewList; set => Set(ref _SkillViewList, value); }
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public ShortcutsListModel()
        {
            SkillViewList = new ObservableCollection<ISkillView>();
            for (int i = 0; i < 10; i++)
            {
                var skillView = new SkillView();
                SkillViewList.Add(skillView);
            }
        }
        public void Initialize(ObservableCollection<ISkillView> playerSkills)
        {
            for (int i = 0; i < playerSkills.Count; i++)
            {
                SkillViewList[i] = playerSkills[i];
            }
        }
    }
}
