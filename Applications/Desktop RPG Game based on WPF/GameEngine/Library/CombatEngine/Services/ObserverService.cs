using GameEngine.NPC;
using GameEngine.Player;

namespace GameEngine.CombatEngine.Services
{
    public class ObserverService
    {
        public delegate void NotifyMaster(string message);
        public event NotifyMaster Log;
        public string DealerName { get; set; }
        public string TargetName { get; set; }

        public ObserverService(CombatManager player1Manager, PlayerModelData player1ModelData, PlayerModelData player2ModelData)
        {
            player1Manager.Ready.Log += ConstructReadyNotification;
            player1Manager.Defense.Log += ConstructDefenseNotification;
            player1Manager.Combat.LogDamage += ConstructCombatDamageNotification;
            player1Manager.Combat.LogBuff += ConstructCombatBuffNotification;
            player1Manager.Combat.LogDebuff += ConstructCombatDebuffNotification;
            player1Manager.Target.LogDotDamage += ConstructCombatDoTNotification;
            player1Manager.Target.LogSpecialDamage += ConstructCombatSpecialDamageNotification;
            player1Manager.Combat.LogDeath += ConstructCharacterDeathNotification;

            DealerName = player1ModelData.Name;
            TargetName = player2ModelData.Name;
        }
        public ObserverService(CombatManager player1Manager, NPC_ModelData npcModelData, PlayerModelData playerModelData)
        {
            player1Manager.Ready.Log += ConstructReadyNotification;
            player1Manager.Defense.Log += ConstructDefenseNotification;
            player1Manager.Combat.LogDamage += ConstructCombatDamageNotification;
            player1Manager.Combat.LogBuff += ConstructCombatBuffNotification;
            player1Manager.Combat.LogDebuff += ConstructCombatDebuffNotification;
            player1Manager.Target.LogDotDamage += ConstructCombatDoTNotification;
            player1Manager.Target.LogSpecialDamage += ConstructCombatSpecialDamageNotification;
            player1Manager.Combat.LogDeath += ConstructCharacterDeathNotification;

            DealerName = npcModelData.Name.ToString();
            TargetName = playerModelData.Name;
        }

        public ObserverService(CombatManager player1Manager, PlayerModelData playerModelData, NPC_ModelData npcModelData)
        {
            player1Manager.Ready.Log += ConstructReadyNotification;
            player1Manager.Defense.Log += ConstructDefenseNotification;
            player1Manager.Combat.LogDamage += ConstructCombatDamageNotification;
            player1Manager.Combat.LogBuff += ConstructCombatBuffNotification;
            player1Manager.Combat.LogDebuff += ConstructCombatDebuffNotification;
            player1Manager.Target.LogDotDamage += ConstructCombatDoTNotification;
            player1Manager.Target.LogSpecialDamage += ConstructCombatSpecialDamageNotification;
            player1Manager.Combat.LogDeath += ConstructCharacterDeathNotification;

            DealerName = playerModelData.Name;
            TargetName = npcModelData.Name.ToString();
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
        public void ConstructCharacterDeathNotification(string str)
        {
            Log($"{TargetName} {str}");
        }
    }
}
