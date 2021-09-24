using GameEngine.Locations;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Armory.MerchantControl;
using GameOfFrameworks.Models.Armory.MerchantControl.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.ObjectModel;
using GameEngine.Player;
using GameEngine.Equipment;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class MerchantControlViewModel : ViewModel
    {
        private ObservableCollection<EquipmentUserInterfaceViewTemplate> _PlayerItems;
        public string CharacterAvatar { get; set; }
        public string CharacterName { get; set; }
        private PlayerConsumablesData _PlayerConsumables;
        private PlayerConsumablesData _MerchantConsumables;
        public MerchantView Merchant { get; set; }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> PlayerItems { get => _PlayerItems; set => Set(ref _PlayerItems, value); }
        public PlayerConsumablesData PlayerConsumables { get => _PlayerConsumables; set => Set(ref _PlayerConsumables, value); }
        public PlayerConsumablesData MerchantConsumables { get => _MerchantConsumables; set => Set(ref _MerchantConsumables, value); }
        public MerchantControlViewModel()
        {
            var playerInventory = ArmoryTemporaryData.PlayerInventory;
            var playerEquipment = new WearedEquipment(0,1,2);
            var itemEntityConverter = new ItemEntityConverter();

            var playerEquipmentObservableCollection = itemEntityConverter.ConvertRangeIntoObservableCollection(playerEquipment.ItemsList);

            PlayerItems = itemEntityConverter.ConvertRangeIntoObservableCollection(playerInventory.ItemsInInventory);

            foreach (var item in PlayerItems)
            {
                item.WearStatus = "Inventory item";
            }

            foreach (var item in playerEquipmentObservableCollection)
            {
                item.WearStatus = "Weared";
            }

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
            Merchant = merchantViewBuilder.Build(TOWN.Elfinel);
        }
    }
}
