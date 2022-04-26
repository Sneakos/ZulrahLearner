
namespace ZulrahLearner
{
    partial class ZulrahPhaseGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZulrahPhaseGenerator));
            this.cmbPhases = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHelm = new System.Windows.Forms.Label();
            this.rdioHelmMage = new System.Windows.Forms.RadioButton();
            this.rdioHelmRange = new System.Windows.Forms.RadioButton();
            this.rdioWeaponCrossbow = new System.Windows.Forms.RadioButton();
            this.rdioWeaponStaff = new System.Windows.Forms.RadioButton();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.rdioPrayerRange = new System.Windows.Forms.RadioButton();
            this.rdioPrayerMage = new System.Windows.Forms.RadioButton();
            this.lblPrayer = new System.Windows.Forms.Label();
            this.rdioZulrahStyleMelee = new System.Windows.Forms.RadioButton();
            this.rdioZulrahStyleRange = new System.Windows.Forms.RadioButton();
            this.rdioZulrahStyleMage = new System.Windows.Forms.RadioButton();
            this.lblZulrahStyles = new System.Windows.Forms.Label();
            this.lblZulrahBlockID = new System.Windows.Forms.Label();
            this.rdioZulrahBlockID9 = new System.Windows.Forms.RadioButton();
            this.rdioZulrahBlockID8 = new System.Windows.Forms.RadioButton();
            this.rdioZulrahBlockID7 = new System.Windows.Forms.RadioButton();
            this.rdioZulrahBlockID10 = new System.Windows.Forms.RadioButton();
            this.lblPlayerBlockIDs = new System.Windows.Forms.Label();
            this.txtPlayerBlockIDs1 = new System.Windows.Forms.TextBox();
            this.pnlPrayers = new System.Windows.Forms.Panel();
            this.rdioPrayerNone = new System.Windows.Forms.RadioButton();
            this.pnlZulrahStyles = new System.Windows.Forms.Panel();
            this.pnlWeapons = new System.Windows.Forms.Panel();
            this.pnlHelm = new System.Windows.Forms.Panel();
            this.pnlZulrahBlockID = new System.Windows.Forms.Panel();
            this.pnlPlayerBlockIds = new System.Windows.Forms.Panel();
            this.txtPlayerBlockIDs3 = new System.Windows.Forms.TextBox();
            this.txtPlayerBlockIDs2 = new System.Windows.Forms.TextBox();
            this.pnlJadPhase = new System.Windows.Forms.Panel();
            this.rdioJadPhase = new System.Windows.Forms.RadioButton();
            this.pnlRotationInfo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbZulrahShrine = new System.Windows.Forms.PictureBox();
            this.pnlPrayers.SuspendLayout();
            this.pnlZulrahStyles.SuspendLayout();
            this.pnlWeapons.SuspendLayout();
            this.pnlHelm.SuspendLayout();
            this.pnlZulrahBlockID.SuspendLayout();
            this.pnlPlayerBlockIds.SuspendLayout();
            this.pnlJadPhase.SuspendLayout();
            this.pnlRotationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrahShrine)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPhases
            // 
            this.cmbPhases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPhases.FormattingEnabled = true;
            this.cmbPhases.Location = new System.Drawing.Point(12, 17);
            this.cmbPhases.Name = "cmbPhases";
            this.cmbPhases.Size = new System.Drawing.Size(162, 29);
            this.cmbPhases.TabIndex = 2;
            this.cmbPhases.SelectedIndexChanged += new System.EventHandler(this.cmbPhases_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(180, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHelm
            // 
            this.lblHelm.AutoSize = true;
            this.lblHelm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelm.Location = new System.Drawing.Point(12, 3);
            this.lblHelm.Name = "lblHelm";
            this.lblHelm.Size = new System.Drawing.Size(56, 25);
            this.lblHelm.TabIndex = 4;
            this.lblHelm.Text = "Helm";
            // 
            // rdioHelmMage
            // 
            this.rdioHelmMage.AutoSize = true;
            this.rdioHelmMage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioHelmMage.Location = new System.Drawing.Point(9, 31);
            this.rdioHelmMage.Name = "rdioHelmMage";
            this.rdioHelmMage.Size = new System.Drawing.Size(67, 25);
            this.rdioHelmMage.TabIndex = 5;
            this.rdioHelmMage.TabStop = true;
            this.rdioHelmMage.Text = "Mage";
            this.rdioHelmMage.UseVisualStyleBackColor = true;
            // 
            // rdioHelmRange
            // 
            this.rdioHelmRange.AutoSize = true;
            this.rdioHelmRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioHelmRange.Location = new System.Drawing.Point(9, 62);
            this.rdioHelmRange.Name = "rdioHelmRange";
            this.rdioHelmRange.Size = new System.Drawing.Size(72, 25);
            this.rdioHelmRange.TabIndex = 6;
            this.rdioHelmRange.TabStop = true;
            this.rdioHelmRange.Text = "Range";
            this.rdioHelmRange.UseVisualStyleBackColor = true;
            // 
            // rdioWeaponCrossbow
            // 
            this.rdioWeaponCrossbow.AutoSize = true;
            this.rdioWeaponCrossbow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioWeaponCrossbow.Location = new System.Drawing.Point(11, 62);
            this.rdioWeaponCrossbow.Name = "rdioWeaponCrossbow";
            this.rdioWeaponCrossbow.Size = new System.Drawing.Size(58, 25);
            this.rdioWeaponCrossbow.TabIndex = 9;
            this.rdioWeaponCrossbow.TabStop = true;
            this.rdioWeaponCrossbow.Text = "Bow";
            this.rdioWeaponCrossbow.UseVisualStyleBackColor = true;
            // 
            // rdioWeaponStaff
            // 
            this.rdioWeaponStaff.AutoSize = true;
            this.rdioWeaponStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioWeaponStaff.Location = new System.Drawing.Point(11, 33);
            this.rdioWeaponStaff.Name = "rdioWeaponStaff";
            this.rdioWeaponStaff.Size = new System.Drawing.Size(59, 25);
            this.rdioWeaponStaff.TabIndex = 8;
            this.rdioWeaponStaff.TabStop = true;
            this.rdioWeaponStaff.Text = "Staff";
            this.rdioWeaponStaff.UseVisualStyleBackColor = true;
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeapon.Location = new System.Drawing.Point(5, 5);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(82, 25);
            this.lblWeapon.TabIndex = 7;
            this.lblWeapon.Text = "Weapon";
            // 
            // rdioPrayerRange
            // 
            this.rdioPrayerRange.AutoSize = true;
            this.rdioPrayerRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioPrayerRange.Location = new System.Drawing.Point(4, 64);
            this.rdioPrayerRange.Name = "rdioPrayerRange";
            this.rdioPrayerRange.Size = new System.Drawing.Size(72, 25);
            this.rdioPrayerRange.TabIndex = 12;
            this.rdioPrayerRange.TabStop = true;
            this.rdioPrayerRange.Text = "Range";
            this.rdioPrayerRange.UseVisualStyleBackColor = true;
            // 
            // rdioPrayerMage
            // 
            this.rdioPrayerMage.AutoSize = true;
            this.rdioPrayerMage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioPrayerMage.Location = new System.Drawing.Point(4, 33);
            this.rdioPrayerMage.Name = "rdioPrayerMage";
            this.rdioPrayerMage.Size = new System.Drawing.Size(67, 25);
            this.rdioPrayerMage.TabIndex = 11;
            this.rdioPrayerMage.TabStop = true;
            this.rdioPrayerMage.Text = "Mage";
            this.rdioPrayerMage.UseVisualStyleBackColor = true;
            // 
            // lblPrayer
            // 
            this.lblPrayer.AutoSize = true;
            this.lblPrayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrayer.Location = new System.Drawing.Point(7, 5);
            this.lblPrayer.Name = "lblPrayer";
            this.lblPrayer.Size = new System.Drawing.Size(66, 25);
            this.lblPrayer.TabIndex = 10;
            this.lblPrayer.Text = "Prayer";
            // 
            // rdioZulrahStyleMelee
            // 
            this.rdioZulrahStyleMelee.AutoSize = true;
            this.rdioZulrahStyleMelee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahStyleMelee.Location = new System.Drawing.Point(22, 95);
            this.rdioZulrahStyleMelee.Name = "rdioZulrahStyleMelee";
            this.rdioZulrahStyleMelee.Size = new System.Drawing.Size(70, 25);
            this.rdioZulrahStyleMelee.TabIndex = 17;
            this.rdioZulrahStyleMelee.TabStop = true;
            this.rdioZulrahStyleMelee.Text = "Melee";
            this.rdioZulrahStyleMelee.UseVisualStyleBackColor = true;
            // 
            // rdioZulrahStyleRange
            // 
            this.rdioZulrahStyleRange.AutoSize = true;
            this.rdioZulrahStyleRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahStyleRange.Location = new System.Drawing.Point(22, 64);
            this.rdioZulrahStyleRange.Name = "rdioZulrahStyleRange";
            this.rdioZulrahStyleRange.Size = new System.Drawing.Size(72, 25);
            this.rdioZulrahStyleRange.TabIndex = 16;
            this.rdioZulrahStyleRange.TabStop = true;
            this.rdioZulrahStyleRange.Text = "Range";
            this.rdioZulrahStyleRange.UseVisualStyleBackColor = true;
            // 
            // rdioZulrahStyleMage
            // 
            this.rdioZulrahStyleMage.AutoSize = true;
            this.rdioZulrahStyleMage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahStyleMage.Location = new System.Drawing.Point(22, 33);
            this.rdioZulrahStyleMage.Name = "rdioZulrahStyleMage";
            this.rdioZulrahStyleMage.Size = new System.Drawing.Size(67, 25);
            this.rdioZulrahStyleMage.TabIndex = 15;
            this.rdioZulrahStyleMage.TabStop = true;
            this.rdioZulrahStyleMage.Text = "Mage";
            this.rdioZulrahStyleMage.UseVisualStyleBackColor = true;
            // 
            // lblZulrahStyles
            // 
            this.lblZulrahStyles.AutoSize = true;
            this.lblZulrahStyles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZulrahStyles.Location = new System.Drawing.Point(4, 7);
            this.lblZulrahStyles.Name = "lblZulrahStyles";
            this.lblZulrahStyles.Size = new System.Drawing.Size(111, 25);
            this.lblZulrahStyles.TabIndex = 14;
            this.lblZulrahStyles.Text = "Zulrah Style";
            // 
            // lblZulrahBlockID
            // 
            this.lblZulrahBlockID.AutoSize = true;
            this.lblZulrahBlockID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZulrahBlockID.Location = new System.Drawing.Point(25, 3);
            this.lblZulrahBlockID.Name = "lblZulrahBlockID";
            this.lblZulrahBlockID.Size = new System.Drawing.Size(140, 25);
            this.lblZulrahBlockID.TabIndex = 18;
            this.lblZulrahBlockID.Text = "Zulrah Block ID";
            // 
            // rdioZulrahBlockID9
            // 
            this.rdioZulrahBlockID9.AutoSize = true;
            this.rdioZulrahBlockID9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahBlockID9.Location = new System.Drawing.Point(101, 31);
            this.rdioZulrahBlockID9.Name = "rdioZulrahBlockID9";
            this.rdioZulrahBlockID9.Size = new System.Drawing.Size(37, 25);
            this.rdioZulrahBlockID9.TabIndex = 21;
            this.rdioZulrahBlockID9.TabStop = true;
            this.rdioZulrahBlockID9.Text = "9";
            this.rdioZulrahBlockID9.UseVisualStyleBackColor = true;
            // 
            // rdioZulrahBlockID8
            // 
            this.rdioZulrahBlockID8.AutoSize = true;
            this.rdioZulrahBlockID8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahBlockID8.Location = new System.Drawing.Point(57, 31);
            this.rdioZulrahBlockID8.Name = "rdioZulrahBlockID8";
            this.rdioZulrahBlockID8.Size = new System.Drawing.Size(37, 25);
            this.rdioZulrahBlockID8.TabIndex = 20;
            this.rdioZulrahBlockID8.TabStop = true;
            this.rdioZulrahBlockID8.Text = "8";
            this.rdioZulrahBlockID8.UseVisualStyleBackColor = true;
            // 
            // rdioZulrahBlockID7
            // 
            this.rdioZulrahBlockID7.AutoSize = true;
            this.rdioZulrahBlockID7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahBlockID7.Location = new System.Drawing.Point(13, 31);
            this.rdioZulrahBlockID7.Name = "rdioZulrahBlockID7";
            this.rdioZulrahBlockID7.Size = new System.Drawing.Size(37, 25);
            this.rdioZulrahBlockID7.TabIndex = 19;
            this.rdioZulrahBlockID7.TabStop = true;
            this.rdioZulrahBlockID7.Text = "7";
            this.rdioZulrahBlockID7.UseVisualStyleBackColor = true;
            // 
            // rdioZulrahBlockID10
            // 
            this.rdioZulrahBlockID10.AutoSize = true;
            this.rdioZulrahBlockID10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioZulrahBlockID10.Location = new System.Drawing.Point(144, 31);
            this.rdioZulrahBlockID10.Name = "rdioZulrahBlockID10";
            this.rdioZulrahBlockID10.Size = new System.Drawing.Size(46, 25);
            this.rdioZulrahBlockID10.TabIndex = 22;
            this.rdioZulrahBlockID10.TabStop = true;
            this.rdioZulrahBlockID10.Text = "10";
            this.rdioZulrahBlockID10.UseVisualStyleBackColor = true;
            // 
            // lblPlayerBlockIDs
            // 
            this.lblPlayerBlockIDs.AutoSize = true;
            this.lblPlayerBlockIDs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerBlockIDs.Location = new System.Drawing.Point(24, 4);
            this.lblPlayerBlockIDs.Name = "lblPlayerBlockIDs";
            this.lblPlayerBlockIDs.Size = new System.Drawing.Size(145, 25);
            this.lblPlayerBlockIDs.TabIndex = 23;
            this.lblPlayerBlockIDs.Text = "Player Block IDs";
            // 
            // txtPlayerBlockIDs1
            // 
            this.txtPlayerBlockIDs1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerBlockIDs1.Location = new System.Drawing.Point(10, 34);
            this.txtPlayerBlockIDs1.Name = "txtPlayerBlockIDs1";
            this.txtPlayerBlockIDs1.PlaceholderText = "1,2,3...";
            this.txtPlayerBlockIDs1.Size = new System.Drawing.Size(56, 29);
            this.txtPlayerBlockIDs1.TabIndex = 24;
            // 
            // pnlPrayers
            // 
            this.pnlPrayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrayers.Controls.Add(this.rdioPrayerNone);
            this.pnlPrayers.Controls.Add(this.lblPrayer);
            this.pnlPrayers.Controls.Add(this.rdioPrayerMage);
            this.pnlPrayers.Controls.Add(this.rdioPrayerRange);
            this.pnlPrayers.Location = new System.Drawing.Point(128, 310);
            this.pnlPrayers.Name = "pnlPrayers";
            this.pnlPrayers.Size = new System.Drawing.Size(80, 125);
            this.pnlPrayers.TabIndex = 25;
            // 
            // rdioPrayerNone
            // 
            this.rdioPrayerNone.AutoSize = true;
            this.rdioPrayerNone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioPrayerNone.Location = new System.Drawing.Point(4, 93);
            this.rdioPrayerNone.Name = "rdioPrayerNone";
            this.rdioPrayerNone.Size = new System.Drawing.Size(66, 25);
            this.rdioPrayerNone.TabIndex = 13;
            this.rdioPrayerNone.TabStop = true;
            this.rdioPrayerNone.Text = "None";
            this.rdioPrayerNone.UseVisualStyleBackColor = true;
            // 
            // pnlZulrahStyles
            // 
            this.pnlZulrahStyles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZulrahStyles.Controls.Add(this.rdioZulrahStyleRange);
            this.pnlZulrahStyles.Controls.Add(this.lblZulrahStyles);
            this.pnlZulrahStyles.Controls.Add(this.rdioZulrahStyleMage);
            this.pnlZulrahStyles.Controls.Add(this.rdioZulrahStyleMelee);
            this.pnlZulrahStyles.Location = new System.Drawing.Point(6, 310);
            this.pnlZulrahStyles.Name = "pnlZulrahStyles";
            this.pnlZulrahStyles.Size = new System.Drawing.Size(116, 125);
            this.pnlZulrahStyles.TabIndex = 26;
            // 
            // pnlWeapons
            // 
            this.pnlWeapons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeapons.Controls.Add(this.rdioWeaponStaff);
            this.pnlWeapons.Controls.Add(this.rdioWeaponCrossbow);
            this.pnlWeapons.Controls.Add(this.lblWeapon);
            this.pnlWeapons.Location = new System.Drawing.Point(107, 9);
            this.pnlWeapons.Name = "pnlWeapons";
            this.pnlWeapons.Size = new System.Drawing.Size(101, 93);
            this.pnlWeapons.TabIndex = 27;
            // 
            // pnlHelm
            // 
            this.pnlHelm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHelm.Controls.Add(this.rdioHelmMage);
            this.pnlHelm.Controls.Add(this.lblHelm);
            this.pnlHelm.Controls.Add(this.rdioHelmRange);
            this.pnlHelm.Location = new System.Drawing.Point(9, 9);
            this.pnlHelm.Name = "pnlHelm";
            this.pnlHelm.Size = new System.Drawing.Size(90, 93);
            this.pnlHelm.TabIndex = 28;
            // 
            // pnlZulrahBlockID
            // 
            this.pnlZulrahBlockID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZulrahBlockID.Controls.Add(this.lblZulrahBlockID);
            this.pnlZulrahBlockID.Controls.Add(this.rdioZulrahBlockID7);
            this.pnlZulrahBlockID.Controls.Add(this.rdioZulrahBlockID8);
            this.pnlZulrahBlockID.Controls.Add(this.rdioZulrahBlockID9);
            this.pnlZulrahBlockID.Controls.Add(this.rdioZulrahBlockID10);
            this.pnlZulrahBlockID.Location = new System.Drawing.Point(7, 113);
            this.pnlZulrahBlockID.Name = "pnlZulrahBlockID";
            this.pnlZulrahBlockID.Size = new System.Drawing.Size(201, 63);
            this.pnlZulrahBlockID.TabIndex = 29;
            // 
            // pnlPlayerBlockIds
            // 
            this.pnlPlayerBlockIds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerBlockIds.Controls.Add(this.txtPlayerBlockIDs3);
            this.pnlPlayerBlockIds.Controls.Add(this.txtPlayerBlockIDs2);
            this.pnlPlayerBlockIds.Controls.Add(this.txtPlayerBlockIDs1);
            this.pnlPlayerBlockIds.Controls.Add(this.lblPlayerBlockIDs);
            this.pnlPlayerBlockIds.Location = new System.Drawing.Point(6, 187);
            this.pnlPlayerBlockIds.Name = "pnlPlayerBlockIds";
            this.pnlPlayerBlockIds.Size = new System.Drawing.Size(202, 73);
            this.pnlPlayerBlockIds.TabIndex = 30;
            // 
            // txtPlayerBlockIDs3
            // 
            this.txtPlayerBlockIDs3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerBlockIDs3.Location = new System.Drawing.Point(134, 34);
            this.txtPlayerBlockIDs3.Name = "txtPlayerBlockIDs3";
            this.txtPlayerBlockIDs3.Size = new System.Drawing.Size(56, 29);
            this.txtPlayerBlockIDs3.TabIndex = 26;
            // 
            // txtPlayerBlockIDs2
            // 
            this.txtPlayerBlockIDs2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerBlockIDs2.Location = new System.Drawing.Point(72, 34);
            this.txtPlayerBlockIDs2.Name = "txtPlayerBlockIDs2";
            this.txtPlayerBlockIDs2.Size = new System.Drawing.Size(56, 29);
            this.txtPlayerBlockIDs2.TabIndex = 25;
            // 
            // pnlJadPhase
            // 
            this.pnlJadPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJadPhase.Controls.Add(this.rdioJadPhase);
            this.pnlJadPhase.Location = new System.Drawing.Point(7, 267);
            this.pnlJadPhase.Name = "pnlJadPhase";
            this.pnlJadPhase.Size = new System.Drawing.Size(201, 37);
            this.pnlJadPhase.TabIndex = 31;
            // 
            // rdioJadPhase
            // 
            this.rdioJadPhase.AutoSize = true;
            this.rdioJadPhase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdioJadPhase.Location = new System.Drawing.Point(43, 3);
            this.rdioJadPhase.Name = "rdioJadPhase";
            this.rdioJadPhase.Size = new System.Drawing.Size(113, 29);
            this.rdioJadPhase.TabIndex = 26;
            this.rdioJadPhase.TabStop = true;
            this.rdioJadPhase.Text = "Jad Phase";
            this.rdioJadPhase.UseVisualStyleBackColor = true;
            // 
            // pnlRotationInfo
            // 
            this.pnlRotationInfo.Controls.Add(this.pnlJadPhase);
            this.pnlRotationInfo.Controls.Add(this.pnlPlayerBlockIds);
            this.pnlRotationInfo.Controls.Add(this.pnlZulrahBlockID);
            this.pnlRotationInfo.Controls.Add(this.pnlPrayers);
            this.pnlRotationInfo.Controls.Add(this.pnlHelm);
            this.pnlRotationInfo.Controls.Add(this.pnlZulrahStyles);
            this.pnlRotationInfo.Controls.Add(this.pnlWeapons);
            this.pnlRotationInfo.Enabled = false;
            this.pnlRotationInfo.Location = new System.Drawing.Point(12, 52);
            this.pnlRotationInfo.Name = "pnlRotationInfo";
            this.pnlRotationInfo.Size = new System.Drawing.Size(217, 442);
            this.pnlRotationInfo.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(125, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(39, 500);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 33);
            this.btnLoad.TabIndex = 33;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbZulrahShrine
            // 
            this.pbZulrahShrine.Image = ((System.Drawing.Image)(resources.GetObject("pbZulrahShrine.Image")));
            this.pbZulrahShrine.Location = new System.Drawing.Point(249, 17);
            this.pbZulrahShrine.Name = "pbZulrahShrine";
            this.pbZulrahShrine.Size = new System.Drawing.Size(629, 508);
            this.pbZulrahShrine.TabIndex = 32;
            this.pbZulrahShrine.TabStop = false;
            this.pbZulrahShrine.Paint += new System.Windows.Forms.PaintEventHandler(this.pbZulrahShrine_Paint);
            // 
            // ZulrahPhaseGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 543);
            this.Controls.Add(this.pbZulrahShrine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pnlRotationInfo);
            this.Controls.Add(this.cmbPhases);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZulrahPhaseGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZulrahPhaseGenerator";
            this.pnlPrayers.ResumeLayout(false);
            this.pnlPrayers.PerformLayout();
            this.pnlZulrahStyles.ResumeLayout(false);
            this.pnlZulrahStyles.PerformLayout();
            this.pnlWeapons.ResumeLayout(false);
            this.pnlWeapons.PerformLayout();
            this.pnlHelm.ResumeLayout(false);
            this.pnlHelm.PerformLayout();
            this.pnlZulrahBlockID.ResumeLayout(false);
            this.pnlZulrahBlockID.PerformLayout();
            this.pnlPlayerBlockIds.ResumeLayout(false);
            this.pnlPlayerBlockIds.PerformLayout();
            this.pnlJadPhase.ResumeLayout(false);
            this.pnlJadPhase.PerformLayout();
            this.pnlRotationInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbZulrahShrine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPhases;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHelm;
        private System.Windows.Forms.RadioButton rdioHelmMage;
        private System.Windows.Forms.RadioButton rdioHelmRange;
        private System.Windows.Forms.RadioButton rdioWeaponCrossbow;
        private System.Windows.Forms.RadioButton rdioWeaponStaff;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.RadioButton rdioPrayerRange;
        private System.Windows.Forms.RadioButton rdioPrayerMage;
        private System.Windows.Forms.Label lblPrayer;
        private System.Windows.Forms.RadioButton rdioZulrahStyleMelee;
        private System.Windows.Forms.RadioButton rdioZulrahStyleRange;
        private System.Windows.Forms.RadioButton rdioZulrahStyleMage;
        private System.Windows.Forms.Label lblZulrahStyles;
        private System.Windows.Forms.Label lblZulrahBlockID;
        private System.Windows.Forms.RadioButton rdioZulrahBlockID9;
        private System.Windows.Forms.RadioButton rdioZulrahBlockID8;
        private System.Windows.Forms.RadioButton rdioZulrahBlockID7;
        private System.Windows.Forms.RadioButton rdioZulrahBlockID10;
        private System.Windows.Forms.Label lblPlayerBlockIDs;
        private System.Windows.Forms.TextBox txtPlayerBlockIDs1;
        private System.Windows.Forms.Panel pnlPrayers;
        private System.Windows.Forms.Panel pnlZulrahStyles;
        private System.Windows.Forms.Panel pnlWeapons;
        private System.Windows.Forms.Panel pnlHelm;
        private System.Windows.Forms.Panel pnlZulrahBlockID;
        private System.Windows.Forms.Panel pnlPlayerBlockIds;
        private System.Windows.Forms.Panel pnlJadPhase;
        private System.Windows.Forms.RadioButton rdioJadPhase;
        private System.Windows.Forms.RadioButton rdioPrayerNone;
        private System.Windows.Forms.Panel pnlRotationInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbZulrahShrine;
        private System.Windows.Forms.TextBox txtPlayerBlockIDs3;
        private System.Windows.Forms.TextBox txtPlayerBlockIDs2;
    }
}