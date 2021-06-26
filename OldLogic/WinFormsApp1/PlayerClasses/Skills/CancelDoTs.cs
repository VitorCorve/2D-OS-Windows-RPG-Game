using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class CancelDoTs
    {
        public static void Execute()
        {
            RogueSkills.BackStabTimer?.Stop();
            RogueSkills.RendDurationTimer?.Stop();
            RogueSkills.StunCoolDownTimer?.Stop();
            RogueSkills.StunAffectDurationTimer?.Stop();
            RogueSkills.DissapearCoolDownTimer?.Stop();
            RogueSkills.DissapearDurationTimer?.Stop();
            RogueSkills.FindTheWeaknessCoolDownTimer?.Stop();
            RogueSkills.FindTheWeaknessDurationTimer?.Stop();
            RogueSkills.RendCoolDownTimer?.Stop();

            RogueSkills.BackStabTimer = null;
            RogueSkills.RendCoolDownTimer = null;
            RogueSkills.RendDurationTimer = null;
            RogueSkills.StunCoolDownTimer = null;
            RogueSkills.StunAffectDurationTimer = null;
            RogueSkills.DissapearCoolDownTimer = null;
            RogueSkills.DissapearDurationTimer = null;
            RogueSkills.FindTheWeaknessCoolDownTimer = null;
            RogueSkills.FindTheWeaknessDurationTimer = null;

            MageSkills.FireballCoolDownTimer?.Stop();
            MageSkills.MagicShieldCoolDownTimer?.Stop();
            MageSkills.MagicShieldDurationTimer?.Stop();
            MageSkills.PolymorphCoolDownTimer?.Stop();
            MageSkills.PolymorphAffectDurationTimer?.Stop();
            MageSkills.SoulBurnCoolDownTimer?.Stop();
            MageSkills.SoulBurnDurationTimer?.Stop();
            MageSkills.HealCoolDownTimer?.Stop();

                        MageSkills.FireballCoolDownTimer = null;
            MageSkills.MagicShieldCoolDownTimer = null;
            MageSkills.MagicShieldDurationTimer = null;
            MageSkills.PolymorphCoolDownTimer = null;
            MageSkills.PolymorphAffectDurationTimer = null;
            MageSkills.SoulBurnCoolDownTimer = null;
            MageSkills.SoulBurnDurationTimer = null;
            MageSkills.HealCoolDownTimer = null;
        }
    }
}
