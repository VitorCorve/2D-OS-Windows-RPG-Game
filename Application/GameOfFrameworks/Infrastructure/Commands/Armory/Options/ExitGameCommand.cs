using GameOfFrameworks.Infrastructure.Commands.Base;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Options
{
    public class ExitGameCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => Environment.Exit(0);
    }
}
