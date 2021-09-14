using GameEngine.Equipment;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.Scenes.UserControls;
using System.Windows;

namespace GameOfFrameworks.Models.Services
{
    public class EquipmentControlMouseSelectionHandler
    {
        private readonly EquipmentControl Control;
        public EquipmentControlMouseSelectionHandler(EquipmentControl equipmentControl) => Control = equipmentControl;
        public void SelectItemToView(EQUIPMENT_TYPE equipmentType)
        {
            var itemDescriptionBuilder = new ItemDescriptionBuilder();

            foreach (var item in EquipmentTemporaryData.EquipmentList.ItemsList)
            {
                if (item.Model.WearType == equipmentType)
                {
                    Control.DescriptionToolTip.Visibility = Visibility.Visible;
                    EquipmentTemporaryData.SelectItem(equipmentType);
                }
            }
        }
    }
}
