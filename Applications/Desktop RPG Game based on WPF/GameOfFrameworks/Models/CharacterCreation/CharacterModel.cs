using GameEngine.Player;

namespace GameOfFrameworks.Models.CharacterCreation
{
    public class CharacterModel
    {
        public string Name { get; set; }
        public GENDER Gender { get; set; }
        public SPECIALIZATION Specialization { get; set; }
        public string Bio { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Endurance { get; set; }
        public int Intellect { get; set; }
        public int Agility { get;set; }
    }
}
