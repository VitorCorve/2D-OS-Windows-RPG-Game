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

        private void EquippmentButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(EquipmentControlElement);
        private void MerchantButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(MerchantControlElement);
        private void AttributesButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(AttributesControlElement);
        private void OptionsButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(OptionsControlElement);
        private void LevelUpButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(LevelUpControlElement);
        private void MapButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(MapControlElement);
        public void SetActiveUserControl(UserControl control)
        {
            EquipmentControlElement.Visibility = Visibility.Collapsed;
            MerchantControlElement.Visibility = Visibility.Collapsed;
            AttributesControlElement.Visibility = Visibility.Collapsed;
            OptionsControlElement.Visibility = Visibility.Collapsed;
            LevelUpControlElement.Visibility = Visibility.Collapsed;
            MapControlElement.Visibility = Visibility.Collapsed;
            control.Visibility = Visibility.Visible;
        }
        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            RunGame runGame = new RunGame();
            NavigationService.Navigate(runGame);

        }
        private void HuntButton_Click(object sender, RoutedEventArgs e)
        {
            BattleWindow battleWindow = new BattleWindow();
            NavigationService.Navigate(battleWindow);
        }
    }
}
