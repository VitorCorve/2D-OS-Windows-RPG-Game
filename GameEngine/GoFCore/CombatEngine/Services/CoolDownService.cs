using GameEngine.CombatEngine.Interfaces;
using System.Timers;

namespace GameEngine.CombatEngine.Services
{
    public class CoolDownService : ICoolDownService
    {
        public int CoolDown { get; private set; }
        public Timer CoolDownTimer { get; private set; }

        public ISkill Skill { get; private set; }

        public CoolDownService(ISkill skill)
        {
            Skill = skill;
        }

        public void Activate()
        {
            Skill.CoolDown = Skill.CoolDownDuration;
            CoolDown = Skill.CoolDownDuration;
            CoolDownTimer = new Timer(1000);
            CoolDownTimer.Elapsed += CoolDownTick;
            CoolDownTimer.Start();
        }

        private void CoolDownTick(object sender, ElapsedEventArgs e)
        {
            if (CoolDown == 0)
                Deactivate();
            else
                CoolDown -= 1;

            Skill.CoolDown = CoolDown;

        }

        public void Deactivate()
        {
            CoolDownTimer.Stop();
            Skill.CoolDownEnd();
        }

    }
}
