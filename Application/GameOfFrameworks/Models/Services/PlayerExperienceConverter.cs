using GameEngine.Player;

namespace GameOfFrameworks.Models.Services
{
    public class PlayerExperienceConverter
    {
        private readonly PlayerModelData Model;
        public PlayerExperienceConverter(PlayerModelData playerModel) => Model = playerModel;
        public int Convert()
        {
            double currentExperience = Model.Experience;
            double maxExperience = Model.MaxExperience;
            double progressBarValue = currentExperience / GetPercentage(maxExperience);
            int value = (int)progressBarValue;
            return value;
        }
        private double GetPercentage(double value) => value / 100;
    }
}
