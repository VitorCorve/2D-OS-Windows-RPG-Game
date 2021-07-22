using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.LevelUpMechanics.Interfaces.Services
{
    public interface ISkillRaiseUpService
    {
        int SkillLevel { get; }
        T LevelUpSkill<T>(T skill) where T : ISkill, new();
    }
}
