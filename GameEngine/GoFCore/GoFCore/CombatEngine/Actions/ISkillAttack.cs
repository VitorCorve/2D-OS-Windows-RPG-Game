using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Actions
{
    public interface ISkillAttack
    {
        public delegate void CombatAction(PlayerEntity player);
        void Execute(PlayerEntity player, CombatAction func);
        void Execute(PlayerEntity player, ISkill skill);
    }
}
