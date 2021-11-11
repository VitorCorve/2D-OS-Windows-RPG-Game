using GameOfFrameworks.Models.Temporary;
using System.Windows;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для VideoSettingsControl.xaml
    /// </summary>
    public partial class VideoSettingsControl : UserControl
    {
        public VideoSettingsControl()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void NextButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void PreviousScreenButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void NextScreenButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
