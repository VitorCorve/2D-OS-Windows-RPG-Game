using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class WarriorSkills
    {
        public static int PowerHitSkillLevel = 1;
        public static int PowerHitCooldown = 0;
        public static bool PowerHitReady = true;
        public static Timer PowerHitTimer;
        public static int PowerHitCost = 10;
        public static string PowerHitImagePath = "images\\skills\\warrior\\relButton\\1.jpg";

        public static int WideBlowLevel = 1;
        public static int WideBlowCoolDown = 0;
        public static int WideBlowAffectDuration = 0;
        public static bool WideBlowReady = true;
        public static Timer WideBlowCoolDownTimer;
        public static Timer WideBlowAffectDurationTimer;
        public static int WideBlowCost = 7;
        public static bool WideBlowInflicted;
        public static string WideBlowImagePath = "images\\skills\\warrior\\relButton\\3.jpg";

        public static int CrushLegsLevel = 1;
        public static int CrushLegsCoolDown = 0;
        public static int CrushLegsAffectDuration = 0;
        public static bool CrushLegsReady = true;
        public static Timer CrushLegsCoolDownTimer;
        public static Timer CrushLegsAffectDurationTimer;
        public static int CrushLegsCost = 12;
        public static bool CrushLegsInflicted;
        public static double DefaultCriticalChance;
        public static string CrushLegsImagePath = "images\\skills\\warrior\\relButton\\4.jpg";

        public static int DeepDefenseLevel = 1;
        public static int DeepDefenseCoolDown = 0;
        public static int DeepDefenseDuration = 0;
        public static bool DeepDefenseReady = true;
        public static bool DeepDefenseAffected = false;
        public static Timer DeepDefenseCoolDownTimer;
        public static Timer DeepDefenseDurationTimer;
        private static int DefaultAttackPower = 0;
        private static double DefaultBlockChance = 0;
        public static int DeepDefenseCost = 12;
        public static string DeepDefenseImagePath = "images\\skills\\warrior\\relButton\\2.jpg";

        public static int LastManStandingLevel = 1;
        public static int LastManStandingCoolDown = 0;
        public static int LastManStandingDuration = 0;
        public static bool LastManStandingReady = true;
        public static bool LastManStandingAffected = false;
        public static Timer LastManStandingCoolDownTimer;
        public static Timer LastManStandingDurationTimer;
        public static int LastManStandingCost = 12;
        public static string LastManStandingImagePath = "images\\skills\\warrior\\relButton\\5.jpg";

        public static void PowerHit(Player player, NPC npc)

        {

            if (player.energy < PowerHitCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught energy");
                combatData.Add("images\\combatText\\noEnergy.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }


            if (PowerHitReady)
            {
                Random damageScatter = new Random();
                player.energy -= PowerHitCost;
                int damage = Convert.ToInt32((player.strength + player.attackPower * damageScatter.Next(5, 8) / 10)*2);

                PowerHitCooldown = 2;
                Timer PowerHit = new Timer(1000);
                PowerHit.Elapsed += PowerHit_Elapsed;
                PowerHit.Start();
                PowerHitTimer = PowerHit;
                PowerHitReady = false;

                if (!npc.CrushLegs)
                {
                    if (npc.Dodge())
                    {
                        List<string> dodge = new List<string> { };
                        dodge.Add($"{npc.name} dodged attack.");
                        dodge.Add("images\\combatText\\dodge.jpg");
                        dodge.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = dodge;

                        Sounds.SoundMaster.PlayDefenseEvent("Dodge");
                        return;
                    }

                    if (npc.Block())
                    {
                        List<string> block = new List<string> { };
                        block.Add($"{npc.name} blocked attack.");
                        block.Add("images\\combatText\\block.jpg");
                        block.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = block;

                        Sounds.SoundMaster.PlayDefenseEvent("Block");
                        return;
                    }

                    if (npc.Parry())
                    {
                        List<string> parry = new List<string> { };
                        parry.Add($"{npc.name} parried attack.");
                        parry.Add("images\\combatText\\parry.jpg");
                        parry.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = parry;

                        Sounds.SoundMaster.PlayDefenseEvent("Parry");
                        return;
                    }
                }

                

                npc.healthpoints -= damage;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"Power Hit deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\warrior\\relButton\\1.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }


            if (!PowerHitReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Power Hit ability is not ready yet. Cooldown: 0.{PowerHitCooldown} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\1.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void PowerHit_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (PowerHitCooldown == 0)
            {
                PowerHitReady = true;
                PowerHitTimer.Stop();
            }

            else
            {
                PowerHitCooldown -= 1;
            }

        }

        public static void WideBlow(Player player, NPC npc)
        {

            if (player.energy < WideBlowCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught energy");
                combatData.Add("images\\combatText\\noEnergy.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (WideBlowReady)
            {
                Random damageScatter = new Random();
                player.energy -= WideBlowCost;
                int damage = Convert.ToInt32(player.strength + player.attackPower * damageScatter.Next(5, 8) / 10);

                if (player.level <= 3)
                {
                    damage = Convert.ToInt32(3 * damageScatter.Next(8, 13) / 10);
                    npc.healthpoints -= damage;
                }

                WideBlowAffectDuration = 8;
                WideBlowCoolDown = 12;

                player.energy -= WideBlowCost;

                Timer WideBlowCooldown = new Timer(1000);
                WideBlowCooldown.Elapsed += WideBlowCooldown_Elapsed;

                WideBlowCooldown.Start();

                WideBlowCoolDownTimer = WideBlowCooldown;

                if (!npc.CrushLegs)
                {
                    if (npc.Dodge())
                    {
                        List<string> dodge = new List<string> { };
                        dodge.Add($"{npc.name} dodged attack.");
                        dodge.Add("images\\combatText\\dodge.jpg");
                        dodge.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = dodge;

                        Sounds.SoundMaster.PlayDefenseEvent("Dodge");
                        return;
                    }

                    if (npc.Block())
                    {
                        List<string> block = new List<string> { };
                        block.Add($"{npc.name} blocked attack.");
                        block.Add("images\\combatText\\block.jpg");
                        block.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = block;

                        Sounds.SoundMaster.PlayDefenseEvent("Block");
                        return;
                    }

                    if (npc.Parry())
                    {
                        List<string> parry = new List<string> { };
                        parry.Add($"{npc.name} parried attack.");
                        parry.Add("images\\combatText\\parry.jpg");
                        parry.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = parry;

                        Sounds.SoundMaster.PlayDefenseEvent("Parry");
                        return;
                    }
                }
              

                Timer WideBlow = new Timer(1000);
                WideBlow.Elapsed += WideBlow_Elapsed;
                WideBlow.Start();
                WideBlowReady = false;

                WideBlowAffectDurationTimer = WideBlow;

                WideBlowInflicted = true;

                npc.WideBlow = true;

                npc.healthpoints -= damage;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"Wide Blow deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!WideBlowReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Wide Blow is not ready yet. Cooldown: {WideBlowCoolDown} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

        }

        private static void WideBlowCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (WideBlowCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                WideBlowCoolDownTimer.Stop();
                WideBlowReady = true;
            }

            else
            {
                WideBlowCoolDown -= 1;
            }
        }

        private static void WideBlow_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (WideBlowAffectDuration == 0 || !npc.Alive() || !player.Alive())
            {
                npc.WideBlow = false;
                WideBlowAffectDurationTimer.Stop();
                WideBlowInflicted = false;

            }
            else
            {
                WideBlowAffectDuration -= 1;
            }
        }
        public static void CrushLegs(Player player, NPC npc)
        {

            if (player.energy < CrushLegsCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught energy");
                combatData.Add("images\\combatText\\noEnergy.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (CrushLegsReady)
            {
                Random damageScatter = new Random();
                player.energy -= CrushLegsCost;

                CrushLegsAffectDuration = 6;
                CrushLegsCoolDown = 30;

                player.energy -= CrushLegsCost;

                Timer CrushLegsCooldown = new Timer(1000);
                CrushLegsCooldown.Elapsed += CrushLegsCooldown_Elapsed;

                CrushLegsCooldown.Start();

                CrushLegsCoolDownTimer = CrushLegsCooldown;

                if (!npc.CrushLegs)
                {
                    if (npc.Dodge())
                    {
                        List<string> dodge = new List<string> { };
                        dodge.Add($"{npc.name} dodged attack.");
                        dodge.Add("images\\combatText\\dodge.jpg");
                        dodge.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = dodge;

                        Sounds.SoundMaster.PlayDefenseEvent("Dodge");
                        return;
                    }

                    if (npc.Block())
                    {
                        List<string> block = new List<string> { };
                        block.Add($"{npc.name} blocked attack.");
                        block.Add("images\\combatText\\block.jpg");
                        block.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = block;

                        Sounds.SoundMaster.PlayDefenseEvent("Block");
                        return;
                    }

                    if (npc.Parry())
                    {
                        List<string> parry = new List<string> { };
                        parry.Add($"{npc.name} parried attack.");
                        parry.Add("images\\combatText\\parry.jpg");
                        parry.Add($"{npc.NPCIconPath}");
                        CombatText.Accepted = true;
                        CombatText.CombatData = null;
                        CombatText.CombatData = parry;

                        Sounds.SoundMaster.PlayDefenseEvent("Parry");
                        return;
                    }
                }


                Timer CrushLegs = new Timer(1000);
                CrushLegs.Elapsed += CrushLegs_Elapsed;
                CrushLegs.Start();
                CrushLegsReady = false;

                CrushLegsAffectDurationTimer = CrushLegs;

                CrushLegsInflicted = true;

                npc.CrushLegs = true;

                DefaultCriticalChance = player.CriticalChance;

                player.CriticalChance = 100;

                List<string> combatData = new List<string> { };
                combatData.Add($"Crush Legs affected to {npc.name}");
                combatData.Add("images\\skills\\warrior\\relButton\\4.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!CrushLegsReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Crush Legs ability is not ready yet. Cooldown: {CrushLegsCoolDown} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\4.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

        }

        private static void CrushLegsCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (CrushLegsCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                CrushLegsCoolDownTimer.Stop();
                CrushLegsReady = true;
            }

            else
            {
                CrushLegsCoolDown -= 1;
            }
        }

        private static void CrushLegs_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (CrushLegsAffectDuration == 0 || !npc.Alive() || !player.Alive())
            {
                npc.CrushLegs = false;
                CrushLegsAffectDurationTimer.Stop();
                CrushLegsInflicted = false;

                player.CriticalChance = DefaultCriticalChance;

            }
            else
            {
                CrushLegsAffectDuration -= 1;
            }
        }

        public static void DeepDefense(Player player, NPC npc)
        {
            if (player.LastManStanding)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Unable to use with Last Man Standing");
                combatData.Add("images\\skills\\warrior\\relButton\\5.jpg");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (player.energy < DeepDefenseCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught energy");
                combatData.Add("images\\combatText\\noEnergy.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (DeepDefenseReady)
            {
                DeepDefenseDuration = 6;
                DeepDefenseCoolDown = 10;

                player.energy -= DeepDefenseCost;
                DefaultBlockChance = player.BlockChance;
                DefaultAttackPower = player.attackPower;
                player.attackPower /= 2;
                player.BlockChance = 90;

                Timer DeepDefense = new Timer(1000);
                DeepDefense.Elapsed += DeepDefense_Elapsed;
                DeepDefense.Start();
                DeepDefenseReady = false;

                DeepDefenseDurationTimer = DeepDefense;

                Timer DeepDefenseCooldown = new Timer(1000);
                DeepDefenseCooldown.Elapsed += DeepDefenseCooldown_Elapsed;

                DeepDefenseCooldown.Start();

                DeepDefenseCoolDownTimer = DeepDefenseCooldown;

                DeepDefenseAffected = true;

                player.DeepDefense = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} fell into Deep Defense for {DeepDefenseDuration} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!DeepDefenseReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Deep Defense is not ready yet. Cooldown: {DeepDefenseCoolDown} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void DeepDefenseCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (DeepDefenseCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                DeepDefenseCoolDownTimer.Stop();
                DeepDefenseReady = true;
            }

            else
            {
                DeepDefenseCoolDown -= 1;
            }
        }

        private static void DeepDefense_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (DeepDefenseDuration == 0 || !npc.Alive() || !player.Alive())
            {
                DeepDefenseDurationTimer.Stop();
                player.attackPower = DefaultAttackPower;
                player.BlockChance = DefaultBlockChance;
                DefaultAttackPower = 0;
                DeepDefenseAffected = false;
                player.DeepDefense = false;
            }
            else
            {
                DeepDefenseDuration -= 1;
            }
        }


        public static void LastManStanding(Player player, NPC npc)
        {
            if (player.DeepDefense)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Unable to use with Deep Defense");
                combatData.Add("images\\skills\\warrior\\relButton\\2.jpg");
                combatData.Add("images\\skills\\warrior\\relButton\\5.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (player.energy < LastManStandingCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught energy");
                combatData.Add("images\\combatText\\noEnergy.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (LastManStandingReady)
            {
                LastManStandingDuration = 8;
                LastManStandingCoolDown = 14;

                player.energy -= LastManStandingCost;
                DefaultAttackPower = player.attackPower;
                player.attackPower = (player.attackPower * 120 / 100);

                Timer LastManStanding = new Timer(1000);
                LastManStanding.Elapsed += LastManStanding_Elapsed;
                LastManStanding.Start();
                LastManStandingReady = false;

                LastManStandingDurationTimer = LastManStanding;

                Timer LastManStandingCooldown = new Timer(1000);
                LastManStandingCooldown.Elapsed += LastManStandingCooldown_Elapsed;

                LastManStandingCooldown.Start();

                LastManStandingCoolDownTimer = LastManStandingCooldown;

                LastManStandingAffected = true;
                player.LastManStanding = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} fell into Last Man Standing for {LastManStandingDuration} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\5.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!DeepDefenseReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Last Man Standing is not ready yet. Cooldown: {DeepDefenseCoolDown} sec.");
                combatData.Add("images\\skills\\warrior\\relButton\\5.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }
        private static void LastManStandingCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (LastManStandingCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                LastManStandingCoolDownTimer.Stop();
                LastManStandingReady = true;
            }

            else
            {
                LastManStandingCoolDown -= 1;
            }
        }

        private static void LastManStanding_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (LastManStandingDuration == 0 || !npc.Alive() || !player.Alive())
            {
                LastManStandingDurationTimer.Stop();
                player.attackPower = DefaultAttackPower;
                DefaultAttackPower = 0;
                LastManStandingAffected = false;
                player.LastManStanding = false;
            }
            else
            {
                LastManStandingDuration -= 1;
            }
        }
    }
}
