using GameOfFrameworks.ApplicationData;
using GameOfFrameworks.Models.Temporary;
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
            ApplicationTemporaryData.Sound.SceneBackgroundSoundTrackPlay(SCENE.RunGame);
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            NewGame newGame = new NewGame();
            NavigationService.Navigate(newGame);
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            LoadGame loadGame = new LoadGame();
            NavigationService.Navigate(loadGame);
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTemporaryData.Sound.ButtonPressSoundPlay();
            GameOptions gameOptions = new GameOptions();
            NavigationService.Navigate(gameOptions);
        }
    }
}
