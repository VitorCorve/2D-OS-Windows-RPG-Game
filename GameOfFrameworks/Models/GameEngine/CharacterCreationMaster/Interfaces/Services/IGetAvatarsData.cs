using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Interfaces.Services
{
    public interface IGetAvatarsData
    {
        List<PlayerAvatar> GetAvatarsList(SPECIALIZATION playerSpecialization);
    }
}
