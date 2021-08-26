using GameEngine.CombatEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Abstract
{
    public interface IPlayerSkillList
    {
        List<ISkill> Skills { get; }
    }
}
