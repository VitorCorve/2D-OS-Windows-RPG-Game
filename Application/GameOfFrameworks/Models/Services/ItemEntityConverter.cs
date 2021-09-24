using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.Services
{
    public class ItemEntityConverter
    {
        public EquipmentUserInterfaceViewTemplate ConvertToEquipmentUserInterfaceViewTemplate(ItemEntity itemEntity)
        {
            var equipmentUserInterfaceViewTemplate = new EquipmentUserInterfaceViewTemplate();
            equipmentUserInterfaceViewTemplate.Build(itemEntity);

            return equipmentUserInterfaceViewTemplate;
        }
        public List<EquipmentUserInterfaceViewTemplate> ConvertRangeToInterfaceTemplate(ICollection<ItemEntity> itemsEntityList)
        {
            var equipmentUserInterfaceViewTemplatesList = new List<EquipmentUserInterfaceViewTemplate>();
            foreach (var item in itemsEntityList)
                equipmentUserInterfaceViewTemplatesList.Add(ConvertToEquipmentUserInterfaceViewTemplate(item));
            return equipmentUserInterfaceViewTemplatesList;
        }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> ConvertRangeIntoObservableCollection(ICollection<ItemEntity> itemsEntityList)
        {
            var equipmentUserInterfaceViewTemplatesList = new ObservableCollection<EquipmentUserInterfaceViewTemplate>();
            foreach (var item in itemsEntityList)
                equipmentUserInterfaceViewTemplatesList.Add(ConvertToEquipmentUserInterfaceViewTemplate(item));
            return equipmentUserInterfaceViewTemplatesList;
        }
        public ItemEntity ConvertToItemEntity(EquipmentUserInterfaceViewTemplate equipmentUserInterfaceViewTemplate)
        {
            var itemEntity = new ItemEntity(equipmentUserInterfaceViewTemplate.ItemID);
            itemEntity.ItemDurability.Value = equipmentUserInterfaceViewTemplate.Durability;
            return itemEntity;
        }
        public List<ItemEntity> ConvertRangeItemEntityList(ICollection<EquipmentUserInterfaceViewTemplate> equipmentUserInterfaceViewTemplate)
        {
            var itemEntityList = new List<ItemEntity>();
            foreach (var item in equipmentUserInterfaceViewTemplate)
            {
                var itemEntity = new ItemEntity(item.ItemID);
                itemEntity.ItemDurability.Value = item.Durability;
                itemEntityList.Add(itemEntity);
            }
            return itemEntityList;
        }
    }
}
