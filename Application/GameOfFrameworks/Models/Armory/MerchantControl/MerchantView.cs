using GameOfFrameworks.Models.Armory.MerchantControl.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.MerchantControl
{
    public class MerchantView : IMerchantView, INotifyPropertyChanged
    {
        private string _Name;
        private string _AvatarPath; 
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }
        public string AvatarPath { get => _AvatarPath; set { _AvatarPath = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
