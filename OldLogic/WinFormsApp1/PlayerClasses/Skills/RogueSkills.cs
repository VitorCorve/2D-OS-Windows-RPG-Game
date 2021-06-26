using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class RogueSkills
    {
        public static int BackStabSkillLevel = 1;
        public static int BackStabCooldown = 0;
        public static bool BackStabReady = true;
        public static Timer BackStabTimer;
        public static int BackStabCost = 10;
        public static string BackStabImagePath = "images\\skills\\rogue\\relButton\\1.jpg";

        public static int RendLevel = 1;
        public static int RendTacts;
        public static int RendCoolDown = 0;
        public static int RendDamageDuration = 0;
        public static bool RendReady = true;
        public static Timer RendCoolDownTimer;
        public static Timer RendDurationTimer;
        public static int RendCost = 15;
        public static string RendDamage;
        public static bool RendDamageTextAccepted;
        public static bool RendInflicted;
        public static string RendImagePath = "images\\skills\\rogue\\relButton\\2.jpg";

        public static int StunLevel = 1;
        public static int StunCoolDown = 0;
        public static int StunAffectDuration = 0;
        public static bool StunReady = true;
        public static Timer StunCoolDownTimer;
        public static Timer StunAffectDurationTimer;
        public static int StunCost = 7;
        public static bool StunInflicted;
        public static string StunImagePath = "images\\skills\\rogue\\relButton\\3.jpg";

        public static int DissapearLevel = 1;
        public static int DissapearCoolDown = 0;
        public static int DissapearDuration = 0;
        public static bool DissapearReady = true;
        public static bool DissapearAffected = false;
        public static Timer DissapearCoolDownTimer;
        public static Timer DissapearDurationTimer;
        private static double DefaultDodgeChance = 0;
        public static int DissapearCost = 12;
        public static string DissapearImagePath = "images\\skills\\rogue\\relButton\\4.jpg";

        public static int FindTheWeaknessLevel = 1;
        public static int FindTheWeaknessCoolDown = 0;
        public static int FindTheWeaknessDuration = 0;
        public static bool FindTheWeaknessReady = true;
        public static bool FindTheWeaknessAffected = false;
        public static Timer FindTheWeaknessCoolDownTimer;
        public static Timer FindTheWeaknessDurationTimer;
        public static int FindTheWeaknessCost = 20;
        public static string FindTheWeaknessImagePath = "images\\skills\\rogue\\relButton\\5.jpg";


        public static string Warnings;
        public static bool WarningAccepted;

        public static void BackStab(Player player, NPC npc)

        {

            if (player.energy < BackStabCost)
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


            if (BackStabReady)
            {
                Random damageScatter = new Random();
                player.energy -= BackStabCost;
                int damage = Convert.ToInt32(player.agility + player.attackPower * damageScatter.Next(5, 8)/10);

                if (npc.FindTheWeakness)
                {
                    damage *= 3;
                }

                BackStabCooldown = 2;
                Timer BackStab = new Timer(1000);
                BackStab.Elapsed += BackStab_Elapsed;
                BackStab.Start();
                BackStabTimer = BackStab;
                BackStabReady = false;

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
                

                npc.healthpoints -= damage;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"Backstab deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\rogue\\relButton\\1.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }


            if (!BackStabReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Backstab ability is not ready yet. Cooldown: 0.{BackStabCooldown} sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\1.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void BackStab_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (BackStabCooldown == 0)
            {
                BackStabReady = true;
                BackStabTimer.Stop();
            }

            else
            {
                BackStabCooldown -= 1;
            }

        }

        public static void Rend(Player player, NPC npc)
        {

            if (player.energy < RendCost)
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

            if (RendReady)
            {
                RendDamageDuration = 6;
                RendCoolDown = 9;
                
                player.energy -= RendCost;



                

                Timer rendCooldown = new Timer(1000);
                rendCooldown.Elapsed += RendCooldown_Elapsed;

                rendCooldown.Start();

                RendCoolDownTimer = rendCooldown;

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

                Timer rend = new Timer(1000);
                rend.Elapsed += Rend_Elapsed;
                rend.Start();
                RendReady = false;

                RendDurationTimer = rend;

                RendInflicted = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} crippled {npc.name} for 6 sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\2.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!RendReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Rend is not ready yet. Cooldown: {RendCoolDown} sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\2.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void RendCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (RendCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                RendCoolDownTimer.Stop();
                RendReady = true;
            }

            else
            {
                RendCoolDown -= 1;
            }
        }

        private static void Rend_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (RendDamageDuration == 0 || !npc.Alive() || !player.Alive())
            {
                RendDurationTimer.Stop();
                RendInflicted = false;
            }

            RendTacts += 1;

            RendDamageDuration -= 1;

            if (RendTacts < 3)
            {
                return;
            }

            if (!npc.Alive())
            {
                npc.healthpoints = 0;
            }

            if (!player.Alive())
            {
                player.healthpoints = 0;
            }


            else
            {
                RendTacts = 0;
                Random damageScatter = new Random();
                int damage = Convert.ToInt32(damageScatter.Next(player.agility/2, player.agility/1) + (player.attackPower * 10 / 2));

                List<string> combatData = new List<string> { };
                combatData.Add($"Rend deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\rogue\\relButton\\2.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                npc.healthpoints -= damage;
            }
        }

        public static void Stun(Player player, NPC npc)
        {

            if (player.energy < StunCost)
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

            if (StunReady)
            {
                StunAffectDuration = 4;
                StunCoolDown = 12;

                player.energy -= StunCost;

                Timer stunCooldown = new Timer(1000);
                stunCooldown.Elapsed += StunCooldown_Elapsed;

                stunCooldown.Start();

                StunCoolDownTimer = stunCooldown;

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

                Timer stun = new Timer(1000);
                stun.Elapsed += Stun_Elapsed;
                stun.Start();
                StunReady = false;

                StunAffectDurationTimer = stun;

                StunInflicted = true;

                npc.OutOfControl = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} stuned {npc.name} for 4 sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\3.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!StunReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Stun is not ready yet. Cooldown: {StunCoolDown} sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\3.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

        }

        private static void StunCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (StunCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                StunCoolDownTimer.Stop();
                StunReady = true;
            }

            else
            {
                StunCoolDown -= 1;
            }
        }

        private static void Stun_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (StunAffectDuration == 0 || !npc.Alive() || !player.Alive())
            {
                npc.OutOfControl = false;
                StunAffectDurationTimer.Stop();
                StunInflicted = false;

            }
            else
            {
                StunAffectDuration -= 1;
            }
        }

        public static void Dissapear(Player player, NPC npc)
        {

            if (player.energy < DissapearCost)
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

            if (DissapearReady)
            {
                DissapearDuration = 10;
                DissapearCoolDown = 30;

                player.energy -= DissapearCost;
                DefaultDodgeChance = player.DodgeChance;

                player.DodgeChance = 100;

                Timer dissapear = new Timer(1000);
                dissapear.Elapsed += Dissapear_Elapsed;
                dissapear.Start();
                DissapearReady = false;

                DissapearDurationTimer = dissapear;

                Timer dissapearCooldown = new Timer(1000);
                dissapearCooldown.Elapsed += DissapearCooldown_Elapsed;

                dissapearCooldown.Start();

                DissapearCoolDownTimer = dissapearCooldown;

                DissapearAffected = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} dissapeared {npc.name} for {DissapearDuration} sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\4.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!DissapearReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Dissaper into the Shadows is not ready yet. Cooldown: {DissapearCoolDown} sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\4.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void DissapearCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc= (NPC)Data.GetNPC();

            if (DissapearCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                DissapearCoolDownTimer.Stop();
                DissapearReady = true;
            }

            else
            {
                DissapearCoolDown -= 1;
            }
        }

        private static void Dissapear_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (DissapearDuration == 0 || !npc.Alive() || !player.Alive())
            {
                DissapearDurationTimer.Stop();
                player.DodgeChance = DefaultDodgeChance;
                DefaultDodgeChance = 0;
                DissapearAffected = false;
            }
            else
            {
                DissapearDuration -= 1;
            }
        }

        public static void FindTheWeakness(Player player, NPC npc)
        {
            if (player.mana < FindTheWeaknessCost)
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


            if (FindTheWeaknessReady)
            {
                FindTheWeaknessDuration = 12;
                FindTheWeaknessCoolDown = 60;

                player.mana -= FindTheWeaknessCost;

                Timer findTheWeaknessCooldown = new Timer(1000);
                findTheWeaknessCooldown.Elapsed += FindTheWeaknessCooldown_Elapsed;

                findTheWeaknessCooldown.Start();

                FindTheWeaknessCoolDownTimer = findTheWeaknessCooldown;

                FindTheWeaknessReady = false;

                if (npc.Resist())
                {
                    List<string> resist = new List<string> { };
                    resist.Add($"{npc.name} resisted attack.");
                    resist.Add("images\\combatText\\resist.jpg");
                    resist.Add($"{npc.NPCIconPath}");
                    CombatText.Accepted = true;
                    CombatText.CombatData = null;
                    CombatText.CombatData = resist;
                    return;
                }

                npc.FindTheWeakness = true;

                Timer findTheWeakness = new Timer(1000);
                findTheWeakness.Elapsed += FindTheWeakness_Elapsed;
                findTheWeakness.Start();

                FindTheWeaknessDurationTimer = findTheWeakness;

                FindTheWeaknessAffected = true;

                Random devastation = new Random();

                if (devastation.Next(1, 100) < 10)
                {
                    npc.healthpoints -= (npc.healthpoints / 100 * 90);

                    List<string> dodge = new List<string> { };
                    dodge.Add($"Devastation!");
                    dodge.Add("images\\combatText\\devastation.jpg");
                    dodge.Add($"{npc.NPCIconPath}");
                    CombatText.Accepted = true;
                    CombatText.CombatData = null;
                    CombatText.CombatData = dodge;
                    return;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} succesfuly marked {npc.name} by Find The Weakness ability.");
                combatData.Add("images\\skills\\rogue\\relButton\\5.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!FindTheWeaknessReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Find The Weakness  is not ready yet. Cooldown: {FindTheWeaknessCoolDown} 12 sec.");
                combatData.Add("images\\skills\\rogue\\relButton\\5.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void FindTheWeakness_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (FindTheWeaknessDuration == 0 || !npc.Alive() || !player.Alive())
            {
                FindTheWeaknessDurationTimer.Stop();
                FindTheWeaknessAffected = false;
                npc.FindTheWeakness = false;
            }
            else
            {
                FindTheWeaknessDuration -= 1;
            }
        }

        private static void FindTheWeaknessCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (FindTheWeaknessCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                FindTheWeaknessCoolDownTimer.Stop();
                FindTheWeaknessReady = true;

            }

            else
            {
                FindTheWeaknessCoolDown -= 1;
            }
        }
    }
}
