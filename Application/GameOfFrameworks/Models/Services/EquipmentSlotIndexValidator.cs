using GameEngine.Equipment;

namespace GameOfFrameworks.Models.Services
{
    public static class EquipmentSlotIndexValidator
    {
        public static int Validate(EQUIPMENT_TYPE equipmentType)
        {
            switch (equipmentType)
            {
                case EQUIPMENT_TYPE.Helmet:
                    return 0;
                case EQUIPMENT_TYPE.Gloves:
                    return 1;
                case EQUIPMENT_TYPE.MainWeapon:
                    return 2;
                case EQUIPMENT_TYPE.Shoulder:
                    return 3;
                case EQUIPMENT_TYPE.Bracers:
                    return 4;
                case EQUIPMENT_TYPE.OffHandWeapon:
                    return 5;
                case EQUIPMENT_TYPE.Necklace:
                    return 6;
                case EQUIPMENT_TYPE.Waist:
                    return 7;
                case EQUIPMENT_TYPE.Artefact:
                    return 8;
                case EQUIPMENT_TYPE.Breastplate:
                    return 9;
                case EQUIPMENT_TYPE.Pants:
                    return 10;
                case EQUIPMENT_TYPE.Ring:
                    return 11;
                case EQUIPMENT_TYPE.Cloak:
                    return 12;
                case EQUIPMENT_TYPE.Boots:
                    return 13;
                case EQUIPMENT_TYPE.Earring:
                    return 14;
                default:
                    return 0;
            }
        }
    }
}
