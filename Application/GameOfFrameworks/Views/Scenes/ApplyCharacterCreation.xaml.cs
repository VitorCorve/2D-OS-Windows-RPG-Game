using GameOfFrameworks.Models.Temporary;
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
    /// Логика взаимодействия для ApplyCharacterCreation.xaml
    /// </summary>
    public partial class ApplyCharacterCreation : Page
    {
        public ApplyCharacterCreation()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            NewGame newGame = new NewGame();
            NavigationService.Navigate(newGame);
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            Armory armory = new Armory();
            NavigationService.Navigate(armory);
        }

        private void Button_Click(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

        private void Button_Click_1(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

        private void Button_Click_2(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

        private void Button_Click_3(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();

        private void Button_Click_4(object sender, RoutedEventArgs e) => ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
    }
}
