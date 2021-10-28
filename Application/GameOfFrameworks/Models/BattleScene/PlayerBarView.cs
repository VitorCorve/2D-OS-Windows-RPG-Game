using GameEngine.Abstract;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Data;
using GameEngine.Player;
using GameEngine.Player.ConditionResources;
using GameOfFrameworks.Models.BattleScene.Interfaces;
using System;
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
        private string _HealthPercentFill;
        private string _ManaPercentFill;
        private string _EnergyPercentFill;
        private string _HealthPercentEmpty;
        private string _ManaPercentEmpty;
        private string _EnergyPercentEmptyl;
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
        public string HealthPercentFill { get => _HealthPercentFill; set { _HealthPercentFill = value; OnPropertyChanged(); } }
        public string ManaPercentFill { get => _ManaPercentFill; set { _ManaPercentFill = value; OnPropertyChanged(); } }
        public string EnergyPercentFill { get => _EnergyPercentFill; set { _EnergyPercentFill = value; OnPropertyChanged(); } }
        public string HealthPercentEmpty { get => _HealthPercentEmpty; set { _HealthPercentEmpty = value; OnPropertyChanged(); } }
        public string ManaPercentEmpty { get => _ManaPercentEmpty; set { _ManaPercentEmpty = value; OnPropertyChanged(); } }
        public string EnergyPercentEmpty { get => _EnergyPercentEmptyl; set { _EnergyPercentEmptyl = value; OnPropertyChanged(); } }
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
            HealthPercentFill = GetFillPercentage(Health, MaxHealth);
            ManaPercentFill = GetFillPercentage(Mana, MaxMana);
            EnergyPercentFill = GetFillPercentage(Energy, MaxEnergy);

            HealthPercentEmpty = GetEpmtyPercentage(Health, MaxHealth);
            ManaPercentEmpty = GetEpmtyPercentage(Mana, MaxMana);
            EnergyPercentEmpty = GetEpmtyPercentage(Energy, MaxEnergy);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private string GetFillPercentage(int value, int maxValue)
        {
            double percent = maxValue / 100.0;
            double result = Math.Round(value / percent / 100.0, 3);
            return $"{result}*";
        }
        private string GetEpmtyPercentage(int value, int maxValue)
        {
            double percent = maxValue / 100.0;
            double result = Math.Round(1.0 - (value / percent / 100.0), 3);
            return $"{result}*";
        }
    }
}
