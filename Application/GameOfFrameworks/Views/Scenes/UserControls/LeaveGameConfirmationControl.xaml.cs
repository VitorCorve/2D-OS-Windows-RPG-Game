using GameOfFrameworks.Models.Temporary;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для LeaveGameConfirmationControl.xaml
    /// </summary>
    public partial class LeaveGameConfirmationControl : UserControl
    {
        public LeaveGameConfirmationControl()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }

        private void NoButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }
    }
}
