using GameEngine.Player.ConsumableResources;

namespace GameEngine.Equipment
{
    public class ItemCostData
    {
        public Copper CopperValue { get; private set; } = new();
        public Silver SilverValue { get; private set; } = new();
        public Silver GoldValue { get; private set; } = new();
        public int AbsoluteMoneyValue { get; private set; }
        public ItemCostData(int copperValue)
        {
            AbsoluteMoneyValue = copperValue;
            ConvertValues(copperValue);
        }
        public ItemCostData(int copperValue, int silverValue, int goldValue)
        {
            CopperValue.Value = copperValue;
            SilverValue.Value = silverValue;
            GoldValue.Value = goldValue;
            SetAbsoluteMoneyValue();
        }
        private void ConvertValues(int value)
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
        private void SetAbsoluteMoneyValue()
        {
            AbsoluteMoneyValue = CopperValue.Value + (SilverValue.Value * 100) + (GoldValue.Value * 10000);
        }
    }
}
