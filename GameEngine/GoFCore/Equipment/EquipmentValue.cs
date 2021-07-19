using GameEngine.Equipment;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Strength += item.Strength;
                Stamina += item.Stamina;
                Intellect += item.Intellect;
                Agility += item.Agility;
                Endurance += item.Endurance;
                WeaponDamageValue += item.WeaponDamageValue;
                ArmorValue += item.ArmorValue;
            }
        }
    }
}
