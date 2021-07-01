using GameEngine.Equipment;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.EquipmentManagement
{
    public class EquipmentValue : IAttributes
    {
        public uint Strength { get; set; }
        public uint Stamina { get; set; }
        public uint Intellect { get; set; }
        public uint Agility { get; set; }
        public uint Endurance { get; set; }
        public uint WeaponDamageValue { get; set; }
        public uint ArmorValue { get; set; }

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
