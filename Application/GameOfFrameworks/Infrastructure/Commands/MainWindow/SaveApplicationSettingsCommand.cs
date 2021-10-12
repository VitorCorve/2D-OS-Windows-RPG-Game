using GameOfFrameworks.ApplicationData.Services;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class SaveApplicationSettingsCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var settingsHandlerService = new SettingsHandlerService();
            settingsHandlerService.Save(MainWindowViewModel.Settings);
        }
    }
}
