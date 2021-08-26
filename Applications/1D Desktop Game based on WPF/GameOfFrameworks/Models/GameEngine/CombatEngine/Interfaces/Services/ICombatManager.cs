using GameEngine.CombatEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ICombatManager
    {
        PlayerEntity Dealer { get; }
        PlayerEntity Target { get; }
        DefenseService Defense { get; }
        ValidateEntityCanExecuteActionService Ready { get; }
        CombatServiсe Combat { get; }
        void Action(ISkill skill);
    }
}
