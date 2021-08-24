using GameEngine.NPC.Interfaces.SpecializationArchetypes;
using GameEngine.Player;

namespace GameEngine.NPC.Specializations.NonEnemyCharacters
{
    public class EntityModel_Trader : IHuman
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public NPC_TYPE NPC_Type { get; private set; }
        public NPC_NAME Name { get; private set; }
        public EntityModel_Trader()
        {
            NPC_Type = NPC_TYPE.Human;
            Name = NPC_NAME.Trader;

            Strength = 100;
            Stamina = 100;
            Intellect = 100;
            Agility = 100;
            Endurance = 100;
        }
    }
}
