using GameOfFrameworks.ApplicationData.Interfaces;
using GameOfFrameworks.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GameOfFrameworks.ApplicationData
{
    public class KeyboardBindingsModel : INotifyPropertyChanged
    {
        private List<IButtonBinding> _Bindings;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyChanged = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        public List<IButtonBinding> Bindings { get => _Bindings; set { _Bindings = value; OnPropertyChanged(); } }
        public void ChangeButtonBinding(int index, Key buttonKey)
        {
            var bindings = Bindings;
            Bindings = null;
            bindings[index].Key = buttonKey;
            bindings[index].Name = buttonKey.ToString();
            Bindings = bindings;
        }
        public void SkillUse(Key key)
        {
            foreach (var item in Bindings)
            {
                if (item.Key == key)
                {
                    BattleWindowViewModel.UseSkillCommand.Execute(item.ShortcutIndex);
                    return;
                }
            }
        }
    }
}