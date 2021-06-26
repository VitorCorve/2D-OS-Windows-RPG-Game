
namespace WinFormsApp1.GameMenuForms
{
    partial class GameMenuOptions
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
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.optionsTitleLabel = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(93, 142);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 49);
            this.saveButton.TabIndex = 101;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadButton.AutoSize = true;
            this.loadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(93, 197);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(181, 49);
            this.loadButton.TabIndex = 102;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mainMenu.AutoSize = true;
            this.mainMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainMenu.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenu.Location = new System.Drawing.Point(93, 252);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(181, 49);
            this.mainMenu.TabIndex = 103;
            this.mainMenu.Text = "Main menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quitButton.AutoSize = true;
            this.quitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitButton.Location = new System.Drawing.Point(93, 307);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(181, 49);
            this.quitButton.TabIndex = 104;
            this.quitButton.Text = "Quit game";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // optionsTitleLabel
            // 
            this.optionsTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsTitleLabel.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsTitleLabel.Location = new System.Drawing.Point(72, 36);
            this.optionsTitleLabel.Name = "optionsTitleLabel";
            this.optionsTitleLabel.Size = new System.Drawing.Size(233, 39);
            this.optionsTitleLabel.TabIndex = 105;
            this.optionsTitleLabel.Text = "Options";
            this.optionsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resumeButton
            // 
            this.resumeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resumeButton.AutoSize = true;
            this.resumeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resumeButton.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resumeButton.Location = new System.Drawing.Point(93, 87);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(181, 49);
            this.resumeButton.TabIndex = 106;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // GameMenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(372, 520);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.optionsTitleLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenuOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenuOptions";
            this.Load += new System.EventHandler(this.GameMenuOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label optionsTitleLabel;
        private System.Windows.Forms.Button resumeButton;
    }
}