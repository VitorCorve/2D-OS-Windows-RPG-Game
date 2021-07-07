using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class LogService
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;

        public LogService(params CombatManager[] managers)
        {
            foreach (var service in managers)
            {
                service.Ready.Log += GetLog;
                service.Defense.Log += GetLog;
                service.Combat.Log += GetLog;
            }
        }

        private void GetLog(string str)
        {
            Log(str);
        }
    }
}
