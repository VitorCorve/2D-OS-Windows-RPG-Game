using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using GameEngine.Player.ModelConditions;
using GameOfFrameworks.Models.CharacterCreation;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;

namespace GameOfFrameworks.ViewModels
{
    public class ApplyCharacterCreationViewModel : ViewModel
    {
        public string SelectedSkillDescription { get; set; }
        public string SelectedSkillName { get; set; }
        public Health PlayerHealth { get; set; }
        public Mana PlayerMana { get; set; }
        public Energy PlayerEnergy { get; set; }
        public AttackPower PlayerAttackPower { get; set; }
        public Dodge PlayerDodgeChance { get; set; }
        public IEnumerable<ISkill> SkillList { get; set; }

        private PlayerModelData _PlayerModel;
        private PlayerEntity _PlayerEntity;
        private IEntityAttributes _CharacterBasicAttributes;
        public PlayerModelData PlayerModel { get => _PlayerModel; set { _PlayerModel = value; OnPropertyChanged(); } }
        public PlayerEntity PlayerEntity { get => _PlayerEntity; set { _PlayerEntity = value; OnPropertyChanged(); } }
        public IEntityAttributes CharacterBasicAttributes { get => _CharacterBasicAttributes; set { _CharacterBasicAttributes = value; OnPropertyChanged(); } }

        private string _SpecializationDescription;
        public string SpecializationDescription { get => _SpecializationDescription; set { _SpecializationDescription = value; OnPropertyChanged(); } }
        public ApplyCharacterCreationViewModel()
        {
            PlayerModel = NewGameCharacterTemporaryData.PlayerModel;
            PlayerEntity = NewGameCharacterTemporaryData.PlayerEntity;
            CharacterBasicAttributes = NewGameCharacterTemporaryData.CharacterBaseAttributes;
            SpecializationDescription = NewGameCharacterTemporaryData.SpecializationDescription.Description;
        }
    }
}
