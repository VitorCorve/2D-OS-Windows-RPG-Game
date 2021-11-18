using GameEngine.CombatEngine;
using GameEngine.NPC.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GameOfFrameworks.Models.BattleScene
{
    public class CharacterPreviewBarModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Visibility _AttributesVisibility;
        private Visibility _AttributesGridVisibility;
        private double _AttributesOpacity;
        private double _AttributesGridOpacity;
        private Thickness _AttributesGridMargin;
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Endurance { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Armor { get; set; }
        public int DamageValue { get; set; }
        public string AvatarPath { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public Visibility AttributesVisibility { get => _AttributesVisibility; set { _AttributesVisibility = value; OnPropertyChanged(); } }
        public Visibility AttributesGridVisibility { get => _AttributesGridVisibility; set { _AttributesGridVisibility = value; OnPropertyChanged(); } }
        public double AttributesOpacity { get => _AttributesOpacity; set { _AttributesOpacity = value; OnPropertyChanged(); } }
        public double AttributesGridOpacity { get => _AttributesGridOpacity; set { _AttributesGridOpacity = value; OnPropertyChanged(); } }
        public Thickness AttributesGridMargin { get => _AttributesGridMargin; set { _AttributesGridMargin = value; OnPropertyChanged(); } }
        public CharacterPreviewBarModel(PlayerEntity playerEntity, IEntityAttributes characterAttributes)
        {
            Strength = characterAttributes.Strength;
            Stamina = characterAttributes.Stamina;
            Endurance = characterAttributes.Endurance;
            Intellect = characterAttributes.Intellect;
            Agility = characterAttributes.Agility;
            Armor = characterAttributes.ArmorValue;
            DamageValue = playerEntity.Attack.Value;
        }
        public CharacterPreviewBarModel(PlayerEntity playerEntity, IEntityAttributes characterAttributes, INPC_ModelData npcModel) : this(playerEntity, characterAttributes)
        {
            AvatarPath = npcModel.Avatar.Path;
            Name = npcModel.Name.ToString().Replace("_", " ");
            Specialization = npcModel.NPC_Type.ToString().Replace("_", " ");
        }
        public CharacterPreviewBarModel(PlayerEntity playerEntity, IEntityAttributes characterAttributes, PlayerModelData playerModel) : this(playerEntity, characterAttributes)
        {
            AvatarPath = playerModel.AvatarPath.Path;
            Name = playerModel.Name;
            Specialization = playerModel.Specialization.ToString();
        }
    }
}
