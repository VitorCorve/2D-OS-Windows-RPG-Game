using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.CharacterCreation;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectFemaleGenderCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => CharacterCreationManager.CreationMaster.SelectGender(1);
    }
}
