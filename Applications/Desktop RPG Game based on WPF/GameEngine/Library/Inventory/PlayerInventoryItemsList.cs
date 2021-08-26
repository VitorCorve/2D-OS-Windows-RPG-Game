using GameEngine.Equipment;
using GameEngine.Inventory.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.Inventory
{
    public class PlayerInventoryItemsList : IInventoryItemsList
    {
        public int MaxItemsInInventory {get;} = 32;
        public List<ItemEntity> ItemsInInventory { get; set; } = new();
        public Dictionary<string, string> GetDescription(int ID)
        {
            var description = new Dictionary<string, string> { };
            foreach (var item in ItemsInInventory)
            {
                if (item.Model.ID == ID)
                {
                    description.Add("Name", item.Model.ItemName);
                    description.Add("Quality", item.Model.Quality.ToString());
                    description.Add("Wear type", item.Model.WearType.ToString());
                    description.Add("Damage value", item.Attributes.WeaponDamageValue.ToString());
                    description.Add("Armor value", item.Attributes.ArmorValue.ToString());
                    description.Add("Stamina", item.Attributes.Stamina.ToString());
                    description.Add("Strength", item.Attributes.Strength.ToString());
                    description.Add("Agility", item.Attributes.Agility.ToString());
                    description.Add("Endurance", item.Attributes.Endurance.ToString());
                    description.Add("Intellect", item.Attributes.Intellect.ToString());
                    description.Add("Durability", item.ItemDurability.Value.ToString());

                    break;
                }
            }
            return AdjustDescription(description);
        }
        public void AddItem(ItemEntity item)
        {
            if (ItemsInInventory.Count > MaxItemsInInventory)
                throw new Exception("No empty slots in inventory");
            else
            {
                ItemsInInventory.Add(item);
            }
        }
        public void RemoveItem(ItemEntity item)
        {
            if (ItemsInInventory.Count < 1)
                throw new Exception($"Your inventory is empty");

            foreach (var calledItem in ItemsInInventory)
            {
                if (calledItem.Model.ID == item.Model.ID)
                {
                    ItemsInInventory.Remove(calledItem);
                    return;
                }
                else
                    throw new Exception($"You dont have {item.Model.ItemName} in your inventory");
            }
        }
        private static Dictionary<string, string> AdjustDescription(Dictionary<string, string> description)
        {
            foreach (var item in description)
            {
                if (item.Value == "0")
                    description.Remove(item.Key);
            }
            return description;
        }
        public PlayerInventoryItemsList(List<ItemEntity> itemsList)
        {
            ItemsInInventory = itemsList;
        }
        public PlayerInventoryItemsList()
        {

        }
    }
}
