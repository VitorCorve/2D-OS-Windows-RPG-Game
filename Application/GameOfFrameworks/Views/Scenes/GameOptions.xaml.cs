using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для GameOptions.xaml
    /// </summary>
    public partial class GameOptions : Page
    {
        public GameOptions()
        {
            InitializeComponent();
        }
        public void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            RunGame runGame = new RunGame();
            NavigationService.Navigate(runGame);
        }
        public void SetActiveUserControl(UserControl control)
        {
            AudioSettingsControlElement.Visibility = Visibility.Collapsed;
            VideoSettingsControlElement.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }
        public void VideoSettingsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(VideoSettingsControlElement);
        public void AudioSettingsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(AudioSettingsControlElement);
    }
}
