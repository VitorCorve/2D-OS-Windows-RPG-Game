using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Windows.Controls;


namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MapControl.xaml
    /// </summary>
    public partial class MapControl : UserControl
    {
        public MapControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_3(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_4(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_5(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_6(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void Button_Click_7(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
