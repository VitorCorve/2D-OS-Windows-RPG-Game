using GameEngine.Abstract.PlayerConsumable;

namespace GameEngine.Player.ConsumableResources
{
    public class SilverCurrency : IConsumableResource
    {
        public CONSUMABLE_NAME Name { get; } = CONSUMABLE_NAME.Silver;
        public int Value {get; set;}
    }
}
