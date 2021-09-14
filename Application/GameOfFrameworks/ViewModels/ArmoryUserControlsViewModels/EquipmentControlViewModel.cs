using GameEngine.Equipment;
using GameOfFrameworks.Infrastructure.Commands.Armory.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;
using System.Windows.Input;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class EquipmentControlViewModel : ViewModel
    {
        private EquipmentUserInterfaceListModel _WearedItemsLisd;
        private EquipmentUserInterfaceViewTemplate _SelectedItem;
        public EquipmentUserInterfaceListModel WearedItemsList { get => _WearedItemsLisd; set => Set(ref _WearedItemsLisd, value); }
        public EquipmentUserInterfaceViewTemplate SelectedItem { get => _SelectedItem; set => Set(ref _SelectedItem, value); }
        public ICommand SelectHelmetCommand { get; }
        public EquipmentControlViewModel()
        {
            var itemEntity0 = new ItemEntity(0);
            var itemEntity1 = new ItemEntity(1);
            var itemEntity2 = new ItemEntity(2);

            var equipmentUserInterfaceViewTemplate0 = new EquipmentUserInterfaceViewTemplate();
            var equipmentUserInterfaceViewTemplate1 = new EquipmentUserInterfaceViewTemplate();
            var equipmentUserInterfaceViewTemplate2 = new EquipmentUserInterfaceViewTemplate();

            equipmentUserInterfaceViewTemplate0.Build(itemEntity0);
            equipmentUserInterfaceViewTemplate1.Build(itemEntity1);
            equipmentUserInterfaceViewTemplate2.Build(itemEntity2);


            WearedItemsList = new EquipmentUserInterfaceListModel();
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate0);
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate1);
            WearedItemsList.AddItem(equipmentUserInterfaceViewTemplate2);

            SelectHelmetCommand = new SelectHelmetInfoCommand(this);

            SelectedItem = WearedItemsList.Helmet;
        }
    }
}
