using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinFormsApp1.PlayerClasses.Skills
{
    public static class MageSkills
    {
        public static int FireballSkillLevel = 1;
        public static int FireballCooldown = 0;
        public static bool FireballReady = true;
        public static Timer FireballCoolDownTimer;
        public static int FireballCost = 10;
        public static string FireballImagePath = "images\\skills\\mage\\relButton\\1.jpg";

        public static int MagicShieldLevel = 1;
        public static int MagicShieldCoolDown = 0;
        public static int MagicShieldDuration = 0;
        public static bool MagicShieldReady = true;
        public static bool MagicShieldAffected = false;
        public static Timer MagicShieldCoolDownTimer;
        public static Timer MagicShieldDurationTimer;
        public static int MagicShieldCost = 20;
        public static string MagicShieldImagePath = "images\\skills\\mage\\relButton\\2.jpg";

        public static int PolymorphLevel = 1;
        public static int PolymorphCoolDown = 0;
        public static int PolymorphAffectDuration = 0;
        public static bool PolymorphReady = true;
        public static string NPCDefaultIconPath;
        public static string NPCDefaultAvatarPath;
        public static int PolymorphCreatureChoise;
        public static Timer PolymorphCoolDownTimer;
        public static Timer PolymorphAffectDurationTimer;
        public static int PolymorphCost = 12;
        public static bool PolymorphInflicted;
        public static string PolymorphImagePath = "images\\skills\\mage\\relButton\\3.jpg";

        public static int SoulBurnLevel = 1;
        public static int SoulBurnTacts;
        public static int SoulBurnCoolDown = 0;
        public static int SoulBurnDamageDuration = 0;
        public static bool SoulBurnReady = true;
        public static Timer SoulBurnCoolDownTimer;
        public static Timer SoulBurnDurationTimer;
        public static int SoulBurnCost = 20;
        public static string SoulBurnDamage;
        public static bool SoulBurnDamageTextAccepted;
        public static bool SoulBurnInflicted;
        public static string SoulBurnImagePath = "images\\skills\\mage\\relButton\\4.jpg";

        public static int HealSkillLevel = 1;
        public static int HealCooldown = 0;
        public static bool HealReady = true;
        public static Timer HealCoolDownTimer;
        public static int HealCost = 15;
        public static string HealImagePath = "images\\skills\\mage\\relButton\\5.jpg";


        public static void Fireball(Player player, NPC npc)
        {
            if (player.energy < FireballCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught mana");
                combatData.Add("images\\combatText\\noMana.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (FireballReady)
            {
                Random damageScatter = new Random();
                player.mana -= FireballCost;
                int damage = Convert.ToInt32(player.intellect + player.attackPower * damageScatter.Next(5, 8) / 10);

                if (player.level <= 3)
                {
                    damage = Convert.ToInt32(3 * damageScatter.Next(8, 13) / 10);
                    npc.healthpoints -= damage;
                }

                FireballCooldown = 3;
                Timer Fireball = new Timer(1000);
                Fireball.Elapsed += Fireball_Elapsed;
                Fireball.Start();
                FireballCoolDownTimer = Fireball;
                FireballReady = false;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

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

                npc.healthpoints -= damage;

                List<string> combatData = new List<string> { };
                combatData.Add($"Fireball deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\mage\\relButton\\1.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!FireballReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Fireball spell is not ready yet. Cooldown: {FireballCooldown} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\1.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void Fireball_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (FireballCooldown == 0)
            {
                FireballReady = true;
                FireballCoolDownTimer.Stop();
            }

            else
            {
                FireballCooldown -= 1;
            }
        }

        public static void MagicShield(Player player, NPC npc)
        {

            if (player.mana < MagicShieldCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught mana");
                combatData.Add("images\\combatText\\noMana.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (MagicShieldReady)
            {
                MagicShieldDuration = 6;
                MagicShieldCoolDown = 10;

                player.mana -= MagicShieldCost;
                

                player.Shield = 30;

                Timer Shield = new Timer(1000);
                Shield.Elapsed += Shield_Elapsed;
                Shield.Start();
                MagicShieldReady = false;

                MagicShieldDurationTimer = Shield;

                Timer magicShieldCooldown = new Timer(1000);
                magicShieldCooldown.Elapsed += MagicShieldCooldown_Elapsed;

                magicShieldCooldown.Start();

                MagicShieldCoolDownTimer = magicShieldCooldown;

                MagicShieldAffected = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} conjured Magic Shield for {MagicShieldDuration} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\2.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!MagicShieldReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Magic Shield is not ready yet. Cooldown: {MagicShieldCoolDown} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\2.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void MagicShieldCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (MagicShieldCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                MagicShieldCoolDownTimer.Stop();
                MagicShieldReady = true;
            }

            else
            {
                MagicShieldCoolDown -= 1;
            }
        }

        private static void Shield_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (player.Shield <= 0)
            {
                MagicShieldDurationTimer.Stop();
                player.Shield = 0;
                MagicShieldAffected = false;

                List<string> combatData = new List<string> { };
                combatData.Add("Magic Shield was crushed!");
                combatData.Add("images\\skills\\mage\\relButton\\2.jpg");
                combatData.Add($"{npc.NPCIconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
            }

            if (MagicShieldDuration == 0 || !npc.Alive() || !player.Alive())
            {
                MagicShieldDurationTimer.Stop();
                player.Shield = 0;
                MagicShieldAffected = false;
            }
            else
            {
                MagicShieldDuration -= 1;
            }
        }

        public static void Polymorph(Player player, NPC npc)
        {
            if (player.mana < PolymorphCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught mana");
                combatData.Add("images\\combatText\\noMana.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (PolymorphReady)
            {
                PolymorphAffectDuration = 6;
                PolymorphCoolDown = 30;

                player.mana -= PolymorphCost;

                Timer PolymorphCooldown = new Timer(1000);
                PolymorphCooldown.Elapsed += PolymorphCooldown_Elapsed;

                PolymorphCooldown.Start();

                PolymorphCoolDownTimer = PolymorphCooldown;

                NPCDefaultAvatarPath = npc.NPCAvatarPath;
                NPCDefaultIconPath = npc.NPCIconPath;

                PolymorphReady = false;

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
                Timer Polymorph = new Timer(1000);
                Polymorph.Elapsed += Polymorph_Elapsed;
                Polymorph.Start();
                

                PolymorphAffectDurationTimer = Polymorph;

                Random chooseCreature = new Random();

                PolymorphCreatureChoise = chooseCreature.Next(1, 4);

                npc.NPCAvatarPath = $"images\\npcs\\enemies\\polymorph\\{PolymorphCreatureChoise}.jpg";
                npc.NPCIconPath = $"images\\npcs\\enemies\\polymorph\\{PolymorphCreatureChoise}.png";
                npc.OutOfControl = true;
                PolymorphInflicted = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} Polymorphed {npc.name} for {PolymorphAffectDuration} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\3.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!PolymorphReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Polymorph is not ready yet. Cooldown: {PolymorphCoolDown}sec.");
                combatData.Add("images\\skills\\mage\\relButton\\3.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

        }

        private static void PolymorphCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (PolymorphCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                PolymorphCoolDownTimer.Stop();
                PolymorphReady = true;
            }

            else
            {
                PolymorphCoolDown -= 1;
            }
        }

        private static void Polymorph_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (PolymorphAffectDuration == 0 || !npc.Alive() || !player.Alive())
            {
                npc.OutOfControl = false;
                PolymorphAffectDurationTimer.Stop();
                PolymorphInflicted = false;
                npc.NPCAvatarPath = NPCDefaultAvatarPath;
                npc.NPCIconPath = NPCDefaultIconPath;

                NPCDefaultAvatarPath = null;
                NPCDefaultIconPath = null;

            }
            else
            {
                PolymorphAffectDuration -= 1;
            }
        }

        public static void SoulBurn(Player player, NPC npc)
        {

            if (player.mana < SoulBurnCost)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught mana");
                combatData.Add("images\\combatText\\noMana.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (SoulBurnReady)
            {
                SoulBurnDamageDuration = 12;
                SoulBurnCoolDown = 30;

                player.mana -= SoulBurnCost;

                Timer SoulBurnCooldown = new Timer(1000);
                SoulBurnCooldown.Elapsed += SoulBurnCooldown_Elapsed;

                SoulBurnCooldown.Start();

                SoulBurnCoolDownTimer = SoulBurnCooldown;

                SoulBurnReady = false;

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

                Timer SoulBurn = new Timer(1000);
                SoulBurn.Elapsed += SoulBurn_Elapsed;
                SoulBurn.Start();

                SoulBurnDurationTimer = SoulBurn;

                SoulBurnInflicted = true;

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} cursed {npc.name} by Soul Burn for {SoulBurnDamageDuration} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\4.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!SoulBurnReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"SoulBurn is not ready yet. Cooldown: {SoulBurnCoolDown} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\4.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void SoulBurnCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (SoulBurnCoolDown == 0 || !npc.Alive() || !player.Alive())
            {
                SoulBurnCoolDownTimer.Stop();
                SoulBurnReady = true;
            }

            else
            {
                SoulBurnCoolDown -= 1;
            }
        }

        private static void SoulBurn_Elapsed(object sender, ElapsedEventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            Player player = (Player)Data.GetPlayer();

            if (SoulBurnDamageDuration == 0 || !npc.Alive() || !player.Alive())
            {
                SoulBurnDurationTimer.Stop();
                SoulBurnInflicted = false;
            }

            SoulBurnTacts += 1;
            SoulBurnDamageDuration -= 1;

            if (SoulBurnTacts < 4)
            {
                return;
            }

            SoulBurnTacts = 1;

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
                Random damageScatter = new Random();
                int damage = Convert.ToInt32(damageScatter.Next(player.intellect + player.level, player.intellect + (player.level*3)) + (player.attackPower * 10 / 4));
                npc.healthpoints -= damage;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"SoulBurn deals {damage} damage to {npc.name}");
                combatData.Add("images\\skills\\mage\\relButton\\4.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        public static void Heal(Player player, NPC npc)
        {
            if (player.mana < HealCooldown)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Not enught mana");
                combatData.Add("images\\combatText\\noMana.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (HealReady)
            {
                Random damageScatter = new Random();
                player.mana -= HealCost;

                HealCooldown = 12;
                Timer Heal = new Timer(1000);
                Heal.Elapsed += Heal_Elapsed;
                Heal.Start();
                HealCoolDownTimer = Heal;
                HealReady = false;

                if (npc.healthpoints < 0)
                {
                    npc.healthpoints = 0;
                }
                int healAmount = player.intellect + player.attackPower;
                if (player.healthpoints + healAmount > player.maxHP)
                {
                    player.healthpoints = player.maxHP;
                }

                if (player.healthpoints + healAmount <= player.maxHP)
                {
                    player.healthpoints += healAmount;
                }

                List<string> combatData = new List<string> { };
                combatData.Add($"{player.name} restored {healAmount} health by Healing");
                combatData.Add("images\\skills\\mage\\relButton\\5.jpg");
                combatData.Add($"{player.IconPath}");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }

            if (!HealReady)
            {
                List<string> combatData = new List<string> { };
                combatData.Add($"Heal spell is not ready yet. Cooldown: {HealCooldown} sec.");
                combatData.Add("images\\skills\\mage\\relButton\\5.jpg");
                combatData.Add("images\\combatText\\cooldown.jpg");
                CombatText.Accepted = true;
                CombatText.CombatData = null;
                CombatText.CombatData = combatData;
                return;
            }
        }

        private static void Heal_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (HealCooldown == 0)
            {
                HealReady = true;
                HealCoolDownTimer.Stop();
            }

            else
            {
                HealCooldown -= 1;
            }
        }
    }
}
