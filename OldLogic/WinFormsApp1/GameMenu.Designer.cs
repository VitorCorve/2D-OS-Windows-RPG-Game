
namespace WinFormsApp1
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            backgroundtemp.Dispose();
            Background.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.nameLabel = new System.Windows.Forms.Label();
            this.huntButton = new System.Windows.Forms.Button();
            this.merchantButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.questsButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.townsButton = new System.Windows.Forms.Button();
            this.blacksmithButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.gameMenuPanel = new System.Windows.Forms.Panel();
            this.equipmentButton = new System.Windows.Forms.Button();
            this.territoryButtons = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.healthPointsLabel = new System.Windows.Forms.Label();
            this.manaPointsLabel = new System.Windows.Forms.Label();
            this.energyPointsLabel = new System.Windows.Forms.Label();
            this.charMetaPanel = new System.Windows.Forms.Panel();
            this.xpBarPanel = new System.Windows.Forms.Panel();
            this.xp1 = new System.Windows.Forms.PictureBox();
            this.xp5 = new System.Windows.Forms.PictureBox();
            this.xp10 = new System.Windows.Forms.PictureBox();
            this.xp2 = new System.Windows.Forms.PictureBox();
            this.xp6 = new System.Windows.Forms.PictureBox();
            this.xp7 = new System.Windows.Forms.PictureBox();
            this.xp8 = new System.Windows.Forms.PictureBox();
            this.xp9 = new System.Windows.Forms.PictureBox();
            this.xp4 = new System.Windows.Forms.PictureBox();
            this.xp3 = new System.Windows.Forms.PictureBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.gameMenuPanel.SuspendLayout();
            this.charMetaPanel.SuspendLayout();
            this.xpBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp3)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(20, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 36);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // huntButton
            // 
            this.huntButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.huntButton.AutoSize = true;
            this.huntButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.huntButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huntButton.Location = new System.Drawing.Point(16, 8);
            this.huntButton.Name = "huntButton";
            this.huntButton.Size = new System.Drawing.Size(181, 49);
            this.huntButton.TabIndex = 92;
            this.huntButton.Text = "Hunt";
            this.huntButton.UseVisualStyleBackColor = false;
            this.huntButton.Click += new System.EventHandler(this.huntButton_Click);
            // 
            // merchantButton
            // 
            this.merchantButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.merchantButton.AutoSize = true;
            this.merchantButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.merchantButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.merchantButton.Location = new System.Drawing.Point(16, 228);
            this.merchantButton.Name = "merchantButton";
            this.merchantButton.Size = new System.Drawing.Size(181, 49);
            this.merchantButton.TabIndex = 93;
            this.merchantButton.Text = "Merchant";
            this.merchantButton.UseVisualStyleBackColor = false;
            // 
            // statsButton
            // 
            this.statsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statsButton.AutoSize = true;
            this.statsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statsButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsButton.Location = new System.Drawing.Point(16, 503);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(181, 49);
            this.statsButton.TabIndex = 94;
            this.statsButton.Text = "Attributes";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // questsButton
            // 
            this.questsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.questsButton.AutoSize = true;
            this.questsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.questsButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questsButton.Location = new System.Drawing.Point(16, 393);
            this.questsButton.Name = "questsButton";
            this.questsButton.Size = new System.Drawing.Size(181, 49);
            this.questsButton.TabIndex = 95;
            this.questsButton.Text = "Quests";
            this.questsButton.UseVisualStyleBackColor = false;
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.optionsButton.AutoSize = true;
            this.optionsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsButton.Location = new System.Drawing.Point(16, 558);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(181, 49);
            this.optionsButton.TabIndex = 96;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inventoryButton.AutoSize = true;
            this.inventoryButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inventoryButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.Location = new System.Drawing.Point(16, 118);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(181, 49);
            this.inventoryButton.TabIndex = 97;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // townsButton
            // 
            this.townsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.townsButton.AutoSize = true;
            this.townsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.townsButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.townsButton.Location = new System.Drawing.Point(16, 283);
            this.townsButton.Name = "townsButton";
            this.townsButton.Size = new System.Drawing.Size(181, 49);
            this.townsButton.TabIndex = 98;
            this.townsButton.Text = "Towns";
            this.townsButton.UseVisualStyleBackColor = false;
            // 
            // blacksmithButton
            // 
            this.blacksmithButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.blacksmithButton.AutoSize = true;
            this.blacksmithButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.blacksmithButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blacksmithButton.Location = new System.Drawing.Point(16, 173);
            this.blacksmithButton.Name = "blacksmithButton";
            this.blacksmithButton.Size = new System.Drawing.Size(181, 49);
            this.blacksmithButton.TabIndex = 99;
            this.blacksmithButton.Text = "Blacksmith";
            this.blacksmithButton.UseVisualStyleBackColor = false;
            // 
            // notesButton
            // 
            this.notesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notesButton.AutoSize = true;
            this.notesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notesButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesButton.Location = new System.Drawing.Point(16, 448);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(181, 49);
            this.notesButton.TabIndex = 101;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // characterImage
            // 
            this.characterImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterImage.Location = new System.Drawing.Point(20, 81);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(300, 519);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImage.TabIndex = 102;
            this.characterImage.TabStop = false;
            // 
            // gameMenuPanel
            // 
            this.gameMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameMenuPanel.Controls.Add(this.equipmentButton);
            this.gameMenuPanel.Controls.Add(this.territoryButtons);
            this.gameMenuPanel.Controls.Add(this.huntButton);
            this.gameMenuPanel.Controls.Add(this.notesButton);
            this.gameMenuPanel.Controls.Add(this.inventoryButton);
            this.gameMenuPanel.Controls.Add(this.blacksmithButton);
            this.gameMenuPanel.Controls.Add(this.merchantButton);
            this.gameMenuPanel.Controls.Add(this.optionsButton);
            this.gameMenuPanel.Controls.Add(this.townsButton);
            this.gameMenuPanel.Controls.Add(this.statsButton);
            this.gameMenuPanel.Controls.Add(this.questsButton);
            this.gameMenuPanel.Location = new System.Drawing.Point(31, 34);
            this.gameMenuPanel.Name = "gameMenuPanel";
            this.gameMenuPanel.Size = new System.Drawing.Size(212, 671);
            this.gameMenuPanel.TabIndex = 103;
            // 
            // equipmentButton
            // 
            this.equipmentButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.equipmentButton.AutoSize = true;
            this.equipmentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.equipmentButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equipmentButton.Location = new System.Drawing.Point(16, 63);
            this.equipmentButton.Name = "equipmentButton";
            this.equipmentButton.Size = new System.Drawing.Size(181, 49);
            this.equipmentButton.TabIndex = 103;
            this.equipmentButton.Text = "Equipment";
            this.equipmentButton.UseVisualStyleBackColor = false;
            this.equipmentButton.Click += new System.EventHandler(this.equipmentButton_Click);
            // 
            // territoryButtons
            // 
            this.territoryButtons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.territoryButtons.AutoSize = true;
            this.territoryButtons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.territoryButtons.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.territoryButtons.Location = new System.Drawing.Point(16, 338);
            this.territoryButtons.Name = "territoryButtons";
            this.territoryButtons.Size = new System.Drawing.Size(181, 49);
            this.territoryButtons.TabIndex = 102;
            this.territoryButtons.Text = "Territories";
            this.territoryButtons.UseVisualStyleBackColor = false;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.Location = new System.Drawing.Point(178, 26);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(142, 36);
            this.levelLabel.TabIndex = 104;
            this.levelLabel.Text = "Level: 0";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthPointsLabel
            // 
            this.healthPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.healthPointsLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthPointsLabel.Location = new System.Drawing.Point(20, 610);
            this.healthPointsLabel.Name = "healthPointsLabel";
            this.healthPointsLabel.Size = new System.Drawing.Size(103, 36);
            this.healthPointsLabel.TabIndex = 105;
            this.healthPointsLabel.Text = "HP: 0";
            this.healthPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manaPointsLabel
            // 
            this.manaPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manaPointsLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manaPointsLabel.Location = new System.Drawing.Point(121, 610);
            this.manaPointsLabel.Name = "manaPointsLabel";
            this.manaPointsLabel.Size = new System.Drawing.Size(98, 36);
            this.manaPointsLabel.TabIndex = 106;
            this.manaPointsLabel.Text = "MP: 0";
            this.manaPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // energyPointsLabel
            // 
            this.energyPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.energyPointsLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.energyPointsLabel.Location = new System.Drawing.Point(212, 610);
            this.energyPointsLabel.Name = "energyPointsLabel";
            this.energyPointsLabel.Size = new System.Drawing.Size(108, 36);
            this.energyPointsLabel.TabIndex = 107;
            this.energyPointsLabel.Text = "EP: 0";
            this.energyPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charMetaPanel
            // 
            this.charMetaPanel.BackColor = System.Drawing.Color.DimGray;
            this.charMetaPanel.Controls.Add(this.xpBarPanel);
            this.charMetaPanel.Controls.Add(this.nameLabel);
            this.charMetaPanel.Controls.Add(this.energyPointsLabel);
            this.charMetaPanel.Controls.Add(this.levelLabel);
            this.charMetaPanel.Controls.Add(this.manaPointsLabel);
            this.charMetaPanel.Controls.Add(this.characterImage);
            this.charMetaPanel.Controls.Add(this.healthPointsLabel);
            this.charMetaPanel.Location = new System.Drawing.Point(1306, 34);
            this.charMetaPanel.Name = "charMetaPanel";
            this.charMetaPanel.Size = new System.Drawing.Size(338, 671);
            this.charMetaPanel.TabIndex = 108;
            // 
            // xpBarPanel
            // 
            this.xpBarPanel.Controls.Add(this.xp1);
            this.xpBarPanel.Controls.Add(this.xp5);
            this.xpBarPanel.Controls.Add(this.xp10);
            this.xpBarPanel.Controls.Add(this.xp2);
            this.xpBarPanel.Controls.Add(this.xp6);
            this.xpBarPanel.Controls.Add(this.xp7);
            this.xpBarPanel.Controls.Add(this.xp8);
            this.xpBarPanel.Controls.Add(this.xp9);
            this.xpBarPanel.Controls.Add(this.xp4);
            this.xpBarPanel.Controls.Add(this.xp3);
            this.xpBarPanel.Location = new System.Drawing.Point(22, 59);
            this.xpBarPanel.Name = "xpBarPanel";
            this.xpBarPanel.Size = new System.Drawing.Size(297, 18);
            this.xpBarPanel.TabIndex = 120;
            // 
            // xp1
            // 
            this.xp1.Image = ((System.Drawing.Image)(resources.GetObject("xp1.Image")));
            this.xp1.Location = new System.Drawing.Point(0, 8);
            this.xp1.Name = "xp1";
            this.xp1.Size = new System.Drawing.Size(27, 10);
            this.xp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp1.TabIndex = 110;
            this.xp1.TabStop = false;
            // 
            // xp5
            // 
            this.xp5.Image = ((System.Drawing.Image)(resources.GetObject("xp5.Image")));
            this.xp5.Location = new System.Drawing.Point(120, 8);
            this.xp5.Name = "xp5";
            this.xp5.Size = new System.Drawing.Size(27, 10);
            this.xp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp5.TabIndex = 114;
            this.xp5.TabStop = false;
            // 
            // xp10
            // 
            this.xp10.Image = ((System.Drawing.Image)(resources.GetObject("xp10.Image")));
            this.xp10.Location = new System.Drawing.Point(270, 8);
            this.xp10.Name = "xp10";
            this.xp10.Size = new System.Drawing.Size(27, 10);
            this.xp10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp10.TabIndex = 119;
            this.xp10.TabStop = false;
            // 
            // xp2
            // 
            this.xp2.Image = ((System.Drawing.Image)(resources.GetObject("xp2.Image")));
            this.xp2.Location = new System.Drawing.Point(30, 8);
            this.xp2.Name = "xp2";
            this.xp2.Size = new System.Drawing.Size(27, 10);
            this.xp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp2.TabIndex = 111;
            this.xp2.TabStop = false;
            // 
            // xp6
            // 
            this.xp6.Image = ((System.Drawing.Image)(resources.GetObject("xp6.Image")));
            this.xp6.Location = new System.Drawing.Point(150, 8);
            this.xp6.Name = "xp6";
            this.xp6.Size = new System.Drawing.Size(27, 10);
            this.xp6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp6.TabIndex = 115;
            this.xp6.TabStop = false;
            // 
            // xp7
            // 
            this.xp7.Image = ((System.Drawing.Image)(resources.GetObject("xp7.Image")));
            this.xp7.Location = new System.Drawing.Point(180, 8);
            this.xp7.Name = "xp7";
            this.xp7.Size = new System.Drawing.Size(27, 10);
            this.xp7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp7.TabIndex = 116;
            this.xp7.TabStop = false;
            // 
            // xp8
            // 
            this.xp8.Image = ((System.Drawing.Image)(resources.GetObject("xp8.Image")));
            this.xp8.Location = new System.Drawing.Point(210, 8);
            this.xp8.Name = "xp8";
            this.xp8.Size = new System.Drawing.Size(27, 10);
            this.xp8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp8.TabIndex = 117;
            this.xp8.TabStop = false;
            // 
            // xp9
            // 
            this.xp9.Image = ((System.Drawing.Image)(resources.GetObject("xp9.Image")));
            this.xp9.Location = new System.Drawing.Point(240, 8);
            this.xp9.Name = "xp9";
            this.xp9.Size = new System.Drawing.Size(27, 10);
            this.xp9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp9.TabIndex = 118;
            this.xp9.TabStop = false;
            // 
            // xp4
            // 
            this.xp4.Image = ((System.Drawing.Image)(resources.GetObject("xp4.Image")));
            this.xp4.Location = new System.Drawing.Point(90, 8);
            this.xp4.Name = "xp4";
            this.xp4.Size = new System.Drawing.Size(27, 10);
            this.xp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp4.TabIndex = 113;
            this.xp4.TabStop = false;
            // 
            // xp3
            // 
            this.xp3.Image = ((System.Drawing.Image)(resources.GetObject("xp3.Image")));
            this.xp3.Location = new System.Drawing.Point(60, 8);
            this.xp3.Name = "xp3";
            this.xp3.Size = new System.Drawing.Size(27, 10);
            this.xp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xp3.TabIndex = 112;
            this.xp3.TabStop = false;
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.Transparent;
            this.viewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPanel.Location = new System.Drawing.Point(281, 34);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(989, 671);
            this.viewPanel.TabIndex = 109;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 980);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.charMetaPanel);
            this.Controls.Add(this.gameMenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.Activated += new System.EventHandler(this.GameMenu_Activated);
            this.Deactivate += new System.EventHandler(this.GameMenu_Deactivate);
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.Click += new System.EventHandler(this.GameMenu_Click);
            this.Enter += new System.EventHandler(this.GameMenu_Enter);
            this.Leave += new System.EventHandler(this.GameMenu_Leave);
            this.ParentChanged += new System.EventHandler(this.GameMenu_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.gameMenuPanel.ResumeLayout(false);
            this.gameMenuPanel.PerformLayout();
            this.charMetaPanel.ResumeLayout(false);
            this.xpBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button huntButton;
        private System.Windows.Forms.Button merchantButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button questsButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button townsButton;
        private System.Windows.Forms.Button blacksmithButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.Panel gameMenuPanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label healthPointsLabel;
        private System.Windows.Forms.Label manaPointsLabel;
        private System.Windows.Forms.Label energyPointsLabel;
        private System.Windows.Forms.Panel charMetaPanel;
        private System.Windows.Forms.Button territoryButtons;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button equipmentButton;
        private System.Windows.Forms.PictureBox xp10;
        private System.Windows.Forms.PictureBox xp9;
        private System.Windows.Forms.PictureBox xp8;
        private System.Windows.Forms.PictureBox xp7;
        private System.Windows.Forms.PictureBox xp6;
        private System.Windows.Forms.PictureBox xp5;
        private System.Windows.Forms.PictureBox xp4;
        private System.Windows.Forms.PictureBox xp3;
        private System.Windows.Forms.PictureBox xp2;
        private System.Windows.Forms.PictureBox xp1;
        private System.Windows.Forms.Panel xpBarPanel;
    }
}