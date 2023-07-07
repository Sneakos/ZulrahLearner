namespace ZulrahLearner
{
    partial class ZulrahLearnerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZulrahLearnerSettings));
            pnlSettings = new System.Windows.Forms.Panel();
            cbLoop = new System.Windows.Forms.CheckBox();
            cbHideRotation = new System.Windows.Forms.CheckBox();
            txtSecondsPerPhase = new System.Windows.Forms.TextBox();
            lblSecondsPerPhase = new System.Windows.Forms.Label();
            pnlButtons = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            checkBox1 = new System.Windows.Forms.CheckBox();
            pnlSettings.SuspendLayout();
            pnlButtons.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(checkBox1);
            pnlSettings.Controls.Add(panel1);
            pnlSettings.Controls.Add(cbLoop);
            pnlSettings.Controls.Add(cbHideRotation);
            pnlSettings.Location = new System.Drawing.Point(12, 12);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new System.Drawing.Size(260, 137);
            pnlSettings.TabIndex = 0;
            // 
            // cbLoop
            // 
            cbLoop.AutoSize = true;
            cbLoop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cbLoop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbLoop.Location = new System.Drawing.Point(3, 3);
            cbLoop.Name = "cbLoop";
            cbLoop.Size = new System.Drawing.Size(73, 29);
            cbLoop.TabIndex = 5;
            cbLoop.Text = "Loop";
            cbLoop.UseVisualStyleBackColor = true;
            // 
            // cbHideRotation
            // 
            cbHideRotation.AutoSize = true;
            cbHideRotation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            cbHideRotation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbHideRotation.Location = new System.Drawing.Point(103, 3);
            cbHideRotation.Name = "cbHideRotation";
            cbHideRotation.Size = new System.Drawing.Size(145, 29);
            cbHideRotation.TabIndex = 4;
            cbHideRotation.Text = "Hide Rotation";
            cbHideRotation.UseVisualStyleBackColor = true;
            // 
            // txtSecondsPerPhase
            // 
            txtSecondsPerPhase.Location = new System.Drawing.Point(179, 5);
            txtSecondsPerPhase.Name = "txtSecondsPerPhase";
            txtSecondsPerPhase.Size = new System.Drawing.Size(69, 23);
            txtSecondsPerPhase.TabIndex = 3;
            // 
            // lblSecondsPerPhase
            // 
            lblSecondsPerPhase.AutoSize = true;
            lblSecondsPerPhase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSecondsPerPhase.Location = new System.Drawing.Point(3, 3);
            lblSecondsPerPhase.Name = "lblSecondsPerPhase";
            lblSecondsPerPhase.Size = new System.Drawing.Size(170, 25);
            lblSecondsPerPhase.TabIndex = 2;
            lblSecondsPerPhase.Text = "Seconds per Phase";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Location = new System.Drawing.Point(15, 153);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new System.Drawing.Size(257, 31);
            pnlButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(126, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(64, 28);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(56, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(64, 28);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSecondsPerPhase);
            panel1.Controls.Add(txtSecondsPerPhase);
            panel1.Location = new System.Drawing.Point(3, 101);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(254, 33);
            panel1.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(94, 54);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(73, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Loop";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ZulrahLearnerSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(284, 246);
            Controls.Add(pnlButtons);
            Controls.Add(pnlSettings);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ZulrahLearnerSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            pnlSettings.ResumeLayout(false);
            pnlSettings.PerformLayout();
            pnlButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSecondsPerPhase;
        private System.Windows.Forms.Label lblHideRotations;
        private System.Windows.Forms.Label lblLoop;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.CheckBox cbHideRotation;
        private System.Windows.Forms.TextBox txtSecondsPerPhase;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}