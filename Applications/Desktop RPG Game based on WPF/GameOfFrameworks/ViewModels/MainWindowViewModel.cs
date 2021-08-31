using GameOfFrameworks.Infrastructure.UserApplicationSettings;
using GameOfFrameworks.ViewModels.Base;

namespace GameOfFrameworks.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public int HorizontalWindowResolution { get; set; }

        public int VerticalWindowResolution { get; set; }
        public string WindowStyle { get; set; }
        public string WindowState { get; set; }
        public GameVideoSettings VideoSettings {get; private set;}
        public MainWindowViewModel()
        {
            VideoSettings = new GameVideoSettings();
            HorizontalWindowResolution = VideoSettings.HorizontalVideoResolution;
            VerticalWindowResolution = VideoSettings.VerticalVideoResolution;
            WindowStyle = VideoSettings.UserWindowStyleSetting;
            WindowState = VideoSettings.UserWindowStateSetting;
        }
    }
}
