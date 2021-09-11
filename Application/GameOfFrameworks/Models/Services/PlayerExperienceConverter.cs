using GameEngine.Player;

namespace GameOfFrameworks.Models.Services
{
    public class PlayerExperienceConverter
    {
        public int PlayerMaxExperience { get; set; }
        public int PlayerCurrentExperience { get; set; }
        public PlayerExperienceConverter(PlayerModelData playerModel)
        {
            PlayerMaxExperience = playerModel.MaxExperience;
            PlayerCurrentExperience = playerModel.Experience;
        }
        public int Convert()
        {
            double maxExp = (double)PlayerMaxExperience;
            double currExp = (double)PlayerCurrentExperience;
            double progressBarValue = currExp / (maxExp / 100);
            int value = (int)progressBarValue;
            return value;
        }
    }
}
