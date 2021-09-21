using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.Inventory;
using GameEngine.Player;
using GameOfFrameworks.Infrastructure.Commands.Armory.Equipment;
using GameOfFrameworks.Models.Armory.AttributesControl;
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
        private Visibility _InventoryItemDeletingDialogUserControl;
        private bool _IsOpenInventoryItemPopubDialogUserControl;
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
        public ICommand ShowInventoryItemPopubDialogUserControlCommand { get; private set; }
        public ICommand ShowInventoryItemDeletingDialogCommand { get; private set; }
        public ICommand HideInventoryItemDeletingDialogUserControl { get; private set; }
        public ICommand DeleteInventoryItemCommand { get; private set; }
        public Visibility DescriptionToolTipVisibility { get => _DescriptionToolTipVisibility; set => Set(ref _DescriptionToolTipVisibility, value); }
        public Visibility InventoryItemDeletingDialogUserControl { get => _InventoryItemDeletingDialogUserControl; set => Set(ref _InventoryItemDeletingDialogUserControl, value); }
        public PlayerInventoryItemsList InventoryModel { get; set; }
        public WearedEquipment EquipmentModel { get; set; }
        public bool IsOpenInventoryItemPopupDialogUserControl { get => _IsOpenInventoryItemPopubDialogUserControl; set => Set(ref _IsOpenInventoryItemPopubDialogUserControl, value); }
        public EquipmentControlViewModel()
        {
            DescriptionToolTipVisibility = Visibility.Hidden;
            InventoryItemDeletingDialogUserControl = Visibility.Hidden;

            PlayerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;

            InventoryModel = new PlayerInventoryItemsList(0, 0, 1, 2, 2, 2, 2, 2, 1, 2, 2, 1, 0, 0, 0, 0, 1, 2, 1, 0, 1, 2, 2, 2, 1, 1, 1, 0, 0, 0, 2, 1, 2, 2, 1, 0, 0, 0, 0, 1);
            EquipmentModel = new WearedEquipment();

/*            InventoryModel = new PlayerInventoryItemsList(ArmoryTemporaryData.SaveData.ItemsInInventory.ConvertToItemsEntityList());
            EquipmentModel = new WearedEquipment(ArmoryTemporaryData.SaveData.ItemsOnCharacter.ConvertToItemsEntityList());*/

            InventoryView = new InventoryViewList();
            EquipmentView = new WearedViewList();

            EquipmentHandler = new EquipmentManager(this);

            InitializeCommands();
        }
        private void InitializeCommands()
        {
            HideDescriptionToolTipDialogCommand = new HideDescriptionToolTipDialogCommand(this);
            TakeOffWearedItemCommand = new TakeOffWearedItemCommand(this);
            WearItemFromInventoryCommand = new WearItemFromInventoryCommand(this);
            SelectItemFromEquippmentCommand = new SelectItemFromEquippmentCommand(this);
            SelectItemInInventoryCommand = new SelectItemInInventoryCommand(this);
            ShowInventoryItemPopubDialogUserControlCommand = new ShowInventoryItemPopubDialogUserControlCommand(this);
            ShowInventoryItemDeletingDialogCommand = new ShowInventoryItemDeletingDialogCommand(this);
            HideInventoryItemDeletingDialogUserControl = new HideInventoryItemDeletingDialogUserControl(this);
            DeleteInventoryItemCommand = new DeleteInventoryItemCommand(this);
        }
        public void SaveInventoryChanges()
        {
            ArmoryTemporaryData.PlayerEquipment = EquipmentModel;
            ArmoryTemporaryData.PlayerInventory = InventoryModel;
        }
    }
}
