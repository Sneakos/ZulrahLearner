
namespace ZulrahLearner
{
    partial class Zulrah
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zulrah));
            PhaseTimer = new System.Windows.Forms.Timer(components);
            lblTimeLeft = new System.Windows.Forms.Label();
            lblRotation = new System.Windows.Forms.Label();
            pbZulrah = new System.Windows.Forms.PictureBox();
            lblScore = new System.Windows.Forms.Label();
            Score = new System.Windows.Forms.Label();
            pbZulrahShrine = new System.Windows.Forms.PictureBox();
            cmsPhaseGen = new System.Windows.Forms.ContextMenuStrip(components);
            phaseGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cbJadPhase = new System.Windows.Forms.CheckBox();
            cmbPhase = new System.Windows.Forms.ComboBox();
            btnStart = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            pnlPhaseInfo = new System.Windows.Forms.Panel();
            pnlScore = new System.Windows.Forms.Panel();
            pnlTimer = new System.Windows.Forms.Panel();
            inventoryScreen = new OSRSGearSetup.Controls.InventoryScreen();
            prayerScreen = new OSRSGearSetup.Controls.PrayerScreen();
            gearScreen = new OSRSGearSetup.Controls.GearScreen();
            pnlScreenButtons = new System.Windows.Forms.Panel();
            btnGear = new System.Windows.Forms.Button();
            btnPrayer = new System.Windows.Forms.Button();
            btnInventory = new System.Windows.Forms.Button();
            pnlStartStop = new System.Windows.Forms.Panel();
            pnlRotation = new System.Windows.Forms.Panel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbZulrah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbZulrahShrine).BeginInit();
            cmsPhaseGen.SuspendLayout();
            pnlPhaseInfo.SuspendLayout();
            pnlScore.SuspendLayout();
            pnlTimer.SuspendLayout();
            pnlScreenButtons.SuspendLayout();
            pnlStartStop.SuspendLayout();
            pnlRotation.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PhaseTimer
            // 
            PhaseTimer.Interval = 20;
            PhaseTimer.Tick += PhaseTimer_TickUp;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTimeLeft.Location = new System.Drawing.Point(0, 0);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new System.Drawing.Size(192, 32);
            lblTimeLeft.TabIndex = 7;
            lblTimeLeft.Text = " 6";
            lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotation
            // 
            lblRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            lblRotation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRotation.Location = new System.Drawing.Point(0, 0);
            lblRotation.Name = "lblRotation";
            lblRotation.Size = new System.Drawing.Size(192, 31);
            lblRotation.TabIndex = 8;
            lblRotation.Text = "Rotation A";
            lblRotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbZulrah
            // 
            pbZulrah.Location = new System.Drawing.Point(-100, -100);
            pbZulrah.Name = "pbZulrah";
            pbZulrah.Size = new System.Drawing.Size(80, 80);
            pbZulrah.TabIndex = 10;
            pbZulrah.TabStop = false;
            pbZulrah.Click += pbZulrah_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScore.Location = new System.Drawing.Point(69, 1);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(66, 28);
            lblScore.TabIndex = 11;
            lblScore.Text = " 0  /  0";
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Score.Location = new System.Drawing.Point(3, 2);
            Score.Name = "Score";
            Score.Size = new System.Drawing.Size(56, 26);
            Score.TabIndex = 12;
            Score.Text = "Score";
            // 
            // pbZulrahShrine
            // 
            pbZulrahShrine.ContextMenuStrip = cmsPhaseGen;
            pbZulrahShrine.Image = (System.Drawing.Image)resources.GetObject("pbZulrahShrine.Image");
            pbZulrahShrine.Location = new System.Drawing.Point(0, 27);
            pbZulrahShrine.Name = "pbZulrahShrine";
            pbZulrahShrine.Size = new System.Drawing.Size(629, 508);
            pbZulrahShrine.TabIndex = 13;
            pbZulrahShrine.TabStop = false;
            pbZulrahShrine.Paint += pbZulrahShrine_Paint;
            pbZulrahShrine.MouseDown += pbZulrahShrine_MouseDown;
            // 
            // cmsPhaseGen
            // 
            cmsPhaseGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { phaseGeneratorToolStripMenuItem });
            cmsPhaseGen.Name = "cmsPhaseGen";
            cmsPhaseGen.Size = new System.Drawing.Size(161, 26);
            // 
            // phaseGeneratorToolStripMenuItem
            // 
            phaseGeneratorToolStripMenuItem.Name = "phaseGeneratorToolStripMenuItem";
            phaseGeneratorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            phaseGeneratorToolStripMenuItem.Text = "Phase Generator";
            phaseGeneratorToolStripMenuItem.Click += phaseGeneratorToolStripMenuItem_Click;
            // 
            // cbJadPhase
            // 
            cbJadPhase.AutoSize = true;
            cbJadPhase.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            cbJadPhase.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbJadPhase.Location = new System.Drawing.Point(700, 468);
            cbJadPhase.Name = "cbJadPhase";
            cbJadPhase.Size = new System.Drawing.Size(83, 46);
            cbJadPhase.TabIndex = 14;
            cbJadPhase.Text = "Jad Phase";
            cbJadPhase.UseVisualStyleBackColor = true;
            // 
            // cmbPhase
            // 
            cmbPhase.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbPhase.FormattingEnabled = true;
            cmbPhase.Items.AddRange(new object[] { "      Rotation A", "      Rotation B", "      Rotation C", "      Rotation D", "      Random" });
            cmbPhase.Location = new System.Drawing.Point(7, 3);
            cmbPhase.Name = "cmbPhase";
            cmbPhase.Size = new System.Drawing.Size(156, 34);
            cmbPhase.TabIndex = 16;
            cmbPhase.SelectedIndexChanged += cmbPhase_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            btnStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(3, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(79, 34);
            btnStart.TabIndex = 17;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.Red;
            btnStop.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStop.Location = new System.Drawing.Point(129, 6);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(76, 34);
            btnStop.TabIndex = 18;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // pnlPhaseInfo
            // 
            pnlPhaseInfo.Controls.Add(pnlScore);
            pnlPhaseInfo.Controls.Add(cmbPhase);
            pnlPhaseInfo.Location = new System.Drawing.Point(0, 538);
            pnlPhaseInfo.Name = "pnlPhaseInfo";
            pnlPhaseInfo.Size = new System.Drawing.Size(629, 42);
            pnlPhaseInfo.TabIndex = 21;
            // 
            // pnlScore
            // 
            pnlScore.Controls.Add(Score);
            pnlScore.Controls.Add(lblScore);
            pnlScore.Location = new System.Drawing.Point(489, 5);
            pnlScore.Name = "pnlScore";
            pnlScore.Size = new System.Drawing.Size(138, 34);
            pnlScore.TabIndex = 21;
            // 
            // pnlTimer
            // 
            pnlTimer.Controls.Add(lblTimeLeft);
            pnlTimer.Location = new System.Drawing.Point(643, 62);
            pnlTimer.Name = "pnlTimer";
            pnlTimer.Size = new System.Drawing.Size(192, 32);
            pnlTimer.TabIndex = 22;
            // 
            // inventoryScreen
            // 
            inventoryScreen.ButtonClick = null;
            inventoryScreen.Location = new System.Drawing.Point(643, 100);
            inventoryScreen.Name = "inventoryScreen";
            inventoryScreen.Size = new System.Drawing.Size(200, 328);
            inventoryScreen.TabIndex = 23;
            // 
            // prayerScreen
            // 
            prayerScreen.ButtonClick = null;
            prayerScreen.Location = new System.Drawing.Point(647, 100);
            prayerScreen.Name = "prayerScreen";
            prayerScreen.Size = new System.Drawing.Size(200, 328);
            prayerScreen.TabIndex = 24;
            // 
            // gearScreen
            // 
            gearScreen.ButtonClick = null;
            gearScreen.Location = new System.Drawing.Point(635, 100);
            gearScreen.Name = "gearScreen";
            gearScreen.Size = new System.Drawing.Size(200, 328);
            gearScreen.TabIndex = 25;
            // 
            // pnlScreenButtons
            // 
            pnlScreenButtons.Controls.Add(btnGear);
            pnlScreenButtons.Controls.Add(btnPrayer);
            pnlScreenButtons.Controls.Add(btnInventory);
            pnlScreenButtons.Location = new System.Drawing.Point(647, 422);
            pnlScreenButtons.Name = "pnlScreenButtons";
            pnlScreenButtons.Size = new System.Drawing.Size(188, 40);
            pnlScreenButtons.TabIndex = 26;
            // 
            // btnGear
            // 
            btnGear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGear.Location = new System.Drawing.Point(130, 2);
            btnGear.Name = "btnGear";
            btnGear.Size = new System.Drawing.Size(55, 35);
            btnGear.TabIndex = 2;
            btnGear.Text = "Gear";
            btnGear.UseVisualStyleBackColor = true;
            // 
            // btnPrayer
            // 
            btnPrayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrayer.Location = new System.Drawing.Point(72, 2);
            btnPrayer.Name = "btnPrayer";
            btnPrayer.Size = new System.Drawing.Size(52, 35);
            btnPrayer.TabIndex = 1;
            btnPrayer.Text = "Prayers";
            btnPrayer.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            btnInventory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInventory.Location = new System.Drawing.Point(3, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new System.Drawing.Size(63, 35);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            // 
            // pnlStartStop
            // 
            pnlStartStop.Controls.Add(btnStart);
            pnlStartStop.Controls.Add(btnStop);
            pnlStartStop.Location = new System.Drawing.Point(635, 535);
            pnlStartStop.Name = "pnlStartStop";
            pnlStartStop.Size = new System.Drawing.Size(212, 45);
            pnlStartStop.TabIndex = 27;
            // 
            // pnlRotation
            // 
            pnlRotation.Controls.Add(lblRotation);
            pnlRotation.Location = new System.Drawing.Point(643, 27);
            pnlRotation.Name = "pnlRotation";
            pnlRotation.Size = new System.Drawing.Size(192, 31);
            pnlRotation.TabIndex = 28;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(852, 24);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // Zulrah
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(852, 584);
            ContextMenuStrip = cmsPhaseGen;
            Controls.Add(menuStrip1);
            Controls.Add(pnlRotation);
            Controls.Add(pnlStartStop);
            Controls.Add(pnlScreenButtons);
            Controls.Add(inventoryScreen);
            Controls.Add(prayerScreen);
            Controls.Add(pnlTimer);
            Controls.Add(pnlPhaseInfo);
            Controls.Add(cbJadPhase);
            Controls.Add(pbZulrah);
            Controls.Add(pbZulrahShrine);
            Controls.Add(gearScreen);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Zulrah";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Zulrah Learner";
            Load += Zulrah_Load;
            Paint += Zulrah_Paint;
            ((System.ComponentModel.ISupportInitialize)pbZulrah).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbZulrahShrine).EndInit();
            cmsPhaseGen.ResumeLayout(false);
            pnlPhaseInfo.ResumeLayout(false);
            pnlScore.ResumeLayout(false);
            pnlScore.PerformLayout();
            pnlTimer.ResumeLayout(false);
            pnlScreenButtons.ResumeLayout(false);
            pnlStartStop.ResumeLayout(false);
            pnlRotation.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer PhaseTimer;
        private SharedControls.LoadingBar loadingBar;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.PictureBox pbZulrah;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox pbZulrahShrine;
        private System.Windows.Forms.CheckBox cbJadPhase;
        private System.Windows.Forms.ComboBox cmbPhase;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ContextMenuStrip cmsPhaseGen;
        private System.Windows.Forms.ToolStripMenuItem phaseGeneratorToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPhaseInfo;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel pnlTimer;
        private OSRSGearSetup.Controls.InventoryScreen inventoryScreen;
        private OSRSGearSetup.Controls.PrayerScreen prayerScreen;
        private OSRSGearSetup.Controls.GearScreen gearScreen;
        private System.Windows.Forms.Panel pnlScreenButtons;
        private System.Windows.Forms.Button btnGear;
        private System.Windows.Forms.Button btnPrayer;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlStartStop;
        private System.Windows.Forms.Panel pnlRotation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

