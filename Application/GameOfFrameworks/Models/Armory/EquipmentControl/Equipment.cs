using GameEngine.Equipment;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class Equipment
    {
        public ItemEntity Helmet { get; set; }
        public ItemEntity Gloves { get; set; }
        public ItemEntity MainWeapon { get; set; }
        public ItemEntity Shoulders { get; set; }
        public ItemEntity Bracers { get; set; }
        public ItemEntity SecondWeapon { get; set; }
        public ItemEntity Necklace { get; set; }
        public ItemEntity Waist { get; set; }
        public ItemEntity FirstArtefact { get; set; }
        public ItemEntity SecondArtefact { get; set; }
        public ItemEntity ThirdArtefact { get; set; }
        public ItemEntity Chest { get; set; }
        public ItemEntity Pants { get; set; }
        public ItemEntity Cloak { get; set; }
        public ItemEntity Boots { get; set; }
        public List<ItemEntity> ItemsList { get; set; } = new();
      
        public Equipment(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                ItemsList.Add(itemEntity);
            }
        }
        public Equipment(WearedEquipment wearedEquipment)
        {
            foreach (var item in wearedEquipment.ItemsList)
            {
                ItemsList.Add(item);
            }
        }
        public void InitializeEquipment()
        {
            foreach (var item in ItemsList)
            {
                switch (item.Model.WearType)
                {
                    case EQUIPMENT_TYPE.Helmet:
                        Helmet = item;
                        break;
                    case EQUIPMENT_TYPE.Necklace:
                        Necklace = item;
                        break;
                    case EQUIPMENT_TYPE.Shoulder:
                        Shoulders = item;
                        break;
                    case EQUIPMENT_TYPE.Breastplate:
                        Chest = item;
                        break;
                    case EQUIPMENT_TYPE.Bracers:
                        Bracers = item;
                        break;
                    case EQUIPMENT_TYPE.Gloves:
                        Gloves = item;
                        break;
                    case EQUIPMENT_TYPE.Waist:
                        Waist = item;
                        break;
                    case EQUIPMENT_TYPE.Pants:
                        Pants = item;
                        break;
                    case EQUIPMENT_TYPE.Boots:
                        Boots = item;
                        break;
                    case EQUIPMENT_TYPE.Cloak:
                        Cloak = item;
                        break;
                    case EQUIPMENT_TYPE.Right:
                        MainWeapon = item;
                        break;
                    case EQUIPMENT_TYPE.Left:
                        SecondWeapon = item;
                        break;
                    case EQUIPMENT_TYPE.Artefact:
                        WearArtefact(item);
                        break;
                }
            }
        }
        public void WearArtefact(ItemEntity itemEntity)
        {
            if (FirstArtefact is null)
            {
                FirstArtefact = itemEntity;
                return;
            }
            if (SecondArtefact is null)
            {
                SecondArtefact = itemEntity;
                return;
            }
            if (ThirdArtefact is null)
            {
                SecondArtefact = itemEntity;
                return;
            }
            FirstArtefact = itemEntity;
        }
    }
}
