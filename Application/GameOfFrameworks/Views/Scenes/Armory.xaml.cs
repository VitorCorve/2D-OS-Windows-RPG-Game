using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels.Options;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            ArmoryTemporaryData.Instance = this;
        }

        private void EquippmentButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(EquipmentControlElement);
        private void MerchantButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(MerchantControlElement);
        private void AttributesButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(AttributesControlElement);
        private void LevelUpButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(LevelUpControlElement);
        private void MapButton_Click(object sender, RoutedEventArgs e) => SetActiveUserControl(MapControlElement);
        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(OptionsControlElement);
            OptionsControlViewModel.ShowOptionsControlCommand.Execute(null);
        }
        public void SetActiveUserControl(UserControl control)
        {
            if (control.Visibility == Visibility.Visible) return;
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
            ArmoryViewModel.SaveGameCommand.Execute(true);
            BattleWindow battleWindow = new BattleWindow();
            NavigationService.Navigate(battleWindow);
        }
    }
}
