using GameEngine.CharacterCreationMaster.Interfaces;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class MageAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public MageAvatarPaths()
        {
            for (int i = 20; i < 30; i++)
            {
                AvatarsData.Add(i, $"{i}");
            }
        }
    }
}
