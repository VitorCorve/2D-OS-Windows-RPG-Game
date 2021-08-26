using GameEngine.Abstract;
using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.Locations;
using GameEngine.Player.ModelConditions;

namespace GameEngine.Player
{
    public class PlayerModelData : IPlayerModelData
    {
        public string Name { get;  set; }
        public SPECIALIZATION Specialization { get; private set; }
        public GENDER Gender { get; set; }
        public int Level { get; set; }
        public LAND CurrentLand { get; set; }
        public TOWN CurrentTown { get; set; }
        public int Experience
        {
            get { return _Experience; }
            set { _Experience = ConvertValue(value); }
        }
        private int _Experience;
        public int MaxExperience { get; set; }
        public PLAYER_GRADE PlayerGrade
        {
            get { return SetPlayerGrade(Level); }
            set { _PlayerGrade = value; }
        }
        private PLAYER_GRADE _PlayerGrade;
        public PlayerBiography Bio { get; set; }
        public PlayerAvatar Avatar_ID { get; set; }
        public PlayerConsumablesData PlayerConsumables { get; set; }
        public PlayerModelData(PlayerSpecializationAttributes player, GENDER gender, string name, int level, int money)
        {
            PlayerConsumables = new PlayerConsumablesData(money);
            PlayerGrade = PLAYER_GRADE.Novice;
            Name = name;
            Specialization = player.Specialization;
            Gender = gender;
            Level = level;
            MaxExperience = 36 + (Level * 6);
        }
        public PlayerModelData(ICharacterCreationData characterCreationData)
        {
            PlayerConsumables = new PlayerConsumablesData(0);
            PlayerGrade = PLAYER_GRADE.Novice;
            Name = characterCreationData.Name;
            Specialization = characterCreationData.CharacterSpecialization;
            Gender = characterCreationData.Gender;
            Level = 1;
            MaxExperience = 36 + (Level * 6);
        }
        private static PLAYER_GRADE SetPlayerGrade(int level)
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
        private int ConvertValue(int value)
        {
            if ((value + Experience) > MaxExperience)
                return (value + Experience) - MaxExperience;
            else
                return value;
        }
    }
}
