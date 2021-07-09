using System.Timers;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface ICoolDown
    {
        int CoolDown { get; }
        Timer CoolDownTimer { get; }
        void Activate();
        void Deactivate();
    }
}
