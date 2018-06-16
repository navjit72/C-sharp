namespace ProjectManagementSystem.Presentation
{
    partial class FormProject
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
            this.components = new System.ComponentModel.Container();
            this.cmbCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dGVProject = new System.Windows.Forms.DataGridView();
            this.cmbCriteriaValue = new System.Windows.Forms.ComboBox();
            this.tabProject = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.cmbCriteriaValue2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCriteria2 = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtProjectManager = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reporteeDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTxtId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProject)).BeginInit();
            this.tabProject.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteeDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCriteria
            // 
            this.cmbCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCriteria.FormattingEnabled = true;
            this.cmbCriteria.Items.AddRange(new object[] {
            "Project Id",
            "Project Name",
            "Project Status",
            "Project Manager"});
            this.cmbCriteria.Location = new System.Drawing.Point(105, 28);
            this.cmbCriteria.Name = "cmbCriteria";
            this.cmbCriteria.Size = new System.Drawing.Size(171, 24);
            this.cmbCriteria.TabIndex = 0;
            this.cmbCriteria.SelectedIndexChanged += new System.EventHandler(this.cmbCriteria_SelectedIndexChanged);
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
            // dGVProject
            // 
            this.dGVProject.AllowUserToAddRows = false;
            this.dGVProject.AllowUserToDeleteRows = false;
            this.dGVProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProject.Location = new System.Drawing.Point(20, 82);
            this.dGVProject.Name = "dGVProject";
            this.dGVProject.ReadOnly = true;
            this.dGVProject.Size = new System.Drawing.Size(611, 262);
            this.dGVProject.TabIndex = 4;
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
            // tabProject
            // 
            this.tabProject.Controls.Add(this.tabPageSearch);
            this.tabProject.Controls.Add(this.tabPageUpdate);
            this.tabProject.Location = new System.Drawing.Point(12, 12);
            this.tabProject.Name = "tabProject";
            this.tabProject.SelectedIndex = 0;
            this.tabProject.Size = new System.Drawing.Size(665, 387);
            this.tabProject.TabIndex = 6;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dGVProject);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.cmbCriteriaValue);
            this.tabPageSearch.Controls.Add(this.label1);
            this.tabPageSearch.Controls.Add(this.cmbCriteria);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(657, 361);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.cmbTxtId);
            this.tabPageUpdate.Controls.Add(this.btnSearch2);
            this.tabPageUpdate.Controls.Add(this.cmbCriteriaValue2);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.cmbCriteria2);
            this.tabPageUpdate.Controls.Add(this.cmbStatus);
            this.tabPageUpdate.Controls.Add(this.txtProjectManager);
            this.tabPageUpdate.Controls.Add(this.label4);
            this.tabPageUpdate.Controls.Add(this.label3);
            this.tabPageUpdate.Controls.Add(this.txtProjectname);
            this.tabPageUpdate.Controls.Add(this.label2);
            this.tabPageUpdate.Controls.Add(this.btnOk);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(657, 361);
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
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch1_Click);
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
            "Project Id",
            "Project Name",
            "Project Status",
            "Project Manager"});
            this.cmbCriteria2.Location = new System.Drawing.Point(143, 38);
            this.cmbCriteria2.Name = "cmbCriteria2";
            this.cmbCriteria2.Size = new System.Drawing.Size(171, 24);
            this.cmbCriteria2.TabIndex = 40;
            this.cmbCriteria2.SelectedIndexChanged += new System.EventHandler(this.cmbCriteria2_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ongoing",
            "Finished"});
            this.cmbStatus.Location = new System.Drawing.Point(317, 190);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(111, 24);
            this.cmbStatus.TabIndex = 39;
            // 
            // txtProjectManager
            // 
            this.txtProjectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectManager.Location = new System.Drawing.Point(314, 237);
            this.txtProjectManager.Name = "txtProjectManager";
            this.txtProjectManager.Size = new System.Drawing.Size(114, 23);
            this.txtProjectManager.TabIndex = 37;
            this.txtProjectManager.Tag = "Project Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Project Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Project Status";
            // 
            // txtProjectname
            // 
            this.txtProjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectname.Location = new System.Drawing.Point(314, 143);
            this.txtProjectname.Name = "txtProjectname";
            this.txtProjectname.Size = new System.Drawing.Size(114, 23);
            this.txtProjectname.TabIndex = 31;
            this.txtProjectname.Tag = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Project Name";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(221, 305);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 32);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Project ID";
            // 
            // reporteeDBBindingSource
            // 
            this.reporteeDBBindingSource.DataSource = typeof(ProjectManagementSystem.Data.ReporteeDB);
            // 
            // projectDBBindingSource
            // 
            this.projectDBBindingSource.DataSource = typeof(ProjectManagementSystem.Data.ProjectDB);
            // 
            // cmbTxtId
            // 
            this.cmbTxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTxtId.FormattingEnabled = true;
            this.cmbTxtId.Location = new System.Drawing.Point(314, 94);
            this.cmbTxtId.Name = "cmbTxtId";
            this.cmbTxtId.Size = new System.Drawing.Size(114, 24);
            this.cmbTxtId.TabIndex = 44;
            this.cmbTxtId.SelectedIndexChanged += new System.EventHandler(this.cmbTxtId_SelectedIndexChanged);
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 411);
            this.Controls.Add(this.tabProject);
            this.Name = "FormProject";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.dGVProject)).EndInit();
            this.tabProject.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteeDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dGVProject;
        private System.Windows.Forms.BindingSource projectDBBindingSource;
        private System.Windows.Forms.BindingSource reporteeDBBindingSource;
        private System.Windows.Forms.ComboBox cmbCriteriaValue;
        private System.Windows.Forms.TabControl tabProject;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtProjectManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.ComboBox cmbCriteriaValue2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCriteria2;
        private System.Windows.Forms.ComboBox cmbTxtId;
    }
}