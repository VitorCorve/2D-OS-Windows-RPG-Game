using GameEngine.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.Models.Services
{
    public class ItemDescriptionBuilder
    {
        public ItemEntity Item { get; private set; }
        public Dictionary<string, string> Build(ItemEntity item)
        {
            Item = item;

            var description = new Dictionary<string, string> { };

            description.Add("Name", Item.Model.ItemName);
            description.Add("Quality", Item.Model.Quality.ToString());
            description.Add("Wear type", Item.Model.WearType.ToString());
            description.Add("Damage value", Item.Attributes.WeaponDamageValue.ToString());
            description.Add("Armor value", Item.Attributes.ArmorValue.ToString());
            description.Add("Stamina", Item.Attributes.Stamina.ToString());
            description.Add("Strength", Item.Attributes.Strength.ToString());
            description.Add("Agility", Item.Attributes.Agility.ToString());
            description.Add("Endurance", Item.Attributes.Endurance.ToString());
            description.Add("Intellect", Item.Attributes.Intellect.ToString());
            description.Add("Durability", Item.ItemDurability.Value.ToString());

            return AdjustDescription(description);
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
    }
}
