using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System.Collections.Generic;

namespace GameOfFrameworks.Infrastructure.Commands.MainWindow
{
    public class ExecuteConsoleCommand : Command
    {
        private readonly MainWindowViewModel ViewModel;
        public ExecuteConsoleCommand(MainWindowViewModel mainWindowViewModel) => ViewModel = mainWindowViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ArmoryTemporaryData.Console = ConsoleHandlerService.SetupConsoleConfiguration();
            ArmoryTemporaryData.Console.RunCommand((string)parameter);
            ConsoleHandlerService.UpdateArmory(ArmoryTemporaryData.Console);
            ViewModel.ConsoleNotificationsList.AddNewCommandToViewList(ArmoryTemporaryData.Console.Notification);
            ViewModel.CommandsList.AddNewCommandToViewList(new List<string> { (string)parameter });
            ViewModel.ConsoleCommand = null;
            ArmoryViewModel.UpdateArmoryViewModelCommand.Execute(null);
            AttributesControlViewModel.UpdateAttributesViewModelCommand.Execute(null);
            AttributesControlViewModel.UpdateAttributesViewModelAvailableSkillsCommand.Execute(null);
            EquipmentControlViewModel.UpdateEquipmentViewModelCommand.Execute(null);
            MerchantControlViewModel.UpdateMerchantViewModelCommand.Execute(null);
        }
    }
}
