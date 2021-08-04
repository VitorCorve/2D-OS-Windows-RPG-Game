using GameEngine.BattleMaster.Interfaces;
using GameEngine.BattleMaster.Services;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Data;
using GameEngine.EquipmentManagement;
using GameEngine.NPC;
using System.Collections.Generic;

namespace GameEngine.BattleMaster
{
    public class BattleMaster : IBattleMaster
    {
        public List<ObserverService> Observers { get; private set; } = new List<ObserverService> { };
        public AutoAttackMaster AutoAttack { get; private set; }
        public CombatManager PlayerCombatManager { get; private set; }
        public List<ISkill> SkillList { get; private set; }
        public BattleMaster(PlayerLoadData playerLoadData)
        {
            var playerEntityConstructor = new PlayerEntityConstructor();
            var npcCreationManager = new NPC_CreationManager(playerLoadData.PlayerModel);

            var equipmentValues = new EquipmentValue(playerLoadData.Equipment);

            var playerEntity = playerEntityConstructor.CreatePlayer(
                playerLoadData.PlayerModel, 
                playerLoadData.SpecializationAttributes, 
                equipmentValues);

            var npcEntity = playerEntityConstructor.CreatePlayer(
                npcCreationManager.NPC_Model, 
                npcCreationManager.NPC);

            var playerCombatManager = new CombatManager(dealer: playerEntity, target: npcEntity);
            var npcCombatManager = new CombatManager(dealer: npcEntity, target: playerEntity);

            AutoAttack = new AutoAttackMaster(
                dealerCombatManager: playerCombatManager, 
                targetCombatManager: npcCombatManager);

            var observerService = new ObserverService(playerCombatManager, playerLoadData.PlayerModel, npcCreationManager.NPC_Model);
            var observerService2 = new ObserverService(npcCombatManager, npcCreationManager.NPC_Model, playerLoadData.PlayerModel);

            Observers.Add(observerService);
            Observers.Add(observerService2);

            playerEntity.HealthPoints.StopCombat += StopFight;
            npcEntity.HealthPoints.StopCombat += StopFight;

            PlayerCombatManager = playerCombatManager;
            SkillList = playerLoadData.ListOfSkills.Skills;
        }
        public void StartFight()
        {
            AutoAttack.RunAutoAttack();
        }
        public void StopFight()
        {
            AutoAttack.StopAutoAttack();
        }
        public void Pause()
        {

        }

        public void UseSkill(int skillIndex)
        {
            PlayerCombatManager.Action(SkillList[skillIndex]);
        }
    }
}
