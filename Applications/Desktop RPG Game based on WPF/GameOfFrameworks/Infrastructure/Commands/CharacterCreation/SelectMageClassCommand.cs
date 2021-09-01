﻿using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.CharacterCreation;

namespace GameOfFrameworks.Infrastructure.Commands.CharacterCreation
{
    public class SelectMageClassCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => CharacterCreationManager.CreationMaster.SelectSpecialization(1);
    }
}
