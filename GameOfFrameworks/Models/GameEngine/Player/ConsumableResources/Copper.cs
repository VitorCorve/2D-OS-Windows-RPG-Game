using GameEngine.Abstract.PlayerConsumable;

namespace GameEngine.Player.ConsumableResources
{
    public class Copper : IConsumableResource
    {
        public CONSUMABLE_NAME Name { get; } = CONSUMABLE_NAME.Copper;
        public int Value { get; set; }
    }
}
