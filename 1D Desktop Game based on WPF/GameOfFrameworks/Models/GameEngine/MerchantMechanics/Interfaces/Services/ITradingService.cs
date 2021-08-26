using GameEngine.Equipment;
using GameEngine.Player;

namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface ITradingService
    {
        int LocationValueMultiplier { get; }
        PlayerConsumablesData PlayerConsumables { get; }
        void IncreasePlayerMoneyValue(ItemEntity item);
        void DecreasePlayerMoneyValue(ItemEntity item);
    }
}
