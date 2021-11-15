using GameEngine.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl.Interfaces;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class EquipmentUserInterfaceViewTemplate : IEquipmentUserInterfaceViewTemplate
    {
        private WEARED_STATUS _Status;
        private string _ItemQuality;
        public string WearColor { get; set; }
        public string ItemQualityColor { get; set; }
        public WEARED_STATUS Status { get => _Status; set { _Status = value; ConvertWearColor(value); } }
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
        public string ItemQuality { get => _ItemQuality; set { _ItemQuality = value; ConvertItemQualityColor(value); } }
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
            Status = itemEntity.Model.Status;
        }
        private void ConvertWearColor(WEARED_STATUS wearStatus)
        {
            if (wearStatus == WEARED_STATUS.Weared) WearColor = "#FF21BDAF";
            else WearColor = "#FF218CBD";
        }
        private void ConvertItemQualityColor(string itemQuality)
        {
            switch (itemQuality)
            {
                case "Poor":
                    ItemQualityColor = "White";
                    return;
                case "Good":
                    ItemQualityColor = "#FF20DA8E";
                    return;
                case "Rare":
                    ItemQualityColor = "#FF3E4BD1";
                    return;
                case "Epic":
                    ItemQualityColor = "#FFDCDC30";
                    return;
                case "Legendary":
                    ItemQualityColor = "#FFE65908";
                    return;
                default:
                    break;
            }
        }
        public int ReturnAbsoluteValue() => CopperPrice + (SilverPrice * 100) + (GoldPrice * 10000);
    }
}
