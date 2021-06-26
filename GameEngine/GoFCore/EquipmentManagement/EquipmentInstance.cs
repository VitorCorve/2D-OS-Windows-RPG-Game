using GameEngine.EquipmentManagement.Types;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.EquipmentManagement
{
    public class EquipmentInstance : AbstractAttributes
    {
        private readonly List<ItemEntity> ItemsList = new List<ItemEntity> { };
        public EquipmentInstance(ItemList itemList)
        {
            ItemsList = itemList.Items;

            foreach (var item in ItemsList)
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
