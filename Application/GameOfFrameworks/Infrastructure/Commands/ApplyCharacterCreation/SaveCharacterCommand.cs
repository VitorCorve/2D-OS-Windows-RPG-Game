using GameEngine.CombatEngine;
using GameEngine.Data;
using GameEngine.Data.Interfaces;
using GameEngine.Data.Services;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Locations;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.ViewModels;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.ApplyCharacterCreation
{
    public class SaveCharacterCommand : Command
    {
        private readonly PlayerEntity Entity;
        public ApplyCharacterCreationViewModel ViewModel { get; set; }
        public PlayerModelData PlayerModel { get; set; }
        public PlayerSaveData DataToSave { get; private set; }
        public SaveGameService SaveService { get; private set; }
        public PlayerSkillList SkillList { get; private set; } 
        public AvailableSkillListBuilder AvailableSkillListManager { get; set; }
        public PlayerModelToPlayerSaveDataConverter DataConverter { get; set; }
        public SaveCharacterCommand(PlayerModelData playerModelData, ApplyCharacterCreationViewModel viewModel)
        {
            PlayerModel = playerModelData;
            ViewModel = viewModel;
            var playerEntityConstructor = new PlayerEntityConstructor();
            Entity = playerEntityConstructor.CreatePlayer(PlayerModel, ViewModel.CharacterBasicAttributes);
        }

        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            SkillList = new PlayerSkillList();
            AvailableSkillListManager = new AvailableSkillListBuilder(PlayerModel);
            SkillList.Skills = AvailableSkillListManager.SkillList;

            var playerSaveDataBuilder = new PlayerSaveDataBuilder();
            DataToSave = playerSaveDataBuilder.Build(PlayerModel, new Location(), new PlayerInventoryItemsList(), new WearedEquipment(), SkillList, ViewModel.CharacterBasicAttributes, null, Entity);

            DataToSave.Date = DateTime.Now.ToString("yy.MM.dd H:mm:ss");
            var saveService = new SaveGameService();
            saveService.Save(DataToSave, false);
            MainWindowViewModel.ShowNotificationCommand.Execute(null);
        }
    }
}
