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
    public partial class FrmChangePassword : Form
    {
        Admin admin;
        public FrmChangePassword(Admin adminObj)
        {
            admin = adminObj;
            InitializeComponent();
        }

        private void txtOldPass_Enter(object sender, EventArgs e)
        {
            txtOldPass.Clear();
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            txtNewPass.Clear();
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            txtConfirmPass.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
