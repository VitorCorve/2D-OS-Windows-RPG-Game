using GameOfFrameworks.Models.UISkillsCollection.Player;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class WearedViewList : INotifyPropertyChanged
    {
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _EquipmentSlotsList;
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> EquipmentSlotsList { get => _EquipmentSlotsList; set => Set(ref _EquipmentSlotsList, value); }
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public WearedViewList()
        {
            EquipmentSlotsList = new ObservableCollection<EquipmentUserInterfaceViewTemplate>();
        }
    }
}
