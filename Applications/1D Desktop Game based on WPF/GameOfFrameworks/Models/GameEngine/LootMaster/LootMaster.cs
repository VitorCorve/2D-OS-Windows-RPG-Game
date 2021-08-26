using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.LootMaster.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;
using GameEngine.Equipment.Db.Services;
using System.Linq;
using System;

namespace GameEngine.LootMaster
{
    public class LootMaster : ILootMaster
    {
        private readonly string ItemQuality;
        public PlayerInventoryItemsList Inventory { get; private set; }
        public PlayerConsumablesData Consumables { get; private set; }
        public List<ItemEntity> ProbableLootList { get; private set; }
        public List<ItemEntity> Loot { get; private set; } = new();
        public int MoneyReward { get; private set; }
        public LootMaster(PlayerLoadData playerData)
        {
            switch (playerData.PlayerModel.PlayerGrade)
            {
                case PLAYER_GRADE.Novice:
                    ItemQuality = "Poor";
                    break;
                case PLAYER_GRADE.Advanced:
                    ItemQuality = "Poor";
                    break;
                case PLAYER_GRADE.Adept:
                    ItemQuality = "Good";
                    break;
                case PLAYER_GRADE.Expert:
                    ItemQuality = "Rare";
                    break;
                case PLAYER_GRADE.Master:
                    ItemQuality = "Epic";
                    break;
                default:
                    ItemQuality = "Legendary";
                    break;
            }
            Inventory = playerData.Inventory;
            Consumables = playerData.PlayerModel.PlayerConsumables;

            PrepareLoot();
        }
        public void ThrowItems()
        {
            if (ProbableLootList.Count <= 0)
                return;

            Random randomize = new Random();

            if (ProbableLootList.Count > 0)
                MoneyReward = ProbableLootList.First().Model.Price.AbsoluteMoneyValue;
            else
                MoneyReward = randomize.Next(0, 1000);

            Consumables.AbsoluteMoneyValue += MoneyReward;

            Loot.Add(ProbableLootList[randomize.Next(0, ProbableLootList.Count - 1)]);

            if (randomize.Next(0, ProbableLootList.Count) > (ProbableLootList.Count / 2))
                Loot.Add(ProbableLootList[randomize.Next(0, ProbableLootList.Count - 1)]);
        }
        public void PickUpItem(int index)
        {
            Inventory.AddItem(Loot[index]);
        }
        public void PickUpAllItems()
        {
            foreach (var item in Loot)
                Inventory.AddItem(item);
        }
        public void PrepareLoot()
        {
            var dbConnection = new DbConnectionService();

            ProbableLootList = new List<ItemEntity>();
            foreach (var item in dbConnection.DataBase.ItemModels)
            {
                if (item.Quality == ItemQuality)
                    ProbableLootList.Add(new ItemEntity(item.ID));
            }
        }
    }
}
