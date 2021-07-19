using GameEngine.NPC.Interfaces.SpecializationArchetypes;

namespace GameEngine.NPC.Specializations.Humans
{
    public class EntityModel_Scavenger : IHuman
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public EntityModel_Scavenger()
        {
            Strength = 7;
            Stamina = 6;
            Intellect = 2;
            Agility = 3;
            Endurance = 3;
        }
    }
}
