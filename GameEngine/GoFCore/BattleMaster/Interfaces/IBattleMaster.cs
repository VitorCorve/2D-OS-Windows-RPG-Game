using GameEngine.BattleMaster.Services;
using GameEngine.CombatEngine.Services;
using System.Collections.Generic;


namespace GameEngine.BattleMaster.Interfaces
{
    public interface IBattleMaster
    {
        List<ObserverService> Observers { get; }
        AutoAttackMaster AutoAttack { get; }
        void StartFight();
        void StopFight();
        void Pause();
    }
}
