using GameEngine.Player;
using GameEngine.Player.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.NPC.Interfaces.Managers
{
    public interface INPC_CreationManager
    {
        INPC_Enemy NPC { get; }
        NPC_ModelData NPC_Model { get; }
    }
}
