using GameEngine.Equipment;
using GameEngine.Inventory;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.Services.Interfaces;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Models.Services
{
    public class EquipmentManager : IEquipmentManager
    {
        public EquipmentControlViewModel ViewModel { get; private set; }
        public WearedEquipment EquipmentWearedModel { get; private set; }
        public PlayerInventoryItemsList InventoryItemsModel { get; private set; }
        public ItemEntityConverter Converter { get; private set; } = new();
        public EquipmentUserInterfaceViewTemplate SelectedItemReferenseFromViewModel { get; private set; }
        public EquipmentManager(EquipmentControlViewModel vm, InventoryViewList invView, WearedViewList eqView, WearedEquipment weared, PlayerInventoryItemsList inv, EquipmentUserInterfaceViewTemplate selected)
        {
            ViewModel = vm;
            ViewModel.InventoryView = invView;
            ViewModel.EquipmentView = eqView;
            EquipmentWearedModel = weared;
            InventoryItemsModel = inv;
            SelectedItemReferenseFromViewModel = selected;
            InitializeInventoryView();
            InitializeEquipmentView();
        }

        public void WearItemFromInventory(EquipmentUserInterfaceViewTemplate viewTemplate)
        {
            foreach (var item in ViewModel.InventoryView.InventorySlotsList)
            {
                if (item.EquipmentType == viewTemplate.EquipmentType)
                    ViewModel.InventoryView.InventorySlotsList.Remove(item);
                else
                    continue;
                WearItemDirectly(viewTemplate);
                ViewModel.EquipmentModel.ItemsList.Add(Converter.ConvertToItemEntity(viewTemplate));
                return;
            }
        }

        public void TakeOffEquippedItem(EquipmentUserInterfaceViewTemplate viewTemplate)
        {
            var itemToRemove = new EquipmentUserInterfaceViewTemplate();
            ViewModel.EquipmentView.EquipmentSlotsList.Remove(viewTemplate);
            ViewModel.EquipmentModel.ItemsList.Remove(Converter.ConvertToItemEntity(viewTemplate));
            AddItemToInventory(viewTemplate);
            ViewModel.EquipmentView = SortEquipmentByIndex();
        }
        private void InitializeInventoryView()
        {
            foreach (var item in InventoryItemsModel.ItemsInInventory)
                ViewModel.InventoryView.InventorySlotsList.Add(Converter.ConvertToEquipmentUserInterfaceViewTemplate(item));
        }
        private void InitializeEquipmentView()
        {
            foreach (var item in EquipmentWearedModel.ItemsList)
                ViewModel.EquipmentView.EquipmentSlotsList.Add(Converter.ConvertToEquipmentUserInterfaceViewTemplate(item));

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
        public void WearItemDirectly(EquipmentUserInterfaceViewTemplate itemToWear)
        {
            switch (itemToWear.EquipmentType)
            {
                case EQUIPMENT_TYPE.Helmet:
                    SetItemToEquipmentSlot(0, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Gloves:
                    SetItemToEquipmentSlot(1, itemToWear);
                    return;
                case EQUIPMENT_TYPE.MainWeapon:
                    SetItemToEquipmentSlot(2, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Shoulder:
                    SetItemToEquipmentSlot(3, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Bracers:
                    SetItemToEquipmentSlot(4, itemToWear);
                    return;
                case EQUIPMENT_TYPE.OffHandWeapon:
                    SetItemToEquipmentSlot(5, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Necklace:
                    SetItemToEquipmentSlot(6, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Waist:
                    SetItemToEquipmentSlot(7, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Artefact:
                    SetItemToEquipmentSlot(8, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Breastplate:
                    SetItemToEquipmentSlot(9, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Pants:
                    SetItemToEquipmentSlot(10, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Ring:
                    SetItemToEquipmentSlot(11, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Cloak:
                    SetItemToEquipmentSlot(12, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Boots:
                    SetItemToEquipmentSlot(13, itemToWear);
                    return;
                case EQUIPMENT_TYPE.Earring:
                    SetItemToEquipmentSlot(14, itemToWear);
                    return;
                default:
                    return;
            }
        }
        private void SetItemToEquipmentSlot(int index, EquipmentUserInterfaceViewTemplate itemToWear)
        {
            ViewModel.EquipmentView = SortEquipmentByIndex();
            if (ViewModel.EquipmentView.EquipmentSlotsList[index].Source != null)
                AddItemToInventory(ViewModel.EquipmentView.EquipmentSlotsList[index]);
            ViewModel.EquipmentView.EquipmentSlotsList[index] = itemToWear;
        }
        private void AddItemToInventory(EquipmentUserInterfaceViewTemplate itemToWear)
        {
            ViewModel.InventoryView.InventorySlotsList.Add(itemToWear);
            ViewModel.InventoryModel.ItemsInInventory.Add(Converter.ConvertToItemEntity(itemToWear));
        }
    }
}
