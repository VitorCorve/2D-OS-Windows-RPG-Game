using GameEngine.Equipment;
using GameOfFrameworks.Models.UISkillsCollection.Player;
using GameOfFrameworks.ViewModels.Base;

namespace GameOfFrameworks.Models.Armory.EquipmentControl
{
    public class EquipmentUserInterfaceListModel : ViewModel
    {
        private EquipmentUserInterfaceViewTemplate _Helmet;
        private EquipmentUserInterfaceViewTemplate _Gloves;
        private EquipmentUserInterfaceViewTemplate _MainWeapon;
        private EquipmentUserInterfaceViewTemplate _Shoulders;
        private EquipmentUserInterfaceViewTemplate _Bracers;
        private EquipmentUserInterfaceViewTemplate _SecondWeapon;
        private EquipmentUserInterfaceViewTemplate _Necklace;
        private EquipmentUserInterfaceViewTemplate _Waist;
        private EquipmentUserInterfaceViewTemplate _FirstArtefact;
        private EquipmentUserInterfaceViewTemplate _SecondArtefact;
        private EquipmentUserInterfaceViewTemplate _ThirdArtefact;
        private EquipmentUserInterfaceViewTemplate _Chest;
        private EquipmentUserInterfaceViewTemplate _Pants;
        private EquipmentUserInterfaceViewTemplate _Cloak;
        private EquipmentUserInterfaceViewTemplate _Boots;
        public EquipmentUserInterfaceViewTemplate Helmet { get => _Helmet; set => Set(ref _Helmet, value); }
        public EquipmentUserInterfaceViewTemplate Gloves { get => _Gloves; set => Set(ref _Gloves, value); }
        public EquipmentUserInterfaceViewTemplate MainWeapon { get => _MainWeapon; set => Set(ref _MainWeapon, value); }
        public EquipmentUserInterfaceViewTemplate Shoulders { get => _Shoulders; set => Set(ref _Shoulders, value); }
        public EquipmentUserInterfaceViewTemplate Bracers { get => _Bracers; set => Set(ref _Bracers, value); }
        public EquipmentUserInterfaceViewTemplate SecondWeapon { get => _SecondWeapon; set => Set(ref _SecondWeapon, value); }
        public EquipmentUserInterfaceViewTemplate Necklace { get => _Necklace; set => Set(ref _Necklace, value); }
        public EquipmentUserInterfaceViewTemplate Waist { get => _Waist; set => Set(ref _Waist, value); }
        public EquipmentUserInterfaceViewTemplate FirstArtefact { get => _FirstArtefact; set => Set(ref _FirstArtefact, value); }
        public EquipmentUserInterfaceViewTemplate SecondArtefact { get => _SecondArtefact; set => Set(ref _SecondArtefact, value); }
        public EquipmentUserInterfaceViewTemplate ThirdArtefact { get => _ThirdArtefact; set => Set(ref _ThirdArtefact, value); }
        public EquipmentUserInterfaceViewTemplate Chest { get => _Chest; set => Set(ref _Chest, value); }
        public EquipmentUserInterfaceViewTemplate Pants { get => _Pants; set => Set(ref _Pants, value); }
        public EquipmentUserInterfaceViewTemplate Cloak { get => _Cloak; set => Set(ref _Cloak, value); }
        public EquipmentUserInterfaceViewTemplate Boots { get => _Boots; set => Set(ref _Boots, value); }
      
        public void AddItem(EquipmentUserInterfaceViewTemplate itemViewTemplate)
        {
            switch (itemViewTemplate.EquipmentType)
            {
                case EQUIPMENT_TYPE.Helmet:
                    Helmet = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Necklace:
                    Necklace = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Shoulder:
                    Shoulders = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Breastplate:
                    Chest = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Bracers:
                    Bracers = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Gloves:
                    Gloves = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Waist:
                    Waist = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Pants:
                    Pants = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Boots:
                    Boots = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Cloak:
                    Cloak = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.MainWeapon:
                    MainWeapon = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.OffHandWeapon:
                    SecondWeapon = itemViewTemplate;
                    break;
                case EQUIPMENT_TYPE.Artefact:
                    WearArtefact(itemViewTemplate);
                    break;
            }
        }
        public void WearArtefact(EquipmentUserInterfaceViewTemplate itemViewTemplate)
        {
            if (FirstArtefact is null)
            {
                FirstArtefact = itemViewTemplate;
                return;
            }
            if (SecondArtefact is null)
            {
                SecondArtefact = itemViewTemplate;
                return;
            }
            if (ThirdArtefact is null)
            {
                SecondArtefact = itemViewTemplate;
                return;
            }
            FirstArtefact = itemViewTemplate;
        }
    }
}