using GameOfFrameworks.Models.Temporary;
using System.Windows.Controls;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ItemInInventoryDeletingDialogUserControl.xaml
    /// </summary>
    public partial class ItemInInventoryDeletingDialogUserControl : UserControl
    {
        public ItemInInventoryDeletingDialogUserControl()
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
