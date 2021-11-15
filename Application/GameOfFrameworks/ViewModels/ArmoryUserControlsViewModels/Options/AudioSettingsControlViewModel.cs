using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;

namespace GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options
{
    public class AudioSettingsControlViewModel : ViewModel
    {
        private int _FXSliderValue;
        private int _SoundtrackSliderValue;
        public int FXSliderValue { get => _FXSliderValue; set { _FXSliderValue = value; UpdateFXVolume(value);  OnPropertyChanged(); } }
        public int SoundtrackSliderValue { get => _SoundtrackSliderValue; set { _SoundtrackSliderValue = value; UpdateSoundtrackValue(value);  OnPropertyChanged(); } }
        private SoundMaster Master;
        public AudioSettingsControlViewModel()
        {
            Master = ApplicationTemporaryData.Sound;
            SoundtrackSliderValue = (int)SoundLevelValueConverter.ConvertToSliderValue(Master.SoundTrackVolume);
            FXSliderValue = (int)SoundLevelValueConverter.ConvertToSliderValue(Master.FXVolume);
        }
        private void UpdateFXVolume(double value)
        {
            if (Master is null) return;
            Master.FXVolume = SoundLevelValueConverter.ConvertToSoundMasterValue(value);
        }

        private void UpdateSoundtrackValue(double value)
        {
            if (Master is null) return;
            Master.SoundTrackVolume = SoundLevelValueConverter.ConvertToSoundMasterValue(value);
        }
    }
}
