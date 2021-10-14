using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.LevelUp
{
    public class UpdatePlayerAttributeCommand : ICommand
    {
        public LevelUpViewModel ViewModel { get; }
        public event EventHandler CanExecuteChanged;
        public UpdatePlayerAttributeCommand(LevelUpViewModel levelUpViewModel) => ViewModel = levelUpViewModel;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter)
        {
            string attribute = (string)parameter;
            ViewModel.Attributes.UpdateAttribute(ArmoryTemporaryData.PlayerAttributes, attribute);
            ViewModel.PlayerConsumables.AttributePointsValue.Value--;
            ArmoryTemporaryData.PlayerAttributes = ViewModel.Attributes.ReturnEntityAttributes();
            AttributesControlViewModel.UpdateAttributesViewModelCommand.Execute(null);
            ArmoryViewModel.UpdateArmoryViewModelCommand.Execute(null);
            LevelUpViewModel.UpdateLevelUpViewModelCommand.Execute(null);
        }
    }
}
