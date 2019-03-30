namespace FinishLine
{
    partial class Form2
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
            this.dtGrdRegisteredRunnersVw = new System.Windows.Forms.DataGridView();
            this.bttnAddRunnerWithGeneratedId = new System.Windows.Forms.Button();
            this.txtBxRunnerNameAdd = new System.Windows.Forms.TextBox();
            this.cmbBxCountryAdd = new System.Windows.Forms.ComboBox();
            this.cmbBxSexAdd = new System.Windows.Forms.ComboBox();
            this.bttnAddRunnerWithCustomId = new System.Windows.Forms.Button();
            this.lblTitleOfRunnerstable = new System.Windows.Forms.Label();
            this.grpBxAddingRunner = new System.Windows.Forms.GroupBox();
            this.lblNameRunner = new System.Windows.Forms.Label();
            this.lblCountryRunner = new System.Windows.Forms.Label();
            this.lblAgeRunner = new System.Windows.Forms.Label();
            this.lblSexRunner = new System.Windows.Forms.Label();
            this.lblNumberRunner = new System.Windows.Forms.Label();
            this.grpBxEditRunner = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxRunnerNameEdit = new System.Windows.Forms.TextBox();
            this.bttnOkNumberEdit = new System.Windows.Forms.Button();
            this.cmbBxCountryEdit = new System.Windows.Forms.ComboBox();
            this.nmrcUpDwnAgeEdit = new System.Windows.Forms.NumericUpDown();
            this.bttnOkRunnerEdit = new System.Windows.Forms.Button();
            this.cmbBxSexEdit = new System.Windows.Forms.ComboBox();
            this.lblTypeNumberOfRunnerToEdit = new System.Windows.Forms.Label();
            this.lblNumberRunnerEdit = new System.Windows.Forms.Label();
            this.grpBxDeleteRunner = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnOkRunnerDelete = new System.Windows.Forms.Button();
            this.nmrcUpDwnNumberDelete = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnPickNumberToEdit = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnAgeAdd = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnNumberEdit = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDwnNumberAdd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRegisteredRunnersVw)).BeginInit();
            this.grpBxAddingRunner.SuspendLayout();
            this.grpBxEditRunner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnAgeEdit)).BeginInit();
            this.grpBxDeleteRunner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnPickNumberToEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnAgeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdRegisteredRunnersVw
            // 
            this.dtGrdRegisteredRunnersVw.AllowUserToAddRows = false;
            this.dtGrdRegisteredRunnersVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdRegisteredRunnersVw.Location = new System.Drawing.Point(73, 51);
            this.dtGrdRegisteredRunnersVw.Name = "dtGrdRegisteredRunnersVw";
            this.dtGrdRegisteredRunnersVw.ReadOnly = true;
            this.dtGrdRegisteredRunnersVw.Size = new System.Drawing.Size(582, 237);
            this.dtGrdRegisteredRunnersVw.TabIndex = 0;
            this.dtGrdRegisteredRunnersVw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttnAddRunnerWithGeneratedId
            // 
            this.bttnAddRunnerWithGeneratedId.Location = new System.Drawing.Point(435, 31);
            this.bttnAddRunnerWithGeneratedId.Name = "bttnAddRunnerWithGeneratedId";
            this.bttnAddRunnerWithGeneratedId.Size = new System.Drawing.Size(138, 23);
            this.bttnAddRunnerWithGeneratedId.TabIndex = 1;
            this.bttnAddRunnerWithGeneratedId.Text = "Add runner";
            this.bttnAddRunnerWithGeneratedId.UseVisualStyleBackColor = true;
            this.bttnAddRunnerWithGeneratedId.Click += new System.EventHandler(this.bttn_AddRunnerWithGeneratedId_Click);
            // 
            // txtBxRunnerNameAdd
            // 
            this.txtBxRunnerNameAdd.Location = new System.Drawing.Point(6, 35);
            this.txtBxRunnerNameAdd.Name = "txtBxRunnerNameAdd";
            this.txtBxRunnerNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtBxRunnerNameAdd.TabIndex = 2;
            this.txtBxRunnerNameAdd.Click += new System.EventHandler(this.com);
            // 
            // cmbBxCountryAdd
            // 
            this.cmbBxCountryAdd.FormattingEnabled = true;
            this.cmbBxCountryAdd.Location = new System.Drawing.Point(112, 34);
            this.cmbBxCountryAdd.Name = "cmbBxCountryAdd";
            this.cmbBxCountryAdd.Size = new System.Drawing.Size(121, 21);
            this.cmbBxCountryAdd.TabIndex = 3;
            // 
            // cmbBxSexAdd
            // 
            this.cmbBxSexAdd.FormattingEnabled = true;
            this.cmbBxSexAdd.Location = new System.Drawing.Point(308, 33);
            this.cmbBxSexAdd.Name = "cmbBxSexAdd";
            this.cmbBxSexAdd.Size = new System.Drawing.Size(121, 21);
            this.cmbBxSexAdd.TabIndex = 5;
            // 
            // bttnAddRunnerWithCustomId
            // 
            this.bttnAddRunnerWithCustomId.Location = new System.Drawing.Point(435, 59);
            this.bttnAddRunnerWithCustomId.Name = "bttnAddRunnerWithCustomId";
            this.bttnAddRunnerWithCustomId.Size = new System.Drawing.Size(138, 23);
            this.bttnAddRunnerWithCustomId.TabIndex = 7;
            this.bttnAddRunnerWithCustomId.Text = "Add Runner with number";
            this.bttnAddRunnerWithCustomId.UseVisualStyleBackColor = true;
            // 
            // lblTitleOfRunnerstable
            // 
            this.lblTitleOfRunnerstable.AutoSize = true;
            this.lblTitleOfRunnerstable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleOfRunnerstable.Location = new System.Drawing.Point(68, 23);
            this.lblTitleOfRunnerstable.Name = "lblTitleOfRunnerstable";
            this.lblTitleOfRunnerstable.Size = new System.Drawing.Size(301, 25);
            this.lblTitleOfRunnerstable.TabIndex = 8;
            this.lblTitleOfRunnerstable.Text = "Registered runners for race";
            // 
            // grpBxAddingRunner
            // 
            this.grpBxAddingRunner.Controls.Add(this.nmrcUpDwnNumberAdd);
            this.grpBxAddingRunner.Controls.Add(this.nmrcUpDwnAgeAdd);
            this.grpBxAddingRunner.Controls.Add(this.lblNumberRunner);
            this.grpBxAddingRunner.Controls.Add(this.lblSexRunner);
            this.grpBxAddingRunner.Controls.Add(this.lblAgeRunner);
            this.grpBxAddingRunner.Controls.Add(this.lblCountryRunner);
            this.grpBxAddingRunner.Controls.Add(this.lblNameRunner);
            this.grpBxAddingRunner.Controls.Add(this.txtBxRunnerNameAdd);
            this.grpBxAddingRunner.Controls.Add(this.bttnAddRunnerWithCustomId);
            this.grpBxAddingRunner.Controls.Add(this.cmbBxCountryAdd);
            this.grpBxAddingRunner.Controls.Add(this.bttnAddRunnerWithGeneratedId);
            this.grpBxAddingRunner.Controls.Add(this.cmbBxSexAdd);
            this.grpBxAddingRunner.Location = new System.Drawing.Point(73, 294);
            this.grpBxAddingRunner.Name = "grpBxAddingRunner";
            this.grpBxAddingRunner.Size = new System.Drawing.Size(582, 91);
            this.grpBxAddingRunner.TabIndex = 9;
            this.grpBxAddingRunner.TabStop = false;
            this.grpBxAddingRunner.Text = "Add runner for race";
            // 
            // lblNameRunner
            // 
            this.lblNameRunner.AutoSize = true;
            this.lblNameRunner.Location = new System.Drawing.Point(13, 19);
            this.lblNameRunner.Name = "lblNameRunner";
            this.lblNameRunner.Size = new System.Drawing.Size(35, 13);
            this.lblNameRunner.TabIndex = 8;
            this.lblNameRunner.Text = "Name";
            // 
            // lblCountryRunner
            // 
            this.lblCountryRunner.AutoSize = true;
            this.lblCountryRunner.Location = new System.Drawing.Point(118, 18);
            this.lblCountryRunner.Name = "lblCountryRunner";
            this.lblCountryRunner.Size = new System.Drawing.Size(43, 13);
            this.lblCountryRunner.TabIndex = 9;
            this.lblCountryRunner.Text = "Country";
            // 
            // lblAgeRunner
            // 
            this.lblAgeRunner.AutoSize = true;
            this.lblAgeRunner.Location = new System.Drawing.Point(250, 18);
            this.lblAgeRunner.Name = "lblAgeRunner";
            this.lblAgeRunner.Size = new System.Drawing.Size(26, 13);
            this.lblAgeRunner.TabIndex = 10;
            this.lblAgeRunner.Text = "Age";
            // 
            // lblSexRunner
            // 
            this.lblSexRunner.AutoSize = true;
            this.lblSexRunner.Location = new System.Drawing.Point(314, 17);
            this.lblSexRunner.Name = "lblSexRunner";
            this.lblSexRunner.Size = new System.Drawing.Size(25, 13);
            this.lblSexRunner.TabIndex = 11;
            this.lblSexRunner.Text = "Sex";
            // 
            // lblNumberRunner
            // 
            this.lblNumberRunner.AutoSize = true;
            this.lblNumberRunner.Location = new System.Drawing.Point(242, 69);
            this.lblNumberRunner.Name = "lblNumberRunner";
            this.lblNumberRunner.Size = new System.Drawing.Size(123, 13);
            this.lblNumberRunner.TabIndex = 12;
            this.lblNumberRunner.Text = "Number runner (optional)";
            // 
            // grpBxEditRunner
            // 
            this.grpBxEditRunner.Controls.Add(this.nmrcUpDwnNumberEdit);
            this.grpBxEditRunner.Controls.Add(this.nmrcUpDwnPickNumberToEdit);
            this.grpBxEditRunner.Controls.Add(this.lblNumberRunnerEdit);
            this.grpBxEditRunner.Controls.Add(this.lblTypeNumberOfRunnerToEdit);
            this.grpBxEditRunner.Controls.Add(this.label2);
            this.grpBxEditRunner.Controls.Add(this.label3);
            this.grpBxEditRunner.Controls.Add(this.label4);
            this.grpBxEditRunner.Controls.Add(this.label5);
            this.grpBxEditRunner.Controls.Add(this.bttnOkNumberEdit);
            this.grpBxEditRunner.Controls.Add(this.txtBxRunnerNameEdit);
            this.grpBxEditRunner.Controls.Add(this.cmbBxCountryEdit);
            this.grpBxEditRunner.Controls.Add(this.nmrcUpDwnAgeEdit);
            this.grpBxEditRunner.Controls.Add(this.bttnOkRunnerEdit);
            this.grpBxEditRunner.Controls.Add(this.cmbBxSexEdit);
            this.grpBxEditRunner.Location = new System.Drawing.Point(73, 400);
            this.grpBxEditRunner.Name = "grpBxEditRunner";
            this.grpBxEditRunner.Size = new System.Drawing.Size(582, 108);
            this.grpBxEditRunner.TabIndex = 13;
            this.grpBxEditRunner.TabStop = false;
            this.grpBxEditRunner.Text = "Edit Runner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // txtBxRunnerNameEdit
            // 
            this.txtBxRunnerNameEdit.Location = new System.Drawing.Point(6, 74);
            this.txtBxRunnerNameEdit.Name = "txtBxRunnerNameEdit";
            this.txtBxRunnerNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtBxRunnerNameEdit.TabIndex = 2;
            // 
            // bttnOkNumberEdit
            // 
            this.bttnOkNumberEdit.Location = new System.Drawing.Point(85, 30);
            this.bttnOkNumberEdit.Name = "bttnOkNumberEdit";
            this.bttnOkNumberEdit.Size = new System.Drawing.Size(53, 23);
            this.bttnOkNumberEdit.TabIndex = 7;
            this.bttnOkNumberEdit.Text = "OK";
            this.bttnOkNumberEdit.UseVisualStyleBackColor = true;
            // 
            // cmbBxCountryEdit
            // 
            this.cmbBxCountryEdit.FormattingEnabled = true;
            this.cmbBxCountryEdit.Location = new System.Drawing.Point(112, 73);
            this.cmbBxCountryEdit.Name = "cmbBxCountryEdit";
            this.cmbBxCountryEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbBxCountryEdit.TabIndex = 3;
            // 
            // nmrcUpDwnAgeEdit
            // 
            this.nmrcUpDwnAgeEdit.Location = new System.Drawing.Point(244, 73);
            this.nmrcUpDwnAgeEdit.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.nmrcUpDwnAgeEdit.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmrcUpDwnAgeEdit.Name = "nmrcUpDwnAgeEdit";
            this.nmrcUpDwnAgeEdit.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnAgeEdit.TabIndex = 4;
            this.nmrcUpDwnAgeEdit.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // bttnOkRunnerEdit
            // 
            this.bttnOkRunnerEdit.Location = new System.Drawing.Point(502, 72);
            this.bttnOkRunnerEdit.Name = "bttnOkRunnerEdit";
            this.bttnOkRunnerEdit.Size = new System.Drawing.Size(71, 21);
            this.bttnOkRunnerEdit.TabIndex = 1;
            this.bttnOkRunnerEdit.Text = "Edit Runner";
            this.bttnOkRunnerEdit.UseVisualStyleBackColor = true;
            // 
            // cmbBxSexEdit
            // 
            this.cmbBxSexEdit.FormattingEnabled = true;
            this.cmbBxSexEdit.Location = new System.Drawing.Point(308, 72);
            this.cmbBxSexEdit.Name = "cmbBxSexEdit";
            this.cmbBxSexEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbBxSexEdit.TabIndex = 5;
            // 
            // lblTypeNumberOfRunnerToEdit
            // 
            this.lblTypeNumberOfRunnerToEdit.AutoSize = true;
            this.lblTypeNumberOfRunnerToEdit.Location = new System.Drawing.Point(6, 14);
            this.lblTypeNumberOfRunnerToEdit.Name = "lblTypeNumberOfRunnerToEdit";
            this.lblTypeNumberOfRunnerToEdit.Size = new System.Drawing.Size(210, 13);
            this.lblTypeNumberOfRunnerToEdit.TabIndex = 12;
            this.lblTypeNumberOfRunnerToEdit.Text = "Type number of runner to edit and press ok";
            // 
            // lblNumberRunnerEdit
            // 
            this.lblNumberRunnerEdit.AutoSize = true;
            this.lblNumberRunnerEdit.Location = new System.Drawing.Point(432, 56);
            this.lblNumberRunnerEdit.Name = "lblNumberRunnerEdit";
            this.lblNumberRunnerEdit.Size = new System.Drawing.Size(44, 13);
            this.lblNumberRunnerEdit.TabIndex = 14;
            this.lblNumberRunnerEdit.Text = "Number";
            // 
            // grpBxDeleteRunner
            // 
            this.grpBxDeleteRunner.Controls.Add(this.label6);
            this.grpBxDeleteRunner.Controls.Add(this.bttnOkRunnerDelete);
            this.grpBxDeleteRunner.Controls.Add(this.nmrcUpDwnNumberDelete);
            this.grpBxDeleteRunner.Location = new System.Drawing.Point(73, 514);
            this.grpBxDeleteRunner.Name = "grpBxDeleteRunner";
            this.grpBxDeleteRunner.Size = new System.Drawing.Size(582, 80);
            this.grpBxDeleteRunner.TabIndex = 15;
            this.grpBxDeleteRunner.TabStop = false;
            this.grpBxDeleteRunner.Text = "Delete runner";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type number of runner to delete and press ok";
            // 
            // bttnOkRunnerDelete
            // 
            this.bttnOkRunnerDelete.Location = new System.Drawing.Point(85, 30);
            this.bttnOkRunnerDelete.Name = "bttnOkRunnerDelete";
            this.bttnOkRunnerDelete.Size = new System.Drawing.Size(53, 23);
            this.bttnOkRunnerDelete.TabIndex = 7;
            this.bttnOkRunnerDelete.Text = "OK";
            this.bttnOkRunnerDelete.UseVisualStyleBackColor = true;
            // 
            // nmrcUpDwnNumberDelete
            // 
            this.nmrcUpDwnNumberDelete.Location = new System.Drawing.Point(9, 33);
            this.nmrcUpDwnNumberDelete.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmrcUpDwnNumberDelete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDwnNumberDelete.Name = "nmrcUpDwnNumberDelete";
            this.nmrcUpDwnNumberDelete.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnNumberDelete.TabIndex = 6;
            this.nmrcUpDwnNumberDelete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrcUpDwnPickNumberToEdit
            // 
            this.nmrcUpDwnPickNumberToEdit.Location = new System.Drawing.Point(9, 33);
            this.nmrcUpDwnPickNumberToEdit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmrcUpDwnPickNumberToEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDwnPickNumberToEdit.Name = "nmrcUpDwnPickNumberToEdit";
            this.nmrcUpDwnPickNumberToEdit.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnPickNumberToEdit.TabIndex = 13;
            this.nmrcUpDwnPickNumberToEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrcUpDwnAgeAdd
            // 
            this.nmrcUpDwnAgeAdd.Location = new System.Drawing.Point(244, 34);
            this.nmrcUpDwnAgeAdd.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.nmrcUpDwnAgeAdd.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmrcUpDwnAgeAdd.Name = "nmrcUpDwnAgeAdd";
            this.nmrcUpDwnAgeAdd.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnAgeAdd.TabIndex = 15;
            this.nmrcUpDwnAgeAdd.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // nmrcUpDwnNumberEdit
            // 
            this.nmrcUpDwnNumberEdit.Location = new System.Drawing.Point(435, 72);
            this.nmrcUpDwnNumberEdit.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmrcUpDwnNumberEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDwnNumberEdit.Name = "nmrcUpDwnNumberEdit";
            this.nmrcUpDwnNumberEdit.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnNumberEdit.TabIndex = 13;
            this.nmrcUpDwnNumberEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrcUpDwnNumberAdd
            // 
            this.nmrcUpDwnNumberAdd.Location = new System.Drawing.Point(371, 62);
            this.nmrcUpDwnNumberAdd.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmrcUpDwnNumberAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDwnNumberAdd.Name = "nmrcUpDwnNumberAdd";
            this.nmrcUpDwnNumberAdd.Size = new System.Drawing.Size(58, 20);
            this.nmrcUpDwnNumberAdd.TabIndex = 15;
            this.nmrcUpDwnNumberAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 639);
            this.Controls.Add(this.grpBxDeleteRunner);
            this.Controls.Add(this.grpBxEditRunner);
            this.Controls.Add(this.lblTitleOfRunnerstable);
            this.Controls.Add(this.dtGrdRegisteredRunnersVw);
            this.Controls.Add(this.grpBxAddingRunner);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRegisteredRunnersVw)).EndInit();
            this.grpBxAddingRunner.ResumeLayout(false);
            this.grpBxAddingRunner.PerformLayout();
            this.grpBxEditRunner.ResumeLayout(false);
            this.grpBxEditRunner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnAgeEdit)).EndInit();
            this.grpBxDeleteRunner.ResumeLayout(false);
            this.grpBxDeleteRunner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnPickNumberToEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnAgeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnNumberAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdRegisteredRunnersVw;
        private System.Windows.Forms.Button bttnAddRunnerWithGeneratedId;
        private System.Windows.Forms.TextBox txtBxRunnerNameAdd;
        private System.Windows.Forms.ComboBox cmbBxCountryAdd;
        private System.Windows.Forms.ComboBox cmbBxSexAdd;
        private System.Windows.Forms.Button bttnAddRunnerWithCustomId;
        private System.Windows.Forms.Label lblTitleOfRunnerstable;
        private System.Windows.Forms.GroupBox grpBxAddingRunner;
        private System.Windows.Forms.Label lblNumberRunner;
        private System.Windows.Forms.Label lblSexRunner;
        private System.Windows.Forms.Label lblAgeRunner;
        private System.Windows.Forms.Label lblCountryRunner;
        private System.Windows.Forms.Label lblNameRunner;
        private System.Windows.Forms.GroupBox grpBxEditRunner;
        private System.Windows.Forms.Label lblNumberRunnerEdit;
        private System.Windows.Forms.Label lblTypeNumberOfRunnerToEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnOkNumberEdit;
        private System.Windows.Forms.TextBox txtBxRunnerNameEdit;
        private System.Windows.Forms.ComboBox cmbBxCountryEdit;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnAgeEdit;
        private System.Windows.Forms.Button bttnOkRunnerEdit;
        private System.Windows.Forms.ComboBox cmbBxSexEdit;
        private System.Windows.Forms.GroupBox grpBxDeleteRunner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnOkRunnerDelete;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnNumberDelete;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnNumberAdd;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnAgeAdd;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnNumberEdit;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnPickNumberToEdit;
    }
}