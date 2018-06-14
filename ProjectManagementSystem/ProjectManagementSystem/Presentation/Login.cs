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
                            Admin admin = (Admin)Validator.IsValidInputId(typeof(Admin), txtUsername.Text);
                            if (admin != null)
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
                                throw new CustomMadeException("No admin with id " + txtUsername.Text + " exists");
                        }
                        else if (c == 'M')
                        {
                            Manager manager = (Manager)Validator.IsValidInputId(typeof(Manager), txtUsername.Text);
                            if (manager != null)
                                if (manager.Password.Equals(txtPassword.Text))
                                {
                                    MessageBox.Show("Login Successfull!!", "Success Message");
                                    this.Hide();
                                    FrmManagerDashboard managerForm = new FrmManagerDashboard(manager);
                                    managerForm.Show();
                                }
                                else
                                    throw new CustomMadeException("Wrong Password!!");
                            else
                                throw new CustomMadeException("No manager with id " + txtUsername.Text + " exists");
                        }
                        else if (c == 'R')
                        {
                            Reportee reportee = (Reportee)Validator.IsValidInputId(typeof(Reportee), txtUsername.Text);
                            if (reportee != null)
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
                                throw new CustomMadeException("No reportee with id " + txtUsername.Text + " exists");
                        }
                        else
                            throw new CustomMadeException("Invalid Id!!");

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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
