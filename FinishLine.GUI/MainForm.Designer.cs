namespace FinishLine
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnStartTheRace = new System.Windows.Forms.Button();
            this.lblRaceStartTime = new System.Windows.Forms.Label();
            this.dtGrdVwMainRaceForm = new System.Windows.Forms.DataGridView();
            this.bttnRunnerAddLap = new System.Windows.Forms.Button();
            this.nmercUpDwnRunnerAddLap = new System.Windows.Forms.NumericUpDown();
            this.bttnRunnerSteppingOut = new System.Windows.Forms.Button();
            this.nmercUpDwnRunnerSteppingOut = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnLengthOfLap = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnNumberOfLaps = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnNumberOfWinners = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxSettingRace = new System.Windows.Forms.GroupBox();
            this.dtGrdVwFinishedRunners = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMainRaceForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmercUpDwnRunnerAddLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmercUpDwnRunnerSteppingOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnLengthOfLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberOfLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberOfWinners)).BeginInit();
            this.grpBxSettingRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFinishedRunners)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.RunnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.souborToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Load";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RunnerToolStripMenuItem
            // 
            this.RunnerToolStripMenuItem.Name = "RunnerToolStripMenuItem";
            this.RunnerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.RunnerToolStripMenuItem.Text = "Runners ";
            this.RunnerToolStripMenuItem.Click += new System.EventHandler(this.addRunnerToolStripMenuItem_Click);
            // 
            // bttnStartTheRace
            // 
            this.bttnStartTheRace.Location = new System.Drawing.Point(121, 180);
            this.bttnStartTheRace.Name = "bttnStartTheRace";
            this.bttnStartTheRace.Size = new System.Drawing.Size(80, 27);
            this.bttnStartTheRace.TabIndex = 1;
            this.bttnStartTheRace.Text = "Start Race";
            this.bttnStartTheRace.UseVisualStyleBackColor = true;
            this.bttnStartTheRace.Click += new System.EventHandler(this.bttnStartTheRace_Click);
            // 
            // lblRaceStartTime
            // 
            this.lblRaceStartTime.AutoSize = true;
            this.lblRaceStartTime.Location = new System.Drawing.Point(6, 189);
            this.lblRaceStartTime.Name = "lblRaceStartTime";
            this.lblRaceStartTime.Size = new System.Drawing.Size(78, 13);
            this.lblRaceStartTime.TabIndex = 2;
            this.lblRaceStartTime.Text = "Race start time";
            // 
            // dtGrdVwMainRaceForm
            // 
            this.dtGrdVwMainRaceForm.AllowUserToAddRows = false;
            this.dtGrdVwMainRaceForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwMainRaceForm.Location = new System.Drawing.Point(24, 37);
            this.dtGrdVwMainRaceForm.Name = "dtGrdVwMainRaceForm";
            this.dtGrdVwMainRaceForm.ReadOnly = true;
            this.dtGrdVwMainRaceForm.Size = new System.Drawing.Size(419, 360);
            this.dtGrdVwMainRaceForm.TabIndex = 3;
            // 
            // bttnRunnerAddLap
            // 
            this.bttnRunnerAddLap.Location = new System.Drawing.Point(572, 331);
            this.bttnRunnerAddLap.Name = "bttnRunnerAddLap";
            this.bttnRunnerAddLap.Size = new System.Drawing.Size(89, 20);
            this.bttnRunnerAddLap.TabIndex = 4;
            this.bttnRunnerAddLap.Text = "Add lap";
            this.bttnRunnerAddLap.UseVisualStyleBackColor = true;
            this.bttnRunnerAddLap.Click += new System.EventHandler(this.bttnRunnerAddLap_Click);
            // 
            // nmercUpDwnRunnerAddLap
            // 
            this.nmercUpDwnRunnerAddLap.Location = new System.Drawing.Point(460, 331);
            this.nmercUpDwnRunnerAddLap.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmercUpDwnRunnerAddLap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmercUpDwnRunnerAddLap.Name = "nmercUpDwnRunnerAddLap";
            this.nmercUpDwnRunnerAddLap.Size = new System.Drawing.Size(66, 20);
            this.nmercUpDwnRunnerAddLap.TabIndex = 5;
            this.nmercUpDwnRunnerAddLap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bttnRunnerSteppingOut
            // 
            this.bttnRunnerSteppingOut.Location = new System.Drawing.Point(572, 374);
            this.bttnRunnerSteppingOut.Name = "bttnRunnerSteppingOut";
            this.bttnRunnerSteppingOut.Size = new System.Drawing.Size(89, 23);
            this.bttnRunnerSteppingOut.TabIndex = 6;
            this.bttnRunnerSteppingOut.Text = "Step out";
            this.bttnRunnerSteppingOut.UseVisualStyleBackColor = true;
            this.bttnRunnerSteppingOut.Click += new System.EventHandler(this.bttnRunnerSteppingOut_Click);
            // 
            // nmercUpDwnRunnerSteppingOut
            // 
            this.nmercUpDwnRunnerSteppingOut.Location = new System.Drawing.Point(460, 374);
            this.nmercUpDwnRunnerSteppingOut.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmercUpDwnRunnerSteppingOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmercUpDwnRunnerSteppingOut.Name = "nmercUpDwnRunnerSteppingOut";
            this.nmercUpDwnRunnerSteppingOut.Size = new System.Drawing.Size(66, 20);
            this.nmercUpDwnRunnerSteppingOut.TabIndex = 7;
            this.nmercUpDwnRunnerSteppingOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrcUpDwnLengthOfLap
            // 
            this.nmrcUpDwnLengthOfLap.DecimalPlaces = 1;
            this.nmrcUpDwnLengthOfLap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrcUpDwnLengthOfLap.Location = new System.Drawing.Point(135, 71);
            this.nmrcUpDwnLengthOfLap.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmrcUpDwnLengthOfLap.Name = "nmrcUpDwnLengthOfLap";
            this.nmrcUpDwnLengthOfLap.Size = new System.Drawing.Size(66, 20);
            this.nmrcUpDwnLengthOfLap.TabIndex = 11;
            // 
            // nmrcUpDwnNumberOfLaps
            // 
            this.nmrcUpDwnNumberOfLaps.Location = new System.Drawing.Point(135, 32);
            this.nmrcUpDwnNumberOfLaps.Name = "nmrcUpDwnNumberOfLaps";
            this.nmrcUpDwnNumberOfLaps.Size = new System.Drawing.Size(66, 20);
            this.nmrcUpDwnNumberOfLaps.TabIndex = 9;
            // 
            // nmrcUpDwnNumberOfWinners
            // 
            this.nmrcUpDwnNumberOfWinners.Location = new System.Drawing.Point(135, 111);
            this.nmrcUpDwnNumberOfWinners.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrcUpDwnNumberOfWinners.Name = "nmrcUpDwnNumberOfWinners";
            this.nmrcUpDwnNumberOfWinners.Size = new System.Drawing.Size(66, 20);
            this.nmrcUpDwnNumberOfWinners.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of winners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Length of lap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number of laps";
            // 
            // grpBxSettingRace
            // 
            this.grpBxSettingRace.Controls.Add(this.label3);
            this.grpBxSettingRace.Controls.Add(this.nmrcUpDwnNumberOfLaps);
            this.grpBxSettingRace.Controls.Add(this.label2);
            this.grpBxSettingRace.Controls.Add(this.nmrcUpDwnLengthOfLap);
            this.grpBxSettingRace.Controls.Add(this.nmrcUpDwnNumberOfWinners);
            this.grpBxSettingRace.Controls.Add(this.bttnStartTheRace);
            this.grpBxSettingRace.Controls.Add(this.lblRaceStartTime);
            this.grpBxSettingRace.Controls.Add(this.label1);
            this.grpBxSettingRace.Location = new System.Drawing.Point(460, 37);
            this.grpBxSettingRace.Name = "grpBxSettingRace";
            this.grpBxSettingRace.Size = new System.Drawing.Size(210, 213);
            this.grpBxSettingRace.TabIndex = 18;
            this.grpBxSettingRace.TabStop = false;
            this.grpBxSettingRace.Text = "Setting Race";
            // 
            // dtGrdVwFinishedRunners
            // 
            this.dtGrdVwFinishedRunners.AllowUserToAddRows = false;
            this.dtGrdVwFinishedRunners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwFinishedRunners.Location = new System.Drawing.Point(676, 37);
            this.dtGrdVwFinishedRunners.Name = "dtGrdVwFinishedRunners";
            this.dtGrdVwFinishedRunners.ReadOnly = true;
            this.dtGrdVwFinishedRunners.Size = new System.Drawing.Size(419, 360);
            this.dtGrdVwFinishedRunners.TabIndex = 19;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 462);
            this.Controls.Add(this.dtGrdVwFinishedRunners);
            this.Controls.Add(this.nmercUpDwnRunnerSteppingOut);
            this.Controls.Add(this.bttnRunnerSteppingOut);
            this.Controls.Add(this.nmercUpDwnRunnerAddLap);
            this.Controls.Add(this.bttnRunnerAddLap);
            this.Controls.Add(this.dtGrdVwMainRaceForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBxSettingRace);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Finish Line";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwMainRaceForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmercUpDwnRunnerAddLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmercUpDwnRunnerSteppingOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnLengthOfLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberOfLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberOfWinners)).EndInit();
            this.grpBxSettingRace.ResumeLayout(false);
            this.grpBxSettingRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFinishedRunners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunnerToolStripMenuItem;
        private System.Windows.Forms.Button bttnStartTheRace;
        private System.Windows.Forms.Label lblRaceStartTime;
        private System.Windows.Forms.DataGridView dtGrdVwMainRaceForm;
        private System.Windows.Forms.Button bttnRunnerAddLap;
        private System.Windows.Forms.NumericUpDown nmercUpDwnRunnerAddLap;
        private System.Windows.Forms.Button bttnRunnerSteppingOut;
        private System.Windows.Forms.NumericUpDown nmercUpDwnRunnerSteppingOut;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnLengthOfLap;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnNumberOfLaps;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnNumberOfWinners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBxSettingRace;
        private System.Windows.Forms.DataGridView dtGrdVwFinishedRunners;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

