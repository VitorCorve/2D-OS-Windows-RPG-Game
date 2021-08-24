using GameEngine.Equipment.Interfaces;

namespace GameEngine.Equipment.Resource
{
    public class Durability : IEquipmentDurability
    {
        public int Value { get; set; }
        public void Increase(int value)
        {
            if (Value + value > 100)
                Value = 100;
            else
                Value += value;
        }
        public void Decrease(int value)
        {
            if (Value - value < 0)
                Value = 0;
            else
                Value -= value;
        }
    }
}
