using GameEngine.CombatEngine;
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
            if (IsSkillReadyToUse(GetSkillID(int.Parse((string)parameter))))
            {
                ViewModel.Effects.SkillEffectViewList[int.Parse((string)parameter)].Activate();
            }
            ViewModel.UseSkillByIndex(GetSkillIndex(GetSkillID(int.Parse((string)parameter))));
        }
        public void Execute(int parameter)
        {
            if (IsExists(parameter))
            {
                if (IsSkillReadyToUse(GetSkillID(parameter)))
                {
                    ViewModel.Effects.SkillEffectViewList[parameter].Activate();
                }
                ViewModel.UseSkillByIndex(GetSkillIndex(GetSkillID(parameter)));
            }
            else
            {
                return;
            }

        }
        private int GetSkillID(int shortcutsBarItemIndex) => ViewModel.SkillShortcuts.SkillViewList[shortcutsBarItemIndex].Skill.Skill_ID;
        public bool IsSkillReadyToUse(int ID)
        {
            var validateSkillUse = new ValidateEntityCanExecuteActionService(ViewModel.Master.PlayerCombatManager.Dealer);

            foreach (var item in ViewModel.Master.SkillList)
            {
                if (item.Skill_ID == ID)
                    return validateSkillUse.CheckStatement(item);
            }
            return false;
        }
        public int GetSkillIndex(int ID)
        {
            int count = 0;

            foreach (var item in ViewModel.Master.SkillList)
            {
                if (item.Skill_ID == ID)
                    return count;
                else
                    count++;
            }
            return count;
        }
        private bool IsExists(int index) => ViewModel.SkillShortcuts.SkillViewList[index].Skill != null;
    }
}
