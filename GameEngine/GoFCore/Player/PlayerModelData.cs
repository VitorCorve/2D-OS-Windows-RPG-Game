using GameEngine.Abstract;
using GameEngine.Locations_ALPHA;

namespace GameEngine.Player
{
    public class PlayerModelData : IPlayerModelData
    {
        public string Name { get; private set; }
        public SPECIALIZATION Specialization { get; private set; }
        public string Gender { get; set; }
        public int Level { get; private set; }
        public LOCATION CurrentLocation { get; set; }
        public PLAYER_GRADE PlayerGrade { get; set; }
        public int Experience { get; set; }
        public int MaxExperience { get; set; }

        public PlayerModelData(AbstractPlayer player, string gender, string name, int level)
        {
            PlayerGrade = PLAYER_GRADE.Novice;
            Name = name;
            Specialization = player.Specialization;
            Gender = gender;
            Level = level;
        }


    }
}
