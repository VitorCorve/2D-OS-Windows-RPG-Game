using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Parry : IDefenseResourceType
    {
        public double Value { get; set; }
        public double MaxValue { get; private set; }
        public ResourceName Name { get; private set; } = ResourceName.Parry;
        public Parry(double value)
        {
            MaxValue = value;
            Value = value;
        }
        public Parry()
        {

        }
    }
}
