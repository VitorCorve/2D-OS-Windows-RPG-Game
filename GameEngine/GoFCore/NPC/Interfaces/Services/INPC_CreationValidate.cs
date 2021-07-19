using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.NPC.Interfaces.Services
{
    public interface INPC_CreationValidate
    {
        INPC_Enemy Validate(int playerLevel);
    }
}
