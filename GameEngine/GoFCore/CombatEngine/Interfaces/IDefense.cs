using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDefense
    {
        double BlockChance { get; }
        double DodgeChance { get; }
        double ParryChance { get; }
        double ResistChance { get; }
        bool DefenseCheck(ISkill type);
        double Chance();
    }
}
