
namespace YoutubeToMp3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.downloadButton = new System.Windows.Forms.Button();
            this.videoLinkTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.completeNotifyLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.downloadAsVideoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.White;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadButton.Location = new System.Drawing.Point(95, 242);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(134, 22);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download Audio";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // videoLinkTextBox
            // 
            this.videoLinkTextBox.Location = new System.Drawing.Point(26, 142);
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
            this.linkLabel.Location = new System.Drawing.Point(124, 124);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(73, 15);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.Text = "Youtube link";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(26, 186);
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
            this.destinationLabel.Location = new System.Drawing.Point(124, 168);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(67, 15);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Destination";
            // 
            // completeNotifyLabel
            // 
            this.completeNotifyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completeNotifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.completeNotifyLabel.ForeColor = System.Drawing.Color.White;
            this.completeNotifyLabel.Location = new System.Drawing.Point(26, 212);
            this.completeNotifyLabel.Name = "completeNotifyLabel";
            this.completeNotifyLabel.Size = new System.Drawing.Size(268, 20);
            this.completeNotifyLabel.TabIndex = 5;
            this.completeNotifyLabel.Text = "Downloaded and converted";
            this.completeNotifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(247, 242);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 22);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoNameLabel.Location = new System.Drawing.Point(26, 33);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(268, 48);
            this.videoNameLabel.TabIndex = 7;
            this.videoNameLabel.Text = "Video name label";
            this.videoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.videoNameLabel.Visible = false;
            // 
            // openFolderButton
            // 
            this.openFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFolderButton.Location = new System.Drawing.Point(26, 242);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(51, 22);
            this.openFolderButton.TabIndex = 8;
            this.openFolderButton.Text = "Open";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // downloadAsVideoButton
            // 
            this.downloadAsVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadAsVideoButton.Location = new System.Drawing.Point(95, 271);
            this.downloadAsVideoButton.Name = "downloadAsVideoButton";
            this.downloadAsVideoButton.Size = new System.Drawing.Size(134, 22);
            this.downloadAsVideoButton.TabIndex = 9;
            this.downloadAsVideoButton.Text = "Download Video";
            this.downloadAsVideoButton.UseVisualStyleBackColor = true;
            this.downloadAsVideoButton.Click += new System.EventHandler(this.DownlooadVideoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.downloadAsVideoButton);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.videoNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.completeNotifyLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.videoLinkTextBox);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Youtube Download Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
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
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Button downloadAsVideoButton;
    }
}

