namespace ProjectManagementSystem.Presentation
{
    partial class FrmManagerDashboard
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
            this.projectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReporteeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeReporteeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignRatingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demandsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.managerName = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectMenuItem,
            this.reporteeMenuItem,
            this.demandsMenuItem,
            this.changePasswordMenuItem,
            this.logOutMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripManager";
            // 
            // projectMenuItem
            // 
            this.projectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReporteeItem,
            this.removeReporteeItem,
            this.updateDetailsItem});
            this.projectMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.projectMenuItem.Name = "projectMenuItem";
            this.projectMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectMenuItem.Text = "Project";
            // 
            // addReporteeItem
            // 
            this.addReporteeItem.Name = "addReporteeItem";
            this.addReporteeItem.Size = new System.Drawing.Size(167, 22);
            this.addReporteeItem.Text = "Add Reportee";
            this.addReporteeItem.Click += new System.EventHandler(this.addReporteeItem_Click);
            // 
            // removeReporteeItem
            // 
            this.removeReporteeItem.Name = "removeReporteeItem";
            this.removeReporteeItem.Size = new System.Drawing.Size(167, 22);
            this.removeReporteeItem.Text = "Remove Reportee";
            // 
            // updateDetailsItem
            // 
            this.updateDetailsItem.Name = "updateDetailsItem";
            this.updateDetailsItem.Size = new System.Drawing.Size(167, 22);
            this.updateDetailsItem.Text = "Update Details";
            // 
            // reporteeMenuItem
            // 
            this.reporteeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignRatingItem});
            this.reporteeMenuItem.Name = "reporteeMenuItem";
            this.reporteeMenuItem.Size = new System.Drawing.Size(66, 20);
            this.reporteeMenuItem.Text = "Reportee";
            // 
            // assignRatingItem
            // 
            this.assignRatingItem.Name = "assignRatingItem";
            this.assignRatingItem.Size = new System.Drawing.Size(151, 22);
            this.assignRatingItem.Text = "Assign Ratings";
            // 
            // demandsMenuItem
            // 
            this.demandsMenuItem.Name = "demandsMenuItem";
            this.demandsMenuItem.Size = new System.Drawing.Size(69, 20);
            this.demandsMenuItem.Text = "Demands";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(113, 20);
            this.changePasswordMenuItem.Text = "Change Password";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutMenuItem.Text = "Log Out";
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.managerName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel1.Text = "WELCOME";
            // 
            // managerName
            // 
            this.managerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.managerName.Name = "managerName";
            this.managerName.Size = new System.Drawing.Size(0, 22);
            // 
            // FrmManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 413);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReporteeItem;
        private System.Windows.Forms.ToolStripMenuItem removeReporteeItem;
        private System.Windows.Forms.ToolStripMenuItem reporteeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignRatingItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsItem;
        private System.Windows.Forms.ToolStripMenuItem demandsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel managerName;
    }
}