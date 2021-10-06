using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.MerchantMechanics;
using GameEngine.MerchantMechanics.Services;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Armory.MerchantControl.Interfaces;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
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

            if (itemTemplate.Status is WEARED_STATUS.Weared) UpdateArmoryPlayerStats();
            RefreshData();
            SaveChanges();
        }
        public void RepairAllItems()
        {
            Blacksmith.PlayerAbsoluteMoneyValue = ViewModel.PlayerConsumables.AbsoluteMoneyValue;
            Blacksmith.RepairWearedEquipment(ViewModel.PlayerWearedEquipment);
            ViewModel.PlayerConsumables.ConvertValues(ViewModel.PlayerConsumables.AbsoluteMoneyValue - ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);
            ViewModel.MerchantConsumables.ConvertValues(ViewModel.MerchantConsumables.AbsoluteMoneyValue + ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);

            Blacksmith.PlayerAbsoluteMoneyValue = ViewModel.PlayerConsumables.AbsoluteMoneyValue;
            Blacksmith.RepairInventoryItems(ViewModel.PlayerInventory);
            ViewModel.PlayerConsumables.ConvertValues(ViewModel.PlayerConsumables.AbsoluteMoneyValue - ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);
            ViewModel.MerchantConsumables.ConvertValues(ViewModel.MerchantConsumables.AbsoluteMoneyValue + ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);

            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerConsumables));
            ViewModel.OnPropertyChanged(nameof(ViewModel.MerchantConsumables));
            SaveChanges();
        }
        public void SetItemRepairCostValue() => Blacksmith.SetRepairCostValue(ViewModel.PlayerWearedEquipment);
        public void SetPlayerMoneyValue() => Blacksmith.PlayerAbsoluteMoneyValue = ViewModel.PlayerConsumables.AbsoluteMoneyValue;
        public void RepairItem(ItemEntity itemEntity)
        {
            SetPlayerMoneyValue();
            Blacksmith.RepairItem(itemEntity);
            ViewModel.PlayerConsumables.ConvertValues(ViewModel.PlayerConsumables.AbsoluteMoneyValue - ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);
            ViewModel.MerchantConsumables.ConvertValues(ViewModel.MerchantConsumables.AbsoluteMoneyValue + ViewModel.EquipmentHandler.Blacksmith.RepairCostValue);
            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerConsumables));
            ViewModel.OnPropertyChanged(nameof(ViewModel.MerchantConsumables));
            SaveChanges();
        }
        private void UpdateArmoryPlayerStats()
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var equippmentValues = new EquipmentValue(ViewModel.PlayerWearedEquipment);
            var playerEntity = playerEntityConstructor.CreatePlayer(ArmoryTemporaryData.PlayerModel, ArmoryTemporaryData.PlayerAttributes, equippmentValues);

            ArmoryTemporaryData.CharacterEntity = playerEntity;
            ArmoryTemporaryData.PlayerModel = ViewModel.PlayerModel;
        }
        private void SaveChanges()
        {
            ViewModel.PlayerModel.PlayerConsumables = ViewModel.PlayerConsumables;
            ArmoryTemporaryData.PlayerInventory = ViewModel.PlayerInventory;
            ArmoryTemporaryData.PlayerEquipment = ViewModel.PlayerWearedEquipment;
            ArmoryTemporaryData.MerchantInventory = ViewModel.MerchantInventory;
            ArmoryViewModel.UpdateArmoryViewModelCommand.Execute(null);
            EquipmentControlViewModel.UpdateEquipmentViewModelCommand.Execute(null);
            AttributesControlViewModel.UpdateAttributesViewModelCommand.Execute(null);
            LevelUpViewModel.UpdatePlayerAttributeCommand.Execute(null);
        }
        private void RefreshData()
        {
            ViewModel.OnPropertyChanged(nameof(ViewModel.PlayerConsumables));
            ViewModel.OnPropertyChanged(nameof(ViewModel.MerchantConsumables));
        }
        public void FindAndRepair(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            if (itemTemplate.Status == WEARED_STATUS.Weared)
            {
                foreach (var item in ViewModel.PlayerWearedEquipment.ItemsList)
                {
                    if (item.Model.ID == itemTemplate.ItemID && item.ItemDurability.Value == itemTemplate.Durability)
                    {
                        RepairItem(item);
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in ViewModel.PlayerInventory.ItemsInInventory)
                {
                    if (item.Model.ID == itemTemplate.ItemID && item.ItemDurability.Value == itemTemplate.Durability)
                    {
                        RepairItem(item);
                        break;
                    }
                }
            }
        }
    }
}
