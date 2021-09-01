using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.CharacterCreation;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectRogueClassCommand : Command
    {
        public delegate void Action();
        public SelectRogueClassCommand(Action func = null)
        {
            func?.Invoke();
        }
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => CharacterCreationManager.CreationMaster.SelectSpecialization(2);
    }
}
