namespace WindowsGlitchHarvester
{
    partial class WGH_MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WGH_MainForm));
			this.btnBlastTarget = new System.Windows.Forms.Button();
			this.btnBrowseTarget = new System.Windows.Forms.Button();
			this.lbStashHistory = new System.Windows.Forms.ListBox();
			this.btnLoadStockpile = new System.Windows.Forms.Button();
			this.btnClearStashHistory = new System.Windows.Forms.Button();
			this.btnSaveStockpileAs = new System.Windows.Forms.Button();
			this.btnSaveStockpile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClearStockpile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbTarget = new System.Windows.Forms.Label();
			this.btnStockpileMoveDown = new System.Windows.Forms.Button();
			this.btnStockpileMoveUp = new System.Windows.Forms.Button();
			this.nmIntensity = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.tbIntensity = new System.Windows.Forms.TrackBar();
			this.tbStartingAddress = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.nmStartingAddress = new System.Windows.Forms.NumericUpDown();
			this.tbBlastRange = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.nmBlastRange = new System.Windows.Forms.NumericUpDown();
			this.btnAddStashToStockpile = new System.Windows.Forms.Button();
			this.cbBlastRange = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnRestoreFileBackup = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbBlastType = new System.Windows.Forms.ComboBox();
			this.cbCorruptionEngine = new System.Windows.Forms.ComboBox();
			this.rbTargetFile = new System.Windows.Forms.RadioButton();
			this.rbTargetProcess = new System.Windows.Forms.RadioButton();
			this.btnRemoveSelected = new System.Windows.Forms.Button();
			this.btnImportStockpile = new System.Windows.Forms.Button();
			this.btnStockpileUp = new System.Windows.Forms.Button();
			this.btnStockpileDown = new System.Windows.Forms.Button();
			this.btnStashHistoryUp = new System.Windows.Forms.Button();
			this.btnStashHistoryDown = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbTargetMultipleFiles = new System.Windows.Forms.RadioButton();
			this.btnClearAllBackups = new System.Windows.Forms.Button();
			this.btnResetBackup = new System.Windows.Forms.Button();
			this.cbWriteCopyMode = new System.Windows.Forms.CheckBox();
			this.btnInjectSelected = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbProcessName = new System.Windows.Forms.TextBox();
			this.nmMaxFind = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbReplaceValue = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbLookupValue = new System.Windows.Forms.TextBox();
			this.btnExecCosmo = new System.Windows.Forms.Button();
			this.btn4d3d3d3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnDisableAutoUncorrupt = new System.Windows.Forms.Button();
			this.btnEnableCaching = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbTerminateOnReExec = new System.Windows.Forms.CheckBox();
			this.rbExecuteWith = new System.Windows.Forms.RadioButton();
			this.rbExecuteScript = new System.Windows.Forms.RadioButton();
			this.rbExecuteOtherProgram = new System.Windows.Forms.RadioButton();
			this.rbExecuteCorruptedFile = new System.Windows.Forms.RadioButton();
			this.rbNoExecution = new System.Windows.Forms.RadioButton();
			this.btnEditExec = new System.Windows.Forms.Button();
			this.lbExecution = new System.Windows.Forms.Label();
			this.cbInjectOnSelect = new System.Windows.Forms.CheckBox();
			this.btnRenameSelected = new System.Windows.Forms.Button();
			this.lbStockpile = new WindowsGlitchHarvester.RefreshingListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbStartingAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmStartingAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlastRange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmBlastRange)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmMaxFind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBlastTarget
			// 
			this.btnBlastTarget.BackColor = System.Drawing.Color.Black;
			this.btnBlastTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBlastTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBlastTarget.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnBlastTarget.Location = new System.Drawing.Point(8, 7);
			this.btnBlastTarget.Name = "btnBlastTarget";
			this.btnBlastTarget.Size = new System.Drawing.Size(134, 39);
			this.btnBlastTarget.TabIndex = 0;
			this.btnBlastTarget.Text = "Blast the target";
			this.btnBlastTarget.UseVisualStyleBackColor = false;
			this.btnBlastTarget.Click += new System.EventHandler(this.btnBlastTarget_Click);
			// 
			// btnBrowseTarget
			// 
			this.btnBrowseTarget.BackColor = System.Drawing.Color.Black;
			this.btnBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBrowseTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBrowseTarget.Location = new System.Drawing.Point(14, 29);
			this.btnBrowseTarget.Name = "btnBrowseTarget";
			this.btnBrowseTarget.Size = new System.Drawing.Size(60, 23);
			this.btnBrowseTarget.TabIndex = 1;
			this.btnBrowseTarget.Text = "Browse";
			this.btnBrowseTarget.UseVisualStyleBackColor = false;
			this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
			// 
			// lbStashHistory
			// 
			this.lbStashHistory.BackColor = System.Drawing.Color.Black;
			this.lbStashHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lbStashHistory.FormattingEnabled = true;
			this.lbStashHistory.Location = new System.Drawing.Point(233, 93);
			this.lbStashHistory.Name = "lbStashHistory";
			this.lbStashHistory.ScrollAlwaysVisible = true;
			this.lbStashHistory.Size = new System.Drawing.Size(146, 355);
			this.lbStashHistory.TabIndex = 3;
			this.lbStashHistory.SelectedIndexChanged += new System.EventHandler(this.lbStashHistory_SelectedIndexChanged);
			// 
			// btnLoadStockpile
			// 
			this.btnLoadStockpile.BackColor = System.Drawing.Color.Orange;
			this.btnLoadStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadStockpile.Location = new System.Drawing.Point(389, 447);
			this.btnLoadStockpile.Name = "btnLoadStockpile";
			this.btnLoadStockpile.Size = new System.Drawing.Size(127, 23);
			this.btnLoadStockpile.TabIndex = 4;
			this.btnLoadStockpile.Text = "Load Stockpile";
			this.btnLoadStockpile.UseVisualStyleBackColor = false;
			this.btnLoadStockpile.Click += new System.EventHandler(this.btnLoadStockpile_Click);
			// 
			// btnClearStashHistory
			// 
			this.btnClearStashHistory.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnClearStashHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClearStashHistory.ForeColor = System.Drawing.Color.GreenYellow;
			this.btnClearStashHistory.Location = new System.Drawing.Point(233, 447);
			this.btnClearStashHistory.Name = "btnClearStashHistory";
			this.btnClearStashHistory.Size = new System.Drawing.Size(145, 23);
			this.btnClearStashHistory.TabIndex = 5;
			this.btnClearStashHistory.Text = "Clear History";
			this.btnClearStashHistory.UseVisualStyleBackColor = false;
			this.btnClearStashHistory.Click += new System.EventHandler(this.btnClearStashHistory_Click);
			// 
			// btnSaveStockpileAs
			// 
			this.btnSaveStockpileAs.BackColor = System.Drawing.Color.Firebrick;
			this.btnSaveStockpileAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveStockpileAs.Location = new System.Drawing.Point(515, 447);
			this.btnSaveStockpileAs.Name = "btnSaveStockpileAs";
			this.btnSaveStockpileAs.Size = new System.Drawing.Size(106, 23);
			this.btnSaveStockpileAs.TabIndex = 6;
			this.btnSaveStockpileAs.Text = "Save Stockpile as";
			this.btnSaveStockpileAs.UseVisualStyleBackColor = false;
			this.btnSaveStockpileAs.Click += new System.EventHandler(this.btnSaveStockpileAs_Click);
			// 
			// btnSaveStockpile
			// 
			this.btnSaveStockpile.BackColor = System.Drawing.Color.LightGray;
			this.btnSaveStockpile.Enabled = false;
			this.btnSaveStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveStockpile.Location = new System.Drawing.Point(620, 447);
			this.btnSaveStockpile.Name = "btnSaveStockpile";
			this.btnSaveStockpile.Size = new System.Drawing.Size(46, 23);
			this.btnSaveStockpile.TabIndex = 8;
			this.btnSaveStockpile.Text = "Save";
			this.btnSaveStockpile.UseVisualStyleBackColor = false;
			this.btnSaveStockpile.Click += new System.EventHandler(this.btnSaveStockpile_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(231, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Stash History:";
			// 
			// btnClearStockpile
			// 
			this.btnClearStockpile.BackColor = System.Drawing.Color.LightBlue;
			this.btnClearStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearStockpile.ForeColor = System.Drawing.Color.Black;
			this.btnClearStockpile.Location = new System.Drawing.Point(620, 425);
			this.btnClearStockpile.Name = "btnClearStockpile";
			this.btnClearStockpile.Size = new System.Drawing.Size(46, 23);
			this.btnClearStockpile.TabIndex = 10;
			this.btnClearStockpile.Text = "Clear Stockpile";
			this.btnClearStockpile.UseVisualStyleBackColor = false;
			this.btnClearStockpile.Click += new System.EventHandler(this.btnClearStockpile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(388, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Current Stockpile:";
			// 
			// lbTarget
			// 
			this.lbTarget.BackColor = System.Drawing.Color.Black;
			this.lbTarget.ForeColor = System.Drawing.Color.Gold;
			this.lbTarget.Location = new System.Drawing.Point(80, 35);
			this.lbTarget.Name = "lbTarget";
			this.lbTarget.Padding = new System.Windows.Forms.Padding(1);
			this.lbTarget.Size = new System.Drawing.Size(585, 15);
			this.lbTarget.TabIndex = 12;
			this.lbTarget.Text = "No target selected";
			this.lbTarget.Click += new System.EventHandler(this.lbTargetName_Click);
			// 
			// btnStockpileMoveDown
			// 
			this.btnStockpileMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnStockpileMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileMoveDown.Location = new System.Drawing.Point(618, 387);
			this.btnStockpileMoveDown.Name = "btnStockpileMoveDown";
			this.btnStockpileMoveDown.Size = new System.Drawing.Size(48, 23);
			this.btnStockpileMoveDown.TabIndex = 13;
			this.btnStockpileMoveDown.Text = "\\\\//";
			this.btnStockpileMoveDown.UseVisualStyleBackColor = false;
			this.btnStockpileMoveDown.Click += new System.EventHandler(this.btnStockpileMoveDown_Click);
			// 
			// btnStockpileMoveUp
			// 
			this.btnStockpileMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnStockpileMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStockpileMoveUp.Location = new System.Drawing.Point(571, 387);
			this.btnStockpileMoveUp.Name = "btnStockpileMoveUp";
			this.btnStockpileMoveUp.Size = new System.Drawing.Size(48, 23);
			this.btnStockpileMoveUp.TabIndex = 14;
			this.btnStockpileMoveUp.Text = "//\\\\";
			this.btnStockpileMoveUp.UseVisualStyleBackColor = false;
			this.btnStockpileMoveUp.Click += new System.EventHandler(this.btnStockpileMoveUp_Click);
			// 
			// nmIntensity
			// 
			this.nmIntensity.BackColor = System.Drawing.Color.Black;
			this.nmIntensity.ForeColor = System.Drawing.Color.Gold;
			this.nmIntensity.Location = new System.Drawing.Point(103, 72);
			this.nmIntensity.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
			this.nmIntensity.Name = "nmIntensity";
			this.nmIntensity.Size = new System.Drawing.Size(120, 20);
			this.nmIntensity.TabIndex = 15;
			this.nmIntensity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nmIntensity.ValueChanged += new System.EventHandler(this.nmIntensity_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(10, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Intensity (Bytes) :";
			// 
			// tbIntensity
			// 
			this.tbIntensity.Location = new System.Drawing.Point(13, 95);
			this.tbIntensity.Maximum = 4000000;
			this.tbIntensity.Name = "tbIntensity";
			this.tbIntensity.Size = new System.Drawing.Size(210, 45);
			this.tbIntensity.TabIndex = 17;
			this.tbIntensity.TickFrequency = 0;
			this.tbIntensity.Value = 100;
			this.tbIntensity.Scroll += new System.EventHandler(this.tbIntensity_Scroll);
			// 
			// tbStartingAddress
			// 
			this.tbStartingAddress.Location = new System.Drawing.Point(13, 152);
			this.tbStartingAddress.Maximum = 100;
			this.tbStartingAddress.Name = "tbStartingAddress";
			this.tbStartingAddress.Size = new System.Drawing.Size(210, 45);
			this.tbStartingAddress.TabIndex = 20;
			this.tbStartingAddress.TickFrequency = 0;
			this.tbStartingAddress.Value = 100;
			this.tbStartingAddress.Scroll += new System.EventHandler(this.tbStartingAddress_Scroll);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(10, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Starting address:";
			// 
			// nmStartingAddress
			// 
			this.nmStartingAddress.BackColor = System.Drawing.Color.Black;
			this.nmStartingAddress.ForeColor = System.Drawing.Color.Gold;
			this.nmStartingAddress.Location = new System.Drawing.Point(103, 128);
			this.nmStartingAddress.Name = "nmStartingAddress";
			this.nmStartingAddress.Size = new System.Drawing.Size(120, 20);
			this.nmStartingAddress.TabIndex = 18;
			this.nmStartingAddress.ValueChanged += new System.EventHandler(this.nmStartingAddress_ValueChanged);
			// 
			// tbBlastRange
			// 
			this.tbBlastRange.Location = new System.Drawing.Point(13, 234);
			this.tbBlastRange.Maximum = 100;
			this.tbBlastRange.Name = "tbBlastRange";
			this.tbBlastRange.Size = new System.Drawing.Size(210, 45);
			this.tbBlastRange.TabIndex = 23;
			this.tbBlastRange.TickFrequency = 0;
			this.tbBlastRange.Value = 100;
			this.tbBlastRange.Scroll += new System.EventHandler(this.tbBlastRange_Scroll);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(7, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Blast range (size) :";
			// 
			// nmBlastRange
			// 
			this.nmBlastRange.BackColor = System.Drawing.Color.Black;
			this.nmBlastRange.ForeColor = System.Drawing.Color.Gold;
			this.nmBlastRange.Location = new System.Drawing.Point(103, 211);
			this.nmBlastRange.Name = "nmBlastRange";
			this.nmBlastRange.Size = new System.Drawing.Size(120, 20);
			this.nmBlastRange.TabIndex = 21;
			this.nmBlastRange.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nmBlastRange.ValueChanged += new System.EventHandler(this.nmBlastRange_ValueChanged);
			// 
			// btnAddStashToStockpile
			// 
			this.btnAddStashToStockpile.BackColor = System.Drawing.Color.Aquamarine;
			this.btnAddStashToStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddStashToStockpile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddStashToStockpile.Location = new System.Drawing.Point(389, 425);
			this.btnAddStashToStockpile.Name = "btnAddStashToStockpile";
			this.btnAddStashToStockpile.Size = new System.Drawing.Size(127, 23);
			this.btnAddStashToStockpile.TabIndex = 24;
			this.btnAddStashToStockpile.Text = "Add Stash to Stockpile";
			this.btnAddStashToStockpile.UseVisualStyleBackColor = false;
			this.btnAddStashToStockpile.Click += new System.EventHandler(this.btnAddStashToStockpile_Click);
			// 
			// cbBlastRange
			// 
			this.cbBlastRange.AutoSize = true;
			this.cbBlastRange.ForeColor = System.Drawing.Color.White;
			this.cbBlastRange.Location = new System.Drawing.Point(13, 187);
			this.cbBlastRange.Name = "cbBlastRange";
			this.cbBlastRange.Size = new System.Drawing.Size(100, 17);
			this.cbBlastRange.TabIndex = 25;
			this.cbBlastRange.Text = "Use blast range";
			this.cbBlastRange.UseVisualStyleBackColor = true;
			this.cbBlastRange.CheckedChanged += new System.EventHandler(this.cbBlastRange_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(9, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Corruption engine:";
			// 
			// btnRestoreFileBackup
			// 
			this.btnRestoreFileBackup.BackColor = System.Drawing.Color.Black;
			this.btnRestoreFileBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestoreFileBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRestoreFileBackup.Location = new System.Drawing.Point(352, 6);
			this.btnRestoreFileBackup.Name = "btnRestoreFileBackup";
			this.btnRestoreFileBackup.Size = new System.Drawing.Size(107, 23);
			this.btnRestoreFileBackup.TabIndex = 27;
			this.btnRestoreFileBackup.Text = "Restore Backup";
			this.btnRestoreFileBackup.UseVisualStyleBackColor = false;
			this.btnRestoreFileBackup.Click += new System.EventHandler(this.btnRestoreFileBackup_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbBlastType);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(10, 296);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 174);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Engine settings:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 41;
			this.label3.Text = "Blast Type:";
			// 
			// cbBlastType
			// 
			this.cbBlastType.BackColor = System.Drawing.Color.Black;
			this.cbBlastType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBlastType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbBlastType.ForeColor = System.Drawing.Color.Gold;
			this.cbBlastType.FormattingEnabled = true;
			this.cbBlastType.Items.AddRange(new object[] {
            "RANDOM",
            "RANDOMTILT",
            "TILT"});
			this.cbBlastType.Location = new System.Drawing.Point(80, 23);
			this.cbBlastType.Name = "cbBlastType";
			this.cbBlastType.Size = new System.Drawing.Size(120, 21);
			this.cbBlastType.TabIndex = 40;
			this.cbBlastType.SelectedIndexChanged += new System.EventHandler(this.cbBlastType_SelectedIndexChanged);
			// 
			// cbCorruptionEngine
			// 
			this.cbCorruptionEngine.BackColor = System.Drawing.Color.Black;
			this.cbCorruptionEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCorruptionEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCorruptionEngine.ForeColor = System.Drawing.Color.Gold;
			this.cbCorruptionEngine.FormattingEnabled = true;
			this.cbCorruptionEngine.Items.AddRange(new object[] {
            "NIGHTMARE"});
			this.cbCorruptionEngine.Location = new System.Drawing.Point(103, 272);
			this.cbCorruptionEngine.Name = "cbCorruptionEngine";
			this.cbCorruptionEngine.Size = new System.Drawing.Size(120, 21);
			this.cbCorruptionEngine.TabIndex = 29;
			this.cbCorruptionEngine.SelectedIndexChanged += new System.EventHandler(this.cbCorruptionEngine_SelectedIndexChanged);
			// 
			// rbTargetFile
			// 
			this.rbTargetFile.AutoSize = true;
			this.rbTargetFile.Checked = true;
			this.rbTargetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTargetFile.ForeColor = System.Drawing.Color.White;
			this.rbTargetFile.Location = new System.Drawing.Point(8, 6);
			this.rbTargetFile.Name = "rbTargetFile";
			this.rbTargetFile.Size = new System.Drawing.Size(75, 17);
			this.rbTargetFile.TabIndex = 30;
			this.rbTargetFile.TabStop = true;
			this.rbTargetFile.Text = "Target File";
			this.rbTargetFile.UseVisualStyleBackColor = true;
			this.rbTargetFile.CheckedChanged += new System.EventHandler(this.rbTargetFile_CheckedChanged);
			// 
			// rbTargetProcess
			// 
			this.rbTargetProcess.AutoSize = true;
			this.rbTargetProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTargetProcess.ForeColor = System.Drawing.Color.White;
			this.rbTargetProcess.Location = new System.Drawing.Point(207, 6);
			this.rbTargetProcess.Name = "rbTargetProcess";
			this.rbTargetProcess.Size = new System.Drawing.Size(137, 17);
			this.rbTargetProcess.TabIndex = 31;
			this.rbTargetProcess.Text = "Target Process Memory";
			this.rbTargetProcess.UseVisualStyleBackColor = true;
			this.rbTargetProcess.Visible = false;
			this.rbTargetProcess.CheckedChanged += new System.EventHandler(this.rbTargetProcess_CheckedChanged);
			// 
			// btnRemoveSelected
			// 
			this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveSelected.ForeColor = System.Drawing.Color.Black;
			this.btnRemoveSelected.Location = new System.Drawing.Point(389, 387);
			this.btnRemoveSelected.Name = "btnRemoveSelected";
			this.btnRemoveSelected.Size = new System.Drawing.Size(80, 23);
			this.btnRemoveSelected.TabIndex = 33;
			this.btnRemoveSelected.Text = "Remove Item";
			this.btnRemoveSelected.UseVisualStyleBackColor = false;
			this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
			// 
			// btnImportStockpile
			// 
			this.btnImportStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnImportStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportStockpile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportStockpile.Location = new System.Drawing.Point(515, 425);
			this.btnImportStockpile.Name = "btnImportStockpile";
			this.btnImportStockpile.Size = new System.Drawing.Size(106, 23);
			this.btnImportStockpile.TabIndex = 34;
			this.btnImportStockpile.Text = "Import Stockpile";
			this.btnImportStockpile.UseVisualStyleBackColor = false;
			this.btnImportStockpile.Click += new System.EventHandler(this.btnImportStockpile_Click);
			// 
			// btnStockpileUp
			// 
			this.btnStockpileUp.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnStockpileUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStockpileUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnStockpileUp.Location = new System.Drawing.Point(596, 71);
			this.btnStockpileUp.Name = "btnStockpileUp";
			this.btnStockpileUp.Size = new System.Drawing.Size(35, 23);
			this.btnStockpileUp.TabIndex = 36;
			this.btnStockpileUp.Text = "/\\";
			this.btnStockpileUp.UseVisualStyleBackColor = false;
			this.btnStockpileUp.Click += new System.EventHandler(this.btnStockpileUp_Click);
			// 
			// btnStockpileDown
			// 
			this.btnStockpileDown.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnStockpileDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStockpileDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnStockpileDown.Location = new System.Drawing.Point(630, 71);
			this.btnStockpileDown.Name = "btnStockpileDown";
			this.btnStockpileDown.Size = new System.Drawing.Size(35, 23);
			this.btnStockpileDown.TabIndex = 35;
			this.btnStockpileDown.Text = "\\/";
			this.btnStockpileDown.UseVisualStyleBackColor = false;
			this.btnStockpileDown.Click += new System.EventHandler(this.btnStockpileDown_Click);
			// 
			// btnStashHistoryUp
			// 
			this.btnStashHistoryUp.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnStashHistoryUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStashHistoryUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnStashHistoryUp.Location = new System.Drawing.Point(309, 71);
			this.btnStashHistoryUp.Name = "btnStashHistoryUp";
			this.btnStashHistoryUp.Size = new System.Drawing.Size(35, 23);
			this.btnStashHistoryUp.TabIndex = 38;
			this.btnStashHistoryUp.Text = "/\\";
			this.btnStashHistoryUp.UseVisualStyleBackColor = false;
			this.btnStashHistoryUp.Click += new System.EventHandler(this.btnStashHistoryUp_Click);
			// 
			// btnStashHistoryDown
			// 
			this.btnStashHistoryDown.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnStashHistoryDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStashHistoryDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnStashHistoryDown.Location = new System.Drawing.Point(343, 71);
			this.btnStashHistoryDown.Name = "btnStashHistoryDown";
			this.btnStashHistoryDown.Size = new System.Drawing.Size(35, 23);
			this.btnStashHistoryDown.TabIndex = 37;
			this.btnStashHistoryDown.Text = "\\/";
			this.btnStashHistoryDown.UseVisualStyleBackColor = false;
			this.btnStashHistoryDown.Click += new System.EventHandler(this.btnStashHistoryDown_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.rbTargetMultipleFiles);
			this.panel1.Controls.Add(this.btnClearAllBackups);
			this.panel1.Controls.Add(this.btnResetBackup);
			this.panel1.Controls.Add(this.rbTargetFile);
			this.panel1.Controls.Add(this.rbTargetProcess);
			this.panel1.Controls.Add(this.btnBrowseTarget);
			this.panel1.Controls.Add(this.lbTarget);
			this.panel1.Controls.Add(this.btnRestoreFileBackup);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(675, 60);
			this.panel1.TabIndex = 39;
			// 
			// rbTargetMultipleFiles
			// 
			this.rbTargetMultipleFiles.AutoSize = true;
			this.rbTargetMultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTargetMultipleFiles.ForeColor = System.Drawing.Color.White;
			this.rbTargetMultipleFiles.Location = new System.Drawing.Point(86, 6);
			this.rbTargetMultipleFiles.Name = "rbTargetMultipleFiles";
			this.rbTargetMultipleFiles.Size = new System.Drawing.Size(119, 17);
			this.rbTargetMultipleFiles.TabIndex = 34;
			this.rbTargetMultipleFiles.Text = "Target Multiple Files";
			this.rbTargetMultipleFiles.UseVisualStyleBackColor = true;
			this.rbTargetMultipleFiles.CheckedChanged += new System.EventHandler(this.rbTargetMultipleFiles_CheckedChanged);
			// 
			// btnClearAllBackups
			// 
			this.btnClearAllBackups.BackColor = System.Drawing.Color.Black;
			this.btnClearAllBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearAllBackups.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnClearAllBackups.Location = new System.Drawing.Point(557, 6);
			this.btnClearAllBackups.Name = "btnClearAllBackups";
			this.btnClearAllBackups.Size = new System.Drawing.Size(108, 23);
			this.btnClearAllBackups.TabIndex = 33;
			this.btnClearAllBackups.Text = "Clear all Backups";
			this.btnClearAllBackups.UseVisualStyleBackColor = false;
			this.btnClearAllBackups.Click += new System.EventHandler(this.btnClearAllBackups_Click);
			// 
			// btnResetBackup
			// 
			this.btnResetBackup.BackColor = System.Drawing.Color.Black;
			this.btnResetBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResetBackup.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnResetBackup.Location = new System.Drawing.Point(465, 6);
			this.btnResetBackup.Name = "btnResetBackup";
			this.btnResetBackup.Size = new System.Drawing.Size(87, 23);
			this.btnResetBackup.TabIndex = 32;
			this.btnResetBackup.Text = "Reset Backup";
			this.btnResetBackup.UseVisualStyleBackColor = false;
			this.btnResetBackup.Click += new System.EventHandler(this.btnResetBackup_Click);
			// 
			// cbWriteCopyMode
			// 
			this.cbWriteCopyMode.AutoSize = true;
			this.cbWriteCopyMode.ForeColor = System.Drawing.Color.White;
			this.cbWriteCopyMode.Location = new System.Drawing.Point(251, 54);
			this.cbWriteCopyMode.Name = "cbWriteCopyMode";
			this.cbWriteCopyMode.Size = new System.Drawing.Size(117, 17);
			this.cbWriteCopyMode.TabIndex = 34;
			this.cbWriteCopyMode.Text = "Write in copy mode";
			this.cbWriteCopyMode.UseVisualStyleBackColor = true;
			this.cbWriteCopyMode.CheckedChanged += new System.EventHandler(this.cbWriteCopyMode_CheckedChanged);
			// 
			// btnInjectSelected
			// 
			this.btnInjectSelected.BackColor = System.Drawing.Color.Black;
			this.btnInjectSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInjectSelected.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnInjectSelected.Location = new System.Drawing.Point(8, 45);
			this.btnInjectSelected.Name = "btnInjectSelected";
			this.btnInjectSelected.Size = new System.Drawing.Size(134, 24);
			this.btnInjectSelected.TabIndex = 40;
			this.btnInjectSelected.Text = "Inject selected item";
			this.btnInjectSelected.UseVisualStyleBackColor = false;
			this.btnInjectSelected.Click += new System.EventHandler(this.btnInjectSelected_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(6, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 24);
			this.button1.TabIndex = 32;
			this.button1.Text = "hook to process";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.Location = new System.Drawing.Point(6, 255);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 24);
			this.button2.TabIndex = 32;
			this.button2.Text = "dump process";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.tbProcessName);
			this.groupBox2.Controls.Add(this.nmMaxFind);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.tbReplaceValue);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.tbLookupValue);
			this.groupBox2.Controls.Add(this.btnExecCosmo);
			this.groupBox2.Controls.Add(this.btn4d3d3d3);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.btnDisableAutoUncorrupt);
			this.groupBox2.Controls.Add(this.btnEnableCaching);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Red;
			this.groupBox2.Location = new System.Drawing.Point(681, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(133, 548);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Very Experimental";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(3, 198);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 13);
			this.label11.TabIndex = 47;
			this.label11.Text = "ProcessName";
			// 
			// tbProcessName
			// 
			this.tbProcessName.BackColor = System.Drawing.Color.Black;
			this.tbProcessName.ForeColor = System.Drawing.Color.Gold;
			this.tbProcessName.Location = new System.Drawing.Point(5, 213);
			this.tbProcessName.Name = "tbProcessName";
			this.tbProcessName.Size = new System.Drawing.Size(122, 20);
			this.tbProcessName.TabIndex = 46;
			this.tbProcessName.Text = "kigb";
			// 
			// nmMaxFind
			// 
			this.nmMaxFind.BackColor = System.Drawing.Color.Black;
			this.nmMaxFind.ForeColor = System.Drawing.Color.Gold;
			this.nmMaxFind.Location = new System.Drawing.Point(6, 388);
			this.nmMaxFind.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
			this.nmMaxFind.Name = "nmMaxFind";
			this.nmMaxFind.Size = new System.Drawing.Size(120, 20);
			this.nmMaxFind.TabIndex = 42;
			this.nmMaxFind.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(6, 374);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 45;
			this.label10.Text = "MaxFind";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(4, 339);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 13);
			this.label9.TabIndex = 44;
			this.label9.Text = "ReplaceValue";
			// 
			// tbReplaceValue
			// 
			this.tbReplaceValue.BackColor = System.Drawing.Color.Black;
			this.tbReplaceValue.ForeColor = System.Drawing.Color.Gold;
			this.tbReplaceValue.Location = new System.Drawing.Point(6, 354);
			this.tbReplaceValue.Name = "tbReplaceValue";
			this.tbReplaceValue.Size = new System.Drawing.Size(121, 20);
			this.tbReplaceValue.TabIndex = 43;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(4, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 42;
			this.label8.Text = "LookupValue";
			// 
			// tbLookupValue
			// 
			this.tbLookupValue.BackColor = System.Drawing.Color.Black;
			this.tbLookupValue.ForeColor = System.Drawing.Color.Gold;
			this.tbLookupValue.Location = new System.Drawing.Point(6, 319);
			this.tbLookupValue.Name = "tbLookupValue";
			this.tbLookupValue.Size = new System.Drawing.Size(121, 20);
			this.tbLookupValue.TabIndex = 40;
			// 
			// btnExecCosmo
			// 
			this.btnExecCosmo.BackColor = System.Drawing.Color.Black;
			this.btnExecCosmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExecCosmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnExecCosmo.Location = new System.Drawing.Point(6, 409);
			this.btnExecCosmo.Name = "btnExecCosmo";
			this.btnExecCosmo.Size = new System.Drawing.Size(121, 24);
			this.btnExecCosmo.TabIndex = 39;
			this.btnExecCosmo.Text = "Exec cosmo algo";
			this.btnExecCosmo.UseVisualStyleBackColor = false;
			this.btnExecCosmo.Click += new System.EventHandler(this.btnExecCosmo_Click);
			// 
			// btn4d3d3d3
			// 
			this.btn4d3d3d3.BackColor = System.Drawing.Color.Black;
			this.btn4d3d3d3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn4d3d3d3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn4d3d3d3.Location = new System.Drawing.Point(6, 517);
			this.btn4d3d3d3.Name = "btn4d3d3d3";
			this.btn4d3d3d3.Size = new System.Drawing.Size(121, 24);
			this.btn4d3d3d3.TabIndex = 38;
			this.btn4d3d3d3.Text = "4d3d3d3d";
			this.btn4d3d3d3.UseVisualStyleBackColor = false;
			this.btn4d3d3d3.Click += new System.EventHandler(this.btn4d3d3d3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsGlitchHarvester.Properties.Resources.tayne_flarhgunnstow;
			this.pictureBox1.Location = new System.Drawing.Point(6, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// btnDisableAutoUncorrupt
			// 
			this.btnDisableAutoUncorrupt.BackColor = System.Drawing.Color.Black;
			this.btnDisableAutoUncorrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDisableAutoUncorrupt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnDisableAutoUncorrupt.Location = new System.Drawing.Point(6, 438);
			this.btnDisableAutoUncorrupt.Name = "btnDisableAutoUncorrupt";
			this.btnDisableAutoUncorrupt.Size = new System.Drawing.Size(121, 41);
			this.btnDisableAutoUncorrupt.TabIndex = 36;
			this.btnDisableAutoUncorrupt.Text = "Disable Auto-Uncorrupt";
			this.btnDisableAutoUncorrupt.UseVisualStyleBackColor = false;
			this.btnDisableAutoUncorrupt.Click += new System.EventHandler(this.btnDisableAutoUncorrupt_Click);
			// 
			// btnEnableCaching
			// 
			this.btnEnableCaching.BackColor = System.Drawing.Color.Black;
			this.btnEnableCaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnableCaching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnEnableCaching.Location = new System.Drawing.Point(6, 478);
			this.btnEnableCaching.Name = "btnEnableCaching";
			this.btnEnableCaching.Size = new System.Drawing.Size(121, 40);
			this.btnEnableCaching.TabIndex = 35;
			this.btnEnableCaching.Text = "Enable caching on current target";
			this.btnEnableCaching.UseVisualStyleBackColor = false;
			this.btnEnableCaching.Click += new System.EventHandler(this.btnEnableCaching_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.Location = new System.Drawing.Point(6, 278);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(121, 24);
			this.button3.TabIndex = 33;
			this.button3.Text = "Blast 100 bytes";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Controls.Add(this.cbTerminateOnReExec);
			this.panel2.Controls.Add(this.cbWriteCopyMode);
			this.panel2.Controls.Add(this.rbExecuteWith);
			this.panel2.Controls.Add(this.rbExecuteScript);
			this.panel2.Controls.Add(this.rbExecuteOtherProgram);
			this.panel2.Controls.Add(this.rbExecuteCorruptedFile);
			this.panel2.Controls.Add(this.rbNoExecution);
			this.panel2.Controls.Add(this.btnEditExec);
			this.panel2.Controls.Add(this.lbExecution);
			this.panel2.Controls.Add(this.cbInjectOnSelect);
			this.panel2.Controls.Add(this.btnBlastTarget);
			this.panel2.Controls.Add(this.btnInjectSelected);
			this.panel2.Location = new System.Drawing.Point(0, 479);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(675, 80);
			this.panel2.TabIndex = 40;
			// 
			// cbTerminateOnReExec
			// 
			this.cbTerminateOnReExec.AutoSize = true;
			this.cbTerminateOnReExec.Checked = true;
			this.cbTerminateOnReExec.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTerminateOnReExec.ForeColor = System.Drawing.Color.White;
			this.cbTerminateOnReExec.Location = new System.Drawing.Point(372, 54);
			this.cbTerminateOnReExec.Name = "cbTerminateOnReExec";
			this.cbTerminateOnReExec.Size = new System.Drawing.Size(189, 17);
			this.cbTerminateOnReExec.TabIndex = 48;
			this.cbTerminateOnReExec.Text = "Terminate Target on Re-Execution";
			this.cbTerminateOnReExec.UseVisualStyleBackColor = true;
			// 
			// rbExecuteWith
			// 
			this.rbExecuteWith.AutoSize = true;
			this.rbExecuteWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExecuteWith.ForeColor = System.Drawing.Color.White;
			this.rbExecuteWith.Location = new System.Drawing.Point(370, 12);
			this.rbExecuteWith.Name = "rbExecuteWith";
			this.rbExecuteWith.Size = new System.Drawing.Size(86, 17);
			this.rbExecuteWith.TabIndex = 47;
			this.rbExecuteWith.Text = "Execute with";
			this.rbExecuteWith.UseVisualStyleBackColor = true;
			// 
			// rbExecuteScript
			// 
			this.rbExecuteScript.AutoSize = true;
			this.rbExecuteScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExecuteScript.ForeColor = System.Drawing.Color.White;
			this.rbExecuteScript.Location = new System.Drawing.Point(607, 35);
			this.rbExecuteScript.Name = "rbExecuteScript";
			this.rbExecuteScript.Size = new System.Drawing.Size(52, 17);
			this.rbExecuteScript.TabIndex = 46;
			this.rbExecuteScript.Text = "Script";
			this.rbExecuteScript.UseVisualStyleBackColor = true;
			this.rbExecuteScript.Visible = false;
			this.rbExecuteScript.CheckedChanged += new System.EventHandler(this.rbExecuteScript_CheckedChanged);
			// 
			// rbExecuteOtherProgram
			// 
			this.rbExecuteOtherProgram.AutoSize = true;
			this.rbExecuteOtherProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExecuteOtherProgram.ForeColor = System.Drawing.Color.White;
			this.rbExecuteOtherProgram.Location = new System.Drawing.Point(461, 12);
			this.rbExecuteOtherProgram.Name = "rbExecuteOtherProgram";
			this.rbExecuteOtherProgram.Size = new System.Drawing.Size(132, 17);
			this.rbExecuteOtherProgram.TabIndex = 45;
			this.rbExecuteOtherProgram.Text = "Execute other program";
			this.rbExecuteOtherProgram.UseVisualStyleBackColor = true;
			this.rbExecuteOtherProgram.CheckedChanged += new System.EventHandler(this.rbExecuteOtherProgram_CheckedChanged);
			// 
			// rbExecuteCorruptedFile
			// 
			this.rbExecuteCorruptedFile.AutoSize = true;
			this.rbExecuteCorruptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbExecuteCorruptedFile.ForeColor = System.Drawing.Color.White;
			this.rbExecuteCorruptedFile.Location = new System.Drawing.Point(240, 12);
			this.rbExecuteCorruptedFile.Name = "rbExecuteCorruptedFile";
			this.rbExecuteCorruptedFile.Size = new System.Drawing.Size(128, 17);
			this.rbExecuteCorruptedFile.TabIndex = 44;
			this.rbExecuteCorruptedFile.Text = "Execute corrupted file";
			this.rbExecuteCorruptedFile.UseVisualStyleBackColor = true;
			this.rbExecuteCorruptedFile.CheckedChanged += new System.EventHandler(this.rbExecuteCorruptedFile_CheckedChanged);
			// 
			// rbNoExecution
			// 
			this.rbNoExecution.AutoSize = true;
			this.rbNoExecution.Checked = true;
			this.rbNoExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNoExecution.ForeColor = System.Drawing.Color.White;
			this.rbNoExecution.Location = new System.Drawing.Point(149, 12);
			this.rbNoExecution.Name = "rbNoExecution";
			this.rbNoExecution.Size = new System.Drawing.Size(88, 17);
			this.rbNoExecution.TabIndex = 43;
			this.rbNoExecution.TabStop = true;
			this.rbNoExecution.Text = "No execution";
			this.rbNoExecution.UseVisualStyleBackColor = true;
			this.rbNoExecution.CheckedChanged += new System.EventHandler(this.rbNoExecution_CheckedChanged);
			// 
			// btnEditExec
			// 
			this.btnEditExec.BackColor = System.Drawing.Color.Black;
			this.btnEditExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditExec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnEditExec.Location = new System.Drawing.Point(598, 9);
			this.btnEditExec.Name = "btnEditExec";
			this.btnEditExec.Size = new System.Drawing.Size(68, 23);
			this.btnEditExec.TabIndex = 35;
			this.btnEditExec.Text = "Edit Exec";
			this.btnEditExec.UseVisualStyleBackColor = false;
			this.btnEditExec.Click += new System.EventHandler(this.btnEditExec_Click);
			// 
			// lbExecution
			// 
			this.lbExecution.BackColor = System.Drawing.Color.Black;
			this.lbExecution.ForeColor = System.Drawing.Color.Gold;
			this.lbExecution.Location = new System.Drawing.Point(147, 34);
			this.lbExecution.Name = "lbExecution";
			this.lbExecution.Padding = new System.Windows.Forms.Padding(1);
			this.lbExecution.Size = new System.Drawing.Size(440, 15);
			this.lbExecution.TabIndex = 42;
			this.lbExecution.Text = "No execution set";
			// 
			// cbInjectOnSelect
			// 
			this.cbInjectOnSelect.AutoSize = true;
			this.cbInjectOnSelect.ForeColor = System.Drawing.Color.White;
			this.cbInjectOnSelect.Location = new System.Drawing.Point(148, 54);
			this.cbInjectOnSelect.Name = "cbInjectOnSelect";
			this.cbInjectOnSelect.Size = new System.Drawing.Size(98, 17);
			this.cbInjectOnSelect.TabIndex = 41;
			this.cbInjectOnSelect.Text = "Inject on select";
			this.cbInjectOnSelect.UseVisualStyleBackColor = true;
			// 
			// btnRenameSelected
			// 
			this.btnRenameSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnRenameSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRenameSelected.ForeColor = System.Drawing.Color.Black;
			this.btnRenameSelected.Location = new System.Drawing.Point(468, 387);
			this.btnRenameSelected.Name = "btnRenameSelected";
			this.btnRenameSelected.Size = new System.Drawing.Size(80, 23);
			this.btnRenameSelected.TabIndex = 42;
			this.btnRenameSelected.Text = "Rename Item";
			this.btnRenameSelected.UseVisualStyleBackColor = false;
			this.btnRenameSelected.Click += new System.EventHandler(this.btnRenameSelected_Click);
			// 
			// lbStockpile
			// 
			this.lbStockpile.BackColor = System.Drawing.Color.Black;
			this.lbStockpile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lbStockpile.FormattingEnabled = true;
			this.lbStockpile.Location = new System.Drawing.Point(389, 93);
			this.lbStockpile.Name = "lbStockpile";
			this.lbStockpile.ScrollAlwaysVisible = true;
			this.lbStockpile.Size = new System.Drawing.Size(277, 290);
			this.lbStockpile.TabIndex = 2;
			this.lbStockpile.SelectedIndexChanged += new System.EventHandler(this.lbStockpile_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(488, 74);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(107, 17);
			this.checkBox1.TabIndex = 43;
			this.checkBox1.Text = "Pack files in SKS";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Visible = false;
			// 
			// WGH_MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(675, 554);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnRenameSelected);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnStashHistoryUp);
			this.Controls.Add(this.btnStashHistoryDown);
			this.Controls.Add(this.btnStockpileUp);
			this.Controls.Add(this.btnStockpileDown);
			this.Controls.Add(this.btnImportStockpile);
			this.Controls.Add(this.btnRemoveSelected);
			this.Controls.Add(this.cbCorruptionEngine);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbBlastRange);
			this.Controls.Add(this.btnAddStashToStockpile);
			this.Controls.Add(this.tbBlastRange);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nmBlastRange);
			this.Controls.Add(this.tbStartingAddress);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nmStartingAddress);
			this.Controls.Add(this.tbIntensity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nmIntensity);
			this.Controls.Add(this.btnStockpileMoveUp);
			this.Controls.Add(this.btnStockpileMoveDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnClearStockpile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSaveStockpile);
			this.Controls.Add(this.btnSaveStockpileAs);
			this.Controls.Add(this.btnClearStashHistory);
			this.Controls.Add(this.btnLoadStockpile);
			this.Controls.Add(this.lbStashHistory);
			this.Controls.Add(this.lbStockpile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WGH_MainForm";
			this.Text = "Windows Glitch Harvester";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WGH_MainForm_FormClosing);
			this.Load += new System.EventHandler(this.WGH_MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmIntensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbStartingAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmStartingAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBlastRange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmBlastRange)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmMaxFind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlastTarget;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.Button btnLoadStockpile;
        private System.Windows.Forms.Button btnClearStashHistory;
        private System.Windows.Forms.Button btnSaveStockpileAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearStockpile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStockpileMoveDown;
        private System.Windows.Forms.Button btnStockpileMoveUp;
        private System.Windows.Forms.NumericUpDown nmIntensity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbIntensity;
        private System.Windows.Forms.TrackBar tbStartingAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmStartingAddress;
        private System.Windows.Forms.TrackBar tbBlastRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmBlastRange;
        private System.Windows.Forms.Button btnAddStashToStockpile;
        private System.Windows.Forms.CheckBox cbBlastRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRestoreFileBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCorruptionEngine;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnImportStockpile;
        private System.Windows.Forms.Button btnStockpileUp;
        private System.Windows.Forms.Button btnStockpileDown;
        private System.Windows.Forms.Button btnStashHistoryUp;
        private System.Windows.Forms.Button btnStashHistoryDown;
        public RefreshingListBox lbStockpile;
        public System.Windows.Forms.ListBox lbStashHistory;
        public System.Windows.Forms.Button btnSaveStockpile;
        public System.Windows.Forms.RadioButton rbTargetFile;
        public System.Windows.Forms.RadioButton rbTargetProcess;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Button btnClearAllBackups;
        private System.Windows.Forms.Button btnResetBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBlastType;
        private System.Windows.Forms.CheckBox cbWriteCopyMode;
        private System.Windows.Forms.Button btnInjectSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbInjectOnSelect;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.RadioButton rbExecuteOtherProgram;
        public System.Windows.Forms.RadioButton rbExecuteCorruptedFile;
        public System.Windows.Forms.RadioButton rbNoExecution;
        private System.Windows.Forms.Button btnEditExec;
        public System.Windows.Forms.Label lbExecution;
        public System.Windows.Forms.RadioButton rbExecuteScript;
        public System.Windows.Forms.RadioButton rbExecuteWith;
        private System.Windows.Forms.CheckBox cbTerminateOnReExec;
        public System.Windows.Forms.RadioButton rbTargetMultipleFiles;
        private System.Windows.Forms.Button btnEnableCaching;
        private System.Windows.Forms.Button btnDisableAutoUncorrupt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn4d3d3d3;
        private System.Windows.Forms.NumericUpDown nmMaxFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReplaceValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLookupValue;
        private System.Windows.Forms.Button btnExecCosmo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbProcessName;
		private System.Windows.Forms.Button btnRenameSelected;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

