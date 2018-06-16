namespace ProjectManagementSystem.Presentation
{
    partial class FormManager
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
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dGVManager = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCriteriaValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.cmbCriteriaValue2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCriteria2 = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.RadioMale = new System.Windows.Forms.RadioButton();
            this.RadioFemale = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.MtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTxtId = new System.Windows.Forms.ComboBox();
            this.tabEmployee.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVManager)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.tabPageSearch);
            this.tabEmployee.Controls.Add(this.tabPageUpdate);
            this.tabEmployee.Location = new System.Drawing.Point(12, 12);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(665, 473);
            this.tabEmployee.TabIndex = 7;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dGVManager);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.cmbCriteriaValue);
            this.tabPageSearch.Controls.Add(this.label1);
            this.tabPageSearch.Controls.Add(this.cmbCriteria);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(657, 447);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // dGVManager
            // 
            this.dGVManager.AllowUserToAddRows = false;
            this.dGVManager.AllowUserToDeleteRows = false;
            this.dGVManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVManager.Location = new System.Drawing.Point(20, 82);
            this.dGVManager.Name = "dGVManager";
            this.dGVManager.ReadOnly = true;
            this.dGVManager.Size = new System.Drawing.Size(611, 262);
            this.dGVManager.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(494, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCriteriaValue
            // 
            this.cmbCriteriaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteriaValue.FormattingEnabled = true;
            this.cmbCriteriaValue.Location = new System.Drawing.Point(300, 27);
            this.cmbCriteriaValue.Name = "cmbCriteriaValue";
            this.cmbCriteriaValue.Size = new System.Drawing.Size(172, 24);
            this.cmbCriteriaValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by";
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Items.AddRange(new object[] {
            "Manager Id",
            "Manager First Name",
            "Manager Last Name",
            "Manager Email"});
            this.cmbCriteria.Location = new System.Drawing.Point(105, 28);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(171, 24);
            this.cmbCriteria.TabIndex = 0;
            this.cmbCriteria.SelectedIndexChanged += new System.EventHandler(this.cmbCriteria_SelectedIndexChanged);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.cmbTxtId);
            this.tabPageUpdate.Controls.Add(this.txtPassword);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.Gender);
            this.tabPageUpdate.Controls.Add(this.btnOk);
            this.tabPageUpdate.Controls.Add(this.txtEmail);
            this.tabPageUpdate.Controls.Add(this.MtxtPhone);
            this.tabPageUpdate.Controls.Add(this.txtLname);
            this.tabPageUpdate.Controls.Add(this.txtFname);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.label3);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.btnSearch2);
            this.tabPageUpdate.Controls.Add(this.cmbCriteriaValue2);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.cmbCriteria2);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(657, 447);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.Location = new System.Drawing.Point(532, 37);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 25);
            this.btnSearch2.TabIndex = 42;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // cmbCriteriaValue2
            // 
            this.cmbCriteriaValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteriaValue2.FormattingEnabled = true;
            this.cmbCriteriaValue2.Location = new System.Drawing.Point(338, 37);
            this.cmbCriteriaValue2.Name = "cmbCriteriaValue2";
            this.cmbCriteriaValue2.Size = new System.Drawing.Size(172, 24);
            this.cmbCriteriaValue2.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Search by";
            // 
            // cmbCriteria2
            // 
            this.cmbCriteria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteria2.FormattingEnabled = true;
            this.cmbCriteria2.Items.AddRange(new object[] {
            "Manager Id",
            "Manager First Name",
            "Manager Last Name",
            "Manager Email"});
            this.cmbCriteria2.Location = new System.Drawing.Point(143, 38);
            this.cmbCriteria2.Name = "cmbCriteria2";
            this.cmbCriteria2.Size = new System.Drawing.Size(171, 24);
            this.cmbCriteria2.TabIndex = 40;
            this.cmbCriteria2.SelectedIndexChanged += new System.EventHandler(this.cmbCriteria2_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(378, 304);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Password";
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.RadioMale);
            this.Gender.Controls.Add(this.RadioFemale);
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(159, 348);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(319, 37);
            this.Gender.TabIndex = 56;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioMale.Location = new System.Drawing.Point(106, 10);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(37, 21);
            this.RadioMale.TabIndex = 9;
            this.RadioMale.TabStop = true;
            this.RadioMale.Text = "M";
            this.RadioMale.UseVisualStyleBackColor = true;
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioFemale.Location = new System.Drawing.Point(219, 10);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(34, 21);
            this.RadioFemale.TabIndex = 10;
            this.RadioFemale.TabStop = true;
            this.RadioFemale.Text = "F";
            this.RadioFemale.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(265, 402);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 32);
            this.btnOk.TabIndex = 49;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(378, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.Tag = "Email";
            // 
            // MtxtPhone
            // 
            this.MtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtPhone.Location = new System.Drawing.Point(378, 256);
            this.MtxtPhone.Mask = "(999) 000-0000";
            this.MtxtPhone.Name = "MtxtPhone";
            this.MtxtPhone.Size = new System.Drawing.Size(100, 23);
            this.MtxtPhone.TabIndex = 47;
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(378, 158);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 23);
            this.txtLname.TabIndex = 45;
            this.txtLname.Tag = "Last Name";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(378, 113);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 23);
            this.txtFname.TabIndex = 44;
            this.txtFname.Tag = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Employee ID";
            // 
            // cmbTxtId
            // 
            this.cmbTxtId.FormattingEnabled = true;
            this.cmbTxtId.Location = new System.Drawing.Point(374, 77);
            this.cmbTxtId.Name = "cmbTxtId";
            this.cmbTxtId.Size = new System.Drawing.Size(104, 21);
            this.cmbTxtId.TabIndex = 58;
            this.cmbTxtId.SelectedIndexChanged += new System.EventHandler(this.cmbTxtId_SelectedIndexChanged);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 484);
            this.Controls.Add(this.tabEmployee);
            this.Name = "FormManager";
            this.Text = "Manager";
            this.tabEmployee.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVManager)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dGVManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCriteriaValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.ComboBox cmbCriteriaValue2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCriteria2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton RadioMale;
        private System.Windows.Forms.RadioButton RadioFemale;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox MtxtPhone;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTxtId;
    }
}