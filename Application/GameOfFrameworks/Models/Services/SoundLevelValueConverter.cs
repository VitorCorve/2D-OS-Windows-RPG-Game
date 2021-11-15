
namespace GameOfFrameworks.Models.Services
{
    public class SoundLevelValueConverter
    {
        public static double ConvertToSliderValue(double value) => value * 100;
        public static double ConvertToSoundMasterValue(double value) => value / 100.0;
    }
}
