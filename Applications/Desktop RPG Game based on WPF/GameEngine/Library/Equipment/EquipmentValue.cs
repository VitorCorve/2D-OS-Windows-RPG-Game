using GameEngine.Equipment;
using GameEngine.Player.Abstract;

namespace GameEngine.EquipmentManagement
{
    public class EquipmentValue : IEntityAttributes
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }

        public EquipmentValue(WearedEquipment equipment)
        {
            foreach (var item in equipment.ItemsList)
            {
                Strength += item.Attributes.Strength;
                Stamina += item.Attributes.Stamina;
                Intellect += item.Attributes.Intellect;
                Agility += item.Attributes.Agility;
                Endurance += item.Attributes.Endurance;
                WeaponDamageValue += item.Attributes.WeaponDamageValue;
                ArmorValue += item.Attributes.ArmorValue;
            }
        }
    }
}
