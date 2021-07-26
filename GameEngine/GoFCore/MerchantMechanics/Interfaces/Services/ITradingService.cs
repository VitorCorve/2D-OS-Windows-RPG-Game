using GameEngine.Equipment;


namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface ITradingService
    {
        void IncreasePlayerMoneyValue(ItemEntity item);
        void DecreasePlayerMoneyValue(ItemEntity item);
    }
}
