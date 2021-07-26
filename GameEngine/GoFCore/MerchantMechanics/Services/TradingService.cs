using GameEngine.Equipment;
using GameEngine.MerchantMechanics.Interfaces.Services;
using GameEngine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.MerchantMechanics.Services
{
    public class TradingService : ITradingService
    {
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public TradingService(PlayerConsumablesData playerConsumables)
        {
            PlayerConsumables = playerConsumables;
        }
        public void IncreasePlayerMoneyValue(ItemEntity item)
        {
            PlayerConsumables.IncreaseValue(item.Model.Cost.AbsoluteMoneyValue);
        }
        public void DecreasePlayerMoneyValue(ItemEntity item)
        {
            PlayerConsumables.DecreaseValue(item.Model.Cost.AbsoluteMoneyValue);
        }
    }
}