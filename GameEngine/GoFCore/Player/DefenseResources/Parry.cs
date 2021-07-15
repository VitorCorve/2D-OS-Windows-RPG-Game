using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Parry : IDefenseSkillsResourceType
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public ResourceName Name { get; private set; } = ResourceName.Parry;
        public Parry(double value)
        {
            Value = value;
        }
        public Parry()
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
