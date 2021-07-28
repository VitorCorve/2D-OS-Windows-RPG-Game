using GameEngine.Equipment;
using GameEngine.MerchantMechanics.Interfaces.Services;
using GameEngine.Player;

namespace GameEngine.MerchantMechanics.Services
{
    public class TradingService : ITradingService
    {
        public int LocationValueMultiplier { get; set; } = 1;
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public TradingService(PlayerConsumablesData playerConsumables)
        {
            PlayerConsumables = playerConsumables;
        }
        public void IncreasePlayerMoneyValue(ItemEntity item)
        {
            PlayerConsumables.IncreaseValue(item.Model.Cost.AbsoluteMoneyValue * LocationValueMultiplier);
        }
        public void DecreasePlayerMoneyValue(ItemEntity item)
        {
            PlayerConsumables.DecreaseValue(item.Model.Cost.AbsoluteMoneyValue * LocationValueMultiplier);
        }
    }
}