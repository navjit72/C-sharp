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
    }
}
