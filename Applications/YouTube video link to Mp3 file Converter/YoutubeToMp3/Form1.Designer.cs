
namespace YoutubeToMp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadButton = new System.Windows.Forms.Button();
            this.videoLinkTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.completeNotifyLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.White;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadButton.Location = new System.Drawing.Point(94, 248);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(134, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // videoLinkTextBox
            // 
            this.videoLinkTextBox.Location = new System.Drawing.Point(25, 148);
            this.videoLinkTextBox.Name = "videoLinkTextBox";
            this.videoLinkTextBox.Size = new System.Drawing.Size(268, 23);
            this.videoLinkTextBox.TabIndex = 1;
            this.videoLinkTextBox.TextChanged += new System.EventHandler(this.VideoLinkTextBoxPropertyChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel.Location = new System.Drawing.Point(123, 130);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(73, 15);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.Text = "Youtube link";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(25, 192);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(268, 23);
            this.destinationTextBox.TabIndex = 3;
            this.destinationTextBox.TextChanged += new System.EventHandler(this.DestinationLinkTextBoxPropertyChanged);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.BackColor = System.Drawing.Color.Transparent;
            this.destinationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.destinationLabel.Location = new System.Drawing.Point(123, 174);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(67, 15);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination";
            // 
            // completeNotifyLabel
            // 
            this.completeNotifyLabel.AutoSize = true;
            this.completeNotifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.completeNotifyLabel.ForeColor = System.Drawing.Color.White;
            this.completeNotifyLabel.Location = new System.Drawing.Point(84, 230);
            this.completeNotifyLabel.Name = "completeNotifyLabel";
            this.completeNotifyLabel.Size = new System.Drawing.Size(153, 15);
            this.completeNotifyLabel.TabIndex = 5;
            this.completeNotifyLabel.Text = "Downloaded and converted";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(246, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoNameLabel.Location = new System.Drawing.Point(25, 39);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(268, 63);
            this.videoNameLabel.TabIndex = 7;
            this.videoNameLabel.Text = "Video name label";
            this.videoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.videoNameLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 283);
            this.Controls.Add(this.videoNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.completeNotifyLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.videoLinkTextBox);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Youtube Download Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox videoLinkTextBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label completeNotifyLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label videoNameLabel;
    }
}

