using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;


namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class EquipmentUserInterfaceViewTemplate : IEquipmentUserInterfaceViewTemplate
    {
        private string _WearStatus;
        public string WearColor { get; set; }
        public string WearStatus { get => _WearStatus; set { _WearStatus = value; ConvertWearColor(value); } }
        public int CopperPrice { get; set; }
        public int SilverPrice { get; set; }
        public int GoldPrice { get; set; }
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
            CopperPrice = itemEntity.Model.Price.CopperValue.Value;
            SilverPrice = itemEntity.Model.Price.SilverValue.Value;
            GoldPrice = itemEntity.Model.Price.GoldValue.Value;
        }
        private void ConvertWearColor(string wearStatus)
        {
            if (wearStatus == "Weared") WearColor = "Lime";
            else WearColor = "#FF218CBD";
        }
    }
}
