using GameEngine.MerchantMechanics;
using GameEngine.MerchantMechanics.Services;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Armory.MerchantControl.Interfaces;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Models.Armory.MerchantControl.Services
{
    public class MerchantEquipmentHandler : IMerchantEquipmentHandler
    {
        public MerchantControlViewModel ViewModel { get; }
        public BlacksmithingService Blacksmith { get; } = new();
        public TradeManager Trade { get; }
        public MerchantEquipmentHandler(MerchantControlViewModel merchantControlViewModel)
        {
            ViewModel = merchantControlViewModel;
            Trade = new TradeManager(ViewModel.PlayerConsumables, ViewModel.MerchantConsumables, ViewModel.PlayerInventory, ViewModel.MerchantInventory, ViewModel.PlayerWearedEquipment);
        }
        public void BuyItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            var itemEntity = ItemEntityConverter.ConvertToItemEntity(itemTemplate);
            Trade.ItemToTrade = itemEntity;
            Trade.Buy();
            ViewModel.MerchantItems.Remove(itemTemplate);

            itemTemplate = ItemEntityConverter.ConvertToEquipmentUserInterfaceViewTemplate(itemEntity);
            ViewModel.PlayerItems.Add(itemTemplate);
            RefreshData();
            SaveChanges();

            ViewModel.ShowInventory();
        }
        public void SellItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            var itemEntity = ItemEntityConverter.ConvertToItemEntity(itemTemplate);
            Trade.ItemToTrade = itemEntity;
            Trade.Sell();
            ViewModel.PlayerItems.Remove(itemTemplate);

            itemTemplate = ItemEntityConverter.ConvertToEquipmentUserInterfaceViewTemplate(itemEntity);
            ViewModel.MerchantItems.Add(itemTemplate);
            RefreshData();
            SaveChanges();
        }

        public void RepairAllItems()
        {
            Blacksmith.PlayerConsumables = ViewModel.PlayerConsumables;
            ViewModel.PlayerWearedEquipment = Blacksmith.RepairWearedEquipment(ViewModel.PlayerWearedEquipment);
            RefreshData();
            SaveChanges();
        }
        public void SetItemRepairCostValue(EquipmentUserInterfaceViewTemplate itemTemplate) => Blacksmith.SetRepairCostValue(ItemEntityConverter.ConvertToItemEntity(itemTemplate));
        public void SetItemRepairCostValue() => Blacksmith.SetRepairCostValue(ViewModel.PlayerWearedEquipment);
        public void SetPlayerMoneyValue() => Blacksmith.PlayerConsumables = ViewModel.PlayerConsumables;
        public EquipmentUserInterfaceViewTemplate RepairItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            var itemEntity = ItemEntityConverter.ConvertToItemEntity(itemTemplate);
            Blacksmith.PlayerConsumables = ViewModel.PlayerConsumables;
            Blacksmith.RepairItem(itemEntity);
            RefreshData();
            SaveChanges();
            return ItemEntityConverter.ConvertToEquipmentUserInterfaceViewTemplate(itemEntity);
        }
        private void SaveChanges()
        {
            ViewModel.PlayerModel.PlayerConsumables = ViewModel.PlayerConsumables;
            ArmoryTemporaryData.PlayerModel = ViewModel.PlayerModel;
            ArmoryTemporaryData.PlayerInventory = ViewModel.PlayerInventory;
            ArmoryTemporaryData.PlayerEquipment = ViewModel.PlayerWearedEquipment;
            ArmoryTemporaryData.MerchantInventory = ViewModel.MerchantInventory;
            ArmoryTemporaryData.IsMerchantViewModelChanged = true;
        }
        private void RefreshData()
        {
            var playerConsumables = ViewModel.PlayerConsumables;
            var merchantConsumables = ViewModel.MerchantConsumables;
            ViewModel.PlayerConsumables = playerConsumables;
            ViewModel.MerchantConsumables = merchantConsumables;
            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerConsumables));
            ViewModel.OnPropertyChanged(nameof(ViewModel.MerchantConsumables));
        }
    }
}
