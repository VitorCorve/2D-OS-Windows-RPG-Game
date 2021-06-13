using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.CharCreation;
using WinFormsApp1.Interface;
using WinFormsApp1.Interface.BattleWindow;
using WinFormsApp1.NPCs.Mobs;
using WinFormsApp1.PlayerClasses;
using WinFormsApp1.PlayerClasses.Skills;
using System.Timers;
using WinFormsApp1.BattleWindowForms;
using WinFormsApp1.EquipmentData;
using WinFormsApp1.EquipmentData.Weapons;
using WinFormsApp1.CombatTextData;
using WinFormsApp1.EquipmentData.Items;

namespace WinFormsApp1
{
    public partial class BattleWindow : Form
    {
        public System.Timers.Timer CombatTextTimerNPC { get; set; }
        public System.Timers.Timer CombatTextTimerPlayer { get; set; }

        public BattleWindow()
        {
            InitializeComponent();
            Opacity = 0;

            System.Windows.Forms.Timer opacity = new System.Windows.Forms.Timer();
            opacity.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 5) opacity.Stop();
            });
            opacity.Interval = 5;
            opacity.Start();
            BackgroundImage = Image.FromFile(Backgrounds.GetURL());

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public void UpdateCombatText(string text, string eventImagePath, string actor)
        {
            combatText11.Text = combatText10.Text;
            combatText10.Text = combatText9.Text;
            combatText9.Text = combatText8.Text;
            combatText8.Text = combatText7.Text;
            combatText7.Text = combatText6.Text;
            combatText6.Text = combatText5.Text;
            combatText5.Text = combatText4.Text;
            combatText4.Text = combatText3.Text;
            combatText3.Text = combatText2.Text;
            combatText2.Text = combatText.Text;
            combatText.Text = text;

            event11.Image = event10.Image;
            event10.Image = event9.Image;
            event9.Image = event8.Image;
            event8.Image = event7.Image;
            event7.Image = event6.Image;
            event6.Image = event5.Image;
            event5.Image = event4.Image;
            event4.Image = event3.Image;
            event3.Image = event2.Image;
            event2.Image = event1.Image;
            event1.Image = Image.FromFile(eventImagePath);

            actor11.Image = actor10.Image;
            actor10.Image = actor9.Image;
            actor9.Image = actor8.Image;
            actor8.Image = actor7.Image;
            actor7.Image = actor6.Image;
            actor6.Image = actor5.Image;
            actor5.Image = actor4.Image;
            actor4.Image = actor3.Image;
            actor3.Image = actor2.Image;
            actor2.Image = actor1.Image;

            if (actor != null && actor.Length > 1)
            {
            actor1.Image = Image.FromFile(actor);
            }
            else
            {
              actor1.Image = Image.FromFile("images\\combatText\\gameOver.jpg");
            }
            



        }



        public void InitializePlayerAndNPCData(Player player, NPC npc)
        {

            playerHealthP.Text = Convert.ToString(player.GetHealthPoints());
            playerEnergy.Text = Convert.ToString(player.GetEnergy());
            playerMana.Text = Convert.ToString(player.GetMana());
            levelPlayerBar.Text = Convert.ToString(player.level);
            levelNPCBar.Text = Convert.ToString(npc.level);






            npcHP.Text = Convert.ToString(npc.GetHealthPoints());
            npcEnergy.Text = Convert.ToString(npc.GetEnergy());
            npcMP.Text = Convert.ToString(npc.GetMana());


            Data.SetPlayer(player);
            Data.SetNPC(npc);

            playerStatsRecovery.Start();
            npcStatsRecovery.Start();

            if (player.Alive())
            {
                Data.PlayerIsAlive = true;
            }

            if (npc.Alive())
            {
                Data.NPCIsAlive = true;
            }
            playerIcon.Image = Image.FromFile(player.IconPath);
            npcIcon.Image = Image.FromFile(npc.NPCIconPath);
            battleTitleLabel.Text = $"{player.name} vs { npc.name}";
        }

        public void InitializeCombatText()
        {
            combatText11.Text = "";
            combatText10.Text = "";
            combatText9.Text = "";
            combatText8.Text = "";
            combatText7.Text = "";
            combatText6.Text = "";
            combatText5.Text = "";
            combatText4.Text = "";
            combatText3.Text = "";
            combatText2.Text = "";
            combatText.Text = "";
        }

        private void InitializeAvatars()
        {
            Player player = (Player)Data.Player;
            NPC npc = (NPC)Data.NPC;

            playerIcon.Image = Image.FromFile(player.IconPath);
            npcIcon.Image = Image.FromFile(npc.NPCIconPath);
            /*            characterImage.Image = Image.FromFile(player.AvatarPath);
                        npcImage.Image = Image.FromFile("images\\npcs\\enemies\\skillet.jpg");*/

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Data.GetPlayer() != null)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)EnemyInitialization.Initialize();


                InitializePlayerAndNPCData(player, npc);
                UpdateStats();

                battleTitleLabel.Text = $"{player.name} vs { npc.name}";
            }
            else
            {
                Player player = new Player("Arthur Morgan", "Male");
                Data.SetPlayer(player);
                NPC npc = (NPC)EnemyInitialization.Initialize();
                InitializePlayerAndNPCData(player, npc);
                UpdateStats();
            }
            InitializeCombatText();
            InitializeAvatars();
            InitializeIndicators();
            InitializeSkills();
            InitializeMeta();

            Sounds.SoundMaster.Scene = "BattleWindow";
            Sounds.SoundMaster.PlayEvent("EnterBattleScene");
            Sounds.SoundMaster.InitializeGlobalCombatEvents();
            Sounds.SoundMaster.SetGeneralFXVolume(30);



        }

        private void fightStartButton_Click(object sender, EventArgs e)
        {
            Sounds.SoundMaster.Play();
            Sounds.SoundMaster.PlayEvent("CombatStart");
            CleanAttack.StopTimers();
            CancelDoTs.Execute();

            Combat.InCombat = true;

            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();
            /*            hitButton.Visible = true;
                        strikeButton.Visible = true;
                        blowButton.Visible = true;
                        healButton.Visible = true;*/

            combatText.Visible = true;
            combatText2.Visible = true;
            combatText3.Visible = true;
            combatText4.Visible = true;
            combatText5.Visible = true;
            combatText6.Visible = true;
            combatText7.Visible = true;
            combatText8.Visible = true;
            combatText9.Visible = true;
            combatText10.Visible = true;
            combatText11.Visible = true;

            fightStartButton.Visible = false;
            CleanAttack.Run(player, npc);

            npcAttackTimer.Start();
            aliveStatusCheck.Start();
            battleStatusTimers.Start();
            indicatorsCheck.Start();



            UpdateCombatText($"{player.GetName()} and {npc.GetName()} entered the combat.", CombatTextEvents.EnterCombat, player.IconPath);




        }
        private void InitializeMeta()
        {
            Player player = (Player)Data.GetPlayer();
            Combat.InCombat = false;
            player.ScaleStaticStats();
            
        }
        public void UpdateStats()
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            playerHealthP.Text = Convert.ToString(player.GetHealthPoints());

            if (Convert.ToInt32(playerHealthP.Text) < 0)
            {
                playerHealthP.Text = Convert.ToString(0);
            }

            playerEnergy.Text = Convert.ToString(player.GetEnergy());

            if (Convert.ToInt32(playerEnergy.Text) < 0)
            {
                playerEnergy.Text = Convert.ToString(0);
            }

            playerMana.Text = Convert.ToString(player.GetMana());

            if (Convert.ToInt32(playerMana.Text) < 0)
            {
                playerMana.Text = Convert.ToString(0);
            }

            npcHP.Text = Convert.ToString(npc.GetHealthPoints());

            if (Convert.ToInt32(npcHP.Text) < 0)
            {
                npcHP.Text = Convert.ToString(0);
            }

            npcEnergy.Text = Convert.ToString(npc.GetEnergy());

            if (Convert.ToInt32(npcEnergy.Text) < 0)
            {
                npcEnergy.Text = Convert.ToString(0);
            }

            npcMP.Text = Convert.ToString(npc.GetMana());

            if (Convert.ToInt32(npcMP.Text) < 0)
            {
                npcMP.Text = Convert.ToString(0);
            }

            InitializeIndicators();


        }

        private void InitializeIndicators()
        {
            HealthIndicators();
            ManaIndicators();
            EnergyIndicators();


        }
        private void InitializeSkills()
        {
            Player player = (Player)Data.GetPlayer();
            InitializeButtons(player);
        }

        public void InitializeButtons(Player player)
        {

            if (player.Specialization == "rogue")
            {
                SkillButton button1 = new SkillButton(player.Specialization, "Backstab");
                skill1PseudoButton.Image = button1.Statement;
                ButtonsCache.Button1 = button1;



                SkillButton button2 = new SkillButton(player.Specialization, "Rend");
                skill2PseudoButton.Image = button2.Statement;
                ButtonsCache.Button2 = button2;



                SkillButton button3 = new SkillButton(player.Specialization, "Stun");
                skill3PseudoButton.Image = button3.Statement;
                ButtonsCache.Button3 = button3;


                SkillButton button4 = new SkillButton(player.Specialization, "Dissapear");
                skill4PseudoButton.Image = button4.Statement;
                ButtonsCache.Button4 = button4;


                SkillButton button5 = new SkillButton(player.Specialization, "FTW");
                skill5PseudoButton.Image = button5.Statement;
                ButtonsCache.Button5 = button5;

                List<SkillButton> buttons = new List<SkillButton> { };

                buttons.Add(button1);
                buttons.Add(button2);
                buttons.Add(button3);
                buttons.Add(button4);
                buttons.Add(button5);

                ButtonsCache.Buttons = buttons;
            }

            if (player.Specialization == "mage")
            {
                SkillButton button1 = new SkillButton(player.Specialization, "Fireball");
                skill1PseudoButton.Image = button1.Statement;
                ButtonsCache.Button1 = button1;



                SkillButton button2 = new SkillButton(player.Specialization, "MagicShield");
                skill2PseudoButton.Image = button2.Statement;
                ButtonsCache.Button2 = button2;



                SkillButton button3 = new SkillButton(player.Specialization, "Polymorph");
                skill3PseudoButton.Image = button3.Statement;
                ButtonsCache.Button3 = button3;


                SkillButton button4 = new SkillButton(player.Specialization, "Soulburn");
                skill4PseudoButton.Image = button4.Statement;
                ButtonsCache.Button4 = button4;


                SkillButton button5 = new SkillButton(player.Specialization, "Heal");
                skill5PseudoButton.Image = button5.Statement;
                ButtonsCache.Button5 = button5;

                List<SkillButton> buttons = new List<SkillButton> { };

                buttons.Add(button1);
                buttons.Add(button2);
                buttons.Add(button3);
                buttons.Add(button4);
                buttons.Add(button5);

                ButtonsCache.Buttons = buttons;
            }

            if (player.Specialization == "warrior")
            {
                SkillButton button1 = new SkillButton(player.Specialization, "Powerhit");
                skill1PseudoButton.Image = button1.Statement;
                ButtonsCache.Button1 = button1;



                SkillButton button2 = new SkillButton(player.Specialization, "DeepDefense");
                skill2PseudoButton.Image = button2.Statement;
                ButtonsCache.Button2 = button2;



                SkillButton button3 = new SkillButton(player.Specialization, "WideBlow");
                skill3PseudoButton.Image = button3.Statement;
                ButtonsCache.Button3 = button3;


                SkillButton button4 = new SkillButton(player.Specialization, "CrushLegs");
                skill4PseudoButton.Image = button4.Statement;
                ButtonsCache.Button4 = button4;


                SkillButton button5 = new SkillButton(player.Specialization, "LastManStanding");
                skill5PseudoButton.Image = button5.Statement;
                ButtonsCache.Button5 = button5;

                List<SkillButton> buttons = new List<SkillButton> { };

                buttons.Add(button1);
                buttons.Add(button2);
                buttons.Add(button3);
                buttons.Add(button4);
                buttons.Add(button5);

                ButtonsCache.Buttons = buttons;


            }

        }

        private void HealthIndicators()
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            double playerHealthBars = Convert.ToDouble(player.maxHP) / 10;
            double npcHealthBars = Convert.ToDouble(npc.maxHP) / 10;




            int playerHealthBarsCount = Convert.ToInt32(player.healthpoints / playerHealthBars);
            int npcHealthBarsCount = Convert.ToInt32(npc.healthpoints / npcHealthBars);


            if (playerHealthBarsCount < 0)
            {
                playerHealthBarsCount = 0;
            }

            if (npcHealthBarsCount < 0)
            {
                npcHealthBarsCount = 0;
            }


            string[] playerHealthBarIndicators = new string[11];
            string[] npcHealthBarIndicators = new string[11];



            for (int i = 0; i < playerHealthBarIndicators.Length; i++)
            {
                playerHealthBarIndicators[i] = $"images\\textures\\healthIndicator\\hpBar{i}.png";
            }

            for (int i = 0; i < npcHealthBarIndicators.Length; i++)
            {
                npcHealthBarIndicators[i] = $"images\\textures\\healthIndicator\\hpBar{i}.png";
            }

            characterHealthBar.Image = Image.FromFile(playerHealthBarIndicators[playerHealthBarsCount]);
            npcHealthBar.Image = Image.FromFile(npcHealthBarIndicators[npcHealthBarsCount]);

        }

        private void ManaIndicators()
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            double playerManaBars = Convert.ToDouble(player.maxMana) / 10;
            double npcManaBars = Convert.ToDouble(npc.maxMana) / 10;


            int playerManaBarsCount = Convert.ToInt32(player.mana / playerManaBars);
            int npcManaBarsCount = Convert.ToInt32(npc.mana / npcManaBars);


            if (playerManaBarsCount < 0)
            {
                playerManaBarsCount = 0;
            }

            if (npcManaBarsCount < 0)
            {
                npcManaBarsCount = 0;
            }

            string[] playerManaBarIndicators = new string[11];
            string[] npcManaBarIndicators = new string[11];


            for (int i = 0; i < playerManaBarIndicators.Length; i++)
            {
                playerManaBarIndicators[i] = $"images\\textures\\manaIndicator\\mpBar{i}.png";
            }

            for (int i = 0; i < npcManaBarIndicators.Length; i++)
            {
                npcManaBarIndicators[i] = $"images\\textures\\manaIndicator\\mpBar{i}.png";
            }

            characterManaBar.Image = Image.FromFile(playerManaBarIndicators[playerManaBarsCount]);
            npcManaBar.Image = Image.FromFile(npcManaBarIndicators[npcManaBarsCount]);
        }

        private void EnergyIndicators()
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            double playerEnergyBars = Convert.ToDouble(player.maxEnergy) / 10;
            double npcEnergyBars = Convert.ToDouble(npc.maxEnergy) / 10;


            int playerEnergyBarsCount = Convert.ToInt32(player.energy / playerEnergyBars);
            int npcEnergyBarsCount = Convert.ToInt32(npc.energy / npcEnergyBars);


            if (playerEnergyBarsCount < 0)
            {
                playerEnergyBarsCount = 0;
            }

            if (npcEnergyBarsCount < 0)
            {
                npcEnergyBarsCount = 0;
            }

            string[] playerEnergyBarIndicators = new string[11];
            string[] npcEnergyBarIndicators = new string[11];

            for (int i = 0; i < playerEnergyBarIndicators.Length; i++)
            {
                playerEnergyBarIndicators[i] = $"images\\textures\\EnergyIndicator\\enBar{i}.png";
            }

            for (int i = 0; i < npcEnergyBarIndicators.Length; i++)
            {
                npcEnergyBarIndicators[i] = $"images\\textures\\EnergyIndicator\\enBar{i}.png";
            }

            characterEnergyBar.Image = Image.FromFile(playerEnergyBarIndicators[playerEnergyBarsCount]);
            npcEnergyBar.Image = Image.FromFile(npcEnergyBarIndicators[npcEnergyBarsCount]);
        }

        private void npcStatsRecovery_Tick(object sender, EventArgs e)
        {
            NPC npc = (NPC)Data.GetNPC();
            npc.RecoverNPC();
            UpdateStats();
        }

        private void playerStatsRecovery_Tick(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            player.Recover();
            UpdateStats();
        }


        public void StopFight()
        {
            Combat.InCombat = false;


            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();
            aliveStatusCheck.Stop();
            npcAttackTimer.Stop();
            battleStatusTimers.Stop();
            restartButton.Visible = true;
            // damageToNPCText.Text = "";
            // damageToPlayerText.Text = "";




            if (!npc.Alive())
            {
                UpdateCombatText("Enemy is dead", "images\\combatText\\devastation.jpg", "images\\combatText\\finishEnemy.jpg");


                Data.NPCIsAlive = false;
                npcStatsRecovery.Stop();

                PlayerInventory.AddReward(player, CalculateReward.Initialize(npc));

                

                UpdateCombatText($"{npc.GetName()} dropped {CalculateReward.Reward} copper", CombatTextEvents.CombatReward, npc.IconPath);
                UpdateCombatText($"{npc.level * 2} XP gained", CombatTextEvents.CombatEXP, player.IconPath);

                if (Experience.AddExperience(player, npc))
                {

                    var lwlUpMenu = new upgradeAgility();
                    this.Hide();
                    lwlUpMenu.Show();


                }

            }

            if (!player.Alive())
            {
                Data.PlayerIsAlive = false;
                UpdateCombatText("Player is dead", "images\\combatText\\devastation.jpg", "images\\combatText\\gameOver.jpg");
                playerStatsRecovery.Stop();
            }





        }
        private void coolDownTimer_Tick(object sender, EventArgs e)
        {


        }

        private void npcCoolDownTimer_Tick(object sender, EventArgs e)
        {
            if (Data.NPCAttackCooldown > 0)
            {
                Data.NPCAttackCooldown -= 1;
            }

            if (Data.NPCAttackCooldown == 0)
            {
                npcCoolDownTimer.Stop();
            }

        }

        private void npcAttackTimer_Tick(object sender, EventArgs e)
        {
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            StopFight();
            InitializePlayers();
            restartButton.Visible = false;
            fightStartButton.Visible = true;
        }

        public void InitializePlayers()
        {
            if (!Data.PlayerIsAlive)
            {
                NPC npc = (NPC)Data.GetNPC();
                Player player = new Player("Arthur Morgan", "Male");
                Data.SetPlayer(player);
                InitializePlayerAndNPCData(player, npc);
                UpdateStats();
            }

            if (!Data.NPCIsAlive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)EnemyInitialization.Initialize();
                Data.SetNPC(npc);
                InitializePlayerAndNPCData(player, npc);
                UpdateStats();
            }

            if (Data.PlayerIsAlive && Data.NPCIsAlive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                InitializePlayerAndNPCData(player, npc);
            }
        }

        private void aliveStatusCheck_Tick(object sender, EventArgs e)
        {

            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (!player.Alive())
            {
                StopFight();
                Data.PlayerIsAlive = false;
            }

            if (!npc.Alive())
            {
                Sounds.SoundMaster.PlayEvent("BattleWin");
                StopFight();
                Data.NPCIsAlive = false;

                lootPanel.Controls.Clear();
                var loot = new LootMenu();
                loot.TopLevel = false;
                lootPanel.Controls.Add(loot);
                loot.Show();

            }


        }

        private void battleStatusTimers_Tick(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (CombatText.Accepted)
            {

                CombatText.Accepted = false;
                UpdateCombatText(CombatText.CombatData[0], CombatText.CombatData[1], CombatText.CombatData[2]);
            }

            if (CombatText.DefenseAccepted)
            {
                CombatText.DefenseAccepted = false;
                UpdateCombatText(CombatText.CombatDefenseData[0], CombatText.CombatDefenseData[1], CombatText.CombatDefenseData[2]);
            }

            if (CombatText.NPCAccepted)
            {
                CombatText.NPCAccepted = false;
                UpdateCombatText(CombatText.CombatDataNPC[0], CombatText.CombatDataNPC[1], CombatText.CombatDataNPC[2]);
            }
            if (CombatText.NPCDefenseAccepted)
            {
                CombatText.NPCDefenseAccepted = false;
                UpdateCombatText(CombatText.NPCCombatDefenseData[0], CombatText.NPCCombatDefenseData[1], CombatText.NPCCombatDefenseData[2]);
            }


            if (!player.Alive() || !npc.Alive())
            {
                CleanAttack.StopTimers();

            }

            Data.SetPlayer(player);
            Data.SetNPC(npc);
        }

        private void KillButton_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();
            npc.Kill();
        }

        private void BattleWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SaveCharacterButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadCharacterButton_Click(object sender, EventArgs e)
        {

        }

        private void strikeButton_Click(object sender, EventArgs e)
        {

        }

        private void blowButton_Click(object sender, EventArgs e)
        {

        }

        private void healButton_Click(object sender, EventArgs e)
        {

        }

        private void combatText_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            StopFight();
            playerStatsRecovery.Stop();
            npcStatsRecovery.Stop();
            this.Hide();
            var gameMenu = new GameMenu();
            gameMenu.Show();
        }

        private void BattleWindow_Leave(object sender, EventArgs e)
        {
            playerStatsRecovery.Stop();
            npcStatsRecovery.Stop();
        }

        private void indicatorsCheck_Tick(object sender, EventArgs e)
        {
            InitializeIndicators();
            TrackCooldowns();
            UpdateStats();
        }

        private void Skill1Button_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            NPC npc = (NPC)Data.GetNPC();

            if (player.Specialization == "mage")
            {

            }

            if (player.Specialization == "rogue")
            {

            }

            if (player.Specialization == "warrior")
            {

            }
        }

        private void TrackCooldowns()
        {

            /*            if (CoolDownsPanel.GlobalCooldownActive)
                        {
                            return;
                        }*/
            Player player = (Player)Data.GetPlayer();

            // rogue

            if (player.Specialization == "rogue")
            {
                if (player.energy < RogueSkills.BackStabCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                }

                if (player.energy < RogueSkills.RendCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                }

                if (player.energy < RogueSkills.StunCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                }

                if (player.energy < RogueSkills.DissapearCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                }

                if (player.mana < RogueSkills.FindTheWeaknessCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                }

                if (player.energy > RogueSkills.BackStabCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.stByImg;
                }

                if (player.energy > RogueSkills.RendCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.stByImg;
                }

                if (player.energy > RogueSkills.StunCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.stByImg;
                }

                if (player.energy > RogueSkills.DissapearCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.stByImg;
                }

                if (player.energy > RogueSkills.FindTheWeaknessCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.stByImg;
                }




                if (RogueSkills.RendDamageTextAccepted)
                {
                    UpdateCombatText(RogueSkills.RendDamage, RogueSkills.RendImagePath, CombatText.Actor);
                    RogueSkills.RendDamageTextAccepted = false;
                }

                if (!RogueSkills.BackStabReady)
                {
                    ButtonsCache.SetCoolDown("Backstab");
                    coolDown1Text.Visible = true;
                    coolDownPicBox1.Visible = true;
                    coolDownPicBox1.Image = ButtonsCache.GetImage("Backstab");
                    coolDown1Text.Text = $"{RogueSkills.BackStabCooldown} s";
                    skill1PseudoButton.Enabled = false;
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                    ButtonsCache.Button1Ready = false;
                }

                if (RogueSkills.BackStabReady)
                {
                    coolDown1Text.Visible = false;
                    coolDownPicBox1.Visible = false;
                    ButtonsCache.CancelCoolDown("Backstab");
                    skill1PseudoButton.Enabled = true;
                }

                if (!RogueSkills.RendReady)
                {
                    ButtonsCache.SetCoolDown("Rend");
                    coolDown2Text.Visible = true;
                    coolDownPicBox2.Visible = true;
                    coolDownPicBox2.Image = ButtonsCache.GetImage("Rend");
                    coolDown2Text.Text = $"{RogueSkills.RendCoolDown} s";
                    skill2PseudoButton.Enabled = false;
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                    ButtonsCache.Button2Ready = false;
                }

                if (RogueSkills.RendReady)
                {
                    coolDown2Text.Visible = false;
                    coolDownPicBox2.Visible = false;
                    ButtonsCache.CancelCoolDown("Backstab");
                    skill2PseudoButton.Enabled = true;
                }

                if (RogueSkills.RendInflicted)
                {
                    npcDebuffPic1.Visible = true;
                    npcDebuff1duration.Visible = true;
                    npcDebuffPic1.Image = ButtonsCache.GetImage("Rend");
                    npcDebuff1duration.Text = $"{RogueSkills.RendDamageDuration} s";
                }

                if (!RogueSkills.RendInflicted)
                {
                    npcDebuffPic1.Visible = false;
                    npcDebuff1duration.Visible = false;
                }


                if (!RogueSkills.StunReady)
                {
                    ButtonsCache.SetCoolDown("Stun");
                    coolDown3Text.Visible = true;
                    coolDownPicBox3.Visible = true;
                    coolDownPicBox3.Image = ButtonsCache.GetImage("Stun");
                    coolDown3Text.Text = $"{RogueSkills.StunCoolDown} s";
                    skill3PseudoButton.Enabled = false;
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                    ButtonsCache.Button3Ready = false;
                }

                if (RogueSkills.StunReady)
                {
                    coolDown3Text.Visible = false;
                    coolDownPicBox3.Visible = false;
                    ButtonsCache.CancelCoolDown("Stun");
                    skill3PseudoButton.Enabled = true;
                }

                if (RogueSkills.StunInflicted)
                {
                    npcDebuffPic3.Visible = true;
                    npcDebuff3duration.Visible = true;
                    npcDebuffPic3.Image = ButtonsCache.GetImage("Stun");
                    npcDebuff3duration.Text = $"{RogueSkills.StunAffectDuration} s";
                }

                if (!RogueSkills.StunInflicted)
                {
                    npcDebuffPic3.Visible = false;
                    npcDebuff3duration.Visible = false;
                }

                if (!RogueSkills.DissapearReady)
                {
                    ButtonsCache.SetCoolDown("Dissapears Into The Shadows");
                    coolDown4Text.Visible = true;
                    coolDownPicBox4.Visible = true;
                    coolDownPicBox4.Image = ButtonsCache.GetImage("Dissapears Into The Shadows");
                    coolDown4Text.Text = $"{RogueSkills.DissapearCoolDown} s";
                    skill4PseudoButton.Enabled = false;
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                    ButtonsCache.Button4Ready = false;
                }

                if (RogueSkills.DissapearReady)
                {
                    coolDown4Text.Visible = false;
                    coolDownPicBox4.Visible = false;
                    ButtonsCache.CancelCoolDown("Dissapear");
                    skill4PseudoButton.Enabled = true;
                }

                if (!RogueSkills.FindTheWeaknessReady)
                {
                    ButtonsCache.SetCoolDown("Find The Weakness");
                    coolDown5Text.Visible = true;
                    coolDownPicBox5.Visible = true;
                    coolDownPicBox5.Image = ButtonsCache.GetImage("Find The Weakness");
                    coolDown5Text.Text = $"{RogueSkills.FindTheWeaknessCoolDown} s";
                    skill5PseudoButton.Enabled = false;
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                    ButtonsCache.Button5Ready = false;
                }

                if (RogueSkills.FindTheWeaknessReady)
                {
                    coolDown5Text.Visible = false;
                    coolDownPicBox5.Visible = false;
                    ButtonsCache.CancelCoolDown("Find The Weakness");
                    skill5PseudoButton.Enabled = true;
                }
                if (RogueSkills.FindTheWeaknessAffected)
                {
                    npcDebuffPic5.Visible = true;
                    npcDebuff5duration.Visible = true;
                    npcDebuffPic5.Image = ButtonsCache.GetImage("Find The Weakness");
                    npcDebuff5duration.Text = $"{RogueSkills.FindTheWeaknessDuration} s";
                }

                if (!RogueSkills.FindTheWeaknessAffected)
                {
                    npcDebuffPic5.Visible = false;
                    npcDebuff5duration.Visible = false;
                }


                if (!RogueSkills.BackStabReady || !RogueSkills.RendReady || !RogueSkills.StunReady || !RogueSkills.DissapearReady || !RogueSkills.FindTheWeaknessReady)
                {
                    coolDownsPanel.Show();
                }

                if (RogueSkills.BackStabReady && RogueSkills.RendReady && RogueSkills.StunReady && RogueSkills.DissapearReady && RogueSkills.FindTheWeaknessReady)
                {
                    coolDownsPanel.Visible = false; ;
                }


                if (RogueSkills.RendInflicted || RogueSkills.StunInflicted || RogueSkills.FindTheWeaknessAffected)
                {
                    npcDebuffsPanel.Show();
                }

                if (!RogueSkills.RendInflicted && !RogueSkills.StunInflicted && !RogueSkills.FindTheWeaknessAffected)
                {
                    npcDebuffsPanel.Hide();
                }

                if (RogueSkills.DissapearAffected)
                {
                    playerDebuffsPanel.Show();
                    playerDebuffPic1.Visible = true;
                    playerDebuffPic1.Image = ButtonsCache.GetImage("Dissapears Into The Shadows");
                    playerDebuffduration.Show();
                    playerDebuffduration.Text = $"{RogueSkills.DissapearDuration} s";
                }

                if (!RogueSkills.DissapearAffected)
                {
                    playerDebuffsPanel.Hide();
                    playerDebuffPic1.Visible = false;
                    playerDebuffduration.Visible = false;
                }
            }

            // <- rogue

            // mage

            if (player.Specialization == "mage")
            {
                if (player.mana < MageSkills.FireballCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                }

                if (player.mana < MageSkills.MagicShieldCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                }

                if (player.mana < MageSkills.PolymorphCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                }

                if (player.mana < MageSkills.SoulBurnCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                }

                if (player.mana < MageSkills.HealCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                }

                if (player.mana > MageSkills.FireballCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.stByImg;
                }

                if (player.mana > MageSkills.MagicShieldCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.stByImg;
                }


                if (player.mana > MageSkills.PolymorphCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.stByImg;
                }

                if (player.mana > MageSkills.SoulBurnCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.stByImg;
                }

                if (player.mana > MageSkills.HealCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.stByImg;
                }



                if (!MageSkills.FireballReady)
                {
                    ButtonsCache.SetCoolDown("Fireball");
                    coolDown1Text.Visible = true;
                    coolDownPicBox1.Visible = true;
                    coolDownPicBox1.Image = ButtonsCache.GetImage("Fireball");
                    coolDown1Text.Text = $"{MageSkills.FireballCooldown} s";
                    skill1PseudoButton.Enabled = false;
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                    ButtonsCache.Button2Ready = false;
                }

                if (MageSkills.FireballReady)
                {
                    coolDown1Text.Visible = false;
                    coolDownPicBox1.Visible = false;
                    ButtonsCache.CancelCoolDown("Fireball");
                    skill1PseudoButton.Enabled = true;
                }

                if (!MageSkills.MagicShieldReady)
                {
                    ButtonsCache.SetCoolDown("Magic Shield");
                    coolDown2Text.Visible = true;
                    coolDownPicBox2.Visible = true;
                    coolDownPicBox2.Image = ButtonsCache.GetImage("Magic Shield");
                    coolDown2Text.Text = $"{MageSkills.MagicShieldCoolDown} s";
                    skill2PseudoButton.Enabled = false;
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                    ButtonsCache.Button2Ready = false;
                }

                if (MageSkills.MagicShieldReady)
                {
                    coolDown2Text.Visible = false;
                    coolDownPicBox2.Visible = false;
                    ButtonsCache.CancelCoolDown("Magic Shield");
                    skill2PseudoButton.Enabled = true;
                }

                if (MageSkills.MagicShieldAffected)
                {
                    playerDebuffsPanel.Show();
                    playerDebuffPic2.Visible = true;
                    playerDebuffPic2.Image = ButtonsCache.GetImage("Magic Shield");
                    playerDebuffduration.Show();
                    playerDebuffduration.Text = $"{MageSkills.MagicShieldDuration} s";
                }

                if (!MageSkills.MagicShieldAffected)
                {
                    playerDebuffsPanel.Hide();
                    playerDebuffPic2.Visible = false;
                    playerDebuffduration.Visible = false;
                }


                if (!MageSkills.PolymorphReady)
                {
                    ButtonsCache.SetCoolDown("Polymorph");
                    coolDown3Text.Visible = true;
                    coolDownPicBox3.Visible = true;
                    coolDownPicBox3.Image = ButtonsCache.GetImage("Polymorph");
                    coolDown3Text.Text = $"{MageSkills.PolymorphCoolDown} s";
                    skill3PseudoButton.Enabled = false;
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                    ButtonsCache.Button3Ready = false;
                }

                if (MageSkills.PolymorphReady)
                {
                    coolDown3Text.Visible = false;
                    coolDownPicBox3.Visible = false;
                    ButtonsCache.CancelCoolDown("Polymorph");
                    skill3PseudoButton.Enabled = true;
                }

                if (MageSkills.PolymorphInflicted)
                {
                    NPC npc = (NPC)Data.NPC;
                    npcIcon.Image = Image.FromFile(npc.NPCIconPath);
                    npcDebuffPic3.Visible = true;
                    npcDebuff3duration.Visible = true;
                    npcDebuffPic3.Image = ButtonsCache.GetImage("Polymorph");
                    npcDebuff3duration.Text = $"{MageSkills.PolymorphAffectDuration} s";
                }

                if (!MageSkills.PolymorphInflicted)
                {
                    NPC npc = (NPC)Data.NPC;
                    npcIcon.Image = Image.FromFile(npc.NPCIconPath);
                    npcDebuffPic3.Visible = false;
                    npcDebuff3duration.Visible = false;
                }


                if (!MageSkills.SoulBurnReady)
                {
                    ButtonsCache.SetCoolDown("Soul Burn");
                    coolDown4Text.Visible = true;
                    coolDownPicBox4.Visible = true;
                    coolDownPicBox4.Image = ButtonsCache.GetImage("Soul Burn");
                    coolDown4Text.Text = $"{MageSkills.SoulBurnCoolDown} s";
                    skill4PseudoButton.Enabled = false;
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                    ButtonsCache.Button4Ready = false;
                }

                if (MageSkills.SoulBurnReady)
                {
                    coolDown4Text.Visible = false;
                    coolDownPicBox4.Visible = false;
                    ButtonsCache.CancelCoolDown("Soul Burn");
                    skill4PseudoButton.Enabled = true;
                }

                if (MageSkills.SoulBurnInflicted)
                {
                    npcDebuffPic4.Visible = true;
                    npcDebuff4duration.Visible = true;
                    npcDebuffPic4.Image = ButtonsCache.GetImage("Soul Burn");
                    npcDebuff4duration.Text = $"{MageSkills.SoulBurnDamageDuration} s";
                }

                if (!MageSkills.SoulBurnInflicted)
                {
                    npcDebuffPic4.Visible = false;
                    npcDebuff4duration.Visible = false;
                }

                if (MageSkills.PolymorphInflicted || MageSkills.SoulBurnInflicted)
                {
                    npcDebuffsPanel.Show();

                }

                if (!MageSkills.PolymorphInflicted && !MageSkills.SoulBurnInflicted)
                {
                    npcDebuffsPanel.Hide();

                }

                if (!MageSkills.HealReady)
                {
                    ButtonsCache.SetCoolDown("Heal");
                    coolDown5Text.Visible = true;
                    coolDownPicBox5.Visible = true;
                    coolDownPicBox5.Image = ButtonsCache.GetImage("Heal");
                    coolDown5Text.Text = $"{MageSkills.HealCooldown} s";
                    skill5PseudoButton.Enabled = false;
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                    ButtonsCache.Button2Ready = false;
                }

                if (MageSkills.HealReady)
                {
                    coolDown5Text.Visible = false;
                    coolDownPicBox5.Visible = false;
                    ButtonsCache.CancelCoolDown("Heal");
                    skill5PseudoButton.Enabled = true;
                }

                if (!MageSkills.FireballReady || !MageSkills.MagicShieldReady || !MageSkills.PolymorphReady || !MageSkills.SoulBurnReady || !MageSkills.HealReady)
                {
                    coolDownsPanel.Show();
                }

                if (MageSkills.FireballReady && MageSkills.MagicShieldReady && MageSkills.PolymorphReady && MageSkills.SoulBurnReady && MageSkills.HealReady)
                {
                    coolDownsPanel.Visible = false;
                }
            }

            // <- mage

            // warrior

            if (player.Specialization == "warrior")
            {
                if (player.energy < WarriorSkills.PowerHitCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                }
                if (player.energy < WarriorSkills.DeepDefenseCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                }

                if (player.energy < WarriorSkills.WideBlowCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                }

                if (player.energy < WarriorSkills.CrushLegsCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                }

                if (player.energy < WarriorSkills.LastManStandingCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                }

                if (player.energy > WarriorSkills.PowerHitCost)
                {
                    skill1PseudoButton.Image = ButtonsCache.Button1.stByImg;
                }

                if (player.energy > WarriorSkills.DeepDefenseCost)
                {
                    skill2PseudoButton.Image = ButtonsCache.Button2.stByImg;
                }

                if (player.energy > WarriorSkills.WideBlowCost)
                {
                    skill3PseudoButton.Image = ButtonsCache.Button3.stByImg;
                }

                if (player.energy > WarriorSkills.CrushLegsCost)
                {
                    skill4PseudoButton.Image = ButtonsCache.Button4.stByImg;
                }

                if (player.energy > WarriorSkills.LastManStandingCost)
                {
                    skill5PseudoButton.Image = ButtonsCache.Button5.stByImg;
                }

                if (!WarriorSkills.PowerHitReady)
                {
                    ButtonsCache.SetCoolDown("Power Hit");
                    coolDown1Text.Visible = true;
                    coolDownPicBox1.Visible = true;
                    coolDownPicBox1.Image = ButtonsCache.GetImage("Power Hit");
                    coolDown1Text.Text = $"{WarriorSkills.PowerHitCooldown} s";
                    skill1PseudoButton.Enabled = false;
                    skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
                    ButtonsCache.Button1Ready = false;
                }

                if (WarriorSkills.PowerHitReady)
                {
                    coolDown1Text.Visible = false;
                    coolDownPicBox1.Visible = false;
                    ButtonsCache.CancelCoolDown("Power Hit");
                    skill1PseudoButton.Enabled = true;
                }

                if (!WarriorSkills.WideBlowReady)
                {
                    ButtonsCache.SetCoolDown("Wide Blow");
                    coolDown3Text.Visible = true;
                    coolDownPicBox3.Visible = true;
                    coolDownPicBox3.Image = ButtonsCache.GetImage("Wide Blow");
                    coolDown3Text.Text = $"{WarriorSkills.WideBlowCoolDown} s";
                    skill3PseudoButton.Enabled = false;
                    skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
                    ButtonsCache.Button3Ready = false;
                }

                if (WarriorSkills.WideBlowReady)
                {
                    coolDown3Text.Visible = false;
                    coolDownPicBox3.Visible = false;
                    ButtonsCache.CancelCoolDown("Wide Blow");
                    skill3PseudoButton.Enabled = true;
                }

                if (WarriorSkills.WideBlowInflicted)
                {
                    npcDebuffPic3.Visible = true;
                    npcDebuff3duration.Visible = true;
                    npcDebuffPic3.Image = ButtonsCache.GetImage("Wide Blow");
                    npcDebuff3duration.Text = $"{WarriorSkills.WideBlowAffectDuration} s";
                }

                if (!WarriorSkills.WideBlowInflicted)
                {
                    npcDebuffPic3.Visible = false;
                    npcDebuff3duration.Visible = false;
                }

                if (!WarriorSkills.CrushLegsReady)
                {
                    ButtonsCache.SetCoolDown("Crush Legs");
                    coolDown4Text.Visible = true;
                    coolDownPicBox4.Visible = true;
                    coolDownPicBox4.Image = ButtonsCache.GetImage("Crush Legs");
                    coolDown4Text.Text = $"{WarriorSkills.CrushLegsCoolDown} s";
                    skill4PseudoButton.Enabled = false;
                    skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
                    ButtonsCache.Button4Ready = false;
                }

                if (WarriorSkills.CrushLegsReady)
                {
                    coolDown4Text.Visible = false;
                    coolDownPicBox4.Visible = false;
                    ButtonsCache.CancelCoolDown("Crush Legs");
                    skill4PseudoButton.Enabled = true;
                }

                if (WarriorSkills.CrushLegsInflicted)
                {
                    npcDebuffPic4.Visible = true;
                    npcDebuff4duration.Visible = true;
                    npcDebuffPic4.Image = ButtonsCache.GetImage("Crush Legs");
                    npcDebuff4duration.Text = $"{WarriorSkills.CrushLegsAffectDuration} s";
                }

                if (!WarriorSkills.CrushLegsInflicted)
                {
                    npcDebuffPic4.Visible = false;
                    npcDebuff4duration.Visible = false;
                }
                if (!WarriorSkills.DeepDefenseReady)
                {
                    ButtonsCache.SetCoolDown("Deep Defense");
                    coolDown2Text.Visible = true;
                    coolDownPicBox2.Visible = true;
                    coolDownPicBox2.Image = ButtonsCache.GetImage("Deep Defense");
                    coolDown2Text.Text = $"{WarriorSkills.DeepDefenseCoolDown} s";
                    skill2PseudoButton.Enabled = false;
                    skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
                    ButtonsCache.Button2Ready = false;
                }

                if (WarriorSkills.DeepDefenseReady)
                {
                    coolDown2Text.Visible = false;
                    coolDownPicBox2.Visible = false;
                    ButtonsCache.CancelCoolDown("Deep Defense");
                    skill2PseudoButton.Enabled = true;
                }

                if (!WarriorSkills.LastManStandingReady)
                {
                    ButtonsCache.SetCoolDown("Last Man Standing");
                    coolDown5Text.Visible = true;
                    coolDownPicBox5.Visible = true;
                    coolDownPicBox5.Image = ButtonsCache.GetImage("Last Man Standing");
                    coolDown5Text.Text = $"{WarriorSkills.LastManStandingCoolDown} s";
                    skill5PseudoButton.Enabled = false;
                    skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
                    ButtonsCache.Button5Ready = false;
                }

                if (WarriorSkills.LastManStandingReady)
                {
                    coolDown5Text.Visible = false;
                    coolDownPicBox5.Visible = false;
                    ButtonsCache.CancelCoolDown("Deep Defense");
                    skill5PseudoButton.Enabled = true;
                }


                if (WarriorSkills.WideBlowInflicted || WarriorSkills.CrushLegsInflicted)
                {
                    npcDebuffsPanel.Show();
                }

                if (!WarriorSkills.WideBlowInflicted && !WarriorSkills.CrushLegsInflicted)
                {
                    npcDebuffsPanel.Hide();
                }

                if (!WarriorSkills.PowerHitReady || !WarriorSkills.WideBlowReady || !WarriorSkills.CrushLegsReady || !WarriorSkills.DeepDefenseReady || !WarriorSkills.LastManStandingReady)
                {
                    coolDownsPanel.Show();
                }

                if (WarriorSkills.PowerHitReady && WarriorSkills.WideBlowReady && WarriorSkills.CrushLegsReady && WarriorSkills.DeepDefenseReady && WarriorSkills.LastManStandingReady)
                {
                    coolDownsPanel.Visible = false;
                }

                if (WarriorSkills.DeepDefenseAffected)
                {
                    playerDebuffPic1.Visible = true;

                    playerDebuffPic1.Image = ButtonsCache.GetImage("Deep Defense");
                    playerDebuffduration.Show();
                    playerDebuffduration.Text = $"{WarriorSkills.DeepDefenseDuration} s";
                }

                if (!WarriorSkills.DeepDefenseAffected)
                {
                    playerDebuffPic1.Visible = false;
                    playerDebuffduration.Visible = false;
                }

                if (WarriorSkills.LastManStandingAffected)
                {
                    playerDebuffPic2.Visible = true;
                    playerDebuffPic2.Image = ButtonsCache.GetImage("Last Man Standing");
                    playerDebuff2duration.Show();
                    playerDebuff2duration.Text = $"{WarriorSkills.LastManStandingDuration} s";
                }

                if (!WarriorSkills.LastManStandingAffected)
                {
                    playerDebuffPic2.Visible = false;
                    playerDebuff2duration.Visible = false;
                }

                if (WarriorSkills.DeepDefenseAffected || WarriorSkills.LastManStandingAffected)
                {
                    playerDebuffsPanel.Show();

                }

                if (!WarriorSkills.DeepDefenseAffected && !WarriorSkills.LastManStandingAffected)
                {
                    playerDebuffsPanel.Hide();
                }
            }
        }

        private void GlobalCooldown()
        {
            System.Timers.Timer globalCooldown = new System.Timers.Timer(1000);
            globalCooldown.Elapsed += GlobalCooldown_Elapsed;
            globalCooldown.Start();
            CoolDownsPanel.GlobalCoolDown = globalCooldown;
            CoolDownsPanel.GlobalCoolDownStage = 10;
            CoolDownsPanel.GlobalCooldownActive = true;
            skill1PseudoButton.Enabled = false;
            skill2PseudoButton.Enabled = false;
            skill3PseudoButton.Enabled = false;
            skill4PseudoButton.Enabled = false;
            skill5PseudoButton.Enabled = false;

        }

        private void GlobalCooldown_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (CoolDownsPanel.GlobalCoolDownStage == 0)
            {
                CoolDownsPanel.GlobalCoolDown.Stop();

            }

            CoolDownsPanel.GlobalCoolDownStage -= 1;
            CoolDownsPanel.GlobalCooldownActive = false;
        }

        private void skill1PseudoButton_MouseDown(object sender, MouseEventArgs e)
        {
            skill1PseudoButton.Image = ButtonsCache.Button1.pressImg;
            ButtonsCache.Button1.Statement = ButtonsCache.Button1.pressImg;

        }

        private void skill1PseudoButton_MouseUp(object sender, MouseEventArgs e)
        {
            skill1PseudoButton.Image = ButtonsCache.Button1.stByImg;

        }

        private void skill2PseudoButton_MouseDown(object sender, MouseEventArgs e)
        {
            skill2PseudoButton.Image = ButtonsCache.Button2.pressImg;
        }

        private void skill2PseudoButton_MouseUp(object sender, MouseEventArgs e)
        {
            skill2PseudoButton.Image = ButtonsCache.Button2.stByImg;
        }

        private void skill3PseudoButton_MouseUp(object sender, MouseEventArgs e)
        {
            skill3PseudoButton.Image = ButtonsCache.Button3.stByImg;
        }

        private void skill3PseudoButton_MouseDown(object sender, MouseEventArgs e)
        {
            skill3PseudoButton.Image = ButtonsCache.Button3.pressImg;
        }

        private void skill4PseudoButton_MouseUp(object sender, MouseEventArgs e)
        {
            skill4PseudoButton.Image = ButtonsCache.Button4.stByImg;
        }

        private void skill4PseudoButton_MouseDown(object sender, MouseEventArgs e)
        {
            skill4PseudoButton.Image = ButtonsCache.Button4.pressImg;
        }

        private void skill5PseudoButton_MouseUp(object sender, MouseEventArgs e)
        {
            skill5PseudoButton.Image = ButtonsCache.Button5.stByImg;
        }

        private void skill5PseudoButton_MouseDown(object sender, MouseEventArgs e)
        {
            skill5PseudoButton.Image = ButtonsCache.Button5.pressImg;
        }

        private void skill1PseudoButton_Click(object sender, EventArgs e)
        {
            if (Combat.InCombat && !CoolDownsPanel.GlobalCooldownActive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                SkillsInitialize.Use(player, npc, ButtonsCache.Button1.SkillName);
                //GlobalCooldown();
            }

        }

        private void skill2PseudoButton_Click(object sender, EventArgs e)
        {
            if (Combat.InCombat && !CoolDownsPanel.GlobalCooldownActive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                SkillsInitialize.Use(player, npc, ButtonsCache.Button2.SkillName);
               // GlobalCooldown();
            }
        }

        private void skill3PseudoButton_Click(object sender, EventArgs e)
        {
            if (Combat.InCombat && !CoolDownsPanel.GlobalCooldownActive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                SkillsInitialize.Use(player, npc, ButtonsCache.Button3.SkillName);
               // GlobalCooldown();
            }
        }

        private void skill4PseudoButton_Click(object sender, EventArgs e)
        {
            if (Combat.InCombat && !CoolDownsPanel.GlobalCooldownActive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                SkillsInitialize.Use(player, npc, ButtonsCache.Button4.SkillName);
               // GlobalCooldown();
            }
        }

        private void skill5PseudoButton_Click(object sender, EventArgs e)
        {
            if (Combat.InCombat && !CoolDownsPanel.GlobalCooldownActive)
            {
                Player player = (Player)Data.GetPlayer();
                NPC npc = (NPC)Data.GetNPC();
                SkillsInitialize.Use(player, npc, ButtonsCache.Button5.SkillName);
               // GlobalCooldown();
            }
        }

        private void restorePlayerHealthButton_Click(object sender, EventArgs e)
        {
            Player player = (Player)Data.GetPlayer();
            player.healthpoints = player.maxHP;
        }

        private void skill1PseudoButton_MouseHover(object sender, EventArgs e)
        {
            skillDescriptionPanel.Show();
            skillDescriptionName.Text = ButtonsCache.Button1.SkillName;
            skillDescriptionDescription.Text = ButtonsCache.Button1.SkillDescription;
            skillDescriptionImage.Image = ButtonsCache.Button1.stByImg;
        }

        private void skill1PseudoButton_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();

        }

        private void skill2PseudoButton_MouseHover(object sender, EventArgs e)
        {
            skillDescriptionPanel.Show();
            skillDescriptionName.Text = ButtonsCache.Button2.SkillName;
            skillDescriptionDescription.Text = ButtonsCache.Button2.SkillDescription;
            skillDescriptionImage.Image = ButtonsCache.Button2.stByImg;
        }

        private void skill2PseudoButton_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void skill3PseudoButton_MouseHover(object sender, EventArgs e)
        {
            skillDescriptionPanel.Show();
            skillDescriptionName.Text = ButtonsCache.Button3.SkillName;
            skillDescriptionDescription.Text = ButtonsCache.Button3.SkillDescription;
            skillDescriptionImage.Image = ButtonsCache.Button3.stByImg;
        }

        private void skill3PseudoButton_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void skill4PseudoButton_MouseHover(object sender, EventArgs e)
        {
            skillDescriptionPanel.Show();
            skillDescriptionName.Text = ButtonsCache.Button4.SkillName;
            skillDescriptionDescription.Text = ButtonsCache.Button4.SkillDescription;
            skillDescriptionImage.Image = ButtonsCache.Button4.stByImg;
        }

        private void skill4PseudoButton_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void skill5PseudoButton_MouseHover(object sender, EventArgs e)
        {
            skillDescriptionPanel.Show();
            skillDescriptionName.Text = ButtonsCache.Button5.SkillName;
            skillDescriptionDescription.Text = ButtonsCache.Button5.SkillDescription;
            skillDescriptionImage.Image = ButtonsCache.Button5.stByImg;
        }

        private void skill5PseudoButton_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void criticalEncounters_Tick(object sender, EventArgs e)
        {
/*            CritHitColorsPlayer.Initialize();
            damageToNPCText.ForeColor = Color.FromArgb(CritHitColorsPlayer.Color[0], CritHitColorsPlayer.Color[1], CritHitColorsPlayer.Color[2]);

            if (CritHitColorsPlayer.Stage == 0)
            {
                criticalEncountersPlayer.Stop();
                damageToNPCText.Visible = false;
            }*/


        }

        private void criticalEncountersNPC_Tick(object sender, EventArgs e)
        {
            /*            CritHitColorsNPC.Initialize();
                        damageToPlayerText.ForeColor = Color.FromArgb(CritHitColorsNPC.Color[0], CritHitColorsNPC.Color[1], CritHitColorsNPC.Color[2]);

                        if (CritHitColorsNPC.Stage == 0)
                        {
                            criticalEncountersNPC.Stop();
                            // damageToPlayerText.Visible = false;
                        }*/
        }

        private void criticalEncountersWarnings_Tick(object sender, EventArgs e)
        {
/*            WarningsEncounter.Initialize();
            warningsLabel.ForeColor = Color.FromArgb(WarningsEncounter.Color[0], WarningsEncounter.Color[1], WarningsEncounter.Color[2]);

            if (WarningsEncounter.Stage == 0)
            {
                criticalEncountersWarnings.Stop();
                warningsLabel.Visible = false;
            }*/
        }

        private void BattleWindow_KeyUp(object sender, KeyEventArgs e)
        {


            switch (e.KeyValue)
            {
                case (char)Keys.D1:
                    skill1PseudoButton_Click(sender, e);
                    break;
                case (char)Keys.D2:
                    skill2PseudoButton_Click(sender, e);
                    break;
                case (char)Keys.D3:
                    skill3PseudoButton_Click(sender, e);
                    break;
                case (char)Keys.D4:
                    skill4PseudoButton_Click(sender, e);
                    break;
                case (char)Keys.D5:
                    skill5PseudoButton_Click(sender, e);

                    break;
                default:
                    break;
            }

        }

        private void BattleWindow_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BattleWindow_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void playerDebuffPic1_MouseHover(object sender, EventArgs e)
        {
            skill4PseudoButton_MouseHover(sender, e);
        }

        private void playerDebuffPic2_MouseHover(object sender, EventArgs e)
        {

        }

        private void playerDebuffPic3_MouseHover(object sender, EventArgs e)
        {

        }

        private void playerDebuffPic4_MouseHover(object sender, EventArgs e)
        {

        }

        private void playerDebuffPic5_MouseHover(object sender, EventArgs e)
        {

        }

        private void playerDebuffPic1_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void coolDownPicBox1_MouseHover(object sender, EventArgs e)
        {
            skill1PseudoButton_MouseHover(sender, e);
        }

        private void coolDownPicBox1_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void coolDownPicBox2_MouseHover(object sender, EventArgs e)
        {
            skill2PseudoButton_MouseHover(sender, e);
        }

        private void coolDownPicBox2_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void coolDownPicBox3_MouseHover(object sender, EventArgs e)
        {
            skill3PseudoButton_MouseHover(sender, e);
        }

        private void coolDownPicBox3_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void coolDownPicBox4_MouseHover(object sender, EventArgs e)
        {
            skill4PseudoButton_MouseHover(sender, e);
        }

        private void coolDownPicBox4_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void coolDownPicBox5_MouseHover(object sender, EventArgs e)
        {
            skill5PseudoButton_MouseHover(sender, e);
        }

        private void coolDownPicBox5_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void npcDebuffPic1_MouseHover(object sender, EventArgs e)
        {
            skill2PseudoButton_MouseHover(sender, e);
        }

        private void npcDebuffPic1_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void npcDebuffPic3_MouseHover(object sender, EventArgs e)
        {
            skill3PseudoButton_MouseHover(sender, e);
        }

        private void npcDebuffPic3_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }

        private void npcDebuffPic5_MouseHover(object sender, EventArgs e)
        {
            skill5PseudoButton_MouseHover(sender, e);
        }

        private void npcDebuffPic5_MouseLeave(object sender, EventArgs e)
        {
            skillDescriptionPanel.Hide();
        }
    }
}
