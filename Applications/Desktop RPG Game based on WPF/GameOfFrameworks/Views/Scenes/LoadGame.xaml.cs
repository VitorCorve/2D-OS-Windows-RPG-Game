using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для LoadGame.xaml
    /// </summary>
    public partial class LoadGame : Page
    {
        public LoadGame()
        {
            InitializeComponent();
            DeletingConfirmationDialog.YesButton.Click += HideDeletingConfirmationDialog;
            DeletingConfirmationDialog.NoButton.Click += HideDeletingConfirmationDialog;
            DeletingConfirmationDialog.YesButton.Click += EnableDialogBehindUI;
            DeletingConfirmationDialog.NoButton.Click += EnableDialogBehindUI;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Image img = new Image();

            RunGame runGame = new RunGame();
            NavigationService.Navigate(runGame);
        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            DeletingConfirmationDialog.Visibility = Visibility.Visible;
            DisableDialogBehindUI(sender, e);
        }
        private void DisableDialogBehindUI(object sender, RoutedEventArgs e)
        {
            SaveGamesListBox.IsManipulationEnabled = false;
            DeleteButton.IsEnabled = false;
            CharacterAvatar.IsEnabled = false;
            LoadButton.IsEnabled = false;
            BackButton.IsEnabled = false;
        }
        private void EnableDialogBehindUI(object sender, RoutedEventArgs e)
        {
            SaveGamesListBox.IsEnabled = IsManipulationEnabled = true;
            DeleteButton.IsEnabled = true;
            CharacterAvatar.IsEnabled = true;
            LoadButton.IsEnabled = true;
            BackButton.IsEnabled = true;
        }
        private void HideDeletingConfirmationDialog(object sender, RoutedEventArgs e) => DeletingConfirmationDialog.Visibility = Visibility.Hidden;
    }
}
