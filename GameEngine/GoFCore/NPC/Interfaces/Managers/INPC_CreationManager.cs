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
        IEntityAttributes NPC { get; }
        PlayerModelData NPC_Model { get; }
        void Create(List<INPC_Enemy> npcList, int level);
    }
}
