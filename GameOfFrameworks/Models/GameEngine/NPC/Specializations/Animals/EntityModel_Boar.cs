using GameEngine.NPC.Interfaces.SpecializationArchetypes;
using GameEngine.Player;

namespace GameEngine.NPC.Specializations.Animals
{
    public class EntityModel_Boar : IAnimal
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
        public EntityModel_Boar()
        {
            NPC_Type = NPC_TYPE.Animal;
            Name = NPC_NAME.Boar;

            Strength = 7;
            Stamina = 6;
            Intellect = 2;
            Agility = 3;
            Endurance = 3;
        }
    }
}
