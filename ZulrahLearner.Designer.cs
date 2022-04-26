
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zulrah));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.lblInterface = new System.Windows.Forms.Label();
            this.pbMelee = new System.Windows.Forms.PictureBox();
            this.pbRange = new System.Windows.Forms.PictureBox();
            this.pbMage = new System.Windows.Forms.PictureBox();
            this.pbHelm = new System.Windows.Forms.PictureBox();
            this.pbWeapon = new System.Windows.Forms.PictureBox();
            this.PhaseTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.pbZulrah = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.pbZulrahShrine = new System.Windows.Forms.PictureBox();
            this.cbJadPhase = new System.Windows.Forms.CheckBox();
            this.cmbPhase = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbLoop = new System.Windows.Forms.CheckBox();
            this.cbHideRotationInfo = new System.Windows.Forms.CheckBox();
            this.cmsPhaseGen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.phaseGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMelee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrahShrine)).BeginInit();
            this.cmsPhaseGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(879, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlInventory
            // 
            this.pnlInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventory.Controls.Add(this.lblInterface);
            this.pnlInventory.Controls.Add(this.pbMelee);
            this.pnlInventory.Controls.Add(this.pbRange);
            this.pnlInventory.Controls.Add(this.pbMage);
            this.pnlInventory.Controls.Add(this.pbHelm);
            this.pnlInventory.Controls.Add(this.pbWeapon);
            this.pnlInventory.Location = new System.Drawing.Point(646, 107);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(268, 407);
            this.pnlInventory.TabIndex = 2;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInterface.Location = new System.Drawing.Point(65, 371);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(115, 35);
            this.lblInterface.TabIndex = 5;
            this.lblInterface.Text = " Prayers";
            // 
            // pbMelee
            // 
            this.pbMelee.Image = ((System.Drawing.Image)(resources.GetObject("pbMelee.Image")));
            this.pbMelee.Location = new System.Drawing.Point(169, 181);
            this.pbMelee.Name = "pbMelee";
            this.pbMelee.Size = new System.Drawing.Size(45, 50);
            this.pbMelee.TabIndex = 4;
            this.pbMelee.TabStop = false;
            this.pbMelee.Click += new System.EventHandler(this.pbMelee_Click);
            // 
            // pbRange
            // 
            this.pbRange.Image = ((System.Drawing.Image)(resources.GetObject("pbRange.Image")));
            this.pbRange.Location = new System.Drawing.Point(112, 181);
            this.pbRange.Name = "pbRange";
            this.pbRange.Size = new System.Drawing.Size(45, 50);
            this.pbRange.TabIndex = 3;
            this.pbRange.TabStop = false;
            this.pbRange.Click += new System.EventHandler(this.pbRange_Click);
            // 
            // pbMage
            // 
            this.pbMage.Image = ((System.Drawing.Image)(resources.GetObject("pbMage.Image")));
            this.pbMage.Location = new System.Drawing.Point(55, 181);
            this.pbMage.Name = "pbMage";
            this.pbMage.Size = new System.Drawing.Size(45, 50);
            this.pbMage.TabIndex = 2;
            this.pbMage.TabStop = false;
            this.pbMage.Click += new System.EventHandler(this.pbMage_Click);
            // 
            // pbHelm
            // 
            this.pbHelm.Image = ((System.Drawing.Image)(resources.GetObject("pbHelm.Image")));
            this.pbHelm.Location = new System.Drawing.Point(85, 12);
            this.pbHelm.Name = "pbHelm";
            this.pbHelm.Size = new System.Drawing.Size(50, 50);
            this.pbHelm.TabIndex = 1;
            this.pbHelm.TabStop = false;
            this.pbHelm.Tag = "";
            this.pbHelm.Click += new System.EventHandler(this.pbHelm_Click);
            // 
            // pbWeapon
            // 
            this.pbWeapon.Image = ((System.Drawing.Image)(resources.GetObject("pbWeapon.Image")));
            this.pbWeapon.Location = new System.Drawing.Point(17, 12);
            this.pbWeapon.Name = "pbWeapon";
            this.pbWeapon.Size = new System.Drawing.Size(50, 50);
            this.pbWeapon.TabIndex = 0;
            this.pbWeapon.TabStop = false;
            this.pbWeapon.Tag = "";
            this.pbWeapon.Click += new System.EventHandler(this.pbWeapon_Click);
            // 
            // PhaseTimer
            // 
            this.PhaseTimer.Interval = 20;
            this.PhaseTimer.Tick += new System.EventHandler(this.PhaseTimer_TickUp);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLeft.Location = new System.Drawing.Point(721, 39);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(36, 30);
            this.lblTimeLeft.TabIndex = 7;
            this.lblTimeLeft.Text = " 6";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRotation.Location = new System.Drawing.Point(646, 6);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(83, 21);
            this.lblRotation.TabIndex = 8;
            this.lblRotation.Text = "Rotation A";
            // 
            // pbZulrah
            // 
            this.pbZulrah.Location = new System.Drawing.Point(-100, -100);
            this.pbZulrah.Name = "pbZulrah";
            this.pbZulrah.Size = new System.Drawing.Size(80, 80);
            this.pbZulrah.TabIndex = 10;
            this.pbZulrah.TabStop = false;
            this.pbZulrah.Click += new System.EventHandler(this.pbZulrah_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(566, 517);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 28);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = " 0  /  0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(504, 517);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(56, 26);
            this.Score.TabIndex = 12;
            this.Score.Text = "Score";
            // 
            // pbZulrahShrine
            // 
            this.pbZulrahShrine.ContextMenuStrip = this.cmsPhaseGen;
            this.pbZulrahShrine.Image = ((System.Drawing.Image)(resources.GetObject("pbZulrahShrine.Image")));
            this.pbZulrahShrine.Location = new System.Drawing.Point(3, 6);
            this.pbZulrahShrine.Name = "pbZulrahShrine";
            this.pbZulrahShrine.Size = new System.Drawing.Size(629, 508);
            this.pbZulrahShrine.TabIndex = 13;
            this.pbZulrahShrine.TabStop = false;
            this.pbZulrahShrine.Paint += new System.Windows.Forms.PaintEventHandler(this.pbZulrahShrine_Paint);
            this.pbZulrahShrine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbZulrahShrine_MouseDown);
            // 
            // cbJadPhase
            // 
            this.cbJadPhase.AutoSize = true;
            this.cbJadPhase.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbJadPhase.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbJadPhase.Location = new System.Drawing.Point(831, 55);
            this.cbJadPhase.Name = "cbJadPhase";
            this.cbJadPhase.Size = new System.Drawing.Size(83, 46);
            this.cbJadPhase.TabIndex = 14;
            this.cbJadPhase.Text = "Jad Phase";
            this.cbJadPhase.UseVisualStyleBackColor = true;
            // 
            // cmbPhase
            // 
            this.cmbPhase.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPhase.FormattingEnabled = true;
            this.cmbPhase.Items.AddRange(new object[] {
            "      Rotation A",
            "      Rotation B",
            "      Rotation C",
            "      Rotation D",
            "      Random"});
            this.cmbPhase.Location = new System.Drawing.Point(6, 524);
            this.cmbPhase.Name = "cmbPhase";
            this.cmbPhase.Size = new System.Drawing.Size(156, 34);
            this.cmbPhase.TabIndex = 16;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(700, 525);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 34);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(785, 525);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 34);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoop.Location = new System.Drawing.Point(178, 528);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(74, 30);
            this.cbLoop.TabIndex = 19;
            this.cbLoop.Text = "Loop";
            this.cbLoop.UseVisualStyleBackColor = true;
            // 
            // cbHideRotationInfo
            // 
            this.cbHideRotationInfo.AutoSize = true;
            this.cbHideRotationInfo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHideRotationInfo.Location = new System.Drawing.Point(258, 528);
            this.cbHideRotationInfo.Name = "cbHideRotationInfo";
            this.cbHideRotationInfo.Size = new System.Drawing.Size(147, 30);
            this.cbHideRotationInfo.TabIndex = 20;
            this.cbHideRotationInfo.Text = "Hide Rotation";
            this.cbHideRotationInfo.UseVisualStyleBackColor = true;
            // 
            // cmsPhaseGen
            // 
            this.cmsPhaseGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phaseGeneratorToolStripMenuItem});
            this.cmsPhaseGen.Name = "cmsPhaseGen";
            this.cmsPhaseGen.Size = new System.Drawing.Size(161, 26);
            // 
            // phaseGeneratorToolStripMenuItem
            // 
            this.phaseGeneratorToolStripMenuItem.Name = "phaseGeneratorToolStripMenuItem";
            this.phaseGeneratorToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.phaseGeneratorToolStripMenuItem.Text = "Phase Generator";
            this.phaseGeneratorToolStripMenuItem.Click += new System.EventHandler(this.phaseGeneratorToolStripMenuItem_Click);
            // 
            // Zulrah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(917, 571);
            this.ContextMenuStrip = this.cmsPhaseGen;
            this.Controls.Add(this.cbHideRotationInfo);
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbPhase);
            this.Controls.Add(this.cbJadPhase);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbZulrah);
            this.Controls.Add(this.lblRotation);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbZulrahShrine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zulrah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zulrah Learner";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Zulrah_Paint);
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMelee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrahShrine)).EndInit();
            this.cmsPhaseGen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.PictureBox pbMelee;
        private System.Windows.Forms.PictureBox pbRange;
        private System.Windows.Forms.PictureBox pbMage;
        private System.Windows.Forms.PictureBox pbHelm;
        private System.Windows.Forms.PictureBox pbWeapon;
        private System.Windows.Forms.Label lblInterface;
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
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.CheckBox cbHideRotationInfo;
        private System.Windows.Forms.ContextMenuStrip cmsPhaseGen;
        private System.Windows.Forms.ToolStripMenuItem phaseGeneratorToolStripMenuItem;
    }
}

