using GameEngine.CombatEngine;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;
using GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Windows.Input;

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

        private PlayerModelData _PlayerModel;
        public PlayerModelData PlayerModel { get => _PlayerModel; set { _PlayerModel = value; OnPropertyChanged(); } }

        private PlayerEntity _PlayerEntity;
        public PlayerEntity PlayerEntity { get => _PlayerEntity; set { _PlayerEntity = value; OnPropertyChanged(); } }

        private IEntityAttributes _CharacterBasicAttributes;
        public IEntityAttributes CharacterBasicAttributes { get => _CharacterBasicAttributes; set { _CharacterBasicAttributes = value; OnPropertyChanged(); } }

        private string _SpecializationDescription;
        public string SpecializationDescription { get => _SpecializationDescription; set { _SpecializationDescription = value; OnPropertyChanged(); } }
        public List<ISkillView> SkillViewList { get; set; }
        public ISkillView SelectedSkill { get; set; }
        public ICommand SelectSkill1Command { get; set; }
        public ICommand SelectSkill2Command { get; set; }
        public ICommand SelectSkill3Command { get; set; }
        public ICommand SelectSkill4Command { get; set; }
        public ICommand SelectSkill5Command { get; set; }
        public ICommand SaveCharacterCommand { get; set; }
        public ApplyCharacterCreationViewModel()
        {
            InitializeData();
            InitializeSkills();
            InitializeCommands();
            InitializeSkillDataView();
        }
        private void InitializeCommands()
        {
            SelectSkill1Command = new SelectSkill1Command(this);
            SelectSkill2Command = new SelectSkill2Command(this);
            SelectSkill3Command = new SelectSkill3Command(this);
            SelectSkill4Command = new SelectSkill4Command(this);
            SelectSkill5Command = new SelectSkill5Command(this);
            SaveCharacterCommand = new SaveCharacterCommand(PlayerModel);
        }
        private void InitializeData()
        {
            PlayerModel = NewGameCharacterTemporaryData.PlayerModel;
            PlayerEntity = NewGameCharacterTemporaryData.PlayerEntity;
            CharacterBasicAttributes = NewGameCharacterTemporaryData.CharacterBaseAttributes;
            SpecializationDescription = NewGameCharacterTemporaryData.SpecializationDescription.Description;
        }
        private void InitializeSkills()
        {
            var skillViewBuilder = new SkillViewBuilder(PlayerModel);
            SkillViewList = skillViewBuilder.Build();
        }
        private void InitializeSkillDataView()
        {
            SelectedSkill = SkillViewList[0];
            SelectedSkillDescription = SelectedSkill.Description;
        }
    }
}
