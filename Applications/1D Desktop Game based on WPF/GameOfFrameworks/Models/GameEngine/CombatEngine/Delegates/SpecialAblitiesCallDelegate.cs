using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.Resources;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Delegates
{
    public delegate void SpecialAblitiesCallDelegate(ISpecialSkill skill, double value);
}
