
namespace WinFormsApp1
{
    partial class CharacterLoading
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.characterLoadingTitleLabel = new System.Windows.Forms.Label();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.charListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.charInfoPanel = new System.Windows.Forms.Panel();
            this.copperText = new System.Windows.Forms.Label();
            this.manaText = new System.Windows.Forms.Label();
            this.silverText = new System.Windows.Forms.Label();
            this.energyText = new System.Windows.Forms.Label();
            this.healthText = new System.Windows.Forms.Label();
            this.goldText = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.energyLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.charStatPanel = new System.Windows.Forms.Panel();
            this.epicItemsLabel = new System.Windows.Forms.Label();
            this.daysPlayedLabel = new System.Windows.Forms.Label();
            this.enemiesKilledLabel = new System.Windows.Forms.Label();
            this.saveDatePanel = new System.Windows.Forms.Panel();
            this.saveDateText = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.classPanel = new System.Windows.Forms.Panel();
            this.classText = new System.Windows.Forms.Label();
            this.bioPanel = new System.Windows.Forms.Panel();
            this.bioText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.charInfoPanel.SuspendLayout();
            this.charStatPanel.SuspendLayout();
            this.saveDatePanel.SuspendLayout();
            this.classPanel.SuspendLayout();
            this.bioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1234, 779);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 49);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // characterLoadingTitleLabel
            // 
            this.characterLoadingTitleLabel.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.characterLoadingTitleLabel.Location = new System.Drawing.Point(685, 20);
            this.characterLoadingTitleLabel.Name = "characterLoadingTitleLabel";
            this.characterLoadingTitleLabel.Size = new System.Drawing.Size(300, 39);
            this.characterLoadingTitleLabel.TabIndex = 19;
            this.characterLoadingTitleLabel.Text = "Characters";
            this.characterLoadingTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterImage
            // 
            this.characterImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterImage.Location = new System.Drawing.Point(508, 84);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(291, 508);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImage.TabIndex = 20;
            this.characterImage.TabStop = false;
            // 
            // charListBox
            // 
            this.charListBox.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charListBox.FormattingEnabled = true;
            this.charListBox.ItemHeight = 28;
            this.charListBox.Location = new System.Drawing.Point(256, 84);
            this.charListBox.Name = "charListBox";
            this.charListBox.Size = new System.Drawing.Size(176, 508);
            this.charListBox.TabIndex = 22;
            this.charListBox.SelectedIndexChanged += new System.EventHandler(this.charListBox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.AutoSize = true;
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(256, 607);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(176, 49);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // charInfoPanel
            // 
            this.charInfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.charInfoPanel.Controls.Add(this.copperText);
            this.charInfoPanel.Controls.Add(this.manaText);
            this.charInfoPanel.Controls.Add(this.silverText);
            this.charInfoPanel.Controls.Add(this.energyText);
            this.charInfoPanel.Controls.Add(this.healthText);
            this.charInfoPanel.Controls.Add(this.goldText);
            this.charInfoPanel.Controls.Add(this.levelText);
            this.charInfoPanel.Controls.Add(this.manaLabel);
            this.charInfoPanel.Controls.Add(this.healthLabel);
            this.charInfoPanel.Controls.Add(this.energyLabel);
            this.charInfoPanel.Controls.Add(this.moneyLabel);
            this.charInfoPanel.Controls.Add(this.levelLabel);
            this.charInfoPanel.Location = new System.Drawing.Point(1181, 84);
            this.charInfoPanel.Name = "charInfoPanel";
            this.charInfoPanel.Size = new System.Drawing.Size(221, 508);
            this.charInfoPanel.TabIndex = 78;
            // 
            // copperText
            // 
            this.copperText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.copperText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copperText.Location = new System.Drawing.Point(143, 445);
            this.copperText.Name = "copperText";
            this.copperText.Size = new System.Drawing.Size(65, 33);
            this.copperText.TabIndex = 22;
            this.copperText.Text = "0";
            this.copperText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manaText
            // 
            this.manaText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.manaText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manaText.Location = new System.Drawing.Point(14, 246);
            this.manaText.Name = "manaText";
            this.manaText.Size = new System.Drawing.Size(195, 33);
            this.manaText.TabIndex = 19;
            this.manaText.Text = "0";
            this.manaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // silverText
            // 
            this.silverText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.silverText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silverText.Location = new System.Drawing.Point(75, 445);
            this.silverText.Name = "silverText";
            this.silverText.Size = new System.Drawing.Size(71, 33);
            this.silverText.TabIndex = 21;
            this.silverText.Text = "0";
            this.silverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // energyText
            // 
            this.energyText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.energyText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.energyText.Location = new System.Drawing.Point(14, 345);
            this.energyText.Name = "energyText";
            this.energyText.Size = new System.Drawing.Size(195, 33);
            this.energyText.TabIndex = 24;
            this.energyText.Text = "0";
            this.energyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthText
            // 
            this.healthText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.healthText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthText.Location = new System.Drawing.Point(14, 151);
            this.healthText.Name = "healthText";
            this.healthText.Size = new System.Drawing.Size(195, 33);
            this.healthText.TabIndex = 18;
            this.healthText.Text = "0";
            this.healthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goldText
            // 
            this.goldText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.goldText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goldText.Location = new System.Drawing.Point(13, 445);
            this.goldText.Name = "goldText";
            this.goldText.Size = new System.Drawing.Size(63, 33);
            this.goldText.TabIndex = 20;
            this.goldText.Text = "0";
            this.goldText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelText
            // 
            this.levelText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.levelText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelText.Location = new System.Drawing.Point(14, 56);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(195, 33);
            this.levelText.TabIndex = 17;
            this.levelText.Text = "0";
            this.levelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manaLabel
            // 
            this.manaLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.manaLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manaLabel.Location = new System.Drawing.Point(14, 197);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(195, 33);
            this.manaLabel.TabIndex = 15;
            this.manaLabel.Text = "MP";
            this.manaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.healthLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthLabel.Location = new System.Drawing.Point(14, 102);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(195, 33);
            this.healthLabel.TabIndex = 14;
            this.healthLabel.Text = "HP";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // energyLabel
            // 
            this.energyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.energyLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.energyLabel.Location = new System.Drawing.Point(14, 293);
            this.energyLabel.Name = "energyLabel";
            this.energyLabel.Size = new System.Drawing.Size(195, 33);
            this.energyLabel.TabIndex = 23;
            this.energyLabel.Text = "Energy";
            this.energyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moneyLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moneyLabel.Location = new System.Drawing.Point(14, 393);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(195, 33);
            this.moneyLabel.TabIndex = 16;
            this.moneyLabel.Text = "Gold";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.Location = new System.Drawing.Point(14, 13);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(195, 33);
            this.levelLabel.TabIndex = 13;
            this.levelLabel.Text = "Level";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charStatPanel
            // 
            this.charStatPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.charStatPanel.Controls.Add(this.epicItemsLabel);
            this.charStatPanel.Controls.Add(this.daysPlayedLabel);
            this.charStatPanel.Controls.Add(this.enemiesKilledLabel);
            this.charStatPanel.Location = new System.Drawing.Point(872, 476);
            this.charStatPanel.Name = "charStatPanel";
            this.charStatPanel.Size = new System.Drawing.Size(234, 116);
            this.charStatPanel.TabIndex = 79;
            // 
            // epicItemsLabel
            // 
            this.epicItemsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.epicItemsLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.epicItemsLabel.Location = new System.Drawing.Point(14, 42);
            this.epicItemsLabel.Name = "epicItemsLabel";
            this.epicItemsLabel.Size = new System.Drawing.Size(195, 33);
            this.epicItemsLabel.TabIndex = 25;
            this.epicItemsLabel.Text = "Epic items: ";
            this.epicItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daysPlayedLabel
            // 
            this.daysPlayedLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.daysPlayedLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysPlayedLabel.Location = new System.Drawing.Point(14, 75);
            this.daysPlayedLabel.Name = "daysPlayedLabel";
            this.daysPlayedLabel.Size = new System.Drawing.Size(195, 33);
            this.daysPlayedLabel.TabIndex = 24;
            this.daysPlayedLabel.Text = "Days played:";
            this.daysPlayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enemiesKilledLabel
            // 
            this.enemiesKilledLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.enemiesKilledLabel.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemiesKilledLabel.Location = new System.Drawing.Point(14, 9);
            this.enemiesKilledLabel.Name = "enemiesKilledLabel";
            this.enemiesKilledLabel.Size = new System.Drawing.Size(195, 33);
            this.enemiesKilledLabel.TabIndex = 23;
            this.enemiesKilledLabel.Text = "Enemies killed: ";
            this.enemiesKilledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveDatePanel
            // 
            this.saveDatePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveDatePanel.Controls.Add(this.saveDateText);
            this.saveDatePanel.Location = new System.Drawing.Point(508, 607);
            this.saveDatePanel.Name = "saveDatePanel";
            this.saveDatePanel.Size = new System.Drawing.Size(291, 49);
            this.saveDatePanel.TabIndex = 80;
            // 
            // saveDateText
            // 
            this.saveDateText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveDateText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveDateText.Location = new System.Drawing.Point(0, 0);
            this.saveDateText.Name = "saveDateText";
            this.saveDateText.Size = new System.Drawing.Size(291, 49);
            this.saveDateText.TabIndex = 26;
            this.saveDateText.Text = "date";
            this.saveDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadButton.AutoSize = true;
            this.loadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(1181, 607);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(221, 49);
            this.loadButton.TabIndex = 81;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // classPanel
            // 
            this.classPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.classPanel.Controls.Add(this.classText);
            this.classPanel.Location = new System.Drawing.Point(872, 84);
            this.classPanel.Name = "classPanel";
            this.classPanel.Size = new System.Drawing.Size(234, 46);
            this.classPanel.TabIndex = 82;
            // 
            // classText
            // 
            this.classText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.classText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classText.Location = new System.Drawing.Point(0, 0);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(234, 46);
            this.classText.TabIndex = 23;
            this.classText.Text = "Class";
            this.classText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bioPanel
            // 
            this.bioPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bioPanel.Controls.Add(this.bioText);
            this.bioPanel.Location = new System.Drawing.Point(872, 149);
            this.bioPanel.Name = "bioPanel";
            this.bioPanel.Size = new System.Drawing.Size(234, 313);
            this.bioPanel.TabIndex = 83;
            // 
            // bioText
            // 
            this.bioText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bioText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bioText.Location = new System.Drawing.Point(9, 11);
            this.bioText.Name = "bioText";
            this.bioText.Size = new System.Drawing.Size(216, 293);
            this.bioText.TabIndex = 23;
            this.bioText.Text = "Biography";
            this.bioText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharacterLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 980);
            this.Controls.Add(this.bioPanel);
            this.Controls.Add(this.classPanel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveDatePanel);
            this.Controls.Add(this.charStatPanel);
            this.Controls.Add(this.charInfoPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.charListBox);
            this.Controls.Add(this.characterImage);
            this.Controls.Add(this.characterLoadingTitleLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterLoading";
            this.Load += new System.EventHandler(this.CharacterLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.charInfoPanel.ResumeLayout(false);
            this.charStatPanel.ResumeLayout(false);
            this.saveDatePanel.ResumeLayout(false);
            this.classPanel.ResumeLayout(false);
            this.bioPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label characterLoadingTitleLabel;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.ListBox charListBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel charInfoPanel;
        public System.Windows.Forms.Label copperText;
        public System.Windows.Forms.Label silverText;
        public System.Windows.Forms.Label goldText;
        public System.Windows.Forms.Label manaText;
        public System.Windows.Forms.Label healthText;
        public System.Windows.Forms.Label levelText;
        public System.Windows.Forms.Label moneyLabel;
        public System.Windows.Forms.Label manaLabel;
        public System.Windows.Forms.Label healthLabel;
        public System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Panel charStatPanel;
        public System.Windows.Forms.Label enemiesKilledLabel;
        public System.Windows.Forms.Label daysPlayedLabel;
        public System.Windows.Forms.Label epicItemsLabel;
        private System.Windows.Forms.Panel saveDatePanel;
        private System.Windows.Forms.Button loadButton;
        public System.Windows.Forms.Label saveDateText;
        private System.Windows.Forms.Panel classPanel;
        public System.Windows.Forms.Label classText;
        private System.Windows.Forms.Panel bioPanel;
        public System.Windows.Forms.Label bioText;
        public System.Windows.Forms.Label energyText;
        public System.Windows.Forms.Label energyLabel;
    }
}