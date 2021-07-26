using GameEngine.Equipment;
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
        public TradingService TradeOperator { get; private set; }
        public ItemEntity ItemToTrade { get; set; }
        public TradeManager(PlayerConsumablesData playerConsumables)
        {
            TradeOperator = new TradingService(playerConsumables);
        }
        public void Buy()
        {
            if (TradeOperator.PlayerConsumables.AbsoluteMoneyValue < ItemToTrade.Model.Cost.AbsoluteMoneyValue)
                return;
            else
                TradeOperator.DecreasePlayerMoneyValue(ItemToTrade);
        }
        public void Sell()
        {
            TradeOperator.IncreasePlayerMoneyValue(ItemToTrade);
        }
    }
}
