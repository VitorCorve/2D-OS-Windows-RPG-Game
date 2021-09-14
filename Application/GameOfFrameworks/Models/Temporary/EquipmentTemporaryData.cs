using GameEngine.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using System.Collections.Generic;

namespace GameOfFrameworks.Models.Temporary
{
    public static class EquipmentTemporaryData
    {
        public static Dictionary<string, string> ItemDescription { get; set; }
        public static Equipment EquipmentList { get; set; }
        public static ItemEntity MouseOverItemHandler { get; set; }
        public static void SelectItem(EQUIPMENT_TYPE equipmentType)
        {
            foreach (var item in EquipmentList.ItemsList)
            {
                if (item.Model.WearType == equipmentType)
                    MouseOverItemHandler = item;
            }
        }
    }
}
