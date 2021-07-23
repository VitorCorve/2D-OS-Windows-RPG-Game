using GameEngine.Abstract.PlayerConsumable;

namespace GameEngine.Player.ConsumableResources
{
    public class CopperCurrency : IConsumableResource
    {
        public CONSUMABLE_NAME Name { get; } = CONSUMABLE_NAME.Copper;
        public int Value { get; set; }
    }
}
