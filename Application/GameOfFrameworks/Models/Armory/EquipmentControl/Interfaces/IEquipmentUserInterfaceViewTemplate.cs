using GameEngine.Equipment;

namespace GameOfFrameworks.Models.Armory.EquipmentControl.Interfaces
{
    public interface IEquipmentUserInterfaceViewTemplate
    {
        ItemEntity Source { get; }
        ItemAttributes Attributes { get; }
        string ImagePath { get; }
        string ItemName { get; }
        EQUIPMENT_TYPE EquipmentType { get; }
        string ItemQuality { get; }
        void Build(ItemEntity itemEntity);
    }
}
