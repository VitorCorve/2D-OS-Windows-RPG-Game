
namespace WinFormsApp1.BattleWindowForms
{
    partial class LootMenu
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
            this.lootTitleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.rewardImage = new System.Windows.Forms.PictureBox();
            this.rewardTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rewardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lootTitleLabel
            // 
            this.lootTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lootTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lootTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lootTitleLabel.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lootTitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.lootTitleLabel.Location = new System.Drawing.Point(0, -11);
            this.lootTitleLabel.Name = "lootTitleLabel";
            this.lootTitleLabel.Size = new System.Drawing.Size(201, 46);
            this.lootTitleLabel.TabIndex = 116;
            this.lootTitleLabel.Text = "Loot";
            this.lootTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Silver;
            this.closeButton.Location = new System.Drawing.Point(6, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(188, 40);
            this.closeButton.TabIndex = 117;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rewardImage
            // 
            this.rewardImage.BackColor = System.Drawing.Color.Transparent;
            this.rewardImage.Location = new System.Drawing.Point(61, 107);
            this.rewardImage.Name = "rewardImage";
            this.rewardImage.Size = new System.Drawing.Size(75, 68);
            this.rewardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rewardImage.TabIndex = 118;
            this.rewardImage.TabStop = false;
            this.rewardImage.MouseLeave += new System.EventHandler(this.rewardImage_MouseLeave);
            this.rewardImage.MouseHover += new System.EventHandler(this.rewardImage_MouseHover);
            // 
            // rewardTitleLabel
            // 
            this.rewardTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.rewardTitleLabel.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rewardTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.rewardTitleLabel.Location = new System.Drawing.Point(12, 35);
            this.rewardTitleLabel.Name = "rewardTitleLabel";
            this.rewardTitleLabel.Size = new System.Drawing.Size(176, 40);
            this.rewardTitleLabel.TabIndex = 119;
            this.rewardTitleLabel.Text = "Reward";
            this.rewardTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LootMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(200, 260);
            this.Controls.Add(this.rewardTitleLabel);
            this.Controls.Add(this.rewardImage);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lootTitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LootMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LootMenu";
            this.Load += new System.EventHandler(this.LootMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rewardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lootTitleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox rewardImage;
        private System.Windows.Forms.Label rewardTitleLabel;
    }
}