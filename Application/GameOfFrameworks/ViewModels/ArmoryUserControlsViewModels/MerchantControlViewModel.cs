using GameEngine.Locations;
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
using GameEngine.MerchantMechanics.Services;
using GameOfFrameworks.Infrastructure.Commands.Armory.Options;
using GameOfFrameworks.Infrastructure.Commands.Armory;

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
        private int _TradeInventoryCapacity;
        public string CharacterAvatar { get; set; }
        public string CharacterName { get; set; }
        private PlayerConsumablesData _PlayerConsumables;
        private PlayerConsumablesData _MerchantConsumables;
        private Location _CurrentLocation;
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
        public Visibility PlayerItemToTradeDescriptionGridVisibility { get => _PlayerItemToTradeDescriptionGridVisibility; set => Set(ref _PlayerItemToTradeDescriptionGridVisibility, value); }
        public Visibility MerchantItemToTradeDescriptionGridVisibility { get => _MerchantItemToTradeDescriptionGridVisibility; set => Set(ref _MerchantItemToTradeDescriptionGridVisibility, value); }
        public ICommand SelectItemInPlayerInventoryCommand { get; private set; }
        public ICommand SelectItemInMerchantInventoryCommand { get; private set; }
        public ICommand BuyItemCommand { get; private set; }
        public ICommand SellItemCommand { get; private set; }
        public ICommand ShowWearedEquipmentCommand { get; private set; }
        public ICommand ShowItemsInInventoryCommand { get; private set; }
        public ICommand UpdateMerchantViewModelCommand { get; private set; }
        public MerchantEquipmentHandler EquipmentHandler { get; }
        public int TradeInventoryCapacity { get => _TradeInventoryCapacity; set => Set(ref _TradeInventoryCapacity, value); }
        public int PlayerItemsInInventoryCount { get => _PlayerItemsInInventoryCount; set => Set(ref _PlayerItemsInInventoryCount, value); }
        public Location CurrentLocation { get => _CurrentLocation; set => Set(ref _CurrentLocation, value); }
        public MerchantControlViewModel()
        {
            CurrentLocation = ArmoryTemporaryData.CurrentLocation;

            RefreshEquipmentView();

            MerchantInventory = new MerchantInventoryItemsList(0, 0, 0, 0, 1, 0, 1, 2, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2);

            var itemEntityConverter = new ItemEntityConverter();

            TradeInventoryCapacity = PlayerInventoryItemsList.MaxItemsInInventory;
            PlayerItemsInInventoryCount = PlayerInventory.ItemsInInventory.Count;


            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(PlayerInventory.ItemsInInventory);
            MerchantItems = itemEntityConverter.ConvertRangeToObservableCollection(MerchantInventory.ItemsInInventory);


            var playerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;
            playerConsumables.IncreaseValue(332132);

            MerchantConsumables = new PlayerConsumablesData(38717271);
            PlayerConsumables = playerConsumables;

            CharacterAvatar = ArmoryTemporaryData.PlayerModel.AvatarPath.Path;
            CharacterName = ArmoryTemporaryData.PlayerModel.Name;

            var merchantViewBuilder = new MerchantViewBuilder();
            Merchant = merchantViewBuilder.Build(CurrentLocation.Town);

            PlayerItemToTradeDescriptionGridVisibility = Visibility.Hidden;
            MerchantItemToTradeDescriptionGridVisibility = Visibility.Hidden;

            EquipmentHandler = new MerchantEquipmentHandler(this);

            InitializeCommands();

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
            TradeInventoryCapacity = PlayerInventoryItemsList.MaxItemsInInventory;
        }
        public void ShowWearedEquipment()
        {
            var itemEntityConverter = new ItemEntityConverter();
            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(PlayerWearedEquipment.ItemsList);
            TradeInventoryCapacity = 15;
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
        }
        public void RefreshEquipmentView()
        {
            PlayerInventory = ArmoryTemporaryData.PlayerInventory;
            PlayerWearedEquipment = ArmoryTemporaryData.PlayerEquipment;
        }
    }
}
