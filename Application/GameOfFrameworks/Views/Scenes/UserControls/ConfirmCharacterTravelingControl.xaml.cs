using GameOfFrameworks.Models.Temporary;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ConfirmCharacterTravelingControl.xaml
    /// </summary>
    public partial class ConfirmCharacterTravelingControl : UserControl
    {
        public ConfirmCharacterTravelingControl()
        {
            InitializeComponent();
        }
        private void YesButton_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void NoButton_Click(object sender, System.Windows.RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
