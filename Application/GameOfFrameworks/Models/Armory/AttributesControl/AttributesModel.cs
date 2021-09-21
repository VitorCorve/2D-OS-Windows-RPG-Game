using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace GameOfFrameworks.Models.Armory.AttributesControl
{
    public class AttributesModel : INotifyPropertyChanged
    {
        private int _Health;
        private int _Mana;
        private int _Energy;
        private double _HealthRegen;
        private double _ManaRegen;
        private double _EnergyRegen;
        private int _Stamina;
        private int _Strength;
        private int _Endurance;
        private int _Intellect;
        private int _Agility;
        private int _Armor;
        private int _AttackPower;
        private double _CriticalHitChance;
        private double _DodgeChance;
        private double _BlockChance;
        private double _ParryChance;

        public int Health { get => _Health; set => Set(ref _Health, value); }
        public int Mana { get => _Mana; set => Set(ref _Mana, value); }
        public int Energy { get => _Energy; set => Set(ref _Energy, value); }
        public double HealthRegen { get => _HealthRegen; set => Set(ref _HealthRegen, value); }
        public double ManaRegen { get => _ManaRegen; set => Set(ref _ManaRegen, value); }
        public double EnergyRegen { get => _EnergyRegen; set => Set(ref _EnergyRegen, value); }
        public int Stamina { get => _Stamina; set => Set(ref _Stamina, value); }
        public int Strength { get => _Strength; set => Set(ref _Strength, value); }
        public int Endurance { get => _Endurance; set => Set(ref _Endurance, value); }
        public int Intellect { get => _Intellect; set => Set(ref _Intellect, value); }
        public int Agility { get => _Agility; set => Set(ref _Agility, value); }
        public int Armor { get => _Armor; set => Set(ref _Armor, value); }
        public int AttackPower { get => _AttackPower; set => Set(ref _AttackPower, value); }
        public double CriticalHitChance { get => _CriticalHitChance; set { _CriticalHitChance = Convert(value); OnPropertyChanged(); } }
        public double DodgeChance { get => _DodgeChance; set { _DodgeChance = Convert(value); OnPropertyChanged(); } }
        public double BlockChance { get => _BlockChance; set { _BlockChance = Convert(value); OnPropertyChanged(); } }
        public double ParryChance { get => _ParryChance; set { _ParryChance = Convert(value); OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public AttributesModel(PlayerEntity playerEntity, IEntityAttributes playerAttributes, IEntityAttributes equipment)
        {
            Health = playerEntity.HealthPoints.Value;
            Mana = playerEntity.ManaPoints.Value;
            Energy = playerEntity.EnergyPoints.Value;
            HealthRegen = playerEntity.RecoverResources.HealthPoints.RecoveryValue;
            ManaRegen = playerEntity.RecoverResources.ManaPoints.RecoveryValue;
            EnergyRegen = playerEntity.RecoverResources.EnergyPoints.RecoveryValue;
            Stamina = playerAttributes.Stamina + equipment.Stamina;
            Strength = playerAttributes.Strength + equipment.Strength;
            Endurance = playerAttributes.Endurance + equipment.Endurance;
            Intellect = playerAttributes.Intellect + equipment.Intellect;
            Agility = playerAttributes.Agility + equipment.Agility;
            Armor = playerEntity.ArmorPoints.Value;
            AttackPower = playerEntity.Attack.Value;
            CriticalHitChance = playerEntity.CriticalChance.Value;
            DodgeChance = playerEntity.DodgeChance.Value;
            BlockChance = playerEntity.BlockChance.Value;
            ParryChance = playerEntity.ParryChance.Value;
        }
        private double Convert(double value) => Math.Round(value, 2);
    }
}
