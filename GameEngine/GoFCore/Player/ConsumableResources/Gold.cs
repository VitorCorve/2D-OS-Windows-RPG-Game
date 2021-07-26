using GameEngine.Abstract.PlayerConsumable;

namespace GameEngine.Player.ConsumableResources
{
    public class Gold : IConsumableResource
    {
        public CONSUMABLE_NAME Name { get; } = CONSUMABLE_NAME.Gold;
        public int Value { get; set; }
    }
}
