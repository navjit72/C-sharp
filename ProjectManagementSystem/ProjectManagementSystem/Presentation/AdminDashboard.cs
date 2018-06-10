using ProjectManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem.Presentation
{
    public partial class FrmAdminDashboard : Form
    {
        Admin admin;
        public FrmAdminDashboard(Admin adminObj)
        {
            admin = adminObj;
            InitializeComponent();
            toolStripAdminId.Text = adminObj.FirstName + " " + adminObj.LastName;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void addManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addEmp = new FrmAddEmployee("Manager");
            addEmp.MdiParent = this;
            addEmp.Dock = DockStyle.Fill;
            addEmp.Show();
        }

        private void addReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addEmp = new FrmAddEmployee("Reportee");
            addEmp.MdiParent = this;
            addEmp.Dock = DockStyle.Fill;
            addEmp.Show();
        }

        private void addProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddProject addProject = new FrmAddProject();
            addProject.MdiParent = this;
            addProject.Dock = DockStyle.Fill;
            addProject.Show();
        }

        private void updateManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager","update",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void updateReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee","update",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void updateProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project","update",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void deleteManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager","delete",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void deleteReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee","delete",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void deleteProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project","delete",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void searchManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager", "search",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void searchReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee", "search",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void searchProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project", "search",admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePass = new FrmChangePassword(admin);
            changePass.MdiParent = this;
            changePass.Show();
        }
    }
}
