using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.Models.Services
{
    public class ItemEntityToViewTemplateConverter
    {
        public EquipmentUserInterfaceViewTemplate Convert(ItemEntity itemEntity)
        {
            var equipmentUserInterfaceViewTemplate = new EquipmentUserInterfaceViewTemplate();
            equipmentUserInterfaceViewTemplate.Itemlevel = itemEntity.Attributes.ItemLevel;
            equipmentUserInterfaceViewTemplate.Source = itemEntity;
            equipmentUserInterfaceViewTemplate.Attributes = itemEntity.Attributes;
            equipmentUserInterfaceViewTemplate.ImagePath = itemEntity.Model.ItemAvatarPath;
            equipmentUserInterfaceViewTemplate.EquipmentType = itemEntity.Model.WearType;
            equipmentUserInterfaceViewTemplate.ItemName = itemEntity.Model.ItemName;
            equipmentUserInterfaceViewTemplate.ItemQuality = itemEntity.Model.Quality.ToString();
            equipmentUserInterfaceViewTemplate.Durability = itemEntity.ItemDurability.Value;

            return equipmentUserInterfaceViewTemplate;
        }
        public List<EquipmentUserInterfaceViewTemplate> ConvertRange(ICollection<ItemEntity> itemsEntityList)
        {
            var equipmentUserInterfaceViewTemplatesList = new List<EquipmentUserInterfaceViewTemplate>();
            foreach (var item in itemsEntityList)
                equipmentUserInterfaceViewTemplatesList.Add(Convert(item));
            return equipmentUserInterfaceViewTemplatesList;
        }
        public ObservableCollection<EquipmentUserInterfaceViewTemplate> ConvertRangeIntoObservableCollection(ICollection<ItemEntity> itemsEntityList)
        {
            var equipmentUserInterfaceViewTemplatesList = new ObservableCollection<EquipmentUserInterfaceViewTemplate>();
            foreach (var item in itemsEntityList)
                equipmentUserInterfaceViewTemplatesList.Add(Convert(item));
            return equipmentUserInterfaceViewTemplatesList;
        }
    }
}
