﻿using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services.Interfaces;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Models.Services
{
    public class EquipmentManager : IEquipmentManager
    {
        public EquipmentControlViewModel ViewModel { get; private set; }
        public PlayerEntityConstructor EntityConstructor { get; } = new();
        public EquipmentManager(EquipmentControlViewModel vm)
        {
            ViewModel = vm;
            InitializeInventoryView();
            InitializeEquipmentView();
        }
        public void WearItemFromInventory(EquipmentUserInterfaceViewTemplate viewTemplate)
        {
            var itemEntity = new ItemEntity();
            foreach (var item in ViewModel.InventoryModel.ItemsInInventory)
            {
                if (item.Model.ID == viewTemplate.ItemID && item.ItemDurability.Value == viewTemplate.Durability)
                {
                    itemEntity = item;
                    break;
                }
            }
            ViewModel.InventoryView.InventorySlotsList.Remove(viewTemplate);
            ViewModel.InventoryModel.RemoveItem(itemEntity);
            WearItemDirectly(viewTemplate);
            ViewModel.EquipmentModel.Wear(ItemEntityConverter.ConvertToItemEntity(viewTemplate));
            UpdatePlayerEntity();
        }
        public void TakeOffEquippedItem(EquipmentUserInterfaceViewTemplate viewTemplate)
        {
            ViewModel.EquipmentView.EquipmentSlotsList.Remove(viewTemplate);
            var itemEntity = new ItemEntity();
            foreach (var item in ViewModel.EquipmentModel.ItemsList)
            {
                if (item.Model.ID == viewTemplate.ItemID && item.ItemDurability.Value == viewTemplate.Durability)
                {
                    itemEntity = item;
                    break;
                }
            }
            ViewModel.EquipmentModel.ItemsList.Remove(itemEntity);
            AddItemToInventory(viewTemplate);
            ViewModel.EquipmentView = SortEquipmentByIndex();
            UpdatePlayerEntity();
        }
        private void InitializeInventoryView()
        {
            foreach (var item in ViewModel.InventoryModel.ItemsInInventory)
                ViewModel.InventoryView.InventorySlotsList.Add(ItemEntityConverter.ConvertToEquipmentUserInterfaceViewTemplate(item));
        }
        private void InitializeEquipmentView()
        {
            var itemView = new EquipmentUserInterfaceViewTemplate();
            foreach (var item in ViewModel.EquipmentModel.ItemsList)
            {
                itemView = ItemEntityConverter.ConvertToEquipmentUserInterfaceViewTemplate(item);
                ViewModel.EquipmentView.EquipmentSlotsList.Add(itemView);
            }

            ViewModel.EquipmentView = SortEquipmentByIndex();
        }
        public void SelectItemFromEquipment(EQUIPMENT_TYPE wearType)
        {
            foreach (var item in ViewModel.EquipmentView.EquipmentSlotsList)
            {
                if (item.EquipmentType == wearType)
                    ViewModel.SelectedItem = item;
            }
        }
        private EquipmentUserInterfaceViewTemplate GetItemFromEquipment(EQUIPMENT_TYPE wearType)
        {
            foreach (var item in ViewModel.EquipmentView.EquipmentSlotsList)
            {
                if (item.EquipmentType == wearType)
                    return item;
            }
            return null;
        }
        public WearedViewList SortEquipmentByIndex()
        {
            var sortedEquipmentList = new WearedViewList();

            for (int i = 0; i < 15; i++)
            {
                var equipmentViewTemplate = new EquipmentUserInterfaceViewTemplate();
                sortedEquipmentList.EquipmentSlotsList.Add(equipmentViewTemplate);
            }

            sortedEquipmentList.EquipmentSlotsList[0] = GetItemFromEquipment(EQUIPMENT_TYPE.Helmet) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[1] = GetItemFromEquipment(EQUIPMENT_TYPE.Gloves) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[2] = GetItemFromEquipment(EQUIPMENT_TYPE.MainWeapon) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[3] = GetItemFromEquipment(EQUIPMENT_TYPE.Shoulder) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[4] = GetItemFromEquipment(EQUIPMENT_TYPE.Bracers) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[5] = GetItemFromEquipment(EQUIPMENT_TYPE.OffHandWeapon) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[6] = GetItemFromEquipment(EQUIPMENT_TYPE.Necklace) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[7] = GetItemFromEquipment(EQUIPMENT_TYPE.Waist) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[8] = GetItemFromEquipment(EQUIPMENT_TYPE.Artefact) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[9] = GetItemFromEquipment(EQUIPMENT_TYPE.Breastplate) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[10] = GetItemFromEquipment(EQUIPMENT_TYPE.Pants) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[11] = GetItemFromEquipment(EQUIPMENT_TYPE.Ring) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[12] = GetItemFromEquipment(EQUIPMENT_TYPE.Cloak) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[13] = GetItemFromEquipment(EQUIPMENT_TYPE.Boots) ?? new EquipmentUserInterfaceViewTemplate();
            sortedEquipmentList.EquipmentSlotsList[14] = GetItemFromEquipment(EQUIPMENT_TYPE.Earring) ?? new EquipmentUserInterfaceViewTemplate();

            return sortedEquipmentList;
        }
        public void WearItemDirectly(EquipmentUserInterfaceViewTemplate itemToWear) => SetItemToEquipmentSlot(EquipmentSlotIndexValidator.Validate(itemToWear.EquipmentType), itemToWear);
        private void SetItemToEquipmentSlot(int index, EquipmentUserInterfaceViewTemplate itemToWear)
        {
            if (ViewModel.EquipmentView.EquipmentSlotsList[index].Source != null)
            {
                AddItemToInventory(ViewModel.EquipmentView.EquipmentSlotsList[index]);
                var itemEntity = new ItemEntity();
                foreach (var item in ViewModel.EquipmentModel.ItemsList)
                {
                    if (item.Model.ID == itemToWear.ItemID && item.ItemDurability.Value == itemToWear.Durability)
                    {
                        itemEntity = item;
                        break;
                    }
                }
                ViewModel.EquipmentModel.ItemsList.Remove(itemEntity);
                UpdatePlayerEntity();
            }
            ViewModel.EquipmentView.EquipmentSlotsList[index] = itemToWear;
            ViewModel.EquipmentView = SortEquipmentByIndex();
        }
        private void AddItemToInventory(EquipmentUserInterfaceViewTemplate itemToWear)
        {
            ViewModel.InventoryView.InventorySlotsList.Add(itemToWear);
            ViewModel.InventoryModel.AddItem(ItemEntityConverter.ConvertToItemEntity(itemToWear));
        }
        public void DeleteInventoryItem(EquipmentUserInterfaceViewTemplate itemToWear)
        {
            ViewModel.InventoryView.InventorySlotsList.Remove(itemToWear);
            ViewModel.InventoryModel.ItemsInInventory.Remove(ItemEntityConverter.ConvertToItemEntity(itemToWear));
        }
        private void UpdatePlayerEntity()
        {
            var equipment = new EquipmentValue(ViewModel.EquipmentModel);
            ArmoryTemporaryData.CharacterEntity = EntityConstructor.CreatePlayer(ArmoryTemporaryData.PlayerModel, equipment, ArmoryTemporaryData.PlayerAttributes);
            ArmoryTemporaryData.IsPlayerEntityChanged = true;
        }
        public void Refresh()
        {
            ViewModel.InventoryView = new InventoryViewList();
            ViewModel.EquipmentView = new WearedViewList();
            InitializeInventoryView();
            InitializeEquipmentView();
        }
    }
}
