using GameEngine.Abstract;
using GameEngine.Locations_ALPHA;

namespace GameEngine.Player
{
    public class PlayerModelData : IPlayerModelData
    {
        public string Name { get; private set; }
        public SPECIALIZATION Specialization { get; private set; }
        public GENDER Gender { get; set; }
        public int Level { get; set; }
        public LOCATION CurrentLocation { get; set; }
        public int Experience { get; set; }
        public int MaxExperience { get; set; }
        public PLAYER_GRADE PlayerGrade
        {
            get { return SetPlayerGrade(Level); }
            set { _PlayerGrade = value; }
        }
        private PLAYER_GRADE _PlayerGrade;
        public PlayerConsumablesData PlayerConsumablesData { get; set; }
        public PlayerModelData(AbstractPlayer player, GENDER gender, string name, int level)
        {
            PlayerConsumablesData = new PlayerConsumablesData(0);
            PlayerGrade = PLAYER_GRADE.Novice;
            Name = name;
            Specialization = player.Specialization;
            Gender = gender;
            Level = level;
        }
        private PLAYER_GRADE SetPlayerGrade(int level)
        {
            switch (level)
            {
                case < 6:
                    return PLAYER_GRADE.Novice;
                case < 11:
                    return PLAYER_GRADE.Advanced;
                case < 16:
                    return PLAYER_GRADE.Adept;
                case < 21:
                    return PLAYER_GRADE.Expert;
                case < 26:
                    return PLAYER_GRADE.Master;
                case < 31:
                    return PLAYER_GRADE.Legend;
                default:
                    return PLAYER_GRADE.Legend;
            }
        }
    }
}
