using GameEngine.Abstract;
using GameEngine.Player.ConsumableResources;


namespace GameEngine.Player
{
    public class PlayerConsumablesData : IPlayerConsumablesData
    {
        public Copper CopperValue { get; set; } = new();
        public Silver SilverValue { get; set; } = new();
        public Gold GoldValue { get; set; } = new();
        public int AbsoluteMoneyValue { get; set; }
        public SkillPoints SkillPointsValue { get; set; } = new() { Value = 0 };
        public PlayerConsumablesData(int copperValue)
        {
            AbsoluteMoneyValue = copperValue;
            ConvertValues(copperValue);
        }

        public void DecreaseValue(int value)
        {
            AbsoluteMoneyValue -= value;
            ConvertValues(AbsoluteMoneyValue);
        }

        public void IncreaseValue(int value)
        {
            AbsoluteMoneyValue += value;
            ConvertValues(AbsoluteMoneyValue);
        }

        public void ConvertValues(int value)
        {
            if (value >= 10000)
            {
                GoldValue.Value = value / 10000;
                value -= GoldValue.Value * 10000;
            }

            if (value >= 100 && value < 10000)
            {
                SilverValue.Value = value / 100;
                value -= SilverValue.Value * 100;
            }

            CopperValue.Value = value;
        }
    }
}
