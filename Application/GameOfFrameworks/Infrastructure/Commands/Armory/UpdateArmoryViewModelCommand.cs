using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateArmoryViewModelCommand : Command
    {
        public ArmoryViewModel ViewModel { get; set; }
        public UpdateArmoryViewModelCommand(ArmoryViewModel AamoryViewModel) => ViewModel = AamoryViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.CharacterEntity = null;
            ViewModel.PlayerModel = null;
            ViewModel.PlayerModel = ArmoryTemporaryData.PlayerModel;
            ViewModel.CharacterEntity = ArmoryTemporaryData.CharacterEntity;
        }
    }
}
