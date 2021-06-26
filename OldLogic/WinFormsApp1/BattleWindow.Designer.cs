
namespace WinFormsApp1
{
    partial class BattleWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleWindow));
            this.playerHealthP = new System.Windows.Forms.Label();
            this.playerEnergy = new System.Windows.Forms.Label();
            this.playerMana = new System.Windows.Forms.Label();
            this.npcMP = new System.Windows.Forms.Label();
            this.npcEnergy = new System.Windows.Forms.Label();
            this.npcHP = new System.Windows.Forms.Label();
            this.fightStartButton = new System.Windows.Forms.Button();
            this.combatText = new System.Windows.Forms.Label();
            this.playerStatsRecovery = new System.Windows.Forms.Timer(this.components);
            this.coolDownTimer = new System.Windows.Forms.Timer(this.components);
            this.npcCoolDownTimer = new System.Windows.Forms.Timer(this.components);
            this.npcAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.combatText2 = new System.Windows.Forms.Label();
            this.combatText3 = new System.Windows.Forms.Label();
            this.combatText4 = new System.Windows.Forms.Label();
            this.combatText5 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.combatText6 = new System.Windows.Forms.Label();
            this.aliveStatusCheck = new System.Windows.Forms.Timer(this.components);
            this.battleStatusTimers = new System.Windows.Forms.Timer(this.components);
            this.npcStatsRecovery = new System.Windows.Forms.Timer(this.components);
            this.KillButton = new System.Windows.Forms.Button();
            this.combatTextPanel = new System.Windows.Forms.Panel();
            this.actor1 = new System.Windows.Forms.PictureBox();
            this.actor2 = new System.Windows.Forms.PictureBox();
            this.actor3 = new System.Windows.Forms.PictureBox();
            this.actor4 = new System.Windows.Forms.PictureBox();
            this.actor5 = new System.Windows.Forms.PictureBox();
            this.actor6 = new System.Windows.Forms.PictureBox();
            this.actor7 = new System.Windows.Forms.PictureBox();
            this.actor8 = new System.Windows.Forms.PictureBox();
            this.actor9 = new System.Windows.Forms.PictureBox();
            this.actor10 = new System.Windows.Forms.PictureBox();
            this.actor11 = new System.Windows.Forms.PictureBox();
            this.event1 = new System.Windows.Forms.PictureBox();
            this.event2 = new System.Windows.Forms.PictureBox();
            this.event3 = new System.Windows.Forms.PictureBox();
            this.event4 = new System.Windows.Forms.PictureBox();
            this.event5 = new System.Windows.Forms.PictureBox();
            this.event6 = new System.Windows.Forms.PictureBox();
            this.event7 = new System.Windows.Forms.PictureBox();
            this.event8 = new System.Windows.Forms.PictureBox();
            this.event9 = new System.Windows.Forms.PictureBox();
            this.event10 = new System.Windows.Forms.PictureBox();
            this.event11 = new System.Windows.Forms.PictureBox();
            this.combatText11 = new System.Windows.Forms.Label();
            this.combatText10 = new System.Windows.Forms.Label();
            this.combatText9 = new System.Windows.Forms.Label();
            this.combatText8 = new System.Windows.Forms.Label();
            this.combatText7 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.characterEnergyBar = new System.Windows.Forms.PictureBox();
            this.characterManaBar = new System.Windows.Forms.PictureBox();
            this.characterHealthBar = new System.Windows.Forms.PictureBox();
            this.npcEnergyBar = new System.Windows.Forms.PictureBox();
            this.npcManaBar = new System.Windows.Forms.PictureBox();
            this.npcHealthBar = new System.Windows.Forms.PictureBox();
            this.indicatorsCheck = new System.Windows.Forms.Timer(this.components);
            this.skillsPanel = new System.Windows.Forms.Panel();
            this.skill5PseudoButton = new System.Windows.Forms.PictureBox();
            this.skill4PseudoButton = new System.Windows.Forms.PictureBox();
            this.skill1PseudoButton = new System.Windows.Forms.PictureBox();
            this.skill3PseudoButton = new System.Windows.Forms.PictureBox();
            this.skill2PseudoButton = new System.Windows.Forms.PictureBox();
            this.battleTitleLabel = new System.Windows.Forms.Label();
            this.combatPanelBackground = new System.Windows.Forms.Panel();
            this.restorePlayerHealthButton = new System.Windows.Forms.Button();
            this.coolDownsPanel = new System.Windows.Forms.Panel();
            this.coolDownPicBox5 = new System.Windows.Forms.PictureBox();
            this.coolDownPicBox1 = new System.Windows.Forms.PictureBox();
            this.coolDownPicBox4 = new System.Windows.Forms.PictureBox();
            this.coolDownPicBox2 = new System.Windows.Forms.PictureBox();
            this.coolDownPicBox3 = new System.Windows.Forms.PictureBox();
            this.coolDown1Text = new System.Windows.Forms.Label();
            this.coolDown2Text = new System.Windows.Forms.Label();
            this.coolDown3Text = new System.Windows.Forms.Label();
            this.coolDown4Text = new System.Windows.Forms.Label();
            this.coolDown5Text = new System.Windows.Forms.Label();
            this.lootPanel = new System.Windows.Forms.Panel();
            this.skillDescriptionPanel = new System.Windows.Forms.Panel();
            this.skillDescLevel = new System.Windows.Forms.Label();
            this.skillDescriptionDescription = new System.Windows.Forms.Label();
            this.skillDescriptionName = new System.Windows.Forms.Label();
            this.skillDescriptionImage = new System.Windows.Forms.PictureBox();
            this.playerDebuffsPanel = new System.Windows.Forms.Panel();
            this.playerDebuffPic1 = new System.Windows.Forms.PictureBox();
            this.playerDebuffPic5 = new System.Windows.Forms.PictureBox();
            this.playerDebuffPic2 = new System.Windows.Forms.PictureBox();
            this.playerDebuffPic3 = new System.Windows.Forms.PictureBox();
            this.playerDebuffPic4 = new System.Windows.Forms.PictureBox();
            this.playerDebuffduration = new System.Windows.Forms.Label();
            this.playerDebuff5duration = new System.Windows.Forms.Label();
            this.playerDebuff4duration = new System.Windows.Forms.Label();
            this.playerDebuff2duration = new System.Windows.Forms.Label();
            this.playerDebuff3duration = new System.Windows.Forms.Label();
            this.npcDebuff5duration = new System.Windows.Forms.Label();
            this.npcDebuff4duration = new System.Windows.Forms.Label();
            this.npcDebuff2duration = new System.Windows.Forms.Label();
            this.npcDebuff3duration = new System.Windows.Forms.Label();
            this.npcDebuff1duration = new System.Windows.Forms.Label();
            this.npcDebuffsPanel = new System.Windows.Forms.Panel();
            this.npcDebuffPic5 = new System.Windows.Forms.PictureBox();
            this.npcDebuffPic1 = new System.Windows.Forms.PictureBox();
            this.npcDebuffPic4 = new System.Windows.Forms.PictureBox();
            this.npcDebuffPic2 = new System.Windows.Forms.PictureBox();
            this.npcDebuffPic3 = new System.Windows.Forms.PictureBox();
            this.playerBarPanel = new System.Windows.Forms.Panel();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.levelPlayerBar = new System.Windows.Forms.Label();
            this.npcBarPanel = new System.Windows.Forms.Panel();
            this.npcIcon = new System.Windows.Forms.PictureBox();
            this.levelNPCBar = new System.Windows.Forms.Label();
            this.combatTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterEnergyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterManaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterHealthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcEnergyBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcManaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcHealthBar)).BeginInit();
            this.skillsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skill5PseudoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill4PseudoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1PseudoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3PseudoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2PseudoButton)).BeginInit();
            this.combatPanelBackground.SuspendLayout();
            this.coolDownsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox3)).BeginInit();
            this.skillDescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillDescriptionImage)).BeginInit();
            this.playerDebuffsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic4)).BeginInit();
            this.npcDebuffsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic3)).BeginInit();
            this.playerBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            this.npcBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // playerHealthP
            // 
            this.playerHealthP.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHealthP.ForeColor = System.Drawing.Color.White;
            this.playerHealthP.Location = new System.Drawing.Point(445, 175);
            this.playerHealthP.Name = "playerHealthP";
            this.playerHealthP.Size = new System.Drawing.Size(44, 22);
            this.playerHealthP.TabIndex = 5;
            this.playerHealthP.Text = "1000";
            this.playerHealthP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerEnergy
            // 
            this.playerEnergy.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerEnergy.ForeColor = System.Drawing.Color.White;
            this.playerEnergy.Location = new System.Drawing.Point(445, 221);
            this.playerEnergy.Name = "playerEnergy";
            this.playerEnergy.Size = new System.Drawing.Size(44, 22);
            this.playerEnergy.TabIndex = 6;
            this.playerEnergy.Text = "1000";
            this.playerEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerMana
            // 
            this.playerMana.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerMana.ForeColor = System.Drawing.Color.White;
            this.playerMana.Location = new System.Drawing.Point(445, 197);
            this.playerMana.Name = "playerMana";
            this.playerMana.Size = new System.Drawing.Size(44, 22);
            this.playerMana.TabIndex = 7;
            this.playerMana.Text = "1000";
            this.playerMana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcMP
            // 
            this.npcMP.BackColor = System.Drawing.Color.Transparent;
            this.npcMP.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcMP.ForeColor = System.Drawing.Color.White;
            this.npcMP.Location = new System.Drawing.Point(39, 200);
            this.npcMP.Name = "npcMP";
            this.npcMP.Size = new System.Drawing.Size(44, 22);
            this.npcMP.TabIndex = 35;
            this.npcMP.Text = "1000";
            this.npcMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcEnergy
            // 
            this.npcEnergy.BackColor = System.Drawing.Color.Transparent;
            this.npcEnergy.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcEnergy.ForeColor = System.Drawing.Color.White;
            this.npcEnergy.Location = new System.Drawing.Point(39, 225);
            this.npcEnergy.Name = "npcEnergy";
            this.npcEnergy.Size = new System.Drawing.Size(44, 22);
            this.npcEnergy.TabIndex = 34;
            this.npcEnergy.Text = "1000";
            this.npcEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcHP
            // 
            this.npcHP.BackColor = System.Drawing.Color.Transparent;
            this.npcHP.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcHP.ForeColor = System.Drawing.Color.White;
            this.npcHP.Location = new System.Drawing.Point(39, 178);
            this.npcHP.Name = "npcHP";
            this.npcHP.Size = new System.Drawing.Size(44, 22);
            this.npcHP.TabIndex = 33;
            this.npcHP.Text = "1000";
            this.npcHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fightStartButton
            // 
            this.fightStartButton.Location = new System.Drawing.Point(1126, 945);
            this.fightStartButton.Name = "fightStartButton";
            this.fightStartButton.Size = new System.Drawing.Size(79, 25);
            this.fightStartButton.TabIndex = 57;
            this.fightStartButton.Text = "Fight";
            this.fightStartButton.UseVisualStyleBackColor = true;
            this.fightStartButton.Click += new System.EventHandler(this.fightStartButton_Click);
            // 
            // combatText
            // 
            this.combatText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText.Location = new System.Drawing.Point(32, 290);
            this.combatText.Name = "combatText";
            this.combatText.Size = new System.Drawing.Size(389, 29);
            this.combatText.TabIndex = 58;
            this.combatText.Text = "ct";
            this.combatText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText.Visible = false;
            this.combatText.Click += new System.EventHandler(this.combatText_Click);
            // 
            // playerStatsRecovery
            // 
            this.playerStatsRecovery.Interval = 2000;
            this.playerStatsRecovery.Tick += new System.EventHandler(this.playerStatsRecovery_Tick);
            // 
            // coolDownTimer
            // 
            this.coolDownTimer.Tick += new System.EventHandler(this.coolDownTimer_Tick);
            // 
            // npcCoolDownTimer
            // 
            this.npcCoolDownTimer.Tick += new System.EventHandler(this.npcCoolDownTimer_Tick);
            // 
            // npcAttackTimer
            // 
            this.npcAttackTimer.Interval = 2000;
            this.npcAttackTimer.Tick += new System.EventHandler(this.npcAttackTimer_Tick);
            // 
            // combatText2
            // 
            this.combatText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText2.Location = new System.Drawing.Point(32, 261);
            this.combatText2.Name = "combatText2";
            this.combatText2.Size = new System.Drawing.Size(389, 29);
            this.combatText2.TabIndex = 64;
            this.combatText2.Text = "ct2";
            this.combatText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText2.Visible = false;
            // 
            // combatText3
            // 
            this.combatText3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText3.Cursor = System.Windows.Forms.Cursors.Default;
            this.combatText3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText3.Location = new System.Drawing.Point(32, 232);
            this.combatText3.Name = "combatText3";
            this.combatText3.Size = new System.Drawing.Size(389, 29);
            this.combatText3.TabIndex = 65;
            this.combatText3.Text = "ct3";
            this.combatText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText3.Visible = false;
            // 
            // combatText4
            // 
            this.combatText4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText4.Location = new System.Drawing.Point(32, 203);
            this.combatText4.Name = "combatText4";
            this.combatText4.Size = new System.Drawing.Size(389, 29);
            this.combatText4.TabIndex = 66;
            this.combatText4.Text = "ct4";
            this.combatText4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText4.Visible = false;
            // 
            // combatText5
            // 
            this.combatText5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText5.Location = new System.Drawing.Point(32, 174);
            this.combatText5.Name = "combatText5";
            this.combatText5.Size = new System.Drawing.Size(389, 29);
            this.combatText5.TabIndex = 67;
            this.combatText5.Text = "ct5";
            this.combatText5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText5.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(1296, 945);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(79, 25);
            this.restartButton.TabIndex = 68;
            this.restartButton.Text = "Play again";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // combatText6
            // 
            this.combatText6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText6.BackColor = System.Drawing.Color.Transparent;
            this.combatText6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText6.Location = new System.Drawing.Point(32, 145);
            this.combatText6.Name = "combatText6";
            this.combatText6.Size = new System.Drawing.Size(389, 29);
            this.combatText6.TabIndex = 69;
            this.combatText6.Text = "ct6";
            this.combatText6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText6.Visible = false;
            // 
            // aliveStatusCheck
            // 
            this.aliveStatusCheck.Tick += new System.EventHandler(this.aliveStatusCheck_Tick);
            // 
            // battleStatusTimers
            // 
            this.battleStatusTimers.Interval = 10;
            this.battleStatusTimers.Tick += new System.EventHandler(this.battleStatusTimers_Tick);
            // 
            // npcStatsRecovery
            // 
            this.npcStatsRecovery.Interval = 2000;
            this.npcStatsRecovery.Tick += new System.EventHandler(this.npcStatsRecovery_Tick);
            // 
            // KillButton
            // 
            this.KillButton.Location = new System.Drawing.Point(1211, 945);
            this.KillButton.Name = "KillButton";
            this.KillButton.Size = new System.Drawing.Size(79, 25);
            this.KillButton.TabIndex = 70;
            this.KillButton.Text = "Kill";
            this.KillButton.UseVisualStyleBackColor = true;
            this.KillButton.Click += new System.EventHandler(this.KillButton_Click);
            // 
            // combatTextPanel
            // 
            this.combatTextPanel.BackColor = System.Drawing.Color.Transparent;
            this.combatTextPanel.Controls.Add(this.actor1);
            this.combatTextPanel.Controls.Add(this.actor2);
            this.combatTextPanel.Controls.Add(this.actor3);
            this.combatTextPanel.Controls.Add(this.actor4);
            this.combatTextPanel.Controls.Add(this.actor5);
            this.combatTextPanel.Controls.Add(this.actor6);
            this.combatTextPanel.Controls.Add(this.actor7);
            this.combatTextPanel.Controls.Add(this.actor8);
            this.combatTextPanel.Controls.Add(this.actor9);
            this.combatTextPanel.Controls.Add(this.actor10);
            this.combatTextPanel.Controls.Add(this.actor11);
            this.combatTextPanel.Controls.Add(this.event1);
            this.combatTextPanel.Controls.Add(this.event2);
            this.combatTextPanel.Controls.Add(this.event3);
            this.combatTextPanel.Controls.Add(this.event4);
            this.combatTextPanel.Controls.Add(this.event5);
            this.combatTextPanel.Controls.Add(this.event6);
            this.combatTextPanel.Controls.Add(this.event7);
            this.combatTextPanel.Controls.Add(this.event8);
            this.combatTextPanel.Controls.Add(this.event9);
            this.combatTextPanel.Controls.Add(this.event10);
            this.combatTextPanel.Controls.Add(this.event11);
            this.combatTextPanel.Controls.Add(this.combatText11);
            this.combatTextPanel.Controls.Add(this.combatText10);
            this.combatTextPanel.Controls.Add(this.combatText9);
            this.combatTextPanel.Controls.Add(this.combatText8);
            this.combatTextPanel.Controls.Add(this.combatText7);
            this.combatTextPanel.Controls.Add(this.combatText6);
            this.combatTextPanel.Controls.Add(this.combatText4);
            this.combatTextPanel.Controls.Add(this.combatText5);
            this.combatTextPanel.Controls.Add(this.combatText3);
            this.combatTextPanel.Controls.Add(this.combatText);
            this.combatTextPanel.Controls.Add(this.combatText2);
            this.combatTextPanel.Location = new System.Drawing.Point(26, 30);
            this.combatTextPanel.Name = "combatTextPanel";
            this.combatTextPanel.Size = new System.Drawing.Size(563, 318);
            this.combatTextPanel.TabIndex = 78;
            // 
            // actor1
            // 
            this.actor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor1.Location = new System.Drawing.Point(444, 287);
            this.actor1.Name = "actor1";
            this.actor1.Size = new System.Drawing.Size(33, 29);
            this.actor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor1.TabIndex = 96;
            this.actor1.TabStop = false;
            // 
            // actor2
            // 
            this.actor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor2.Location = new System.Drawing.Point(444, 258);
            this.actor2.Name = "actor2";
            this.actor2.Size = new System.Drawing.Size(33, 29);
            this.actor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor2.TabIndex = 95;
            this.actor2.TabStop = false;
            // 
            // actor3
            // 
            this.actor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor3.Location = new System.Drawing.Point(444, 229);
            this.actor3.Name = "actor3";
            this.actor3.Size = new System.Drawing.Size(33, 29);
            this.actor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor3.TabIndex = 94;
            this.actor3.TabStop = false;
            // 
            // actor4
            // 
            this.actor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor4.Location = new System.Drawing.Point(444, 200);
            this.actor4.Name = "actor4";
            this.actor4.Size = new System.Drawing.Size(33, 29);
            this.actor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor4.TabIndex = 93;
            this.actor4.TabStop = false;
            // 
            // actor5
            // 
            this.actor5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor5.Location = new System.Drawing.Point(444, 171);
            this.actor5.Name = "actor5";
            this.actor5.Size = new System.Drawing.Size(33, 29);
            this.actor5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor5.TabIndex = 92;
            this.actor5.TabStop = false;
            // 
            // actor6
            // 
            this.actor6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor6.Location = new System.Drawing.Point(444, 142);
            this.actor6.Name = "actor6";
            this.actor6.Size = new System.Drawing.Size(33, 29);
            this.actor6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor6.TabIndex = 91;
            this.actor6.TabStop = false;
            // 
            // actor7
            // 
            this.actor7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor7.Location = new System.Drawing.Point(444, 113);
            this.actor7.Name = "actor7";
            this.actor7.Size = new System.Drawing.Size(33, 29);
            this.actor7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor7.TabIndex = 90;
            this.actor7.TabStop = false;
            // 
            // actor8
            // 
            this.actor8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor8.Location = new System.Drawing.Point(444, 86);
            this.actor8.Name = "actor8";
            this.actor8.Size = new System.Drawing.Size(33, 29);
            this.actor8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor8.TabIndex = 89;
            this.actor8.TabStop = false;
            // 
            // actor9
            // 
            this.actor9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor9.Location = new System.Drawing.Point(444, 57);
            this.actor9.Name = "actor9";
            this.actor9.Size = new System.Drawing.Size(33, 29);
            this.actor9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor9.TabIndex = 88;
            this.actor9.TabStop = false;
            // 
            // actor10
            // 
            this.actor10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor10.Location = new System.Drawing.Point(444, 28);
            this.actor10.Name = "actor10";
            this.actor10.Size = new System.Drawing.Size(33, 29);
            this.actor10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor10.TabIndex = 87;
            this.actor10.TabStop = false;
            // 
            // actor11
            // 
            this.actor11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actor11.InitialImage = ((System.Drawing.Image)(resources.GetObject("actor11.InitialImage")));
            this.actor11.Location = new System.Drawing.Point(444, 0);
            this.actor11.Name = "actor11";
            this.actor11.Size = new System.Drawing.Size(33, 29);
            this.actor11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.actor11.TabIndex = 86;
            this.actor11.TabStop = false;
            // 
            // event1
            // 
            this.event1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event1.Location = new System.Drawing.Point(478, 289);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(29, 26);
            this.event1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event1.TabIndex = 85;
            this.event1.TabStop = false;
            // 
            // event2
            // 
            this.event2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event2.Location = new System.Drawing.Point(478, 260);
            this.event2.Name = "event2";
            this.event2.Size = new System.Drawing.Size(29, 26);
            this.event2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event2.TabIndex = 84;
            this.event2.TabStop = false;
            // 
            // event3
            // 
            this.event3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event3.Location = new System.Drawing.Point(478, 231);
            this.event3.Name = "event3";
            this.event3.Size = new System.Drawing.Size(29, 26);
            this.event3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event3.TabIndex = 83;
            this.event3.TabStop = false;
            // 
            // event4
            // 
            this.event4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event4.Location = new System.Drawing.Point(478, 202);
            this.event4.Name = "event4";
            this.event4.Size = new System.Drawing.Size(29, 26);
            this.event4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event4.TabIndex = 82;
            this.event4.TabStop = false;
            // 
            // event5
            // 
            this.event5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event5.Location = new System.Drawing.Point(478, 173);
            this.event5.Name = "event5";
            this.event5.Size = new System.Drawing.Size(29, 26);
            this.event5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event5.TabIndex = 81;
            this.event5.TabStop = false;
            // 
            // event6
            // 
            this.event6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event6.Location = new System.Drawing.Point(478, 144);
            this.event6.Name = "event6";
            this.event6.Size = new System.Drawing.Size(29, 26);
            this.event6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event6.TabIndex = 80;
            this.event6.TabStop = false;
            // 
            // event7
            // 
            this.event7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event7.Location = new System.Drawing.Point(478, 115);
            this.event7.Name = "event7";
            this.event7.Size = new System.Drawing.Size(29, 26);
            this.event7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event7.TabIndex = 79;
            this.event7.TabStop = false;
            // 
            // event8
            // 
            this.event8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event8.Location = new System.Drawing.Point(478, 87);
            this.event8.Name = "event8";
            this.event8.Size = new System.Drawing.Size(29, 26);
            this.event8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event8.TabIndex = 78;
            this.event8.TabStop = false;
            // 
            // event9
            // 
            this.event9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event9.Location = new System.Drawing.Point(478, 59);
            this.event9.Name = "event9";
            this.event9.Size = new System.Drawing.Size(29, 26);
            this.event9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event9.TabIndex = 77;
            this.event9.TabStop = false;
            // 
            // event10
            // 
            this.event10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event10.Location = new System.Drawing.Point(478, 30);
            this.event10.Name = "event10";
            this.event10.Size = new System.Drawing.Size(29, 26);
            this.event10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event10.TabIndex = 76;
            this.event10.TabStop = false;
            // 
            // event11
            // 
            this.event11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.event11.Location = new System.Drawing.Point(478, 2);
            this.event11.Name = "event11";
            this.event11.Size = new System.Drawing.Size(29, 26);
            this.event11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.event11.TabIndex = 75;
            this.event11.TabStop = false;
            // 
            // combatText11
            // 
            this.combatText11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText11.BackColor = System.Drawing.Color.Transparent;
            this.combatText11.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText11.Location = new System.Drawing.Point(32, 3);
            this.combatText11.Name = "combatText11";
            this.combatText11.Size = new System.Drawing.Size(389, 29);
            this.combatText11.TabIndex = 74;
            this.combatText11.Text = "ct11";
            this.combatText11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText11.Visible = false;
            // 
            // combatText10
            // 
            this.combatText10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText10.BackColor = System.Drawing.Color.Transparent;
            this.combatText10.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText10.Location = new System.Drawing.Point(32, 31);
            this.combatText10.Name = "combatText10";
            this.combatText10.Size = new System.Drawing.Size(389, 29);
            this.combatText10.TabIndex = 73;
            this.combatText10.Text = "ct10";
            this.combatText10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText10.Visible = false;
            // 
            // combatText9
            // 
            this.combatText9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText9.BackColor = System.Drawing.Color.Transparent;
            this.combatText9.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText9.Location = new System.Drawing.Point(32, 60);
            this.combatText9.Name = "combatText9";
            this.combatText9.Size = new System.Drawing.Size(389, 29);
            this.combatText9.TabIndex = 72;
            this.combatText9.Text = "ct9";
            this.combatText9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText9.Visible = false;
            // 
            // combatText8
            // 
            this.combatText8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText8.BackColor = System.Drawing.Color.Transparent;
            this.combatText8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText8.Location = new System.Drawing.Point(32, 89);
            this.combatText8.Name = "combatText8";
            this.combatText8.Size = new System.Drawing.Size(389, 27);
            this.combatText8.TabIndex = 71;
            this.combatText8.Text = "ct8";
            this.combatText8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText8.Visible = false;
            // 
            // combatText7
            // 
            this.combatText7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.combatText7.BackColor = System.Drawing.Color.Transparent;
            this.combatText7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combatText7.Location = new System.Drawing.Point(32, 116);
            this.combatText7.Name = "combatText7";
            this.combatText7.Size = new System.Drawing.Size(389, 29);
            this.combatText7.TabIndex = 70;
            this.combatText7.Text = "ct7";
            this.combatText7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.combatText7.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.Location = new System.Drawing.Point(1392, 919);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(164, 49);
            this.menuButton.TabIndex = 101;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // characterEnergyBar
            // 
            this.characterEnergyBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("characterEnergyBar.BackgroundImage")));
            this.characterEnergyBar.InitialImage = null;
            this.characterEnergyBar.Location = new System.Drawing.Point(272, 225);
            this.characterEnergyBar.Name = "characterEnergyBar";
            this.characterEnergyBar.Size = new System.Drawing.Size(170, 22);
            this.characterEnergyBar.TabIndex = 108;
            this.characterEnergyBar.TabStop = false;
            // 
            // characterManaBar
            // 
            this.characterManaBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("characterManaBar.BackgroundImage")));
            this.characterManaBar.InitialImage = null;
            this.characterManaBar.Location = new System.Drawing.Point(272, 202);
            this.characterManaBar.Name = "characterManaBar";
            this.characterManaBar.Size = new System.Drawing.Size(170, 22);
            this.characterManaBar.TabIndex = 107;
            this.characterManaBar.TabStop = false;
            // 
            // characterHealthBar
            // 
            this.characterHealthBar.BackColor = System.Drawing.Color.Transparent;
            this.characterHealthBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("characterHealthBar.BackgroundImage")));
            this.characterHealthBar.InitialImage = null;
            this.characterHealthBar.Location = new System.Drawing.Point(272, 178);
            this.characterHealthBar.Name = "characterHealthBar";
            this.characterHealthBar.Size = new System.Drawing.Size(170, 22);
            this.characterHealthBar.TabIndex = 106;
            this.characterHealthBar.TabStop = false;
            // 
            // npcEnergyBar
            // 
            this.npcEnergyBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("npcEnergyBar.BackgroundImage")));
            this.npcEnergyBar.InitialImage = null;
            this.npcEnergyBar.Location = new System.Drawing.Point(89, 225);
            this.npcEnergyBar.Name = "npcEnergyBar";
            this.npcEnergyBar.Size = new System.Drawing.Size(170, 22);
            this.npcEnergyBar.TabIndex = 108;
            this.npcEnergyBar.TabStop = false;
            // 
            // npcManaBar
            // 
            this.npcManaBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("npcManaBar.BackgroundImage")));
            this.npcManaBar.InitialImage = null;
            this.npcManaBar.Location = new System.Drawing.Point(89, 202);
            this.npcManaBar.Name = "npcManaBar";
            this.npcManaBar.Size = new System.Drawing.Size(170, 22);
            this.npcManaBar.TabIndex = 107;
            this.npcManaBar.TabStop = false;
            // 
            // npcHealthBar
            // 
            this.npcHealthBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("npcHealthBar.BackgroundImage")));
            this.npcHealthBar.InitialImage = null;
            this.npcHealthBar.Location = new System.Drawing.Point(89, 178);
            this.npcHealthBar.Name = "npcHealthBar";
            this.npcHealthBar.Size = new System.Drawing.Size(170, 22);
            this.npcHealthBar.TabIndex = 106;
            this.npcHealthBar.TabStop = false;
            // 
            // indicatorsCheck
            // 
            this.indicatorsCheck.Interval = 10;
            this.indicatorsCheck.Tick += new System.EventHandler(this.indicatorsCheck_Tick);
            // 
            // skillsPanel
            // 
            this.skillsPanel.BackColor = System.Drawing.Color.Transparent;
            this.skillsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skillsPanel.BackgroundImage")));
            this.skillsPanel.Controls.Add(this.skill5PseudoButton);
            this.skillsPanel.Controls.Add(this.skill4PseudoButton);
            this.skillsPanel.Controls.Add(this.skill1PseudoButton);
            this.skillsPanel.Controls.Add(this.skill3PseudoButton);
            this.skillsPanel.Controls.Add(this.skill2PseudoButton);
            this.skillsPanel.Location = new System.Drawing.Point(695, 903);
            this.skillsPanel.Name = "skillsPanel";
            this.skillsPanel.Size = new System.Drawing.Size(298, 67);
            this.skillsPanel.TabIndex = 107;
            // 
            // skill5PseudoButton
            // 
            this.skill5PseudoButton.Image = ((System.Drawing.Image)(resources.GetObject("skill5PseudoButton.Image")));
            this.skill5PseudoButton.Location = new System.Drawing.Point(232, 9);
            this.skill5PseudoButton.Name = "skill5PseudoButton";
            this.skill5PseudoButton.Size = new System.Drawing.Size(54, 47);
            this.skill5PseudoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skill5PseudoButton.TabIndex = 113;
            this.skill5PseudoButton.TabStop = false;
            this.skill5PseudoButton.Click += new System.EventHandler(this.skill5PseudoButton_Click);
            this.skill5PseudoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skill5PseudoButton_MouseDown);
            this.skill5PseudoButton.MouseLeave += new System.EventHandler(this.skill5PseudoButton_MouseLeave);
            this.skill5PseudoButton.MouseHover += new System.EventHandler(this.skill5PseudoButton_MouseHover);
            this.skill5PseudoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skill5PseudoButton_MouseUp);
            // 
            // skill4PseudoButton
            // 
            this.skill4PseudoButton.Image = ((System.Drawing.Image)(resources.GetObject("skill4PseudoButton.Image")));
            this.skill4PseudoButton.Location = new System.Drawing.Point(176, 9);
            this.skill4PseudoButton.Name = "skill4PseudoButton";
            this.skill4PseudoButton.Size = new System.Drawing.Size(54, 47);
            this.skill4PseudoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skill4PseudoButton.TabIndex = 112;
            this.skill4PseudoButton.TabStop = false;
            this.skill4PseudoButton.Click += new System.EventHandler(this.skill4PseudoButton_Click);
            this.skill4PseudoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skill4PseudoButton_MouseDown);
            this.skill4PseudoButton.MouseLeave += new System.EventHandler(this.skill4PseudoButton_MouseLeave);
            this.skill4PseudoButton.MouseHover += new System.EventHandler(this.skill4PseudoButton_MouseHover);
            this.skill4PseudoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skill4PseudoButton_MouseUp);
            // 
            // skill1PseudoButton
            // 
            this.skill1PseudoButton.Image = ((System.Drawing.Image)(resources.GetObject("skill1PseudoButton.Image")));
            this.skill1PseudoButton.Location = new System.Drawing.Point(8, 9);
            this.skill1PseudoButton.Name = "skill1PseudoButton";
            this.skill1PseudoButton.Size = new System.Drawing.Size(54, 47);
            this.skill1PseudoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skill1PseudoButton.TabIndex = 108;
            this.skill1PseudoButton.TabStop = false;
            this.skill1PseudoButton.Click += new System.EventHandler(this.skill1PseudoButton_Click);
            this.skill1PseudoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skill1PseudoButton_MouseDown);
            this.skill1PseudoButton.MouseLeave += new System.EventHandler(this.skill1PseudoButton_MouseLeave);
            this.skill1PseudoButton.MouseHover += new System.EventHandler(this.skill1PseudoButton_MouseHover);
            this.skill1PseudoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skill1PseudoButton_MouseUp);
            // 
            // skill3PseudoButton
            // 
            this.skill3PseudoButton.Image = ((System.Drawing.Image)(resources.GetObject("skill3PseudoButton.Image")));
            this.skill3PseudoButton.Location = new System.Drawing.Point(120, 9);
            this.skill3PseudoButton.Name = "skill3PseudoButton";
            this.skill3PseudoButton.Size = new System.Drawing.Size(54, 47);
            this.skill3PseudoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skill3PseudoButton.TabIndex = 111;
            this.skill3PseudoButton.TabStop = false;
            this.skill3PseudoButton.Click += new System.EventHandler(this.skill3PseudoButton_Click);
            this.skill3PseudoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skill3PseudoButton_MouseDown);
            this.skill3PseudoButton.MouseLeave += new System.EventHandler(this.skill3PseudoButton_MouseLeave);
            this.skill3PseudoButton.MouseHover += new System.EventHandler(this.skill3PseudoButton_MouseHover);
            this.skill3PseudoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skill3PseudoButton_MouseUp);
            // 
            // skill2PseudoButton
            // 
            this.skill2PseudoButton.Image = ((System.Drawing.Image)(resources.GetObject("skill2PseudoButton.Image")));
            this.skill2PseudoButton.Location = new System.Drawing.Point(64, 9);
            this.skill2PseudoButton.Name = "skill2PseudoButton";
            this.skill2PseudoButton.Size = new System.Drawing.Size(54, 47);
            this.skill2PseudoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skill2PseudoButton.TabIndex = 110;
            this.skill2PseudoButton.TabStop = false;
            this.skill2PseudoButton.Click += new System.EventHandler(this.skill2PseudoButton_Click);
            this.skill2PseudoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skill2PseudoButton_MouseDown);
            this.skill2PseudoButton.MouseLeave += new System.EventHandler(this.skill2PseudoButton_MouseLeave);
            this.skill2PseudoButton.MouseHover += new System.EventHandler(this.skill2PseudoButton_MouseHover);
            this.skill2PseudoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skill2PseudoButton_MouseUp);
            // 
            // battleTitleLabel
            // 
            this.battleTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.battleTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.battleTitleLabel.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.battleTitleLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.battleTitleLabel.Image = ((System.Drawing.Image)(resources.GetObject("battleTitleLabel.Image")));
            this.battleTitleLabel.Location = new System.Drawing.Point(546, 348);
            this.battleTitleLabel.Name = "battleTitleLabel";
            this.battleTitleLabel.Size = new System.Drawing.Size(605, 84);
            this.battleTitleLabel.TabIndex = 115;
            this.battleTitleLabel.Text = "Player vs NPC";
            this.battleTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combatPanelBackground
            // 
            this.combatPanelBackground.BackColor = System.Drawing.Color.Transparent;
            this.combatPanelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("combatPanelBackground.BackgroundImage")));
            this.combatPanelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.combatPanelBackground.Controls.Add(this.combatTextPanel);
            this.combatPanelBackground.Location = new System.Drawing.Point(546, 435);
            this.combatPanelBackground.Name = "combatPanelBackground";
            this.combatPanelBackground.Size = new System.Drawing.Size(608, 381);
            this.combatPanelBackground.TabIndex = 116;
            // 
            // restorePlayerHealthButton
            // 
            this.restorePlayerHealthButton.Location = new System.Drawing.Point(1041, 945);
            this.restorePlayerHealthButton.Name = "restorePlayerHealthButton";
            this.restorePlayerHealthButton.Size = new System.Drawing.Size(79, 25);
            this.restorePlayerHealthButton.TabIndex = 117;
            this.restorePlayerHealthButton.Text = "Restore HP";
            this.restorePlayerHealthButton.UseVisualStyleBackColor = true;
            this.restorePlayerHealthButton.Click += new System.EventHandler(this.restorePlayerHealthButton_Click);
            // 
            // coolDownsPanel
            // 
            this.coolDownsPanel.BackColor = System.Drawing.Color.Transparent;
            this.coolDownsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coolDownsPanel.BackgroundImage")));
            this.coolDownsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolDownsPanel.Controls.Add(this.coolDownPicBox5);
            this.coolDownsPanel.Controls.Add(this.coolDownPicBox1);
            this.coolDownsPanel.Controls.Add(this.coolDownPicBox4);
            this.coolDownsPanel.Controls.Add(this.coolDownPicBox2);
            this.coolDownsPanel.Controls.Add(this.coolDownPicBox3);
            this.coolDownsPanel.Location = new System.Drawing.Point(742, 856);
            this.coolDownsPanel.Name = "coolDownsPanel";
            this.coolDownsPanel.Size = new System.Drawing.Size(200, 47);
            this.coolDownsPanel.TabIndex = 118;
            this.coolDownsPanel.Visible = false;
            // 
            // coolDownPicBox5
            // 
            this.coolDownPicBox5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coolDownPicBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolDownPicBox5.Location = new System.Drawing.Point(158, 7);
            this.coolDownPicBox5.Name = "coolDownPicBox5";
            this.coolDownPicBox5.Size = new System.Drawing.Size(37, 33);
            this.coolDownPicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coolDownPicBox5.TabIndex = 123;
            this.coolDownPicBox5.TabStop = false;
            this.coolDownPicBox5.Visible = false;
            this.coolDownPicBox5.MouseLeave += new System.EventHandler(this.coolDownPicBox5_MouseLeave);
            this.coolDownPicBox5.MouseHover += new System.EventHandler(this.coolDownPicBox5_MouseHover);
            // 
            // coolDownPicBox1
            // 
            this.coolDownPicBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coolDownPicBox1.Location = new System.Drawing.Point(6, 7);
            this.coolDownPicBox1.Name = "coolDownPicBox1";
            this.coolDownPicBox1.Size = new System.Drawing.Size(37, 33);
            this.coolDownPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coolDownPicBox1.TabIndex = 119;
            this.coolDownPicBox1.TabStop = false;
            this.coolDownPicBox1.Visible = false;
            this.coolDownPicBox1.MouseLeave += new System.EventHandler(this.coolDownPicBox1_MouseLeave);
            this.coolDownPicBox1.MouseHover += new System.EventHandler(this.coolDownPicBox1_MouseHover);
            // 
            // coolDownPicBox4
            // 
            this.coolDownPicBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coolDownPicBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolDownPicBox4.Location = new System.Drawing.Point(120, 7);
            this.coolDownPicBox4.Name = "coolDownPicBox4";
            this.coolDownPicBox4.Size = new System.Drawing.Size(37, 33);
            this.coolDownPicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coolDownPicBox4.TabIndex = 122;
            this.coolDownPicBox4.TabStop = false;
            this.coolDownPicBox4.Visible = false;
            this.coolDownPicBox4.MouseLeave += new System.EventHandler(this.coolDownPicBox4_MouseLeave);
            this.coolDownPicBox4.MouseHover += new System.EventHandler(this.coolDownPicBox4_MouseHover);
            // 
            // coolDownPicBox2
            // 
            this.coolDownPicBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coolDownPicBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolDownPicBox2.Location = new System.Drawing.Point(44, 7);
            this.coolDownPicBox2.Name = "coolDownPicBox2";
            this.coolDownPicBox2.Size = new System.Drawing.Size(37, 33);
            this.coolDownPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coolDownPicBox2.TabIndex = 120;
            this.coolDownPicBox2.TabStop = false;
            this.coolDownPicBox2.Visible = false;
            this.coolDownPicBox2.MouseLeave += new System.EventHandler(this.coolDownPicBox2_MouseLeave);
            this.coolDownPicBox2.MouseHover += new System.EventHandler(this.coolDownPicBox2_MouseHover);
            // 
            // coolDownPicBox3
            // 
            this.coolDownPicBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coolDownPicBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolDownPicBox3.Location = new System.Drawing.Point(82, 7);
            this.coolDownPicBox3.Name = "coolDownPicBox3";
            this.coolDownPicBox3.Size = new System.Drawing.Size(37, 33);
            this.coolDownPicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coolDownPicBox3.TabIndex = 121;
            this.coolDownPicBox3.TabStop = false;
            this.coolDownPicBox3.Visible = false;
            this.coolDownPicBox3.MouseLeave += new System.EventHandler(this.coolDownPicBox3_MouseLeave);
            this.coolDownPicBox3.MouseHover += new System.EventHandler(this.coolDownPicBox3_MouseHover);
            // 
            // coolDown1Text
            // 
            this.coolDown1Text.BackColor = System.Drawing.Color.Transparent;
            this.coolDown1Text.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolDown1Text.ForeColor = System.Drawing.SystemColors.Control;
            this.coolDown1Text.Image = ((System.Drawing.Image)(resources.GetObject("coolDown1Text.Image")));
            this.coolDown1Text.Location = new System.Drawing.Point(748, 819);
            this.coolDown1Text.Name = "coolDown1Text";
            this.coolDown1Text.Size = new System.Drawing.Size(37, 34);
            this.coolDown1Text.TabIndex = 119;
            this.coolDown1Text.Text = "0.0";
            this.coolDown1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coolDown1Text.Visible = false;
            // 
            // coolDown2Text
            // 
            this.coolDown2Text.BackColor = System.Drawing.Color.Transparent;
            this.coolDown2Text.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolDown2Text.ForeColor = System.Drawing.SystemColors.Control;
            this.coolDown2Text.Image = ((System.Drawing.Image)(resources.GetObject("coolDown2Text.Image")));
            this.coolDown2Text.Location = new System.Drawing.Point(786, 819);
            this.coolDown2Text.Name = "coolDown2Text";
            this.coolDown2Text.Size = new System.Drawing.Size(37, 34);
            this.coolDown2Text.TabIndex = 120;
            this.coolDown2Text.Text = "0.0";
            this.coolDown2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coolDown2Text.Visible = false;
            // 
            // coolDown3Text
            // 
            this.coolDown3Text.BackColor = System.Drawing.Color.Transparent;
            this.coolDown3Text.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolDown3Text.ForeColor = System.Drawing.SystemColors.Control;
            this.coolDown3Text.Image = ((System.Drawing.Image)(resources.GetObject("coolDown3Text.Image")));
            this.coolDown3Text.Location = new System.Drawing.Point(824, 819);
            this.coolDown3Text.Name = "coolDown3Text";
            this.coolDown3Text.Size = new System.Drawing.Size(37, 34);
            this.coolDown3Text.TabIndex = 121;
            this.coolDown3Text.Text = "0.0";
            this.coolDown3Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coolDown3Text.Visible = false;
            // 
            // coolDown4Text
            // 
            this.coolDown4Text.BackColor = System.Drawing.Color.Transparent;
            this.coolDown4Text.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolDown4Text.ForeColor = System.Drawing.SystemColors.Control;
            this.coolDown4Text.Image = ((System.Drawing.Image)(resources.GetObject("coolDown4Text.Image")));
            this.coolDown4Text.Location = new System.Drawing.Point(862, 819);
            this.coolDown4Text.Name = "coolDown4Text";
            this.coolDown4Text.Size = new System.Drawing.Size(37, 34);
            this.coolDown4Text.TabIndex = 122;
            this.coolDown4Text.Text = "0.0";
            this.coolDown4Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coolDown4Text.Visible = false;
            // 
            // coolDown5Text
            // 
            this.coolDown5Text.BackColor = System.Drawing.Color.Transparent;
            this.coolDown5Text.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coolDown5Text.ForeColor = System.Drawing.SystemColors.Control;
            this.coolDown5Text.Image = ((System.Drawing.Image)(resources.GetObject("coolDown5Text.Image")));
            this.coolDown5Text.Location = new System.Drawing.Point(900, 819);
            this.coolDown5Text.Name = "coolDown5Text";
            this.coolDown5Text.Size = new System.Drawing.Size(37, 34);
            this.coolDown5Text.TabIndex = 123;
            this.coolDown5Text.Text = "0.0";
            this.coolDown5Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coolDown5Text.Visible = false;
            // 
            // lootPanel
            // 
            this.lootPanel.BackColor = System.Drawing.Color.Transparent;
            this.lootPanel.Location = new System.Drawing.Point(742, 43);
            this.lootPanel.Name = "lootPanel";
            this.lootPanel.Size = new System.Drawing.Size(200, 260);
            this.lootPanel.TabIndex = 124;
            // 
            // skillDescriptionPanel
            // 
            this.skillDescriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.skillDescriptionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skillDescriptionPanel.BackgroundImage")));
            this.skillDescriptionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skillDescriptionPanel.Controls.Add(this.skillDescLevel);
            this.skillDescriptionPanel.Controls.Add(this.skillDescriptionDescription);
            this.skillDescriptionPanel.Controls.Add(this.skillDescriptionName);
            this.skillDescriptionPanel.Controls.Add(this.skillDescriptionImage);
            this.skillDescriptionPanel.Location = new System.Drawing.Point(12, 817);
            this.skillDescriptionPanel.Name = "skillDescriptionPanel";
            this.skillDescriptionPanel.Size = new System.Drawing.Size(393, 153);
            this.skillDescriptionPanel.TabIndex = 125;
            this.skillDescriptionPanel.Visible = false;
            // 
            // skillDescLevel
            // 
            this.skillDescLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillDescLevel.BackColor = System.Drawing.Color.Transparent;
            this.skillDescLevel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillDescLevel.Location = new System.Drawing.Point(78, 45);
            this.skillDescLevel.Name = "skillDescLevel";
            this.skillDescLevel.Size = new System.Drawing.Size(246, 23);
            this.skillDescLevel.TabIndex = 127;
            this.skillDescLevel.Text = "Lvl.1";
            this.skillDescLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skillDescriptionDescription
            // 
            this.skillDescriptionDescription.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillDescriptionDescription.Location = new System.Drawing.Point(14, 69);
            this.skillDescriptionDescription.Name = "skillDescriptionDescription";
            this.skillDescriptionDescription.Size = new System.Drawing.Size(364, 76);
            this.skillDescriptionDescription.TabIndex = 126;
            this.skillDescriptionDescription.Text = resources.GetString("skillDescriptionDescription.Text");
            // 
            // skillDescriptionName
            // 
            this.skillDescriptionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skillDescriptionName.BackColor = System.Drawing.Color.Transparent;
            this.skillDescriptionName.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillDescriptionName.Location = new System.Drawing.Point(76, 15);
            this.skillDescriptionName.Name = "skillDescriptionName";
            this.skillDescriptionName.Size = new System.Drawing.Size(304, 35);
            this.skillDescriptionName.TabIndex = 126;
            this.skillDescriptionName.Text = "Skill Description";
            this.skillDescriptionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skillDescriptionImage
            // 
            this.skillDescriptionImage.Image = ((System.Drawing.Image)(resources.GetObject("skillDescriptionImage.Image")));
            this.skillDescriptionImage.Location = new System.Drawing.Point(18, 22);
            this.skillDescriptionImage.Name = "skillDescriptionImage";
            this.skillDescriptionImage.Size = new System.Drawing.Size(54, 47);
            this.skillDescriptionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skillDescriptionImage.TabIndex = 114;
            this.skillDescriptionImage.TabStop = false;
            // 
            // playerDebuffsPanel
            // 
            this.playerDebuffsPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuffsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerDebuffsPanel.BackgroundImage")));
            this.playerDebuffsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerDebuffsPanel.Controls.Add(this.playerDebuffPic1);
            this.playerDebuffsPanel.Controls.Add(this.playerDebuffPic5);
            this.playerDebuffsPanel.Controls.Add(this.playerDebuffPic2);
            this.playerDebuffsPanel.Controls.Add(this.playerDebuffPic3);
            this.playerDebuffsPanel.Controls.Add(this.playerDebuffPic4);
            this.playerDebuffsPanel.Location = new System.Drawing.Point(316, 277);
            this.playerDebuffsPanel.Name = "playerDebuffsPanel";
            this.playerDebuffsPanel.Size = new System.Drawing.Size(200, 47);
            this.playerDebuffsPanel.TabIndex = 124;
            this.playerDebuffsPanel.Visible = false;
            // 
            // playerDebuffPic1
            // 
            this.playerDebuffPic1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerDebuffPic1.Location = new System.Drawing.Point(6, 7);
            this.playerDebuffPic1.Name = "playerDebuffPic1";
            this.playerDebuffPic1.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDebuffPic1.TabIndex = 119;
            this.playerDebuffPic1.TabStop = false;
            this.playerDebuffPic1.Visible = false;
            this.playerDebuffPic1.MouseLeave += new System.EventHandler(this.playerDebuffPic1_MouseLeave);
            this.playerDebuffPic1.MouseHover += new System.EventHandler(this.playerDebuffPic1_MouseHover);
            // 
            // playerDebuffPic5
            // 
            this.playerDebuffPic5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerDebuffPic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerDebuffPic5.Location = new System.Drawing.Point(158, 7);
            this.playerDebuffPic5.Name = "playerDebuffPic5";
            this.playerDebuffPic5.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDebuffPic5.TabIndex = 123;
            this.playerDebuffPic5.TabStop = false;
            this.playerDebuffPic5.Visible = false;
            this.playerDebuffPic5.MouseHover += new System.EventHandler(this.playerDebuffPic5_MouseHover);
            // 
            // playerDebuffPic2
            // 
            this.playerDebuffPic2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerDebuffPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerDebuffPic2.Location = new System.Drawing.Point(44, 7);
            this.playerDebuffPic2.Name = "playerDebuffPic2";
            this.playerDebuffPic2.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDebuffPic2.TabIndex = 120;
            this.playerDebuffPic2.TabStop = false;
            this.playerDebuffPic2.Visible = false;
            this.playerDebuffPic2.MouseHover += new System.EventHandler(this.playerDebuffPic2_MouseHover);
            // 
            // playerDebuffPic3
            // 
            this.playerDebuffPic3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerDebuffPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerDebuffPic3.Location = new System.Drawing.Point(82, 7);
            this.playerDebuffPic3.Name = "playerDebuffPic3";
            this.playerDebuffPic3.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDebuffPic3.TabIndex = 121;
            this.playerDebuffPic3.TabStop = false;
            this.playerDebuffPic3.Visible = false;
            this.playerDebuffPic3.MouseHover += new System.EventHandler(this.playerDebuffPic3_MouseHover);
            // 
            // playerDebuffPic4
            // 
            this.playerDebuffPic4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerDebuffPic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerDebuffPic4.Location = new System.Drawing.Point(120, 7);
            this.playerDebuffPic4.Name = "playerDebuffPic4";
            this.playerDebuffPic4.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDebuffPic4.TabIndex = 122;
            this.playerDebuffPic4.TabStop = false;
            this.playerDebuffPic4.Visible = false;
            this.playerDebuffPic4.MouseHover += new System.EventHandler(this.playerDebuffPic4_MouseHover);
            // 
            // playerDebuffduration
            // 
            this.playerDebuffduration.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuffduration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDebuffduration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerDebuffduration.Image = ((System.Drawing.Image)(resources.GetObject("playerDebuffduration.Image")));
            this.playerDebuffduration.Location = new System.Drawing.Point(334, 339);
            this.playerDebuffduration.Name = "playerDebuffduration";
            this.playerDebuffduration.Size = new System.Drawing.Size(37, 33);
            this.playerDebuffduration.TabIndex = 128;
            this.playerDebuffduration.Text = "0.0";
            this.playerDebuffduration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerDebuffduration.Visible = false;
            // 
            // playerDebuff5duration
            // 
            this.playerDebuff5duration.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuff5duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDebuff5duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerDebuff5duration.Image = ((System.Drawing.Image)(resources.GetObject("playerDebuff5duration.Image")));
            this.playerDebuff5duration.Location = new System.Drawing.Point(489, 339);
            this.playerDebuff5duration.Name = "playerDebuff5duration";
            this.playerDebuff5duration.Size = new System.Drawing.Size(37, 34);
            this.playerDebuff5duration.TabIndex = 132;
            this.playerDebuff5duration.Text = "0.0";
            this.playerDebuff5duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerDebuff5duration.Visible = false;
            // 
            // playerDebuff4duration
            // 
            this.playerDebuff4duration.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuff4duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDebuff4duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerDebuff4duration.Image = ((System.Drawing.Image)(resources.GetObject("playerDebuff4duration.Image")));
            this.playerDebuff4duration.Location = new System.Drawing.Point(448, 339);
            this.playerDebuff4duration.Name = "playerDebuff4duration";
            this.playerDebuff4duration.Size = new System.Drawing.Size(37, 33);
            this.playerDebuff4duration.TabIndex = 131;
            this.playerDebuff4duration.Text = "0.0";
            this.playerDebuff4duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerDebuff4duration.Visible = false;
            // 
            // playerDebuff2duration
            // 
            this.playerDebuff2duration.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuff2duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDebuff2duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerDebuff2duration.Image = ((System.Drawing.Image)(resources.GetObject("playerDebuff2duration.Image")));
            this.playerDebuff2duration.Location = new System.Drawing.Point(372, 339);
            this.playerDebuff2duration.Name = "playerDebuff2duration";
            this.playerDebuff2duration.Size = new System.Drawing.Size(37, 33);
            this.playerDebuff2duration.TabIndex = 130;
            this.playerDebuff2duration.Text = "0.0";
            this.playerDebuff2duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerDebuff2duration.Visible = false;
            // 
            // playerDebuff3duration
            // 
            this.playerDebuff3duration.BackColor = System.Drawing.Color.Transparent;
            this.playerDebuff3duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerDebuff3duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playerDebuff3duration.Image = ((System.Drawing.Image)(resources.GetObject("playerDebuff3duration.Image")));
            this.playerDebuff3duration.Location = new System.Drawing.Point(410, 339);
            this.playerDebuff3duration.Name = "playerDebuff3duration";
            this.playerDebuff3duration.Size = new System.Drawing.Size(37, 33);
            this.playerDebuff3duration.TabIndex = 129;
            this.playerDebuff3duration.Text = "0.0";
            this.playerDebuff3duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerDebuff3duration.Visible = false;
            // 
            // npcDebuff5duration
            // 
            this.npcDebuff5duration.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuff5duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcDebuff5duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.npcDebuff5duration.Image = ((System.Drawing.Image)(resources.GetObject("npcDebuff5duration.Image")));
            this.npcDebuff5duration.Location = new System.Drawing.Point(1309, 339);
            this.npcDebuff5duration.Name = "npcDebuff5duration";
            this.npcDebuff5duration.Size = new System.Drawing.Size(37, 34);
            this.npcDebuff5duration.TabIndex = 138;
            this.npcDebuff5duration.Text = "0.0";
            this.npcDebuff5duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcDebuff5duration.Visible = false;
            // 
            // npcDebuff4duration
            // 
            this.npcDebuff4duration.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuff4duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcDebuff4duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.npcDebuff4duration.Image = ((System.Drawing.Image)(resources.GetObject("npcDebuff4duration.Image")));
            this.npcDebuff4duration.Location = new System.Drawing.Point(1271, 339);
            this.npcDebuff4duration.Name = "npcDebuff4duration";
            this.npcDebuff4duration.Size = new System.Drawing.Size(37, 34);
            this.npcDebuff4duration.TabIndex = 137;
            this.npcDebuff4duration.Text = "0.0";
            this.npcDebuff4duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcDebuff4duration.Visible = false;
            // 
            // npcDebuff2duration
            // 
            this.npcDebuff2duration.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuff2duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcDebuff2duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.npcDebuff2duration.Image = ((System.Drawing.Image)(resources.GetObject("npcDebuff2duration.Image")));
            this.npcDebuff2duration.Location = new System.Drawing.Point(1195, 339);
            this.npcDebuff2duration.Name = "npcDebuff2duration";
            this.npcDebuff2duration.Size = new System.Drawing.Size(37, 34);
            this.npcDebuff2duration.TabIndex = 136;
            this.npcDebuff2duration.Text = "0.0";
            this.npcDebuff2duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcDebuff2duration.Visible = false;
            // 
            // npcDebuff3duration
            // 
            this.npcDebuff3duration.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuff3duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcDebuff3duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.npcDebuff3duration.Image = ((System.Drawing.Image)(resources.GetObject("npcDebuff3duration.Image")));
            this.npcDebuff3duration.Location = new System.Drawing.Point(1233, 339);
            this.npcDebuff3duration.Name = "npcDebuff3duration";
            this.npcDebuff3duration.Size = new System.Drawing.Size(37, 34);
            this.npcDebuff3duration.TabIndex = 135;
            this.npcDebuff3duration.Text = "0.0";
            this.npcDebuff3duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcDebuff3duration.Visible = false;
            // 
            // npcDebuff1duration
            // 
            this.npcDebuff1duration.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuff1duration.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npcDebuff1duration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.npcDebuff1duration.Image = ((System.Drawing.Image)(resources.GetObject("npcDebuff1duration.Image")));
            this.npcDebuff1duration.Location = new System.Drawing.Point(1157, 339);
            this.npcDebuff1duration.Name = "npcDebuff1duration";
            this.npcDebuff1duration.Size = new System.Drawing.Size(37, 34);
            this.npcDebuff1duration.TabIndex = 134;
            this.npcDebuff1duration.Text = "0.0";
            this.npcDebuff1duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npcDebuff1duration.Visible = false;
            // 
            // npcDebuffsPanel
            // 
            this.npcDebuffsPanel.BackColor = System.Drawing.Color.Transparent;
            this.npcDebuffsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("npcDebuffsPanel.BackgroundImage")));
            this.npcDebuffsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcDebuffsPanel.Controls.Add(this.npcDebuffPic5);
            this.npcDebuffsPanel.Controls.Add(this.npcDebuffPic1);
            this.npcDebuffsPanel.Controls.Add(this.npcDebuffPic4);
            this.npcDebuffsPanel.Controls.Add(this.npcDebuffPic2);
            this.npcDebuffsPanel.Controls.Add(this.npcDebuffPic3);
            this.npcDebuffsPanel.Location = new System.Drawing.Point(17, 277);
            this.npcDebuffsPanel.Name = "npcDebuffsPanel";
            this.npcDebuffsPanel.Size = new System.Drawing.Size(200, 47);
            this.npcDebuffsPanel.TabIndex = 133;
            this.npcDebuffsPanel.Visible = false;
            // 
            // npcDebuffPic5
            // 
            this.npcDebuffPic5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.npcDebuffPic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcDebuffPic5.Location = new System.Drawing.Point(158, 7);
            this.npcDebuffPic5.Name = "npcDebuffPic5";
            this.npcDebuffPic5.Size = new System.Drawing.Size(37, 33);
            this.npcDebuffPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npcDebuffPic5.TabIndex = 123;
            this.npcDebuffPic5.TabStop = false;
            this.npcDebuffPic5.Visible = false;
            this.npcDebuffPic5.MouseLeave += new System.EventHandler(this.npcDebuffPic5_MouseLeave);
            this.npcDebuffPic5.MouseHover += new System.EventHandler(this.npcDebuffPic5_MouseHover);
            // 
            // npcDebuffPic1
            // 
            this.npcDebuffPic1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.npcDebuffPic1.Location = new System.Drawing.Point(6, 7);
            this.npcDebuffPic1.Name = "npcDebuffPic1";
            this.npcDebuffPic1.Size = new System.Drawing.Size(37, 33);
            this.npcDebuffPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npcDebuffPic1.TabIndex = 119;
            this.npcDebuffPic1.TabStop = false;
            this.npcDebuffPic1.Visible = false;
            this.npcDebuffPic1.MouseLeave += new System.EventHandler(this.npcDebuffPic1_MouseLeave);
            this.npcDebuffPic1.MouseHover += new System.EventHandler(this.npcDebuffPic1_MouseHover);
            // 
            // npcDebuffPic4
            // 
            this.npcDebuffPic4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.npcDebuffPic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcDebuffPic4.Location = new System.Drawing.Point(120, 7);
            this.npcDebuffPic4.Name = "npcDebuffPic4";
            this.npcDebuffPic4.Size = new System.Drawing.Size(37, 33);
            this.npcDebuffPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npcDebuffPic4.TabIndex = 122;
            this.npcDebuffPic4.TabStop = false;
            this.npcDebuffPic4.Visible = false;
            // 
            // npcDebuffPic2
            // 
            this.npcDebuffPic2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.npcDebuffPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcDebuffPic2.Location = new System.Drawing.Point(44, 7);
            this.npcDebuffPic2.Name = "npcDebuffPic2";
            this.npcDebuffPic2.Size = new System.Drawing.Size(37, 33);
            this.npcDebuffPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npcDebuffPic2.TabIndex = 120;
            this.npcDebuffPic2.TabStop = false;
            this.npcDebuffPic2.Visible = false;
            // 
            // npcDebuffPic3
            // 
            this.npcDebuffPic3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.npcDebuffPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcDebuffPic3.Location = new System.Drawing.Point(82, 7);
            this.npcDebuffPic3.Name = "npcDebuffPic3";
            this.npcDebuffPic3.Size = new System.Drawing.Size(37, 33);
            this.npcDebuffPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.npcDebuffPic3.TabIndex = 121;
            this.npcDebuffPic3.TabStop = false;
            this.npcDebuffPic3.Visible = false;
            this.npcDebuffPic3.MouseLeave += new System.EventHandler(this.npcDebuffPic3_MouseLeave);
            this.npcDebuffPic3.MouseHover += new System.EventHandler(this.npcDebuffPic3_MouseHover);
            // 
            // playerBarPanel
            // 
            this.playerBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerBarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerBarPanel.BackgroundImage")));
            this.playerBarPanel.Controls.Add(this.playerIcon);
            this.playerBarPanel.Controls.Add(this.levelPlayerBar);
            this.playerBarPanel.Controls.Add(this.playerEnergy);
            this.playerBarPanel.Controls.Add(this.playerMana);
            this.playerBarPanel.Controls.Add(this.playerHealthP);
            this.playerBarPanel.Controls.Add(this.characterEnergyBar);
            this.playerBarPanel.Controls.Add(this.characterHealthBar);
            this.playerBarPanel.Controls.Add(this.characterManaBar);
            this.playerBarPanel.Controls.Add(this.playerDebuffsPanel);
            this.playerBarPanel.Location = new System.Drawing.Point(12, 12);
            this.playerBarPanel.Name = "playerBarPanel";
            this.playerBarPanel.Size = new System.Drawing.Size(534, 324);
            this.playerBarPanel.TabIndex = 140;
            // 
            // playerIcon
            // 
            this.playerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerIcon.Location = new System.Drawing.Point(142, 162);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(106, 95);
            this.playerIcon.TabIndex = 110;
            this.playerIcon.TabStop = false;
            // 
            // levelPlayerBar
            // 
            this.levelPlayerBar.BackColor = System.Drawing.Color.Transparent;
            this.levelPlayerBar.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelPlayerBar.ForeColor = System.Drawing.Color.Black;
            this.levelPlayerBar.Location = new System.Drawing.Point(71, 195);
            this.levelPlayerBar.Name = "levelPlayerBar";
            this.levelPlayerBar.Size = new System.Drawing.Size(40, 26);
            this.levelPlayerBar.TabIndex = 109;
            this.levelPlayerBar.Text = "100";
            this.levelPlayerBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcBarPanel
            // 
            this.npcBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.npcBarPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("npcBarPanel.BackgroundImage")));
            this.npcBarPanel.Controls.Add(this.npcIcon);
            this.npcBarPanel.Controls.Add(this.levelNPCBar);
            this.npcBarPanel.Controls.Add(this.npcHealthBar);
            this.npcBarPanel.Controls.Add(this.npcEnergy);
            this.npcBarPanel.Controls.Add(this.npcManaBar);
            this.npcBarPanel.Controls.Add(this.npcMP);
            this.npcBarPanel.Controls.Add(this.npcHP);
            this.npcBarPanel.Controls.Add(this.npcEnergyBar);
            this.npcBarPanel.Controls.Add(this.npcDebuffsPanel);
            this.npcBarPanel.Location = new System.Drawing.Point(1134, 12);
            this.npcBarPanel.Name = "npcBarPanel";
            this.npcBarPanel.Size = new System.Drawing.Size(534, 324);
            this.npcBarPanel.TabIndex = 141;
            // 
            // npcIcon
            // 
            this.npcIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.npcIcon.ImageLocation = "";
            this.npcIcon.Location = new System.Drawing.Point(284, 162);
            this.npcIcon.Name = "npcIcon";
            this.npcIcon.Size = new System.Drawing.Size(106, 95);
            this.npcIcon.TabIndex = 125;
            this.npcIcon.TabStop = false;
            // 
            // levelNPCBar
            // 
            this.levelNPCBar.BackColor = System.Drawing.Color.Transparent;
            this.levelNPCBar.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelNPCBar.ForeColor = System.Drawing.Color.Black;
            this.levelNPCBar.Location = new System.Drawing.Point(429, 195);
            this.levelNPCBar.Name = "levelNPCBar";
            this.levelNPCBar.Size = new System.Drawing.Size(40, 26);
            this.levelNPCBar.TabIndex = 110;
            this.levelNPCBar.Text = "100";
            this.levelNPCBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 980);
            this.ControlBox = false;
            this.Controls.Add(this.npcBarPanel);
            this.Controls.Add(this.playerBarPanel);
            this.Controls.Add(this.npcDebuff5duration);
            this.Controls.Add(this.playerDebuffduration);
            this.Controls.Add(this.playerDebuff5duration);
            this.Controls.Add(this.npcDebuff4duration);
            this.Controls.Add(this.playerDebuff4duration);
            this.Controls.Add(this.playerDebuff2duration);
            this.Controls.Add(this.npcDebuff2duration);
            this.Controls.Add(this.playerDebuff3duration);
            this.Controls.Add(this.npcDebuff3duration);
            this.Controls.Add(this.npcDebuff1duration);
            this.Controls.Add(this.skillDescriptionPanel);
            this.Controls.Add(this.lootPanel);
            this.Controls.Add(this.coolDown5Text);
            this.Controls.Add(this.coolDown4Text);
            this.Controls.Add(this.coolDown3Text);
            this.Controls.Add(this.coolDown2Text);
            this.Controls.Add(this.coolDown1Text);
            this.Controls.Add(this.coolDownsPanel);
            this.Controls.Add(this.restorePlayerHealthButton);
            this.Controls.Add(this.combatPanelBackground);
            this.Controls.Add(this.battleTitleLabel);
            this.Controls.Add(this.skillsPanel);
            this.Controls.Add(this.KillButton);
            this.Controls.Add(this.fightStartButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.menuButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BattleWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BattleWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BattleWindow_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BattleWindow_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BattleWindow_KeyUp);
            this.Leave += new System.EventHandler(this.BattleWindow_Leave);
            this.combatTextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterEnergyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterManaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterHealthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcEnergyBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcManaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcHealthBar)).EndInit();
            this.skillsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skill5PseudoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill4PseudoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill1PseudoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill3PseudoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skill2PseudoButton)).EndInit();
            this.combatPanelBackground.ResumeLayout(false);
            this.coolDownsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coolDownPicBox3)).EndInit();
            this.skillDescriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillDescriptionImage)).EndInit();
            this.playerDebuffsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDebuffPic4)).EndInit();
            this.npcDebuffsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcDebuffPic3)).EndInit();
            this.playerBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            this.npcBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.npcIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label playerHealthP;
        public System.Windows.Forms.Label playerEnergy;
        public System.Windows.Forms.Label playerMana;
        public System.Windows.Forms.Label npcMP;
        public System.Windows.Forms.Label npcEnergy;
        public System.Windows.Forms.Label npcHP;
        public System.Windows.Forms.Button fightStartButton;
        public System.Windows.Forms.Label combatText;
        public System.Windows.Forms.Timer playerStatsRecovery;
        public System.Windows.Forms.Timer coolDownTimer;
        public System.Windows.Forms.Timer npcCoolDownTimer;
        public System.Windows.Forms.Timer npcAttackTimer;
        public System.Windows.Forms.Label combatText2;
        public System.Windows.Forms.Label combatText3;
        public System.Windows.Forms.Label combatText4;
        public System.Windows.Forms.Label combatText5;
        public System.Windows.Forms.Button restartButton;
        public System.Windows.Forms.Label combatText6;
        public System.Windows.Forms.Timer aliveStatusCheck;
        public System.Windows.Forms.Timer battleStatusTimers;
        public System.Windows.Forms.Timer npcStatsRecovery;
        private System.Windows.Forms.Button KillButton;
        private System.Windows.Forms.Panel combatTextPanel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox characterEnergyBar;
        private System.Windows.Forms.PictureBox characterManaBar;
        private System.Windows.Forms.PictureBox characterHealthBar;
        private System.Windows.Forms.PictureBox npcEnergyBar;
        private System.Windows.Forms.PictureBox npcManaBar;
        private System.Windows.Forms.PictureBox npcHealthBar;
        private System.Windows.Forms.Timer indicatorsCheck;
        private System.Windows.Forms.Panel skillsPanel;
        private System.Windows.Forms.PictureBox skill1PseudoButton;
        private System.Windows.Forms.PictureBox skill5PseudoButton;
        private System.Windows.Forms.PictureBox skill4PseudoButton;
        private System.Windows.Forms.PictureBox skill3PseudoButton;
        private System.Windows.Forms.PictureBox skill2PseudoButton;
        private System.Windows.Forms.Label battleTitleLabel;
        private System.Windows.Forms.Panel combatPanelBackground;
        public System.Windows.Forms.Button restorePlayerHealthButton;
        private System.Windows.Forms.Panel coolDownsPanel;
        private System.Windows.Forms.PictureBox coolDownPicBox2;
        private System.Windows.Forms.PictureBox coolDownPicBox1;
        private System.Windows.Forms.PictureBox coolDownPicBox5;
        private System.Windows.Forms.PictureBox coolDownPicBox4;
        private System.Windows.Forms.PictureBox coolDownPicBox3;
        private System.Windows.Forms.Label coolDown1Text;
        private System.Windows.Forms.Label coolDown2Text;
        private System.Windows.Forms.Label coolDown3Text;
        private System.Windows.Forms.Label coolDown4Text;
        private System.Windows.Forms.Label coolDown5Text;
        private System.Windows.Forms.Panel lootPanel;
        private System.Windows.Forms.Panel skillDescriptionPanel;
        private System.Windows.Forms.Label skillDescriptionDescription;
        private System.Windows.Forms.Label skillDescriptionName;
        private System.Windows.Forms.PictureBox skillDescriptionImage;
        private System.Windows.Forms.Label skillDescLevel;
        private System.Windows.Forms.Panel playerDebuffsPanel;
        private System.Windows.Forms.PictureBox playerDebuffPic5;
        private System.Windows.Forms.PictureBox playerDebuffPic4;
        private System.Windows.Forms.PictureBox playerDebuffPic3;
        private System.Windows.Forms.PictureBox playerDebuffPic2;
        private System.Windows.Forms.PictureBox playerDebuffPic1;
        private System.Windows.Forms.Label playerDebuff5duration;
        private System.Windows.Forms.Label playerDebuff4duration;
        private System.Windows.Forms.Label playerDebuff2duration;
        private System.Windows.Forms.Label playerDebuff3duration;
        private System.Windows.Forms.Label playerDebuffduration;
        private System.Windows.Forms.Label npcDebuff5duration;
        private System.Windows.Forms.Label npcDebuff4duration;
        private System.Windows.Forms.Label npcDebuff2duration;
        private System.Windows.Forms.Label npcDebuff3duration;
        private System.Windows.Forms.Label npcDebuff1duration;
        private System.Windows.Forms.Panel npcDebuffsPanel;
        private System.Windows.Forms.PictureBox npcDebuffPic5;
        private System.Windows.Forms.PictureBox npcDebuffPic4;
        private System.Windows.Forms.PictureBox npcDebuffPic3;
        private System.Windows.Forms.PictureBox npcDebuffPic2;
        private System.Windows.Forms.PictureBox npcDebuffPic1;
        private System.Windows.Forms.Panel playerBarPanel;
        public System.Windows.Forms.Label levelPlayerBar;
        private System.Windows.Forms.Panel npcBarPanel;
        public System.Windows.Forms.Label levelNPCBar;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.PictureBox pla;
        private System.Windows.Forms.PictureBox npcIcon;
        public System.Windows.Forms.Label combatText7;
        public System.Windows.Forms.Label combatText9;
        public System.Windows.Forms.Label combatText8;
        public System.Windows.Forms.Label combatText10;
        public System.Windows.Forms.Label combatText11;
        private System.Windows.Forms.PictureBox event11;
        private System.Windows.Forms.PictureBox event4;
        private System.Windows.Forms.PictureBox event5;
        private System.Windows.Forms.PictureBox event6;
        private System.Windows.Forms.PictureBox event7;
        private System.Windows.Forms.PictureBox event8;
        private System.Windows.Forms.PictureBox event9;
        private System.Windows.Forms.PictureBox event10;
        private System.Windows.Forms.PictureBox event1;
        private System.Windows.Forms.PictureBox event2;
        private System.Windows.Forms.PictureBox event3;
        private System.Windows.Forms.PictureBox actor1;
        private System.Windows.Forms.PictureBox actor2;
        private System.Windows.Forms.PictureBox actor3;
        private System.Windows.Forms.PictureBox actor4;
        private System.Windows.Forms.PictureBox actor5;
        private System.Windows.Forms.PictureBox actor6;
        private System.Windows.Forms.PictureBox actor7;
        private System.Windows.Forms.PictureBox actor8;
        private System.Windows.Forms.PictureBox actor9;
        private System.Windows.Forms.PictureBox actor10;
        private System.Windows.Forms.PictureBox actor11;
    }
}

