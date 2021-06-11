using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для Armory.xaml
    /// </summary>
    public partial class Armory : Page
    {
        public Armory()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            RunGame runGame = new RunGame();
            NavigationService.Navigate(runGame);

        }

        private void EquippmentButton_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(EquipmentControlElement);
        }

        public void SetActiveUserControl(UserControl control)
        {
            EquipmentControlElement.Visibility = Visibility.Collapsed;
            AttributesControlElement.Visibility = Visibility.Collapsed;
            InventoryControlElement.Visibility = Visibility.Collapsed;
            OptionsControlElement.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(InventoryControlElement);
        }

        private void AttributesButton_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(AttributesControlElement);
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(OptionsControlElement);
        }
    }
}
