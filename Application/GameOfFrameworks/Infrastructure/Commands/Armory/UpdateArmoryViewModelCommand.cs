using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateArmoryViewModelCommand : Command
    {
        public ArmoryViewModel ViewModel { get; set; }
        public UpdateArmoryViewModelCommand(ArmoryViewModel AamoryViewModel) => ViewModel = AamoryViewModel;
        public override bool CanExecute(object parameter)
        {
            if (ArmoryTemporaryData.IsPlayerEntityChanged)
            {
                ArmoryTemporaryData.IsPlayerEntityChanged = false;
                return true;
            }
            else return false;
        }
        public override void Execute(object parameter)
        {
            ViewModel.CharacterEntity = null;
            ViewModel.CharacterEntity = ArmoryTemporaryData.CharacterEntity;
        }
    }
}
