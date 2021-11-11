using GameOfFrameworks.Models.Temporary;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для LootBar.xaml
    /// </summary>
    public partial class LootBar : UserControl
    {
        public LootBar()
        {
            InitializeComponent();
        }

        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }
    }
}
