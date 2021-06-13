using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.EquipmentData.Armor;
using WinFormsApp1.EquipmentData.Artefact;
using WinFormsApp1.EquipmentData.Weapons;

namespace WinFormsApp1.EquipmentData
{
    public static class EquipmentValue
    {
        public static int EquipmentArmor = 0;
        public static int EquipmentDamage  = 0;
        public static int EquipmentStamina  = 0;
        public static int EquipmentStrength  = 0;
        public static int EquipmentEndurance  = 0;
        public static int EquipmentIntellect  = 0;
        public static int EquipmentAgility  = 0;

        public static double EquipmentAttackSpeed  = 0;

        public static WeaponClass _MainWeapon { get; set; }
        public static WeaponClass _SecondaryWeapon { get; set; }

        public static Belts _Belt { get; set; }
        public static Boots _Boots { get; set; }
        public static Bracers _Bracers { get; set; }
        public static Breastplates _Breastplate { get; set; }
        public static Cloaks _Cloak { get; set; }
        public static Gloves _Gloves { get; set; }
        public static Helmets _Helmet { get; set; }
        public static Necklaces _Necklace { get; set; }
        public static Pants _Pants { get; set; }
        public static Shoulders _Shoulders { get; set; }
        public static Artefacts _Artefact { get; set; }

        public static List<EquipmentBaseClass> _Equipment { get; set; }


        public static void Add(int itemID)
        {
            if (itemID == 0)
            {
                return;
            }

            foreach (var item in EquipmentData.Items.ArmoryData.Armory)
            {
                if (item.ID == itemID)
                {
                    switch (item.ItemClass)
                    {
                        case "OneHanded":
                            Add((OneHandedWeapons)item);
                            break;
                        case "TwoHanded":
                            Add((TwoHandedWeapons)item);
                            break;
                        case "Staff":
                            Add((Staffs)item);
                            break;
                        case "Book":
                            Add((Books)item);
                            break;
                        case "Belts":
                            Add((Belts)item);
                            break;
                        case "Boots":
                            Add((Boots)item);
                            break;
                        case "Bracers":
                            Add((Bracers)item);
                            break;
                        case "Breastplates":
                            Add((Breastplates)item);
                            break;
                        case "Cloaks":
                            Add((Cloaks)item);
                            break;
                        case "Gloves":
                            Add((Gloves)item);
                            break;
                        case "Helmets":
                            Add((Helmets)item);
                            break;
                        case "Necklaces":
                            Add((Necklaces)item);
                            break;
                        case "Pants":
                            Add((Pants)item);
                            break;
                        case "Shoulders":
                            Add((Shoulders)item);
                            break;
                        case "Artefacts":
                            Add((Artefacts)item);
                            break;
                        default:
                            break;
                    }
                    break;
                }

            }

        }

        public static void Add(Belts armor)
        {
            _Belt = armor;

        }

        public static void Add(Boots armor)
        {
            _Boots = armor;

        }

        public static void Add(Bracers armor)
        {
            _Bracers = armor;

        }

        public static void Add(Breastplates armor)
        {
            _Breastplate = armor;

        }

        public static void Add(Cloaks armor)
        {
            _Cloak = armor;

        }

        public static void Add(Gloves armor)
        {
            _Gloves = armor;

        }

        public static void Add(Helmets armor)
        {
            _Helmet = armor;

        }
        
        public static void Add(Necklaces jewel)
        {
            _Necklace = jewel;

        }

        public static void Add(Pants armor)
        {
            _Pants = armor;

        }

        public static void Add(Shoulders armor)
        {
            _Shoulders = armor;

        }

        public static void Add(Books weapon)
        {
            _SecondaryWeapon = weapon;

        }

        public static void Add(Artefacts artefact)
        {
            _Artefact = artefact;

        }

        public static void Add(OneHandedWeapons weapon)
        {
            if (_MainWeapon == null)
            {
                _MainWeapon = weapon;
            }
            else
            {
                _SecondaryWeapon = weapon;
            }

        }

        public static void Add(Staffs weapon)
        {
            _MainWeapon = weapon;

        }

        public static void Add(TwoHandedWeapons weapon)
        {
            _MainWeapon = weapon;

            if (_SecondaryWeapon != null)
            {
                _SecondaryWeapon = null;
            }

        }

        private static void SetEquipment()
        {
            List<EquipmentBaseClass> equipmentList = new List<EquipmentBaseClass> { };

            equipmentList.Add(_MainWeapon);
            equipmentList.Add(_SecondaryWeapon);
            equipmentList.Add(_Belt);
            equipmentList.Add(_Boots);
            equipmentList.Add(_Bracers);
            equipmentList.Add(_Breastplate);
            equipmentList.Add(_Cloak);
            equipmentList.Add(_Gloves);
            equipmentList.Add(_Helmet);
            equipmentList.Add(_Necklace);
            equipmentList.Add(_Pants);
            equipmentList.Add(_Shoulders);
            equipmentList.Add(_Artefact);

            _Equipment = equipmentList;

        }

        private static void SetValues()
        {
            EquipmentArmor = 0;
            EquipmentDamage = 0;
            EquipmentStamina = 0;
            EquipmentStrength = 0;
            EquipmentEndurance = 0;
            EquipmentIntellect = 0;
            EquipmentAgility = 0;
            EquipmentAttackSpeed = 0;

            foreach (var item in _Equipment)
            {
                if (item == null)
                {
                    continue;
                }
                EquipmentArmor += item.ArmorValue;
                EquipmentDamage += item.DamageValue;
                EquipmentStamina += item.Stamina;
                EquipmentStrength += item.Strength;
                EquipmentEndurance += item.Endurance;
                EquipmentIntellect += item.Intellect;
                EquipmentAgility += item.Agility;
                EquipmentAttackSpeed += item.AttackSpeed;

            }
            Player player = (Player)Data.GetPlayer();
            UpdatePlayerStats(player);
        }

        public static void InitializeValues()
        {
            _Equipment = null;
            SetEquipment();
            SetValues();
        }

        public static void UpdatePlayerStats(Player player)
        {
            player.Armor = EquipmentArmor;
            player.WeaponDamage = EquipmentDamage;
            player.AdditionalStamina = EquipmentStamina;
            player.AdditionalStrength = EquipmentStrength;
            player.AdditionalEndurance = EquipmentEndurance;
            player.AdditionalIntellect = EquipmentIntellect;
            player.AdditionalAgility = EquipmentAgility;
            player.attackSpeed = EquipmentAttackSpeed;
            player.RefreshStats();
        }

        public static List<int> GetWearedIDs()
        {
            List<int> weared = new List<int> { };

            foreach (var item in _Equipment)
            {
                if (item == null)
                {
                    weared.Add(0);
                }
                else
                {
                    weared.Add(item.ID);
                }

            }

            return weared;
        }

        public static void NullWeared()
        {
            _MainWeapon = null;
            _SecondaryWeapon = null;
            _Belt = null;
            _Boots = null;
            _Bracers = null;
            _Breastplate = null;
            _Cloak = null;
            _Gloves = null;
            _Helmet = null;
            _Necklace = null;
            _Pants = null;
            _Shoulders = null;
            _Artefact = null;
        }
    }
}
