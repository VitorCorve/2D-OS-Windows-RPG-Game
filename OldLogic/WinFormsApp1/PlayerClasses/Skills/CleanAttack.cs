using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class CleanAttack
    {
        public static int NPCAttackCoolDown { get; set; }
        public static int PlayerAttackCoolDown { get; set; }

        public static bool NPCAttackInProcess { get; set; }
        public static bool PlayerAttackInProcess { get; set; }

        public static Timer NPCAttackTimer { get; set; }
        public static Timer PlayerAttackTimer { get; set; }

        public static string CombatTextNPC { get; set; }
        public static string CombatTextPlayer { get; set; }

        public static string DamageTextPlayer { get; set; }

        public static bool InCombat { get; set; }

        public static bool CriticalPlayer { get; set; }
        public static bool CriticalNPC { get; set; }


        public static void Run(Player player, NPC npc)


        {

            Timer NPCAttack = new Timer();
            Timer PlayerAttack = new Timer();

            NPCAttack.Interval = npc.attackSpeed * 1500;

            if (NPCAttack.Interval < 1)
            {
                NPCAttack.Interval = 0;
            }

            NPCAttack.Elapsed += NPCAttack_Elapsed;

            PlayerAttack.Interval = player.attackSpeed * 1500;

            if (PlayerAttack.Interval < 1)
            {
                PlayerAttack.Interval = 0;
            }
            PlayerAttack.Elapsed += PlayerAttack_Elapsed;


            NPCAttack.Start();
            System.Threading.Thread.Sleep(500);
            PlayerAttack.Start();


            NPCAttackTimer = NPCAttack;
            PlayerAttackTimer = PlayerAttack;

            

        }

        private static void NPCAttack_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (npc.OutOfControl)
            {
                return;
            }

            if (!player.IsAlive)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                return;
            }

            if (!npc.IsAlive)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                return;
            }

            NPC();


        }

        private static void PlayerAttack_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (player.OutOfControl)
            {
                return;
            }

            if (!npc.IsAlive)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                return;
            }

            if (!player.IsAlive)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                return;
            }

            Player();
        }

        public static void NPC()
        {

            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();


            if (npc.OutOfControl)
            {
                return;
            }

            if (npc.healthpoints < 0 || npc.healthpoints == 0)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                return;
            }

            if (player.healthpoints < 0)
            {
                NPCAttackTimer.Stop();
                PlayerAttackTimer.Stop();
                player.healthpoints = 0;
                return;
            }
            if (NPCAttackCoolDown == 0)
            {
                if (!player.CrushLegs)
                {
                    if (player.Dodge())
                    {
                        List<string> combatData = new List<string> { };

                        combatData.Add($"{player.name} dodged attack.");
                        combatData.Add("images\\combatText\\dodge.jpg");
                        
                        combatData.Add($"{player.IconPath}");

                        CombatText.NPCDefenseAccepted = true;
                        CombatText.NPCCombatDefenseData = null;
                        CombatText.NPCCombatDefenseData = combatData;

                        Sounds.SoundMaster.PlayDefenseEvent("Dodge");

                        return;
                    }

                    if (player.Block())
                    {
                        List<string> combatData = new List<string> { };

                        combatData.Add($"{player.name} blocked attack.");
                        combatData.Add("images\\combatText\\block.jpg");

                        combatData.Add($"{player.IconPath}");

                        CombatText.NPCDefenseAccepted = true;
                        CombatText.NPCCombatDefenseData = null;
                        CombatText.NPCCombatDefenseData = combatData;

                        Sounds.SoundMaster.PlayDefenseEvent("Block");
                        return;
                    }

                    if (player.Parry())
                    {
                        List<string> combatData = new List<string> { };

                        combatData.Add($"{player.name} parried attack.");
                        combatData.Add("images\\combatText\\parry.jpg");

                        combatData.Add($"{player.IconPath}");

                        CombatText.NPCDefenseAccepted = true;
                        CombatText.NPCCombatDefenseData = null;
                        CombatText.NPCCombatDefenseData = combatData;

                        Sounds.SoundMaster.PlayDefenseEvent("Parry");
                        return;
                    }
                }
             

                Random getCritical = new Random();

                int incomingDamage = npc.AttackDamageCalculator() - player.Armor;

                if (incomingDamage < 0 || incomingDamage == 0)
                {
                    incomingDamage = 1;
                }

                CriticalNPC = false;

                if (getCritical.Next(0, 100) < npc.CriticalChance)
                {
                    incomingDamage *= 3;
                    CriticalNPC = true;
                }

                if (player.Shield > 0)
                {
                    player.Shield -= incomingDamage;

                    if (player.Shield < 0)
                    {
                        incomingDamage = player.Shield;
                    }
                }

                if (player.LastManStanding)
                {
                    incomingDamage = (incomingDamage * 130 / 100);
                }

                if (CriticalNPC == false)
                {
                    List<string> combatData = new List<string> { };

                    player.healthpoints -= incomingDamage;

                    if (player.healthpoints < 0)
                    {
                        player.healthpoints = 0;
                    }

                    combatData.Add($"{npc.name} deals {incomingDamage} damage to {player.name}");
                    combatData.Add("images\\combatText\\attack.jpg");
                    combatData.Add($"{npc.NPCIconPath}");

                    CombatText.NPCAccepted = true;
                    CombatText.CombatDataNPC = null;
                    CombatText.CombatDataNPC = combatData;
                    Sounds.SoundMaster.PlayCombatEvent("CleanAttack");
                    return;

                }

                if (CriticalNPC == true)
                {

                    List<string> combatData = new List<string> { };

                    player.healthpoints -= incomingDamage;

                    combatData.Add($"{npc.name} deals {incomingDamage} critical damage to {player.name}!");
                    combatData.Add("images\\combatText\\crit.jpg");
                    combatData.Add($"{npc.NPCIconPath}");

                    CombatText.NPCAccepted = true;
                    CombatText.CombatDataNPC = null;
                    CombatText.CombatDataNPC = combatData;
                    Sounds.SoundMaster.PlayCombatEvent("CleanAttackSwordCritical");
                    Sounds.SoundMaster.PlayVoiceEncounter(npc);

                    return;
                }
            }
        }

        public static void Player()
        {
            
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (player.healthpoints < 0 || player.healthpoints == 0)
            {
                PlayerAttackTimer.Stop();
                NPCAttackTimer.Stop();
                return;
            }

            if (npc.healthpoints < 0)
            {
                PlayerAttackTimer.Stop();
                NPCAttackTimer.Stop();
                npc.healthpoints = 0;
                return;
            }
            if (!npc.CrushLegs)
            {
                if (npc.Dodge())
                {
                    List<string> combatData = new List<string> { };

                    combatData.Add($"{npc.name} dodged attack.");
                    combatData.Add("images\\combatText\\dodge.jpg");

                    combatData.Add($"{npc.NPCIconPath}");

                    CombatText.DefenseAccepted = true;
                    CombatText.CombatDefenseData = null;
                    CombatText.CombatDefenseData = combatData;

                    Sounds.SoundMaster.PlayDefenseEvent("Dodge");
                    return;
                }

                if (npc.Block())
                {
                    List<string> combatData = new List<string> { };

                    combatData.Add($"{npc.name} blocked attack.");
                    combatData.Add("images\\combatText\\block.jpg");

                    combatData.Add($"{npc.NPCIconPath}");

                    CombatText.DefenseAccepted = true;
                    CombatText.CombatDefenseData = null;
                    CombatText.CombatDefenseData = combatData;

                    Sounds.SoundMaster.PlayDefenseEvent("Block");
                    return;
                }

                if (npc.Parry())
                {
                    List<string> combatData = new List<string> { };

                    combatData.Add($"{npc.name} parried attack.");
                    combatData.Add("images\\combatText\\parry.jpg");

                    combatData.Add($"{npc.NPCIconPath}");

                    CombatText.DefenseAccepted = true;
                    CombatText.CombatDefenseData = null;
                    CombatText.CombatDefenseData = combatData;

                    Sounds.SoundMaster.PlayDefenseEvent("Parry");
                    return;
                }
            }
           

            Random getCritical = new Random();

            int incomingDamage = player.AttackDamageCalculator() - npc.Armor;

            if (incomingDamage < 0 || incomingDamage == 0)
            {
                incomingDamage = 1;
            }

            CriticalPlayer = false;

            if (getCritical.Next(0, 100) < player.CriticalChance)
            {
                incomingDamage *= 3;
                CriticalPlayer = true;
            }

            if (npc.Shield > 0)
            {
                npc.Shield -= incomingDamage;

                if (npc.Shield < 0)
                {
                    incomingDamage = player.Shield;
                }
            }



            if (CriticalPlayer == false)
            {
                List<string> combatData = new List<string> { };

                npc.healthpoints -= incomingDamage;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

                combatData.Add($"{player.name} deals {incomingDamage} damage to {npc.name}");
                combatData.Add("images\\combatText\\attack.jpg");
                combatData.Add($"{player.IconPath}");

                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                Sounds.SoundMaster.PlayCombatEvent("CleanAttack");

                return;

             }

            if (CriticalPlayer == true)
            {

                List<string> combatData = new List<string> { };

                npc.healthpoints -= incomingDamage;

                combatData.Add($"{player.name} deals {incomingDamage} critical damage to {npc.name}!");
                combatData.Add("images\\combatText\\crit.jpg");
                combatData.Add($"{player.IconPath}");

                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                Sounds.SoundMaster.PlayCombatEvent("CleanAttackSwordCritical");
                Sounds.SoundMaster.PlayVoiceEncounter(player);

                return;
            }

        }

        public static void StopTimers()
        {
            if (PlayerAttackTimer != null)
            {
                PlayerAttackTimer.Stop();
            }

            if (NPCAttackTimer != null)
            {
                NPCAttackTimer.Stop();
            }
            
        }
    }
}
