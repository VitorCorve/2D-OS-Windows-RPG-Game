using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;


namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class EquipmentUserInterfaceViewTemplate : IEquipmentUserInterfaceViewTemplate
    {
        public int ItemID { get; set; }
        public int Itemlevel { get; set; }
        public ItemEntity Source { get; set; }
        public ItemAttributes Attributes { get; set; }
        public string ImagePath { get; set; }
        public EQUIPMENT_TYPE EquipmentType { get; set; }
        public string ItemName { get; set; }
        public string ItemQuality { get; set; }
        public int Durability { get; set; }
        public void Build(ItemEntity itemEntity)
        {
            ItemID = itemEntity.Model.ID;
            Itemlevel = itemEntity.Attributes.ItemLevel;
            Source = itemEntity;
            Attributes = itemEntity.Attributes;
            ImagePath = itemEntity.Model.ItemAvatarPath;
            EquipmentType = itemEntity.Model.WearType;
            ItemName = itemEntity.Model.ItemName;
            ItemQuality = itemEntity.Model.Quality.ToString();
            Durability = itemEntity.ItemDurability.Value;
        }
    }
}
