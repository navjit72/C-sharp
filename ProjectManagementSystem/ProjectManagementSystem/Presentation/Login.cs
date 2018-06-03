using ProjectManagementSystem.Business;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Presentation;
using ProjectManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsDataPresent(txtUsername))
                    if (Validator.IsDataPresent(txtPassword))
                    {
                        char c = txtUsername.Text.First();
                        if (c == 'A')
                        {
                            foreach (Admin admin in AdminDB.GetData())
                            {
                                if (admin.EmpID.Equals(txtUsername.Text))
                                    if (admin.Password.Equals(txtPassword.Text))
                                    {
                                        MessageBox.Show("Login Successfull!!", "Success Message");
                                        this.Hide();
                                        FrmAdminDashboard adminForm = new FrmAdminDashboard(admin);
                                        adminForm.Show();
                                    }
                                    else
                                        throw new CustomMadeException("Wrong Password!!");
                                else
                                    throw new CustomMadeException("Wrong Employee Id!!");
                            }
                        }
                        else if (c == 'M')
                        {
                            foreach (Manager manager in ManagerDB.GetData())
                            {
                                if (manager.EmpID.Equals(txtUsername.Text))
                                    if (manager.Password.Equals(txtPassword.Text))
                                    {
                                        MessageBox.Show("Login Successfull!!", "Success Message");
                                        this.Hide();
                                        ManagerDashboard managerForm = new ManagerDashboard();
                                        managerForm.Show();
                                    }
                                    else
                                        throw new CustomMadeException("Wrong Password!!");
                                else
                                    throw new CustomMadeException("Wrong Employee Id!!");
                            }
                        }
                        else if (c == 'R')
                        {
                            foreach (Reportee reportee in ReporteeDB.GetData())
                            {
                                if (reportee.EmpID.Equals(txtUsername.Text))
                                    if (reportee.Password.Equals(txtPassword.Text))
                                    {
                                        MessageBox.Show("Login Successfull!!", "Success Message");
                                        this.Hide();
                                        ReporteeDashboard reporteeForm = new ReporteeDashboard();
                                        reporteeForm.Show();
                                    }
                                    else
                                        throw new CustomMadeException("Wrong Password!!");
                                else
                                    throw new CustomMadeException("Wrong Employee Id!!");
                            }
                        }
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
