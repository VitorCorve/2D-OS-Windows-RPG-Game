using GameEngine.Equipment;
using GameEngine.Inventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Inventory
{
    public class MerchantInventoryItemsList : IInventoryItemsList
    {
        public int MaxItemsInInventory { get; } = 128;
        public List<ItemEntity> ItemsInInventory { get; set; } = new();
        public Dictionary<ItemEntity, string> ItemsInInventoryDescription { get; private set; } = new Dictionary<ItemEntity, string> { };
        public Dictionary<string, string> GetDescription(int ID)
        {

            var description = new Dictionary<string, string> { };

            foreach (var item in ItemsInInventoryDescription)
            {
                if (item.Key.Model.ID == ID)
                {
                    description.Add("Name", item.Key.Model.ItemName);
                    description.Add("Quality", item.Key.Model.Quality.ToString());
                    description.Add("Wear type", item.Key.Model.WearType.ToString());

                    if (item.Key.Model.WearType == EQUIPMENT_TYPE.MainWeapon ||
                        item.Key.Model.WearType == EQUIPMENT_TYPE.OffHandWeapon)
                        description.Add("Damage value", item.Key.Attributes.WeaponDamageValue.ToString());

                    description.Add("Armor value", item.Key.Attributes.ArmorValue.ToString());
                    description.Add("Stamina", item.Key.Attributes.Stamina.ToString());
                    description.Add("Strength", item.Key.Attributes.Strength.ToString());
                    description.Add("Agility", item.Key.Attributes.Agility.ToString());
                    description.Add("Endurance", item.Key.Attributes.Endurance.ToString());
                    description.Add("Intellect", item.Key.Attributes.Intellect.ToString());
                    description.Add("Durability", item.Key.ItemDurability.Value.ToString());

                    break;
                }
            }
            return description;
        }
        public void AddItem(ItemEntity item)
        {
            if (ItemsInInventoryDescription.Count > MaxItemsInInventory)
                throw new Exception("No empty slots in inventory");
            else
            {
                ItemsInInventory.Add(item);
                ItemsInInventoryDescription.Add(item, item.Model.ItemName);
            }

        }
        public void RemoveItem(ItemEntity item)
        {
            if (ItemsInInventoryDescription.Count < 1)
                throw new Exception($"Your inventory is empty");

            foreach (var calledItem in ItemsInInventoryDescription)
            {
                if (calledItem.Key.Model.ID == item.Model.ID)
                {
                    ItemsInInventory.Remove(calledItem.Key);
                    ItemsInInventoryDescription.Remove(calledItem.Key);
                    return;
                }
                else
                    throw new Exception($"You dont have {item.Model.ItemName} in your inventory");
            }
        }
    }
}
