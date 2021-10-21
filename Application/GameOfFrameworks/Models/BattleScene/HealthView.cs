using GameEngine.Player.ConditionResources;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.BattleScene
{
    public class HealthView : Health, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private int _Value;
    }
}
