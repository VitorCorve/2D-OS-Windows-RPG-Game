using GameOfFrameworks.Infrastructure.Commands.BattleScene;
using GameOfFrameworks.ApplicationData.Interfaces;
using GameOfFrameworks.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace GameOfFrameworks.ApplicationData
{
    public class KeyboardBindingsModel
    {
        private readonly BattleWindowViewModel ViewModel;
        public List<IButtonBinding> Bindings { get; set; }
        public KeyboardBindingsModel(BattleWindowViewModel battleWindowViewModel)
        {
            ViewModel = battleWindowViewModel;
            InitializeDefault();
        }
        public void InitializeDefault()
        {
            Bindings = new List<IButtonBinding>();

            for (int i = 0; i < 10; i++)
            {
                Bindings.Add(new ButtonBinding());
            }

            Bindings[0] = new ButtonBinding(Key.Q, 0);
            Bindings[1] = new ButtonBinding(Key.W, 1);
            Bindings[2] = new ButtonBinding(Key.E, 2);
            Bindings[3] = new ButtonBinding(Key.R, 3);
            Bindings[4] = new ButtonBinding(Key.T, 4);
            Bindings[5] = new ButtonBinding(Key.A, 5);
            Bindings[6] = new ButtonBinding(Key.S, 6);
            Bindings[7] = new ButtonBinding(Key.D, 7);
            Bindings[8] = new ButtonBinding(Key.F, 8);
            Bindings[9] = new ButtonBinding(Key.X, 9);
        }
        public void SkillUse(Key key)
        {
            foreach (var item in Bindings)
            {
                if (item.Key == key)
                {
                    var useSkillCommand = new UseSkillCommand(ViewModel);
                    useSkillCommand.Execute(item.ShortcutIndex);
                }
            }
        }

    }
}
