using GameEngine.Equipment;
using GameEngine.MerchantMechanics;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Armory.MerchantControl.Interfaces;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.Armory.MerchantControl.Services
{
    public class MerchantEquipmentHandler : IMerchantEquipmentHandler
    {
        public MerchantControlViewModel ViewModel { get; }
        public MerchantEquipmentHandler(MerchantControlViewModel merchantControlViewModel)
        {
            ViewModel = merchantControlViewModel;
            Trade = new TradeManager(ViewModel.PlayerConsumables, ViewModel.MerchantConsumables, ViewModel.PlayerInventory, ViewModel.MerchantInventory);
        }
        public TradeManager Trade { get; }
        public void BuyItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            Trade.ItemToTrade = ItemEntityConverter.ConvertToItemEntity(itemTemplate);
            Trade.Buy();
            ViewModel.MerchantItems.Remove(itemTemplate);
            ViewModel.PlayerItems.Add(itemTemplate);
            RefreshData();
            SaveChanges();
        }

        public void RepairAllItems(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            throw new NotImplementedException();
        }

        public void RepairItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            throw new NotImplementedException();
        }

        public void SellItem(EquipmentUserInterfaceViewTemplate itemTemplate)
        {
            Trade.ItemToTrade = ItemEntityConverter.ConvertToItemEntity(itemTemplate);
            Trade.Sell();
            ViewModel.PlayerItems.Remove(itemTemplate);
            ViewModel.MerchantItems.Add(itemTemplate);
            RefreshData();
            SaveChanges();
        }
        private ItemEntity FindItem(EquipmentUserInterfaceViewTemplate template, List<ItemEntity> itemsList)
        {
            var itemEntity = new ItemEntity();
            foreach (ItemEntity item in itemsList)
            {
                if (item.Model.ID == template.ItemID && item.ItemDurability.Value == template.Durability)
                {
                    itemEntity = item;
                    break;
                }
            }
            return itemEntity;
        }
        private void AddItemToPlayerInventory(EquipmentUserInterfaceViewTemplate template)
        {
            ViewModel.PlayerItems.Add(template);
        }
        private void SaveChanges()
        {
            ArmoryTemporaryData.PlayerInventory = ViewModel.PlayerInventory;
        }
        private void RefreshData()
        {
            var playerConsumables = ViewModel.PlayerConsumables;
            var merchantConsumables = ViewModel.MerchantConsumables;
            ViewModel.PlayerConsumables = null;
            ViewModel.MerchantConsumables = null;
            ViewModel.PlayerConsumables = playerConsumables;
            ViewModel.MerchantConsumables = merchantConsumables;
        }
    }
}
