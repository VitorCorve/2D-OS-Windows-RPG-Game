using GameOfFrameworks.Infrastructure.Commands.LoadGame;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для CustomConfirmationDialogUserControl.xaml
    /// </summary>
    public partial class CustomConfirmationDialogUserControl : UserControl
    {
        public CustomConfirmationDialogUserControl()
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
