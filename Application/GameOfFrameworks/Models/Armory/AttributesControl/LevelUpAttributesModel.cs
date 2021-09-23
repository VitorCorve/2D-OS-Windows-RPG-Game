using GameEngine.Player.Abstract;
using GameEngine.Player.Specializatons;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameOfFrameworks.Models.Armory.AttributesControl
{
    public class LevelUpAttributesModel : INotifyPropertyChanged
    {
        private int _Stamina;
        private int _Strength;
        private int _Endurance;
        private int _Intellect;
        private int _Agility;
        public int Stamina { get => _Stamina; set => Set(ref _Stamina, value); }
        public int Strength { get => _Strength; set => Set(ref _Strength, value); }
        public int Endurance { get => _Endurance; set => Set(ref _Endurance, value); }
        public int Intellect { get => _Intellect; set => Set(ref _Intellect, value); }
        public int Agility { get => _Agility; set => Set(ref _Agility, value); }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string property = null)  => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public LevelUpAttributesModel(IEntityAttributes playerAttributes)
        {
            Stamina = playerAttributes.Stamina;
            Strength = playerAttributes.Strength;
            Endurance = playerAttributes.Endurance;
            Intellect = playerAttributes.Intellect;
            Agility = playerAttributes.Agility;
        }
        public void UpdateAttribute(string attribute)
        {
            switch (attribute)
            {
                case "Stamina":
                    Stamina++;
                    return;
                case "Strength":
                    Strength++;
                    return;
                case "Endurance":
                    Endurance++;
                    return;
                case "Intellect":
                    Intellect++;
                    return;
                case "Agility":
                    Agility++;
                    return;
            }
        }
        public IEntityAttributes ReturnEntityAttributes()
        {
            var entityModelTemplate = new EntityModelTemplate();

            entityModelTemplate.Stamina = Stamina;
            entityModelTemplate.Strength = Strength;
            entityModelTemplate.Endurance = Endurance;
            entityModelTemplate.Intellect = Intellect;
            entityModelTemplate.Agility = Agility;

            return entityModelTemplate;
        }
    }
}