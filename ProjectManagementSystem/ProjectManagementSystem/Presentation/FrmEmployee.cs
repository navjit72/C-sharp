using ProjectManagementSystem.Business;
using ProjectManagementSystem.Data;
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
    public partial class FrmEmployee : Form
    {
        Manager manager;
        Reportee reportee;
        Type employee;
        string operation;

        public FrmEmployee(Type emp, string op)
        {
            employee = emp;
            operation = op;
            InitializeComponent();
        }

        private bool IsValidData()
        {
            return Validator.IsValidEmail(txtEmail) || Validator.IsValidName(txtFname)
                || Validator.IsValidName(txtLname);
        }

        private RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }

        private void UpdateManager(RadioButton radio)
        {
            manager = (Manager)Validator.IsValidInputId(employee, toolStripTxtId.Text);
            manager.FirstName = txtFname.Text;
            manager.LastName = txtLname.Text;
            manager.Email = txtEmail.Text;
            manager.ContactNumber = MtxtPhone.Text;
            manager.Gender = Convert.ToChar(radio.Text);
            manager.Password = txtPassword.Text;        
            MessageBox.Show("Manager with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateReportee(RadioButton radio)
        {
            reportee = (Reportee)Validator.IsValidInputId(employee, toolStripTxtId.Text);
            reportee.FirstName = txtFname.Text;
            reportee.LastName = txtLname.Text;
            reportee.Email = txtEmail.Text;
            reportee.ContactNumber = MtxtPhone.Text;
            reportee.Gender = Convert.ToChar(radio.Text);
            reportee.Password = txtPassword.Text;
            MessageBox.Show("Reportee with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (operation.Equals("Search"))
                this.Close();
            else
            {
                try
                {
                    if (IsValidData())
                    {
                        RadioButton radioBtn = GetCheckedRadio(Gender);
                        if (radioBtn != null)
                        {
                            if (employee.GetType() == typeof(Manager))
                                UpdateManager(radioBtn);
                            else if (employee.GetType() == typeof(Reportee))
                                UpdateReportee(radioBtn);
                            this.Close();
                        }
                        else
                            throw new CustomMadeException("Please select a gender.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
            if (employee.GetType() == typeof(Manager))
            {
                manager = (Manager)Validator.IsValidInputId(employee, toolStripTxtId.Text);
                txtId.Text = manager.EmpID;
                txtFname.Text = manager.FirstName;
                txtLname.Text = manager.LastName;
                txtEmail.Text = manager.Email;
                MtxtPhone.Text = manager.ContactNumber;
                txtPassword.Text = manager.Password;
                if (manager.Gender == 'F')
                    RadioFemale.Checked = true;
                else if (manager.Gender == 'M')
                    RadioMale.Checked = true;
            }
            else if (employee.GetType() == typeof(Reportee))
            {
                reportee = (Reportee)Validator.IsValidInputId(employee, toolStripTxtId.Text);
                txtId.Text = reportee.EmpID;
                txtFname.Text = reportee.FirstName;
                txtLname.Text = reportee.LastName;
                txtEmail.Text = reportee.Email;
                MtxtPhone.Text = reportee.ContactNumber;
                txtPassword.Text = reportee.Password;
                if (reportee.Gender == 'F')
                    RadioFemale.Checked = true;
                else if (reportee.Gender == 'M')
                    RadioMale.Checked = true;
            }
            if(operation.Equals("Search"))
            {
                txtFname.ReadOnly = true;
                txtLname.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
        }
    }
}
