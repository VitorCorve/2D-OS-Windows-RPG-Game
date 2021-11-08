using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels;
using System;
using System.Windows.Input;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class RecognizeKeyDownCommand : Command
    {
        private BattleWindowViewModel ViewModel;
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            if (BattleWindowTemporaryData.IsActive)
            {
                var key = KeyCodeConverter.Convert(parameter.ToString());

                if (key != Key.None)
                {
                    BattleWindowTemporaryData.ViewModel.Bindings.SkillUse(key);
                }
            }
            else
            {
                return;
            }

        }
    }
}
