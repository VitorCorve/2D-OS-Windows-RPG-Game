using GameEngine.CharacterCreationMaster.Interfaces;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class WarriorAvatarsPaths : IAvatarPaths
    {
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public WarriorAvatarsPaths()
        {
            for (int i = 0; i < 10; i++)
            {
                AvatarsData.Add(i, $"{i}");
            }
        }
    }
}
