using GameOfFrameworks.Infrastructure.Commands.LoadGame;
using GameOfFrameworks.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace GameOfFrameworks.Scenes.UserControls
{
    /// <summary>
    /// Логика взаимодействия для CustomConfirmationDialogUserControl.xaml
    /// </summary>
    public partial class CustomConfirmationDialogUserControl : UserControl
    {
        public LoadGameViewModel ParentViewModel { get; set; }
        public ICommand DeletingCharacterConfirmation { get; set; }
        public CustomConfirmationDialogUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            ParentViewModel = new LoadGameViewModel();
            DeletingCharacterConfirmation = new DeleteGameSaveCommand(ParentViewModel);
        }
        public void DeletingCharacterConfirmationClick(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
