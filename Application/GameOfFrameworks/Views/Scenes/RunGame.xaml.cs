using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GameOfFrameworks.Scenes
{
    /// <summary>
    /// Логика взаимодействия для RunGame.xaml
    /// </summary>
    public partial class RunGame : Page
    {
        public RunGame()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            NewGame newGame = new NewGame();
            NavigationService.Navigate(newGame);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadGame loadGame = new LoadGame();
            NavigationService.Navigate(loadGame);
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            GameOptions gameOptions = new GameOptions();
            NavigationService.Navigate(gameOptions);
        }
    }
}
