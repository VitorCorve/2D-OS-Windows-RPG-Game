using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Armory.MerchantControl;
using GameOfFrameworks.Models.Armory.MerchantControl.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using GameEngine.Player;
using GameEngine.Equipment;
using System.Windows;
using System.Windows.Input;
using GameOfFrameworks.Infrastructure.Commands.Armory.Merchant;
using GameEngine.Inventory;
using GameOfFrameworks.Infrastructure.Commands.Armory;
using GameEngine.Locations.Interfaces;
using System;
using System.Collections.Generic;
using GameEngine.Equipment.Db.Items;
using GameEngine.LootMaster;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class MerchantControlViewModel : ViewModel
    {
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _PlayerItems;
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _MerchantItems;
        private EquipmentUserInterfaceViewTemplate _PlayerInventorySelect;
        private EquipmentUserInterfaceViewTemplate _MecrhantInventorySelect;
        private Visibility _PlayerItemToTradeDescriptionGridVisibility;
        private Visibility _MerchantItemToTradeDescriptionGridVisibility;
        private int _PlayerItemsInInventoryCount;
        private PlayerConsumablesData _PlayerConsumables;
        private PlayerConsumablesData _MerchantConsumables;
        private ILocation _CurrentLocation;
        private CostValue _RepairCostValue;
        public MerchantView Merchant { get; set; }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> PlayerItems { get => _PlayerItems; set => Set(ref _PlayerItems, value); }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> MerchantItems { get => _MerchantItems; set => Set(ref _MerchantItems, value); }
        public EquipmentUserInterfaceViewTemplate PlayerInventorySelect { get => _PlayerInventorySelect; set { Set(ref _PlayerInventorySelect, value); ValidatePlayerItemGridVisibility(value); } }
        public EquipmentUserInterfaceViewTemplate MerchantInventorySelect { get => _MecrhantInventorySelect; set { Set(ref _MecrhantInventorySelect, value); ValidateMerchantItemGridVisibility(value); } }
        public PlayerConsumablesData PlayerConsumables { get => _PlayerConsumables; set => Set(ref _PlayerConsumables, value); }
        public PlayerConsumablesData MerchantConsumables { get => _MerchantConsumables; set => Set(ref _MerchantConsumables, value); }
        public PlayerInventoryItemsList PlayerInventory { get; set; }
        public WearedEquipment PlayerWearedEquipment { get; set; }
        public MerchantInventoryItemsList MerchantInventory { get; set; }
        public MerchantEquipmentHandler EquipmentHandler { get; }
        public int PlayerItemsInInventoryCount { get => _PlayerItemsInInventoryCount; set => Set(ref _PlayerItemsInInventoryCount, value); }
        public ILocation CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public PlayerModelData PlayerModel { get; set; }
        public CostValue RepairCostValue { get => _RepairCostValue; set => Set(ref _RepairCostValue, value); }
        public Visibility PlayerItemToTradeDescriptionGridVisibility { get => _PlayerItemToTradeDescriptionGridVisibility; set => Set(ref _PlayerItemToTradeDescriptionGridVisibility, value); }
        public Visibility MerchantItemToTradeDescriptionGridVisibility { get => _MerchantItemToTradeDescriptionGridVisibility; set => Set(ref _MerchantItemToTradeDescriptionGridVisibility, value); }
        public ICommand SelectItemInPlayerInventoryCommand { get; private set; }
        public ICommand SelectItemInMerchantInventoryCommand { get; private set; }
        public ICommand BuyItemCommand { get; private set; }
        public ICommand SellItemCommand { get; private set; }
        public ICommand ShowWearedEquipmentCommand { get; private set; }
        public ICommand ShowItemsInInventoryCommand { get; private set; }
        public static ICommand UpdateMerchantViewModelCommand { get; private set; }
        public ICommand RepairAllItemsCommand { get; private set; }
        public ICommand RepairItemCommand { get; private set; }
        public ICommand CalculateItemRepairCostValueCommand { get; private set; }
        public ICommand CalculateTotalRepairCostValueCommand { get; private set; }
        public MerchantControlViewModel()
        {
            var merchantViewBuilder = new MerchantViewBuilder();
            CurrentLocation = ArmoryTemporaryData.CurrentLocation;
            PlayerModel = ArmoryTemporaryData.PlayerModel;
            Merchant = merchantViewBuilder.Build(CurrentLocation.Town);

            var random = new Random();
            int itemscount = random.Next(1, 7);

            var db = new ItemsMetaData();
            var itemsQuality = LootMaster.GetItemsQuality(ArmoryTemporaryData.PlayerModel.PlayerGrade);

            var probablyItemsList = new List<ItemEntity>();

            int count = 0;
            foreach (var item in db.ItemsTotal)
            {
                if (count == itemscount)
                    break;
                if (item.Model.Quality == itemsQuality)
                {
                    probablyItemsList.Add(item);
                    count++;
                }
            }
            MerchantInventory = new MerchantInventoryItemsList(probablyItemsList);

            RefreshEquipmentView();

            PlayerItemsInInventoryCount = PlayerInventory.ItemsInInventory.Count;

            MerchantConsumables = new PlayerConsumablesData(121382);
            PlayerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;

            PlayerItemToTradeDescriptionGridVisibility = Visibility.Hidden;
            MerchantItemToTradeDescriptionGridVisibility = Visibility.Hidden;

            EquipmentHandler = new MerchantEquipmentHandler(this);

            InitializeCommands();

            RepairCostValue = new CostValue(0);
        }
        private void InitalizeInventories()
        {
            var itemEntityConverter = new ItemEntityConverter();
            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(PlayerInventory.ItemsInInventory);
            MerchantItems = itemEntityConverter.ConvertRangeToObservableCollection(MerchantInventory.ItemsInInventory);
        }
        private void ValidateMerchantItemGridVisibility(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            if (itemTemplate is null) MerchantItemToTradeDescriptionGridVisibility = Visibility.Hidden;
            else MerchantItemToTradeDescriptionGridVisibility = Visibility.Visible;
        }
        private void ValidatePlayerItemGridVisibility(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            if (itemTemplate is null) PlayerItemToTradeDescriptionGridVisibility = Visibility.Hidden;
            else PlayerItemToTradeDescriptionGridVisibility = Visibility.Visible;
        }
        public void ShowInventory()
        {
            var itemEntityConverter = new ItemEntityConverter();
            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(PlayerInventory.ItemsInInventory);
        }
        public void ShowWearedEquipment()
        {
            var itemEntityConverter = new ItemEntityConverter();
            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(PlayerWearedEquipment.ItemsList);
        }
        private void InitializeCommands()
        {
            SelectItemInPlayerInventoryCommand = new SelectItemInPlayerInventoryCommand(this);
            SelectItemInMerchantInventoryCommand = new SelectItemInMerchantInventoryCommand(this);
            BuyItemCommand = new BuyItemCommand(this);
            SellItemCommand = new SellItemCommand(this);

            ShowWearedEquipmentCommand = new ShowWearedEquipmentCommand(this);
            ShowItemsInInventoryCommand = new ShowItemsInInventoryCommand(this);
            UpdateMerchantViewModelCommand = new UpdateMerchantViewModelCommand(this);
            RepairAllItemsCommand = new RepairAllItemsCommand(this);
            RepairItemCommand = new RepairItemCommand(this);
            CalculateItemRepairCostValueCommand = new CalculateItemRepairCostValueCommand(this);
            CalculateTotalRepairCostValueCommand = new CalculateTotalRepairCostValueCommand(this);
        }
        public void RefreshEquipmentView()
        {
            PlayerInventory = ArmoryTemporaryData.PlayerInventory;
            PlayerWearedEquipment = ArmoryTemporaryData.PlayerEquipment;
            InitalizeInventories();
        }
    }
}
