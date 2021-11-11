using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для GameplayOptionsControl.xaml
    /// </summary>
    public partial class GameplayOptionsControl : UserControl
    {
        public GameplayOptionsControl()
        {
            InitializeComponent();
        }
        public void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }
        public void SetActiveUserControl(UserControl control)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

            if (control.Visibility == Visibility.Visible) return;
            AudioSettingsControlElement.Visibility = Visibility.Collapsed;
            VideoSettingsControlElement.Visibility = Visibility.Collapsed;
            ControlsControlElement.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }
        public void VideoSettingsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(VideoSettingsControlElement);
        public void AudioSettingsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(AudioSettingsControlElement);
        public void ControlsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(ControlsControlElement);
        public void BackButton_Click(object sender, RoutedEventArgs e)
        {
            OptionsControlViewModel.ShowOptionsControlCommand.Execute(null);
        }

        private void Button_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

        private void Button_Click_1(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
