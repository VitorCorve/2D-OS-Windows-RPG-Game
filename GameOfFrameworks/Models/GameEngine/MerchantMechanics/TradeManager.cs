using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.MerchantMechanics.Services;
using GameEngine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.MerchantMechanics
{
    public class TradeManager
    {
        public TradingService PlayerTradingService { get; private set; }
        public TradingService merchantTradingService { get; private set; }
        public PlayerInventoryItemsList PlayerInventory { get; private set; }
        public MerchantInventoryItemsList MerchantInventory { get; private set; }
        public ItemEntity ItemToTrade { get; set; }
        public TradeManager(PlayerConsumablesData playerConsumables, PlayerConsumablesData merchantConsumables, PlayerInventoryItemsList playerInventory, MerchantInventoryItemsList merchantInventory)
        {
            PlayerTradingService = new TradingService(playerConsumables);
            merchantTradingService = new TradingService(merchantConsumables);
            PlayerInventory = playerInventory;
            MerchantInventory = merchantInventory;
        }
        public void Buy()
        {
            if (PlayerTradingService.PlayerConsumables.AbsoluteMoneyValue < ItemToTrade.Model.Price.AbsoluteMoneyValue)
            {
                throw new Exception("Not enought money");
            }

            else
            {
                PlayerTradingService.DecreasePlayerMoneyValue(ItemToTrade);
                PlayerInventory.AddItem(ItemToTrade);

                merchantTradingService.IncreasePlayerMoneyValue(ItemToTrade);
                MerchantInventory.RemoveItem(ItemToTrade);
            }
        }
        public void Sell()
        {
            PlayerTradingService.IncreasePlayerMoneyValue(ItemToTrade);
            PlayerInventory.RemoveItem(ItemToTrade);

            merchantTradingService.DecreasePlayerMoneyValue(ItemToTrade);
            MerchantInventory.AddItem(ItemToTrade);
        }
    }
}
