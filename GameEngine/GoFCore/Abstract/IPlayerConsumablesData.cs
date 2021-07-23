using GameEngine.Player.ConsumableResources;

namespace GameEngine.Abstract
{
    public interface IPlayerConsumablesData
    {
        CopperCurrency CopperValue { get; }
        SilverCurrency SilverValue { get; }
        GoldCurrency GoldValue { get; }
        SkillPointsCurrency SkillPointsValue { get; }
    }
}
