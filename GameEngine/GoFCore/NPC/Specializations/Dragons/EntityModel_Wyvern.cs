using GameEngine.NPC.Interfaces.SpecializationArchetypes;

namespace GameEngine.NPC.Specializations.Dragons
{
    public class EntityModel_Wyvern : IDragon
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public EntityModel_Wyvern()
        {
            Strength = 7;
            Stamina = 6;
            Intellect = 2;
            Agility = 3;
            Endurance = 3;
        }
    }
}
