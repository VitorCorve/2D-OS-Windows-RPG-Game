using GameEngine.Equipment;
using GameOfFrameworks.Infrastructure.Commands.Armory.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class EquipmentControlViewModel : ViewModel
    {
        private Dictionary<string, string> _ItemDescription;
        private EquipmentUserInterfaceListModel _WearedItemsLisd;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        public EquipmentUserInterfaceListModel WearedItemsList { get => _WearedItemsLisd; set => Set(ref _WearedItemsLisd, value); }
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set => Set(ref _SelectedItem, value); }
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }
        public ICommand SelectHelmetInfoCommand { get; private set; }
        public ICommand SelectGlovesInfoCommand { get; private set; }
        public ICommand SelectMainWeaponInfoCommand { get; private set; }
        public ICommand SelectShouldersInfoCommand { get; private set; }
        public ICommand SelectBracersInfoCommand { get; private set; }
        public ICommand SelectSecondWeaponInfoCommand { get; private set; }
        public ICommand SelectNecklaceInfoCommand { get; private set; }
        public ICommand SelectWaistInfoCommand { get; private set; }
        public ICommand SelectFisrtArtefactInfoCommand { get; private set; }
        public ICommand SelectSecondArtefactInfoCommand { get; private set; }
        public ICommand SelectThirdArtefactInfoCommand { get; private set; }
        public ICommand SelectChestInfoCommand { get; private set; }
        public ICommand SelectPantsInfoCommand { get; private set; }
        public ICommand SelectCloakInfoCommand { get; private set; }
        public ICommand SelectBootsInfoCommand { get; private set; }

        public EquipmentControlViewModel()
        {
            var itemEntity0 = new ItemEntity(0);
            var itemEntity1 = new ItemEntity(1);
            var itemEntity2 = new ItemEntity(2);

            var equipmentUserInterfaceViewTemplate0 = new EquipmentUserInterfaceViewTemplate();
            var equipmentUserInterfaceViewTemplate1 = new EquipmentUserInterfaceViewTemplate();
            var equipmentUserInterfaceViewTemplate2 = new EquipmentUserInterfaceViewTemplate();

            equipmentUserInterfaceViewTemplate0.Build(itemEntity0);
            equipmentUserInterfaceViewTemplate1.Build(itemEntity1);
            equipmentUserInterfaceViewTemplate2.Build(itemEntity2);


            WearedItemsList = new EquipmentUserInterfaceListModel();
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate0);
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate1);
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate2);

            InitializeCommands();

            SelectedItem = WearedItemsList.MainWeapon;

        }
        private void InitializeCommands()
        {
            SelectHelmetInfoCommand = new SelectHelmetInfoCommand(this);
            SelectGlovesInfoCommand = new SelectGlovesInfoCommand(this);
            SelectMainWeaponInfoCommand = new SelectMainWeaponInfoCommand(this);
            SelectShouldersInfoCommand = new SelectShouldersInfoCommand(this);
            SelectBracersInfoCommand = new SelectBracersInfoCommand(this);
            SelectSecondWeaponInfoCommand = new SelectSecondWeaponInfoCommand(this);
            SelectNecklaceInfoCommand = new SelectNecklaceInfoCommand(this);
            SelectWaistInfoCommand = new SelectWaistInfoCommand(this);
            SelectFisrtArtefactInfoCommand = new SelectFisrtArtefactInfoCommand(this);
            SelectSecondArtefactInfoCommand = new SelectSecondArtefactInfoCommand(this);
            SelectThirdArtefactInfoCommand = new SelectThirdArtefactInfoCommand(this);
            SelectChestInfoCommand = new SelectChestInfoCommand(this);
            SelectPantsInfoCommand = new SelectPantsInfoCommand(this);
            SelectCloakInfoCommand = new SelectCloakInfoCommand(this);
            SelectBootsInfoCommand = new SelectBootsInfoCommand(this);
        }
    }
}
