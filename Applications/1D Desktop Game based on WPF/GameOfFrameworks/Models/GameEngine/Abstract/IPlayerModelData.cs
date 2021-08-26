using GameEngine.Locations;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
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
        PlayerBiography Bio { get; }
        PlayerAvatar Avatar_ID { get; }
        int Experience { get; }
        int MaxExperience { get; }
    }
}
