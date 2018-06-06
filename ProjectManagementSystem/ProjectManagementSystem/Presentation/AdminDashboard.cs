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
        public FrmAdminDashboard(Admin adminObj)
        {
            InitializeComponent();
            adminId.Text = adminObj.FirstName + " " + adminObj.LastName;
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
            addEmp.ShowDialog();
        }

        private void addReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addEmp = new FrmAddEmployee("Reportee");
            addEmp.ShowDialog();
        }

        private void addProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddProject addProject = new FrmAddProject();
            addProject.ShowDialog();
        }

        private void updateManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager","update");
            inputId.ShowDialog();
        }

        private void updateReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee","update");
            inputId.ShowDialog();
        }

        private void updateProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project","update");
            inputId.ShowDialog();
        }

        private void deleteManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager","delete");
            inputId.ShowDialog();
        }

        private void deleteReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee","delete");
            inputId.ShowDialog();
        }

        private void deleteProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project","delete");
            inputId.ShowDialog();
        }

        private void searchManagerMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Manager", "search");
            inputId.ShowDialog();
        }

        private void searchReporteeMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Reportee", "search");
            inputId.ShowDialog();
        }

        private void searchProjectMenuItem_Click(object sender, EventArgs e)
        {
            FrmInputId inputId = new FrmInputId("Project", "search");
            inputId.ShowDialog();
        }
    }
}
