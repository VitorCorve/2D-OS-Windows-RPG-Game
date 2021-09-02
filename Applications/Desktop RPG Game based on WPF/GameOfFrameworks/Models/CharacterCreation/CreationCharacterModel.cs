using GameEngine.Player;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.CharacterCreation
{
    public class CreationCharacterModel : INotifyPropertyChanged
    {
        public string Name { get => _Name; set => Set(ref _Name, value); }
        public GENDER Gender { get => _Gender; set => Set(ref _Gender, value); }
        public SPECIALIZATION Specialization { get => _Specialization; set => Set(ref _Specialization, value); }
        public string Bio { get => _Bio; set => Set(ref _Bio, value); }
        public int Strength { get => _Strength; set => Set(ref _Strength, value); }
        public int Stamina { get => _Stamina; set => Set(ref _Stamina, value); }
        public int Endurance { get => _Endurance; set => Set(ref _Endurance, value); }
        public int Intellect { get => _Intellect; set => Set(ref _Intellect, value); }
        public int Agility { get => _Agility; set => Set(ref _Agility, value); }

        private string _Name;
        private GENDER _Gender;
        private SPECIALIZATION _Specialization;
        private string _Bio;
        private int _Strength;
        private int _Stamina;
        private int _Endurance;
        private int _Intellect;
        private int _Agility;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
