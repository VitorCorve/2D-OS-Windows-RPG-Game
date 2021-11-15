using GameOfFrameworks.ApplicationData.Interfaces;
using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.ApplicationData
{
    public class ApplicationSettings : IApplicationSettings
    {
        public IApplicationDisplayResolution Resolution { get; set; } = new ApplicationDisplayResolution();
        public IApplicationDisplayWindowStyle WindowStyle { get; set; } = new ApplicationDisplayWindowStyle();
        public KeyboardBindingsModel Bindings { get; set; } = new KeyboardBindingsModel();
        public SoundMaster Sound { get; set; } = new SoundMaster();
    }
}
