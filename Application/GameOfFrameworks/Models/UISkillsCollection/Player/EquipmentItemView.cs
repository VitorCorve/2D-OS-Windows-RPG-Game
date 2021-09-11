using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player.Interfaces;


namespace GameOfFrameworks.Models.UISkillsCollection.Player
{
    public class EquipmentItemView : IEquipmentItemView
    {
        public ItemEntity Item { get; set; }
        public string ImagePath { get; set; }
        public EQUIPMENT_TYPE EquipmentType { get; set; }
    }
}
