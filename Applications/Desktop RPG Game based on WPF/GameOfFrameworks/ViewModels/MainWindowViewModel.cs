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
        public MainWindowViewModel()
        {
            var videoSettings = new GameVideoSettings();
            HorizontalWindowResolution = videoSettings.HorizontalVideoResolution;
            VerticalWindowResolution = videoSettings.VerticalVideoResolution;
            WindowStyle = videoSettings.UserWindowStyleSetting;
            WindowState = videoSettings.UserWindowStateSetting;
        }
    }
}
