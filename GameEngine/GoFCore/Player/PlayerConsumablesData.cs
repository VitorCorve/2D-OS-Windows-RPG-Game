using GameEngine.Abstract;
using GameEngine.Player.ConsumableResources;


namespace GameEngine.Player
{
    public class PlayerConsumablesData : IPlayerConsumablesData
    {
        public CopperCurrency CopperValue { get; set; } = new();
        public SilverCurrency SilverValue { get; set; } = new();
        public GoldCurrency GoldValue { get; set; } = new();
        public SkillPointsCurrency SkillPointsValue { get; set; } = new();
    }
}
