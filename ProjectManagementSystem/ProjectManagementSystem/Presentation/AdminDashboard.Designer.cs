namespace ProjectManagementSystem.Presentation
{
    partial class FrmAdminDashboard
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
            this.MenuNav = new System.Windows.Forms.MenuStrip();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReporteeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateReporteeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReporteeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchReporteeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripAdminId = new System.Windows.Forms.ToolStripLabel();
            this.MenuNav.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuNav
            // 
            this.MenuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.updateMenuItem,
            this.deleteMenuItem,
            this.searchMenuItem,
            this.changePasswordMenuItem,
            this.logoutMenuItem});
            this.MenuNav.Location = new System.Drawing.Point(0, 0);
            this.MenuNav.Name = "MenuNav";
            this.MenuNav.Size = new System.Drawing.Size(674, 24);
            this.MenuNav.TabIndex = 0;
            this.MenuNav.Text = "menuStrip1";
            // 
            // addMenuItem
            // 
            this.addMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addManagerMenuItem,
            this.addReporteeMenuItem,
            this.addProjectMenuItem});
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.ToolTipText = "Add";
            // 
            // addManagerMenuItem
            // 
            this.addManagerMenuItem.Name = "addManagerMenuItem";
            this.addManagerMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addManagerMenuItem.Text = "Manager";
            this.addManagerMenuItem.ToolTipText = "Add Manager";
            this.addManagerMenuItem.Click += new System.EventHandler(this.addManagerMenuItem_Click);
            // 
            // addReporteeMenuItem
            // 
            this.addReporteeMenuItem.Name = "addReporteeMenuItem";
            this.addReporteeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addReporteeMenuItem.Text = "Reportee";
            this.addReporteeMenuItem.ToolTipText = "Add Reportee";
            this.addReporteeMenuItem.Click += new System.EventHandler(this.addReporteeMenuItem_Click);
            // 
            // addProjectMenuItem
            // 
            this.addProjectMenuItem.Name = "addProjectMenuItem";
            this.addProjectMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addProjectMenuItem.Text = "Project";
            this.addProjectMenuItem.ToolTipText = "Add Project";
            this.addProjectMenuItem.Click += new System.EventHandler(this.addProjectMenuItem_Click);
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateManagerMenuItem,
            this.updateReporteeMenuItem,
            this.updateProjectMenuItem});
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateMenuItem.Text = "Update";
            this.updateMenuItem.ToolTipText = "Update";
            // 
            // updateManagerMenuItem
            // 
            this.updateManagerMenuItem.Name = "updateManagerMenuItem";
            this.updateManagerMenuItem.Size = new System.Drawing.Size(121, 22);
            this.updateManagerMenuItem.Text = "Manager";
            this.updateManagerMenuItem.ToolTipText = "Update Manager";
            this.updateManagerMenuItem.Click += new System.EventHandler(this.updateManagerMenuItem_Click);
            // 
            // updateReporteeMenuItem
            // 
            this.updateReporteeMenuItem.Name = "updateReporteeMenuItem";
            this.updateReporteeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.updateReporteeMenuItem.Text = "Reportee";
            this.updateReporteeMenuItem.ToolTipText = "Update Reportee";
            this.updateReporteeMenuItem.Click += new System.EventHandler(this.updateReporteeMenuItem_Click);
            // 
            // updateProjectMenuItem
            // 
            this.updateProjectMenuItem.Name = "updateProjectMenuItem";
            this.updateProjectMenuItem.Size = new System.Drawing.Size(121, 22);
            this.updateProjectMenuItem.Text = "Project";
            this.updateProjectMenuItem.ToolTipText = "Update Project";
            this.updateProjectMenuItem.Click += new System.EventHandler(this.updateProjectMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteManagerMenuItem,
            this.deleteReporteeMenuItem,
            this.deleteProjectMenuItem});
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.ToolTipText = "Delete";
            // 
            // deleteManagerMenuItem
            // 
            this.deleteManagerMenuItem.Name = "deleteManagerMenuItem";
            this.deleteManagerMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteManagerMenuItem.Text = "Manager";
            this.deleteManagerMenuItem.ToolTipText = "Delete Manager";
            this.deleteManagerMenuItem.Click += new System.EventHandler(this.deleteManagerMenuItem_Click);
            // 
            // deleteReporteeMenuItem
            // 
            this.deleteReporteeMenuItem.Name = "deleteReporteeMenuItem";
            this.deleteReporteeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteReporteeMenuItem.Text = "Reportee";
            this.deleteReporteeMenuItem.ToolTipText = "Delete Reportee";
            this.deleteReporteeMenuItem.Click += new System.EventHandler(this.deleteReporteeMenuItem_Click);
            // 
            // deleteProjectMenuItem
            // 
            this.deleteProjectMenuItem.Name = "deleteProjectMenuItem";
            this.deleteProjectMenuItem.Size = new System.Drawing.Size(121, 22);
            this.deleteProjectMenuItem.Text = "Project";
            this.deleteProjectMenuItem.ToolTipText = "Delete Project";
            this.deleteProjectMenuItem.Click += new System.EventHandler(this.deleteProjectMenuItem_Click);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchManagerMenuItem,
            this.searchReporteeMenuItem,
            this.searchProjectMenuItem});
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchMenuItem.Text = "Search";
            this.searchMenuItem.ToolTipText = "Search";
            // 
            // searchManagerMenuItem
            // 
            this.searchManagerMenuItem.Name = "searchManagerMenuItem";
            this.searchManagerMenuItem.Size = new System.Drawing.Size(121, 22);
            this.searchManagerMenuItem.Text = "Manager";
            this.searchManagerMenuItem.ToolTipText = "Search Manager";
            this.searchManagerMenuItem.Click += new System.EventHandler(this.searchManagerMenuItem_Click);
            // 
            // searchReporteeMenuItem
            // 
            this.searchReporteeMenuItem.Name = "searchReporteeMenuItem";
            this.searchReporteeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.searchReporteeMenuItem.Text = "Reportee";
            this.searchReporteeMenuItem.ToolTipText = "Search Reportee";
            this.searchReporteeMenuItem.Click += new System.EventHandler(this.searchReporteeMenuItem_Click);
            // 
            // searchProjectMenuItem
            // 
            this.searchProjectMenuItem.Name = "searchProjectMenuItem";
            this.searchProjectMenuItem.Size = new System.Drawing.Size(121, 22);
            this.searchProjectMenuItem.Text = "Project";
            this.searchProjectMenuItem.ToolTipText = "Search Project";
            this.searchProjectMenuItem.Click += new System.EventHandler(this.searchProjectMenuItem_Click);
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(113, 20);
            this.changePasswordMenuItem.Text = "Change Password";
            this.changePasswordMenuItem.ToolTipText = "Change Password";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.ToolTipText = "Sign out";
            this.logoutMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripAdminId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel1.Text = "WELCOME";
            // 
            // toolStripAdminId
            // 
            this.toolStripAdminId.Name = "toolStripAdminId";
            this.toolStripAdminId.Size = new System.Drawing.Size(0, 22);
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuNav);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuNav;
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.MenuNav.ResumeLayout(false);
            this.MenuNav.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuNav;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReporteeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateReporteeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReporteeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchReporteeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripAdminId;
    }
}