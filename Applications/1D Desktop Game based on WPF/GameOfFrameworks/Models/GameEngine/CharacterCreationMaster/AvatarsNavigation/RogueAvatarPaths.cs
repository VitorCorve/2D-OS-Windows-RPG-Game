using GameEngine.CharacterCreationMaster.Interfaces;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class RogueAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public RogueAvatarPaths()
        {
            for (int i = 10; i < 20; i++)
            {
                AvatarsData.Add(i, $"{i}");
            }
        }
    }
}
