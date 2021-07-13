using GameEngine.CombatEngine.Interfaces;


namespace GameEngine.Player.DefenseResources
{
    public class Dodge : IDefenseResourceType
    {
        public double Value { get; set; }
        public double MaxValue { get; private set; }
        public ResourceName Name { get; private set; } = ResourceName.Dodge;
        public Dodge(double value)
        {
            MaxValue = value;
            Value = value;
        }
        public Dodge()
        {

        }
    }
}
