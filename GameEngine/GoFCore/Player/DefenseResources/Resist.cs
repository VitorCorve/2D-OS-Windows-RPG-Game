using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Resist : IDefenseResourceType
    {
        public double Value { get; set; }
        public double MaxValue { get; private set; }
        public ResourceName Name { get; private set; } = ResourceName.Resist;
        public Resist(double value)
        {
            MaxValue = value;
            Value = value;
        }
        public Resist()
        {

        }
    }
}
