using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Armory.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class EquipmentControlViewModel : ViewModel
    {
        private WearedViewList _WearedItemsList;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        private InventoryViewList _InventoryItemsList;
        private Dictionary<string, string> _ItemDescription;
        private PlayerConsumablesData _PlayerConsumables;
        private Visibility _DescriptionToolTipVisibility;
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set => Set(ref _SelectedItem, value); }
        public InventoryViewList InventoryView { get => _InventoryItemsList; set => Set(ref _InventoryItemsList, value); }
        public WearedViewList EquipmentView { get => _WearedItemsList; set => Set(ref _WearedItemsList, value); }
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }
        public PlayerConsumablesData PlayerConsumables { get => _PlayerConsumables; set => Set(ref _PlayerConsumables, value); }
        public EquipmentManager EquipmentHandler { get; set; }
        public ICommand HideDescriptionToolTipDialogCommand { get; private set; }
        public ICommand SelectItemInInventoryCommand { get; private set; }
        public ICommand TakeOffWearedItemCommand { get; private set; }
        public ICommand WearItemFromInventoryCommand { get; private set; }
        public ICommand SelectItemFromEquippmentCommand { get; private set; }
        public Visibility DescriptionToolTipVisibility { get => _DescriptionToolTipVisibility; set => Set(ref _DescriptionToolTipVisibility, value); }
        public PlayerInventoryItemsList InventoryModel { get; set; }
        public WearedEquipment EquipmentModel { get; set; }
        public EquipmentControlViewModel()
        {
            PlayerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;

            InventoryModel = new PlayerInventoryItemsList(0, 0, 1, 2, 2, 2, 2, 2);
            EquipmentModel = new WearedEquipment();

            InventoryView = new InventoryViewList();
            EquipmentView = new WearedViewList();

            EquipmentHandler = new EquipmentManager(this, InventoryView, EquipmentView, EquipmentModel, InventoryModel, SelectedItem);

            InitializeCommands();

        }
        private void InitializeCommands()
        {
            HideDescriptionToolTipDialogCommand = new HideDescriptionToolTipDialogCommand(this);

            TakeOffWearedItemCommand = new TakeOffWearedItemCommand(this);
            WearItemFromInventoryCommand = new WearItemFromInventoryCommand(this);
            SelectItemFromEquippmentCommand = new SelectItemFromEquippmentCommand(this);
            SelectItemInInventoryCommand = new SelectItemInInventoryCommand(this);
        }
    }
}
