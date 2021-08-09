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
                Strength += item.Key.Strength;
                Stamina += item.Key.Stamina;
                Intellect += item.Key.Intellect;
                Agility += item.Key.Agility;
                Endurance += item.Key.Endurance;
                WeaponDamageValue += item.Key.WeaponDamageValue;
                ArmorValue += item.Key.ArmorValue;
            }
        }
    }
}
