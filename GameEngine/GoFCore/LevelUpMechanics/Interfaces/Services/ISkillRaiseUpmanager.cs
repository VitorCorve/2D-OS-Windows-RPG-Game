using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.LevelUpMechanics.Interfaces.Services
{
    public interface ISkillRaiseUpmanager
    {
        ISkill Skill { get; }
        int SkillLevel { get; }
        void Raise();
    }
}
