using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ICoolDownService
    {
        int CoolDown { get; }
        Timer CoolDownTimer { get; }
        void Activate();
        void Deactivate();
    }
}
