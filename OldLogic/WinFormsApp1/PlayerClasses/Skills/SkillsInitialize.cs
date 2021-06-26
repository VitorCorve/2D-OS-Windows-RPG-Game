using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class SkillsInitialize
    {
        public static void Use(Player player, NPC npc, string skillName)
        {
            switch (skillName)
            {
                case "Backstab":
                     RogueSkills.BackStab(player, npc);
                    return;
                case "Rend":
                     RogueSkills.Rend(player, npc);
                    return;
                case "Stun":
                     RogueSkills.Stun(player, npc);
                    return;
                case "Dissapears Into The Shadows":
                     RogueSkills.Dissapear(player, npc);
                    return;
                case "Find The Weakness":
                     RogueSkills.FindTheWeakness(player, npc);
                    return;
                case "Fireball":
                     MageSkills.Fireball(player, npc);
                    return;
                case "Magic Shield":
                     MageSkills.MagicShield(player, npc);
                    return;
                case "Polymorph":
                     MageSkills.Polymorph(player, npc);
                    return;
                case "Soul Burn":
                     MageSkills.SoulBurn(player, npc);
                    return;
                case "Heal":
                     MageSkills.Heal(player, npc);
                    return;
                case "Power Hit":
                    WarriorSkills.PowerHit(player, npc);
                    return;
                case "Wide Blow":
                    WarriorSkills.WideBlow(player, npc);
                    return;
                case "Crush Legs":
                    WarriorSkills.CrushLegs(player, npc);
                    return;
                case "Deep Defense":
                    WarriorSkills.DeepDefense(player, npc);
                    return;
                case "Last Man Standing":
                    WarriorSkills.LastManStanding(player, npc);
                    return;
                default:
                    break;
            }
        }
    }
}
