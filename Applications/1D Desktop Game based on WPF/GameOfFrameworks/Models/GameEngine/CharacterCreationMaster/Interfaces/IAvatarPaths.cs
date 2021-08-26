using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CharacterCreationMaster.Interfaces
{
    public interface IAvatarPaths
    {
        Dictionary<int, string> AvatarsData { get; }
    }
}
