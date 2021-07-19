using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.DefenseResources
{
    public class Block : IDefenseSkillsResourceType
    {
        private double _value;
        public double Value 
        {
            get { return _value; }
            set { _value = ValidateValue(value); } 
        }
        public RESOURCE_NAME Name { get; private set; } = RESOURCE_NAME.Parry;
        public Block(double value)
        {
            Value = value;
        }
        public Block()
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
