using GameOfFrameworks.ApplicationData.Interfaces;

namespace GameOfFrameworks.ApplicationData
{
    public class ApplicationSettings : IApplicationSettings
    {
        public IApplicationDisplayResolution Resolution { get; set; } = new ApplicationDisplayResolution();
        public IApplicationDisplayWindowStyle WindowStyle { get; set; } = new ApplicationDisplayWindowStyle();
        public IGeneralSoundVolume GeneralSoundVolume { get; set; } = new GeneralSoundVolume();
        public IMusicVolume MusicVolume { get; set; } = new MusicVolume();
        public ISoundEffectsVolume SoundEffectsVolume { get; set; } = new SoundEffectsVolume();
        public KeyboardBindingsModel Bindings { get; set; } = new KeyboardBindingsModel();
    }
}
