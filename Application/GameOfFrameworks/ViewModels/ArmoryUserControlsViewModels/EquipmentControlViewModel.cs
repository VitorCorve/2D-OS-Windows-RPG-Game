using GameEngine.Equipment;
using GameEngine.Inventory;
using GameOfFrameworks.Infrastructure.Commands.Armory.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class EquipmentControlViewModel : ViewModel
    {
        private double _panelX;
        private double _panelY;
        private int _InventoryMouseOverSelectionIndex;
        private Dictionary<string, string> _ItemDescription;
        private EquipmentUserInterfaceListModel _WearedItemsLisd;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _ItemsInInventory;
        public EquipmentUserInterfaceListModel WearedItemsList { get => _WearedItemsLisd; set => Set(ref _WearedItemsLisd, value); }
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set => Set(ref _SelectedItem, value); }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> ItemsInInventory { get => _ItemsInInventory; set => Set(ref _ItemsInInventory, value); }
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }
        public int InventoryMouseOverSelectionIndex { get => _InventoryMouseOverSelectionIndex; set => Set(ref _InventoryMouseOverSelectionIndex, value); }
        private Visibility _DescriptionToolTipVisibility;
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
        public ICommand HideDescriptionToolTipDialogCommand { get; private set; }
        public ICommand SelectItemInInventoryCommand { get; private set; }
        public Visibility DescriptionToolTipVisibility { get => _DescriptionToolTipVisibility; set { _DescriptionToolTipVisibility = value; OnPropertyChanged(); } }
        public double PanelX
        {
            get { return _panelX; }
            set
            {
                if (value.Equals(_panelX)) return;
                _panelX = value;
                OnPropertyChanged();
            }
        }

        public double PanelY
        {
            get { return _panelY; }
            set
            {
                if (value.Equals(_panelY)) return;
                _panelY = value;
                OnPropertyChanged();
            }
        }
        public EquipmentControlViewModel()
        {
            var itemEntityToViewTemplateConverter = new ItemEntityToViewTemplateConverter();
            var itemEntity0 = new ItemEntity(0);
            var itemEntity1 = new ItemEntity(1);
            var itemEntity2 = new ItemEntity(2);

            var itemsList = new List<ItemEntity>();
            itemsList.Add(itemEntity0);
            itemsList.Add(itemEntity1);
            itemsList.Add(itemEntity2);

            var itemEntity3 = new ItemEntity(0);
            var itemEntity4 = new ItemEntity(1);
            var itemEntity5 = new ItemEntity(2);
            var itemEntity6 = new ItemEntity(2);
            var itemEntity7 = new ItemEntity(2);
            var itemEntity8 = new ItemEntity(2);
            var itemEntity9 = new ItemEntity(2);
            var itemEntity10 = new ItemEntity(2);

            var inventoryItemsList = new List<ItemEntity>();
            inventoryItemsList.Add(itemEntity3);
            inventoryItemsList.Add(itemEntity4);
            inventoryItemsList.Add(itemEntity5);
            inventoryItemsList.Add(itemEntity6);
            inventoryItemsList.Add(itemEntity7);
            inventoryItemsList.Add(itemEntity8);
            inventoryItemsList.Add(itemEntity9);
            inventoryItemsList.Add(itemEntity10);

            var inventoryItemsListObservableCollection = new ObservableCollection<EquipmentUserInterfaceViewTemplate>();
            inventoryItemsListObservableCollection = itemEntityToViewTemplateConverter.ConvertRangeIntoObservableCollection(inventoryItemsList);
            var equipmentUserInterfaceViewTemplatesList = new List<EquipmentUserInterfaceViewTemplate>();

            equipmentUserInterfaceViewTemplatesList.AddRange(itemEntityToViewTemplateConverter.ConvertRange(itemsList));

            var playerItemList = new PlayerInventoryItemsList();
            playerItemList.AddRange(inventoryItemsList);
            ItemsInInventory = inventoryItemsListObservableCollection;

            WearedItemsList = new EquipmentUserInterfaceListModel();
            WearedItemsList.AddItemsRange(equipmentUserInterfaceViewTemplatesList);


            InitializeCommands();

            SelectedItem = WearedItemsList.MainWeapon;

            DescriptionToolTipVisibility = Visibility.Hidden;

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
            HideDescriptionToolTipDialogCommand = new HideDescriptionToolTipDialogCommand(this);
            SelectItemInInventoryCommand = new SelectItemInInventoryCommand(this);
        }
    }
}
