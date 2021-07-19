using GameEngine.Player;

namespace GameEngine.CombatEngine.Services
{
    public class ObserverService
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public string DealerName { get; set; }
        public string TargetName { get; set; }

        public ObserverService(CombatManager player1Manager, PlayerModelData player1Data, PlayerModelData player2Data)
        {
            player1Manager.Ready.Log += ConstructReadyNotification;
            player1Manager.Defense.Log += ConstructDefenseNotification;
            player1Manager.Combat.LogDamage += ConstructCombatDamageNotification;
            player1Manager.Combat.LogBuff += ConstructCombatBuffNotification;
            player1Manager.Combat.LogDebuff += ConstructCombatDebuffNotification;
            player1Manager.Target.LogDotDamage += ConstructCombatDoTNotification;
            player1Manager.Target.LogSpecialDamage += ConstructCombatSpecialDamageNotification;

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

        private void ConstructCombatDebuffNotification(string str)
        {
            Log(DealerName + $" {str} on " + TargetName);
        }

        private void ConstructCombatDoTNotification(string str)
        {
            Log(DealerName + $"'s {str} to " + TargetName);
        }

        private void ConstructCombatSpecialDamageNotification(string str)
        {
            Log($"{DealerName}'s {str} " + TargetName + "!");
        }
    }
}
