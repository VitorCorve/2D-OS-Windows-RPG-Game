using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;

namespace GameEngine.CombatEngine
{
    public class CombatManager : ICombatManager
    {
        public PlayerEntity Dealer { get; private set; }
        public PlayerEntity Target { get; private set; }
        public DefenseService Defense { get; private set; }
        public ValidateEntityCanExecuteActionService Ready { get; private set; }
        public CombatServiсe Combat { get; private set; }
        public CombatManager(PlayerEntity dealer, PlayerEntity target)
        {
            Dealer = dealer;
            Target = target;
            Defense = new DefenseService(Target);
            Ready = new ValidateEntityCanExecuteActionService(Dealer);
            Combat = new CombatServiсe(Dealer);
        }

        public void Action(ISkill skill)
        {
            if (Ready.CheckStatement(skill))
            {
                switch (skill)
                {
                    case IDamageSkill:
                        Damage(skill);
                        return;
                    case IBuffSkill:
                        Buff(skill);
                        return;
                    case IDebuffSkill:
                        Debuff(skill);
                        return;
                    case IHealSkill:
                        Buff(skill);
                        return;
                    default:
                        break;
                }
            }
        }

        private void Damage(ISkill skill)
        {
            Dealer.ReduceResource(skill);

            if (Defense.DefenseCheck(skill))
                Combat.Execute(Target, skill);
            else
                return;
        }

        private void Buff(ISkill skill)
        {
            Dealer.ReduceResource(skill);
            Combat.Execute(Dealer, skill);
        }

        private void Debuff(ISkill skill)
        {
            Dealer.ReduceResource(skill);
            Combat.Execute(Target, skill);
        }
    }
}
