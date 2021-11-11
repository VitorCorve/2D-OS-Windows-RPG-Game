using GameOfFrameworks.Models.Temporary;
using System.Windows;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ConfirmCharacterCreationDialog.xaml
    /// </summary>
    public partial class ConfirmCharacterCreationDialog : UserControl
    {
        public ConfirmCharacterCreationDialog()
        {
            InitializeComponent();
        }
        private void YesButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        private void NoButton_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
