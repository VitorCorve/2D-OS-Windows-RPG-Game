using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Resist : IDefenseSkillsResourceType
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public ResourceName Name { get; private set; } = ResourceName.Resist;
        public Resist(double value)
        {
            Value = value;
        }
        public Resist()
        {

        }
        public double ValidateValue(double value)
        {
            if (value < 0)
                return 0;
            if (value > 100)
                return 100;
            return value;
        }
    }
}
