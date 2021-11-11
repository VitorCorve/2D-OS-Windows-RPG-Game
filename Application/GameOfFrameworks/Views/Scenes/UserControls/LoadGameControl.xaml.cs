using GameOfFrameworks.Models.Temporary;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для LoadGameControl.xaml
    /// </summary>
    public partial class LoadGameControl : UserControl
    {
        public LoadGameControl()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void BackButton_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void LoadButton_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
