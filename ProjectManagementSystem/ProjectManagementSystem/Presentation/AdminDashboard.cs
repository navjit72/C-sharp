using ProjectManagementSystem.Business;
using ProjectManagementSystem.Utilities;
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

        //private void updateManagerMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmEmployee updateMan = new FrmEmployee(typeof(Manager),"Update");
        //    updateMan.MdiParent = this;
        //    updateMan.Dock = DockStyle.Fill;
        //    updateMan.Show();
        //}

        //private void updateReporteeMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmEmployee updateRep = new FrmEmployee(typeof(Reportee),"Update");
        //    updateRep.MdiParent = this;
        //    updateRep.Dock = DockStyle.Fill;
        //    updateRep.Show();
        //}

        //private void updateProjectMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmProject updateProj = new FrmProject("Update");
        //    updateProj.MdiParent = this;
        //    updateProj.Dock = DockStyle.Fill;
        //    updateProj.Show();
        //}

        private void deleteManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId(typeof(Manager),admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void deleteReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId(typeof(Reportee),admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void deleteProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId(typeof(Project),admin);
            inputId.MdiParent = this;
            inputId.Show();
        }

        private void searchManagerMenuItem_Click(object sender, EventArgs e)
        {
            FormManager searchMan = new FormManager();
            searchMan.MdiParent = this;
            searchMan.Dock = DockStyle.Fill;
            searchMan.Show();
        }

        private void searchReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FormReportee searchRep = new FormReportee();
            searchRep.MdiParent = this;
            searchRep.Dock = DockStyle.Fill;
            searchRep.Show();
        }

        private void searchProjectMenuItem_Click(object sender, EventArgs e)
        {
            FormProject project = new FormProject();
            project.MdiParent = this;
            project.Dock = DockStyle.Fill;
            project.Show();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePass = new FrmChangePassword(typeof(Admin),admin);
            changePass.MdiParent = this;
            changePass.Dock = DockStyle.Fill;
            changePass.Show();
        }
    }
}
