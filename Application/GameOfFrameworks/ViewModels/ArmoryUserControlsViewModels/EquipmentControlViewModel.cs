using GameEngine.Equipment;
using GameOfFrameworks.Models.Armory.EquipmentControl;
using GameOfFrameworks.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels
{
    public class EquipmentControlViewModel : ViewModel
    {
        private Equipment _EquipmentListModel;
        public Equipment EquipmentListModel { get => _EquipmentListModel; set => _EquipmentListModel = value; }
        private string _HelmetAvatarPath;
        private string _GlovesAvatarPath;
        private string _MainWeaponAvatarPath;
        private string _ShouldersAvatarPath;
        private string _BracersAvatarPath;
        private string _SecondWeaponAvatarPath;
        private string _NecklaceAvatarPath;
        private string _WaistAvatarPath;
        private string _FirstArtefactAvatarPath;
        private string _SecondArtefactAvatarPath;
        private string _ThirdArtefactAvatarPath;
        private string _ChestAvatarPath;
        private string _PantsAvatarPath;
        private string _CloakAvatarPath;
        private string _BootsAvatarPath;
        public string HelmetAvatarPath { get => _HelmetAvatarPath; set => Set(ref _HelmetAvatarPath, value); }
        public string GlovesAvatarPath { get => _GlovesAvatarPath; set => Set(ref _GlovesAvatarPath, value); }
        public string MainWeaponAvatarPath { get => _MainWeaponAvatarPath; set => Set(ref _MainWeaponAvatarPath, value); }
        public string ShouldersAvatarPath { get => _ShouldersAvatarPath; set => Set(ref _ShouldersAvatarPath, value); }
        public string BracersAvatarPath { get => _BracersAvatarPath; set => Set(ref _BracersAvatarPath, value); }
        public string SecondWeaponAvatarPath { get => _SecondWeaponAvatarPath; set => Set(ref _SecondWeaponAvatarPath, value); }
        public string NecklaceAvatarPath { get => _NecklaceAvatarPath; set => Set(ref _NecklaceAvatarPath, value); }
        public string WaistAvatarPath { get => _WaistAvatarPath; set => Set(ref _WaistAvatarPath, value); }
        public string FirstArtefactAvatarPath { get => _FirstArtefactAvatarPath; set => Set(ref _FirstArtefactAvatarPath, value); }
        public string SecondArtefactAvatarPath { get => _SecondArtefactAvatarPath; set => Set(ref _SecondArtefactAvatarPath, value); }
        public string ThirdArtefactAvatarPath { get => _ThirdArtefactAvatarPath; set => Set(ref _ThirdArtefactAvatarPath, value); }
        public string ChestAvatarPath { get => _ChestAvatarPath; set => Set(ref _ChestAvatarPath, value); }
        public string PantsAvatarPath { get => _PantsAvatarPath; set => Set(ref _PantsAvatarPath, value); }
        public string CloakAvatarPath { get => _CloakAvatarPath; set => Set(ref _CloakAvatarPath, value); }
        public string BootsAvatarPath { get => _BootsAvatarPath; set => Set(ref _BootsAvatarPath, value); }
        public EquipmentControlViewModel()
        {
            var itemEntityID0 = new ItemEntity(0);
            var itemEntityID1 = new ItemEntity(1);
            var itemEntityID2 = new ItemEntity(2);

            var itemList = new List<ItemEntity>();
            itemList.Add(itemEntityID0);
            itemList.Add(itemEntityID1);
            itemList.Add(itemEntityID2);

            var itemSerializationData = new ItemSerializationData();
            itemSerializationData.PrepareToSerialize(itemList);

            var wearedEquipment = new WearedEquipment(itemSerializationData.ConvertToItemsEntityList());
            EquipmentListModel = new Equipment(wearedEquipment);
            EquipmentListModel.InitializeEquipment();
            InitializeEquipmentUserInterface();
        }
        public void InitializeEquipmentUserInterface()
        {
            HelmetAvatarPath = EquipmentListModel.Helmet?.Model.ItemAvatarPath;
            GlovesAvatarPath = EquipmentListModel.Gloves?.Model.ItemAvatarPath;
            MainWeaponAvatarPath = EquipmentListModel.MainWeapon?.Model.ItemAvatarPath;
            ShouldersAvatarPath = EquipmentListModel.Shoulders?.Model.ItemAvatarPath;
            BracersAvatarPath = EquipmentListModel.Bracers?.Model.ItemAvatarPath;
            SecondWeaponAvatarPath = EquipmentListModel.SecondWeapon?.Model.ItemAvatarPath;
            NecklaceAvatarPath = EquipmentListModel.Necklace?.Model.ItemAvatarPath;
            WaistAvatarPath = EquipmentListModel.Waist?.Model.ItemAvatarPath;
            FirstArtefactAvatarPath = EquipmentListModel.FirstArtefact?.Model.ItemAvatarPath;
            SecondArtefactAvatarPath = EquipmentListModel.SecondArtefact?.Model.ItemAvatarPath;
            ThirdArtefactAvatarPath = EquipmentListModel.ThirdArtefact?.Model.ItemAvatarPath;
            ChestAvatarPath = EquipmentListModel.Chest?.Model.ItemAvatarPath;
            PantsAvatarPath = EquipmentListModel.Pants?.Model.ItemAvatarPath;
            CloakAvatarPath = EquipmentListModel.Cloak?.Model.ItemAvatarPath;
            BootsAvatarPath = EquipmentListModel.Boots?.Model.ItemAvatarPath ;
        }
       
    }
}
