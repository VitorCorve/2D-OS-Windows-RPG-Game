using GameOfFrameworks.Infrastructure.Commands.Base;
using System;

namespace GameOfFrameworks.Infrastructure.Commands
{
    public class LambdaCommands : Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;
        public LambdaCommands(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _Execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
        public override void Execute(object parameter) => _Execute?.Invoke(parameter);
    }
}
