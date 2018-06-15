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
    public partial class FrmManagerDashboard : Form
    {
        Manager manager;
        public FrmManagerDashboard(Manager manObj)
        {
            manager = manObj;
            InitializeComponent();
            managerName.Text = manager.FirstName + " " + manager.LastName;
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePass = new FrmChangePassword(typeof(Manager),manager);
            changePass.MdiParent = this;
            changePass.Dock = DockStyle.Fill;
            changePass.Show();
        }

        private void addReporteeItem_Click(object sender, EventArgs e)
        {

        }
    }
}
