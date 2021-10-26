using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class UseSkillCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public UseSkillCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter)
        {
            if (parameter is null) return false;
            if (ViewModel.SkillShortcuts.SkillViewList[int.Parse((string)parameter)].Skill is null) return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            ViewModel.UseSkillByIndex(ViewModel.GetSkillIndex(GetSkillID(int.Parse((string)parameter))));
            ViewModel.Effects.SkillEffectViewList[int.Parse((string)parameter)].Activate();
        }
        private int GetSkillID(int shortcutsBarItemIndex) => ViewModel.SkillShortcuts.SkillViewList[shortcutsBarItemIndex].Skill.Skill_ID;
    }
}
