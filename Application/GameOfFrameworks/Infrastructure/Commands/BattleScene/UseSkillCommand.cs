using GameEngine.CombatEngine;
using GameOfFrameworks.Infrastructure.Commands.Base;
using GameOfFrameworks.ViewModels;
using System;

namespace GameOfFrameworks.Infrastructure.Commands.BattleScene
{
    public class UseSkillCommand : Command
    {
        private readonly BattleWindowViewModel ViewModel;
        public UseSkillCommand(BattleWindowViewModel battleWindowViewModel) => ViewModel = battleWindowViewModel;
        public override bool CanExecute(object parameter)
        {
            if (parameter is null) return false;
            if (ViewModel.SkillShortcuts.SkillViewList[ConvertValue(parameter)].Skill is null) return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            if (ViewModel.BattleIsOver) return;

            if (ConvertValue(parameter) > 9) return;

            if (!IsExists(ConvertValue(parameter))) return;

            if (IsSkillReadyToUse(GetSkillID(ConvertValue(parameter))))
            {
                int skillId = ViewModel.Effects.SkillEffectViewList[ConvertValue(parameter)].ID;
                foreach (var item in ViewModel.Effects.SkillEffectViewList)
                {
                    if (item.ID == skillId)
                    {
                        item.Activate();
                    }
                }
            }
            ViewModel.UseSkillByIndex(GetSkillIndex(GetSkillID(ConvertValue(parameter))));
        }
        public void Execute(int parameter)
        {
            if (ConvertValue(parameter) > 9) return;

            if (IsExists(ConvertValue(parameter)))
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
        private int ConvertValue(object value)
        {
            if (value is int)
            {
                return (int)value;
            }
            return int.Parse(value.ToString());
        }
    }
}
