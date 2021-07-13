using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Block : IDefenseResourceType
    {
        public double Value { get; set; }
        public double MaxValue { get; private set; }
        public ResourceName Name { get; private set; } = ResourceName.Parry;
        public Block(double value)
        {
            MaxValue = value;
            Value = value;
        }
        public Block()
        {

        }
    }
}
