﻿using GameOfFrameworks.Infrastructure.Commands.Base;

namespace GameOfFrameworks.Infrastructure.Commands.Armory.Equipment
{
    public class TakeOffWearedItemCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            // application logic
        }
    }
}