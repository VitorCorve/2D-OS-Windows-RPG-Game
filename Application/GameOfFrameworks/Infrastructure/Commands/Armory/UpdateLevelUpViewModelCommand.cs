using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Armory.AttributesControl;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.ArmoryUserControlsViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.Armory
{
    public class UpdateLevelUpViewModelCommand : Command
    {
        public LevelUpViewModel ViewModel { get; set; }
        public UpdateLevelUpViewModelCommand(LevelUpViewModel levelUpViewModel) => ViewModel = levelUpViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            ViewModel.PlayerConsumables = null;
            ViewModel.Attributes = null;
            ViewModel.Attributes = new LevelUpAttributesModel(ArmoryTemporaryData.PlayerAttributes);
            ViewModel.PlayerConsumables = ArmoryTemporaryData.PlayerModel.PlayerConsumables;
        }
    }
}
