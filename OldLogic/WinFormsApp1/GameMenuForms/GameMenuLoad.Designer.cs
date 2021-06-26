
namespace WinFormsApp1.GameMenuForms
{
    partial class GameMenuLoad
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
            this.loadGameTitleLabel = new System.Windows.Forms.Label();
            this.charsList = new System.Windows.Forms.ListBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveDateText = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadGameTitleLabel
            // 
            this.loadGameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadGameTitleLabel.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadGameTitleLabel.Location = new System.Drawing.Point(57, 9);
            this.loadGameTitleLabel.Name = "loadGameTitleLabel";
            this.loadGameTitleLabel.Size = new System.Drawing.Size(233, 39);
            this.loadGameTitleLabel.TabIndex = 106;
            this.loadGameTitleLabel.Text = "Saves";
            this.loadGameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charsList
            // 
            this.charsList.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charsList.FormattingEnabled = true;
            this.charsList.ItemHeight = 28;
            this.charsList.Location = new System.Drawing.Point(78, 51);
            this.charsList.Name = "charsList";
            this.charsList.Size = new System.Drawing.Size(188, 256);
            this.charsList.TabIndex = 107;
            this.charsList.SelectedIndexChanged += new System.EventHandler(this.charsList_SelectedIndexChanged);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadButton.AutoSize = true;
            this.loadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadButton.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(78, 353);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(188, 38);
            this.loadButton.TabIndex = 108;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveDateText
            // 
            this.saveDateText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveDateText.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveDateText.Location = new System.Drawing.Point(78, 310);
            this.saveDateText.Name = "saveDateText";
            this.saveDateText.Size = new System.Drawing.Size(188, 29);
            this.saveDateText.TabIndex = 109;
            this.saveDateText.Text = "date";
            this.saveDateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(78, 397);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(188, 38);
            this.backButton.TabIndex = 110;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameMenuLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 481);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveDateText);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.charsList);
            this.Controls.Add(this.loadGameTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenuLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenuLoad";
            this.Load += new System.EventHandler(this.GameMenuLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadGameTitleLabel;
        private System.Windows.Forms.ListBox charsList;
        private System.Windows.Forms.Button loadButton;
        public System.Windows.Forms.Label saveDateText;
        private System.Windows.Forms.Button backButton;
    }
}