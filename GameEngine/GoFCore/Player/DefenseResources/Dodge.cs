using GameEngine.CombatEngine.Interfaces;


namespace GameEngine.Player.DefenseResources
{
    public class Dodge : IDefenseResourceType
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public ResourceName Name { get; private set; } = ResourceName.Dodge;
        public Dodge(double value)
        {
            Value = value;
        }
        public Dodge()
        {

        }
        public double ValidateValue(double value)
        {
            if (value > 100)
                return 100;
            return value;
        }
    }
}
