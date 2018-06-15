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
    public partial class FrmChangePassword : Form
    {
        Admin admin;
        Manager manager;
        Reportee reportee;
        Type employee;

        public FrmChangePassword(Type emp,Employee obj)
        {
            employee = emp;
            if (employee == typeof(Admin))
                admin = (Admin)obj;
            else if(employee == typeof(Manager))
                manager = (Manager)obj;
            else if(employee == typeof(Reportee))
                reportee = (Reportee)obj;
            
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

        private bool ValidateTextBoxes()
        {
            bool flag = false;
            if (Validator.IsDataPresent(txtOldPass))
                if (employee == typeof(Admin))
                    if (admin.Password.Equals(txtOldPass.Text))
                        flag = true;
                else if (employee == typeof(Manager))
                    if (manager.Password.Equals(txtOldPass.Text))
                            flag = true;
                else if (employee == typeof(Reportee))
                    if (reportee.Password.Equals(txtOldPass.Text))
                                flag = true;
                if(flag)
                {
                        if (Validator.IsValidData(txtNewPass))
                            if (Validator.IsDataPresent(txtConfirmPass))
                                if (txtConfirmPass.Text.Equals(txtNewPass.Text))
                                    return true;
                                else
                                    throw new CustomMadeException("New Password column should match with Confirm Password column.");
                    }
                  else
                        throw new CustomMadeException("Old Password is incorrect. Enter the correct Password.");
            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try {
                 if (ValidateTextBoxes())
                 {
                    if (employee == typeof(Admin))
                        admin.Password = txtNewPass.Text;
                    else if (employee == typeof(Manager))
                        manager.Password = txtNewPass.Text;
                    else if (employee == typeof(Reportee))
                        reportee.Password = txtNewPass.Text;
                    MessageBox.Show("Password Changed Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                 }                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
