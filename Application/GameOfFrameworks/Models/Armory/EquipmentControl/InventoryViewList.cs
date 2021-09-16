using GameOfFrameworks.Models.UISkillsCollection.Player;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class InventoryViewList : INotifyPropertyChanged
    {
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _InventorySlotsList;
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> InventorySlotsList { get => _InventorySlotsList; set => Set(ref _InventorySlotsList, value); }
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public InventoryViewList()
        {
            InventorySlotsList = new ObservableCollection<EquipmentUserInterfaceViewTemplate>();
        }
    }
}
