using GameEngine.Data;
using GameEngine.Player;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.Options
{
    public class SaveDataPresentationModel : INotifyPropertyChanged
    {
        private string _Name;
        private int _Level;
        private SPECIALIZATION _Specialization;
        private int _Health;
        private int _Mana;
        private int _Energy;
        private string _Location;
        private string _Date;
        private string _AvatarPath;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }
        public int Level { get => _Level; set { _Level = value; OnPropertyChanged(); } }
        public SPECIALIZATION Specialization { get => _Specialization; set { _Specialization = value; OnPropertyChanged(); } }
        public int Health { get => _Health; set { _Health = value; OnPropertyChanged(); } }
        public int Mana { get => _Mana; set { _Mana = value; OnPropertyChanged(); } }
        public int Energy { get => _Energy; set { _Energy = value; OnPropertyChanged(); } }
        public string Location { get => _Location; set { _Location = value; OnPropertyChanged(); } }
        public string Date { get => _Date; set { _Date = value; OnPropertyChanged(); } }
        public string AvatarPath { get => _AvatarPath; set { _AvatarPath = value; OnPropertyChanged(); } }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public event PropertyChangedEventHandler PropertyChanged;
        public void Show(PlayerSaveData playerSaveData)
        {
            Name = playerSaveData.Name;
            Level = playerSaveData.Level;
            Specialization = playerSaveData.Specialization;
            Health = playerSaveData.PlayerHealthValue;
            Mana = playerSaveData.PlayerManaValue;
            Energy = playerSaveData.PlayerEnergyValue;
            Location = playerSaveData.CurrentTown.ToString().Replace("_", " ");
            Date = playerSaveData.Date;
            AvatarPath = playerSaveData.AvatarPath.Path;
        }
    }
}
