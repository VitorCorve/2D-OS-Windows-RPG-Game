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
        public string Name { get; private set; }
        public int Level { get; private set; }
        public IConditionResourceType HP { get; private set; }
        public IConditionResourceType MP { get; private set; }
        public IConditionResourceType ENRG { get; private set; }
        public int Health { get => _Health; set { _Health = value; OnPropertyChanged(); } }
        public int Mana { get => _Mana; set { _Mana = value; OnPropertyChanged(); } }
        public int Energy { get => _Energy; set { _Energy = value; OnPropertyChanged(); } }
        public PlayerBarView(PlayerEntity playerEntity, int level, string name)
        {
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
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
