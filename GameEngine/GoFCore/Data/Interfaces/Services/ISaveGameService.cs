using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Data.Interfaces.Services
{
    public interface ISaveGameService
    {
        void Save(PlayerSaveData playerData);
    }
}
