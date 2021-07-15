using GameEngine.CombatEngine.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces.SkillMechanics
{
    public interface ISpecialSkill : IBuffResourceType
    {
        event SpecialAblitiesCallDelegate Buff;
        event SpecialAbilitiesFadeDelegate BuffFade;
        IResourceType SpecialResource { get; }
        void CancelEffect();
    }
}
