using GameOfFrameworks.Models.Temporary;
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
        public bool CanExecute(object parameter)
        {
            if (ViewModel.PlayerConsumables.AttributePointsValue.Value > 0)
            {
                return true;
            }
            return false;

        }
        public void Execute(object parameter)
        {
            string attribute = (string)parameter;
            ViewModel.Attributes.UpdateAttribute(attribute);
            ViewModel.PlayerConsumables.AttributePointsValue.Value--;
            ViewModel.AvailableAttributesPoints--;
            ArmoryTemporaryData.PlayerAttributes = ViewModel.Attributes.ReturnEntityAttributes();
            ArmoryTemporaryData.IsPlayerAttributesUpdated = true;
        }
    }
}
