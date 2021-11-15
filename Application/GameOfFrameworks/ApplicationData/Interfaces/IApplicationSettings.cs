using GameOfFrameworks.Models.Services;

namespace GameOfFrameworks.ApplicationData.Interfaces
{
    public interface IApplicationSettings
    {
        public IApplicationDisplayResolution Resolution { get; set; }
        public IApplicationDisplayWindowStyle WindowStyle { get; set; }
        KeyboardBindingsModel Bindings { get; set; }
        SoundMaster Sound { get; set; }
    }
}
