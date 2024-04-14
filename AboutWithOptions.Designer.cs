namespace LevelCapExtender
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            TextBoxAboutExtender = new RichTextBox();
            AboutLabel = new Label();
            GameInstallationFolderExample = new Label();
            openGameLocation = new OpenFileDialog();
            SelectGameFileButton = new Button();
            ChooseLevelCapExtenderPanel = new Panel();
            LevelCapExtenderUninstallButton = new Button();
            LevelCapExtender6xButton = new Button();
            LevelCapExtender5xButton = new Button();
            LevelCapExtender4xButton = new Button();
            LevelCapExtender3xButton = new Button();
            LevelCapExtender2xButton = new Button();
            ChooseLevelCapExtenderLabel = new Label();
            pictureBox1 = new PictureBox();
            WatchLearnEnjoyLabel = new Label();
            playBaldursGate3LinkLabel = new LinkLabel();
            YouTubeChannelLabel = new Label();
            eclecticXAtYouTubeChannelLinkLabel = new LinkLabel();
            ChooseLevelCapExtenderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxAboutExtender
            // 
            TextBoxAboutExtender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxAboutExtender.BackColor = Color.White;
            TextBoxAboutExtender.BorderStyle = BorderStyle.None;
            TextBoxAboutExtender.Font = new Font("Segoe UI", 11F);
            TextBoxAboutExtender.Location = new Point(13, 158);
            TextBoxAboutExtender.Name = "TextBoxAboutExtender";
            TextBoxAboutExtender.Size = new Size(776, 296);
            TextBoxAboutExtender.TabIndex = 2;
            TextBoxAboutExtender.Text = resources.GetString("TextBoxAboutExtender.Text");
            TextBoxAboutExtender.TextChanged += TextBoxAboutExtender_TextChanged;
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AboutLabel.Location = new Point(307, 127);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(189, 20);
            AboutLabel.TabIndex = 3;
            AboutLabel.Text = "About Level Cap Extender";
            // 
            // GameInstallationFolderExample
            // 
            GameInstallationFolderExample.AutoSize = true;
            GameInstallationFolderExample.Location = new Point(161, 509);
            GameInstallationFolderExample.Name = "GameInstallationFolderExample";
            GameInstallationFolderExample.Size = new Size(480, 15);
            GameInstallationFolderExample.TabIndex = 5;
            GameInstallationFolderExample.Text = "Example: C:\\Program Files (x86)\\Steam\\steamapps\\common\\Baldurs Gate 3\\bin\\bg3.exe.";
            GameInstallationFolderExample.Click += GameInstallationFolderExample_Click;
            // 
            // openGameLocation
            // 
            openGameLocation.FileName = "bg3.exe";
            // 
            // SelectGameFileButton
            // 
            SelectGameFileButton.Cursor = Cursors.Hand;
            SelectGameFileButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            SelectGameFileButton.ForeColor = SystemColors.HotTrack;
            SelectGameFileButton.Location = new Point(273, 477);
            SelectGameFileButton.Name = "SelectGameFileButton";
            SelectGameFileButton.Size = new Size(256, 29);
            SelectGameFileButton.TabIndex = 6;
            SelectGameFileButton.Text = "Select Game File";
            SelectGameFileButton.UseVisualStyleBackColor = true;
            SelectGameFileButton.Click += SelectGameInstallationFolderButton_Click;
            // 
            // ChooseLevelCapExtenderPanel
            // 
            ChooseLevelCapExtenderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtenderUninstallButton);
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtender6xButton);
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtender5xButton);
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtender4xButton);
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtender3xButton);
            ChooseLevelCapExtenderPanel.Controls.Add(LevelCapExtender2xButton);
            ChooseLevelCapExtenderPanel.Controls.Add(ChooseLevelCapExtenderLabel);
            ChooseLevelCapExtenderPanel.Location = new Point(13, 546);
            ChooseLevelCapExtenderPanel.Name = "ChooseLevelCapExtenderPanel";
            ChooseLevelCapExtenderPanel.Size = new Size(776, 83);
            ChooseLevelCapExtenderPanel.TabIndex = 7;
            ChooseLevelCapExtenderPanel.Visible = false;
            // 
            // LevelCapExtenderUninstallButton
            // 
            LevelCapExtenderUninstallButton.Cursor = Cursors.Hand;
            LevelCapExtenderUninstallButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtenderUninstallButton.ForeColor = Color.FromArgb(192, 0, 0);
            LevelCapExtenderUninstallButton.Location = new Point(8, 31);
            LevelCapExtenderUninstallButton.Name = "LevelCapExtenderUninstallButton";
            LevelCapExtenderUninstallButton.Size = new Size(75, 37);
            LevelCapExtenderUninstallButton.TabIndex = 6;
            LevelCapExtenderUninstallButton.Text = "Uninstall";
            LevelCapExtenderUninstallButton.UseVisualStyleBackColor = true;
            LevelCapExtenderUninstallButton.Click += LevelCapExtenderUninstallButton_Click;
            // 
            // LevelCapExtender6xButton
            // 
            LevelCapExtender6xButton.Cursor = Cursors.Hand;
            LevelCapExtender6xButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtender6xButton.ForeColor = SystemColors.HotTrack;
            LevelCapExtender6xButton.Location = new Point(693, 31);
            LevelCapExtender6xButton.Name = "LevelCapExtender6xButton";
            LevelCapExtender6xButton.Size = new Size(75, 37);
            LevelCapExtender6xButton.TabIndex = 5;
            LevelCapExtender6xButton.Text = "6x";
            LevelCapExtender6xButton.UseVisualStyleBackColor = true;
            LevelCapExtender6xButton.Click += LevelCapExtender6xButton_Click;
            // 
            // LevelCapExtender5xButton
            // 
            LevelCapExtender5xButton.Cursor = Cursors.Hand;
            LevelCapExtender5xButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtender5xButton.ForeColor = SystemColors.HotTrack;
            LevelCapExtender5xButton.Location = new Point(556, 31);
            LevelCapExtender5xButton.Name = "LevelCapExtender5xButton";
            LevelCapExtender5xButton.Size = new Size(75, 37);
            LevelCapExtender5xButton.TabIndex = 4;
            LevelCapExtender5xButton.Text = "5x";
            LevelCapExtender5xButton.UseVisualStyleBackColor = true;
            LevelCapExtender5xButton.Click += LevelCapExtender5xButton_Click;
            // 
            // LevelCapExtender4xButton
            // 
            LevelCapExtender4xButton.Cursor = Cursors.Hand;
            LevelCapExtender4xButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtender4xButton.ForeColor = SystemColors.HotTrack;
            LevelCapExtender4xButton.Location = new Point(419, 31);
            LevelCapExtender4xButton.Name = "LevelCapExtender4xButton";
            LevelCapExtender4xButton.Size = new Size(75, 37);
            LevelCapExtender4xButton.TabIndex = 3;
            LevelCapExtender4xButton.Text = "4x";
            LevelCapExtender4xButton.UseVisualStyleBackColor = true;
            LevelCapExtender4xButton.Click += LevelCapExtender4xButton_Click;
            // 
            // LevelCapExtender3xButton
            // 
            LevelCapExtender3xButton.Cursor = Cursors.Hand;
            LevelCapExtender3xButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtender3xButton.ForeColor = SystemColors.HotTrack;
            LevelCapExtender3xButton.Location = new Point(282, 31);
            LevelCapExtender3xButton.Name = "LevelCapExtender3xButton";
            LevelCapExtender3xButton.Size = new Size(75, 37);
            LevelCapExtender3xButton.TabIndex = 2;
            LevelCapExtender3xButton.Text = "3x";
            LevelCapExtender3xButton.UseVisualStyleBackColor = true;
            LevelCapExtender3xButton.Click += LevelCapExtender3xButton_Click;
            // 
            // LevelCapExtender2xButton
            // 
            LevelCapExtender2xButton.Cursor = Cursors.Hand;
            LevelCapExtender2xButton.Font = new Font("Segoe UI", 11F);
            LevelCapExtender2xButton.ForeColor = SystemColors.HotTrack;
            LevelCapExtender2xButton.Location = new Point(145, 31);
            LevelCapExtender2xButton.Name = "LevelCapExtender2xButton";
            LevelCapExtender2xButton.Size = new Size(75, 37);
            LevelCapExtender2xButton.TabIndex = 1;
            LevelCapExtender2xButton.Text = "2x";
            LevelCapExtender2xButton.UseVisualStyleBackColor = true;
            LevelCapExtender2xButton.Click += LevelCapExtender2xButton_Click;
            // 
            // ChooseLevelCapExtenderLabel
            // 
            ChooseLevelCapExtenderLabel.AutoSize = true;
            ChooseLevelCapExtenderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ChooseLevelCapExtenderLabel.Location = new Point(0, 0);
            ChooseLevelCapExtenderLabel.Name = "ChooseLevelCapExtenderLabel";
            ChooseLevelCapExtenderLabel.Size = new Size(196, 20);
            ChooseLevelCapExtenderLabel.TabIndex = 0;
            ChooseLevelCapExtenderLabel.Text = "Choose Level Cap Extender";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 99);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // WatchLearnEnjoyLabel
            // 
            WatchLearnEnjoyLabel.AutoSize = true;
            WatchLearnEnjoyLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            WatchLearnEnjoyLabel.Location = new Point(66, 62);
            WatchLearnEnjoyLabel.Name = "WatchLearnEnjoyLabel";
            WatchLearnEnjoyLabel.Size = new Size(140, 20);
            WatchLearnEnjoyLabel.TabIndex = 13;
            WatchLearnEnjoyLabel.Text = "watch, learn, enjoy";
            // 
            // playBaldursGate3LinkLabel
            // 
            playBaldursGate3LinkLabel.AutoSize = true;
            playBaldursGate3LinkLabel.Font = new Font("Segoe UI", 11F);
            playBaldursGate3LinkLabel.Location = new Point(58, 36);
            playBaldursGate3LinkLabel.Name = "playBaldursGate3LinkLabel";
            playBaldursGate3LinkLabel.Size = new Size(156, 20);
            playBaldursGate3LinkLabel.TabIndex = 12;
            playBaldursGate3LinkLabel.TabStop = true;
            playBaldursGate3LinkLabel.Text = "playbaldursgate3.com";
            playBaldursGate3LinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // YouTubeChannelLabel
            // 
            YouTubeChannelLabel.AutoSize = true;
            YouTubeChannelLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            YouTubeChannelLabel.Location = new Point(586, 62);
            YouTubeChannelLabel.Name = "YouTubeChannelLabel";
            YouTubeChannelLabel.Size = new Size(122, 20);
            YouTubeChannelLabel.TabIndex = 15;
            YouTubeChannelLabel.Text = "visit my channel";
            // 
            // eclecticXAtYouTubeChannelLinkLabel
            // 
            eclecticXAtYouTubeChannelLinkLabel.AutoSize = true;
            eclecticXAtYouTubeChannelLinkLabel.Font = new Font("Segoe UI", 11F);
            eclecticXAtYouTubeChannelLinkLabel.Location = new Point(558, 36);
            eclecticXAtYouTubeChannelLinkLabel.Name = "eclecticXAtYouTubeChannelLinkLabel";
            eclecticXAtYouTubeChannelLinkLabel.Size = new Size(178, 20);
            eclecticXAtYouTubeChannelLinkLabel.TabIndex = 14;
            eclecticXAtYouTubeChannelLinkLabel.TabStop = true;
            eclecticXAtYouTubeChannelLinkLabel.Text = "eclectic x @ youtube.com";
            eclecticXAtYouTubeChannelLinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 640);
            Controls.Add(YouTubeChannelLabel);
            Controls.Add(eclecticXAtYouTubeChannelLinkLabel);
            Controls.Add(WatchLearnEnjoyLabel);
            Controls.Add(playBaldursGate3LinkLabel);
            Controls.Add(pictureBox1);
            Controls.Add(ChooseLevelCapExtenderPanel);
            Controls.Add(SelectGameFileButton);
            Controls.Add(GameInstallationFolderExample);
            Controls.Add(AboutLabel);
            Controls.Add(TextBoxAboutExtender);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Text = "Level Cap Extender";
            ChooseLevelCapExtenderPanel.ResumeLayout(false);
            ChooseLevelCapExtenderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextBoxAboutExtender;
        private Label AboutLabel;
        private Label GameInstallationFolderExample;
        private OpenFileDialog openGameLocation;
        private Button SelectGameFileButton;
        private Panel ChooseLevelCapExtenderPanel;
        private Label ChooseLevelCapExtenderLabel;
        private Button LevelCapExtender6xButton;
        private Button LevelCapExtender5xButton;
        private Button LevelCapExtender4xButton;
        private Button LevelCapExtender3xButton;
        private Button LevelCapExtender2xButton;
        private PictureBox pictureBox1;
        private Button LevelCapExtenderUninstallButton;
        private Label WatchLearnEnjoyLabel;
        private LinkLabel playBaldursGate3LinkLabel;
        private Label YouTubeChannelLabel;
        private LinkLabel eclecticXAtYouTubeChannelLinkLabel;
    }
}
