using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine
{
    public class CombatManager : ICombatManager
    {
        public PlayerEntity Dealer { get; private set; }
        public PlayerEntity Target { get; private set; }
        public DefenseService Defense { get; private set; }
        public ReadyToAttackService Ready { get; private set; }
        public CombatServiсe Combat { get; private set; }
        public CombatManager(PlayerEntity dealer, PlayerEntity target)
        {
            Dealer = dealer;
            Target = target;
            Defense = new DefenseService(Target);
            Ready = new ReadyToAttackService(Dealer);
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
