using GameEngine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Services
{
    public class ObserverService
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public string DealerName { get; set; }
        public string TargetName { get; set; }

        public ObserverService(CombatManager player1Manager, PlayerGlobalData player1Data, PlayerGlobalData player2Data)
        {
            player1Manager.Ready.Log += ConstructReadyNotification;
            player1Manager.Defense.Log += ConstructDefenseNotification;
            player1Manager.Combat.LogDamage += ConstructCombatDamageNotification;
            player1Manager.Combat.LogBuff += ConstructCombatBuffNotification;

            DealerName = player1Data.Name;
            TargetName = player2Data.Name;
        }

        private void ConstructReadyNotification(string str)
        {
            Log(DealerName + $" {str}");
        }

        private void ConstructDefenseNotification(string str)
        {
            Log(TargetName + $" {str}");
        }

        private void ConstructCombatDamageNotification(string str)
        {
            Log(DealerName + $" {str} to " + TargetName);
        }
        private void ConstructCombatBuffNotification(string str)
        {
            Log(DealerName + $" {str}");
        }
    }
}
