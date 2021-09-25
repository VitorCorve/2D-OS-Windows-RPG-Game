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
        public string CharacterAvatar { get; set; }
        public string CharacterName { get; set; }
        private PlayerConsumablesData _PlayerConsumables;
        private PlayerConsumablesData _MerchantConsumables;
        public MerchantView Merchant { get; set; }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> PlayerItems { get => _PlayerItems; set => Set(ref _PlayerItems, value); }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> MerchantItems { get => _MerchantItems; set => Set(ref _MerchantItems, value); }
        public EquipmentUserInterfaceViewTemplate PlayerInventorySelect { get => _PlayerInventorySelect; set { Set(ref _PlayerInventorySelect, value); ValidatePlayerItemGridVisibility(value); } }
        public EquipmentUserInterfaceViewTemplate MecrhantInventorySelect { get => _MecrhantInventorySelect; set { Set(ref _MecrhantInventorySelect, value); ValidateMerchantItemGridVisibility(value); } }
        public PlayerConsumablesData PlayerConsumables { get => _PlayerConsumables; set => Set(ref _PlayerConsumables, value); }
        public PlayerConsumablesData MerchantConsumables { get => _MerchantConsumables; set => Set(ref _MerchantConsumables, value); }
        public Visibility PlayerItemToTradeDescriptionGridVisibility { get => _PlayerItemToTradeDescriptionGridVisibility; set => Set(ref _PlayerItemToTradeDescriptionGridVisibility, value); }
        public Visibility MerchantItemToTradeDescriptionGridVisibility { get => _MerchantItemToTradeDescriptionGridVisibility; set => Set(ref _MerchantItemToTradeDescriptionGridVisibility, value); }
        public MerchantControlViewModel()
        {
            var playerInventory = ArmoryTemporaryData.PlayerInventory;
            var playerEquipment = new WearedEquipment(0,1,2);
            var itemEntityConverter = new ItemEntityConverter();

            var playerEquipmentObservableCollection = itemEntityConverter.ConvertRangeToObservableCollection(playerEquipment.ItemsList);

            PlayerItems = itemEntityConverter.ConvertRangeToObservableCollection(playerInventory.ItemsInInventory);

            MerchantItems = itemEntityConverter.CreateObservableCollectionByItemsID(0, 0, 0, 0, 1, 0, 1, 2, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2);

            foreach (var item in playerEquipmentObservableCollection)
            {
                PlayerItems.Add(item);
            }

            var playerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;
            playerConsumables.IncreaseValue(332132);

            MerchantConsumables = new PlayerConsumablesData(38717271);
            PlayerConsumables = playerConsumables;
            CharacterAvatar = ArmoryTemporaryData.PlayerModel.AvatarPath.Path;
            CharacterName = ArmoryTemporaryData.PlayerModel.Name;
            var merchantViewBuilder = new MerchantViewBuilder();
            Merchant = merchantViewBuilder.Build(TOWN.Chartringfall);

            PlayerItemToTradeDescriptionGridVisibility = Visibility.Hidden;
            MerchantItemToTradeDescriptionGridVisibility = Visibility.Hidden;
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
    }
}
