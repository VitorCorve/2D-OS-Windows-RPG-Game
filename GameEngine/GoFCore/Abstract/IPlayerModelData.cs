using GameEngine.Locations;
using GameEngine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Abstract
{
    public interface IPlayerModelData
    {
        string Name { get; }
        SPECIALIZATION Specialization { get; }
        GENDER Gender { get; }
        int Level { get; }
        LAND CurrentLand { get; }
        TOWN CurrentTown { get; }
        PLAYER_GRADE PlayerGrade { get; }
        int Experience { get; }
        int MaxExperience { get; }
    }
}
