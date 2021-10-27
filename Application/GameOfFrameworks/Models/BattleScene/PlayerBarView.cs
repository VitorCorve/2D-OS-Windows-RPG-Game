using GameEngine.Abstract;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Data;
using GameEngine.Player;
using GameEngine.Player.ConditionResources;
using GameOfFrameworks.Models.BattleScene.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace GameOfFrameworks.Models.BattleScene
{
    public class PlayerBarView : ICharacterBarView, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _Health;
        private int _Mana;
        private int _Energy;
        private int _MaxHealth;
        private int _MaxMana;
        private int _MaxEnergy;
        private int _HealthPercent;
        private int _ManaPercent;
        private int _EnergyPercent;
        public string Name { get; private set; }
        public int Level { get; private set; }
        public IConditionResourceType HP { get; private set; }
        public IConditionResourceType MP { get; private set; }
        public IConditionResourceType ENRG { get; private set; }
        public int Health { get => _Health; set { _Health = value; OnPropertyChanged(); } }
        public int Mana { get => _Mana; set { _Mana = value; OnPropertyChanged(); } }
        public int Energy { get => _Energy; set { _Energy = value; OnPropertyChanged(); } }
        public int MaxHealth { get => _MaxHealth; set { _MaxHealth = value; OnPropertyChanged(); } }
        public int MaxMana { get => _MaxMana; set { _MaxMana = value; OnPropertyChanged(); } }
        public int MaxEnergy { get => _MaxEnergy; set { _MaxEnergy = value; OnPropertyChanged(); } }
        public int HealthPercent { get => _HealthPercent; set { _HealthPercent = value; OnPropertyChanged(); } }
        public int ManaPercent { get => _ManaPercent; set { _ManaPercent = value; OnPropertyChanged(); } }
        public int EnergyPercent { get => _EnergyPercent; set { _EnergyPercent = value; OnPropertyChanged(); } }
        public PlayerBarView(PlayerEntity playerEntity, int level, string name)
        {
            MaxHealth = playerEntity.HealthPoints.MaxValue;
            MaxMana = playerEntity.ManaPoints.MaxValue;
            MaxEnergy = playerEntity.EnergyPoints.MaxValue;
            HP = playerEntity.HealthPoints;
            MP = playerEntity.ManaPoints;
            ENRG = playerEntity.EnergyPoints;
            Level = level;
            Name = name;
        }
        public void UpdateValues()
        {
            Health = HP.Value;
            Mana = MP.Value;
            Energy = ENRG.Value;
            HealthPercent = (int)GetPercentage(Health, MaxHealth);
            ManaPercent = (int)GetPercentage(Mana, MaxMana);
            EnergyPercent = (int)GetPercentage(Energy, MaxEnergy);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private double GetPercentage(int value, int maxValue)
        {
            double percent = maxValue / 100.0;
            return value / percent;
        }
    }
}
