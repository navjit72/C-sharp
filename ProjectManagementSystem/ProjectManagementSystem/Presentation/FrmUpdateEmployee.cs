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
    public partial class FrmUpdateEmployee : Form
    {
        Manager manager;
        Reportee reportee;
        string employee;
        public FrmUpdateEmployee(string emp,Object obj)
        {
            employee = emp;
            if (employee.Equals("Manager"))
                manager = (Manager)obj;
            else if (employee.Equals("Reportee"))
                reportee = (Reportee)obj;
                InitializeComponent();
        }

        private void FrmUpdateEmployee_Load(object sender, EventArgs e)
        {
            if (employee.Equals("Manager"))
            {
                txtId.Text = manager.EmpID;
                txtFname.Text = manager.FirstName;
                txtLname.Text = manager.LastName;
                txtEmail.Text = manager.Email;
                MtxtPhone.Text = manager.ContactNumber;
                txtPassword.Text = manager.Password;
            }
            else if (employee.Equals("Reportee"))
            {
                txtId.Text = reportee.EmpID;
                txtFname.Text = reportee.FirstName;
                txtLname.Text = reportee.LastName;
                txtEmail.Text = reportee.Email;
                MtxtPhone.Text = reportee.ContactNumber;
                txtPassword.Text = reportee.Password;
            }
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
            List<Manager> managerList = ManagerDB.GetData();
            foreach(Manager mang in managerList)
            {
                if(mang.EmpID.Equals(manager.EmpID))
                {
                    mang.FirstName = txtFname.Text;
                    mang.LastName = txtLname.Text;
                    mang.Email = txtEmail.Text;
                    mang.ContactNumber = MtxtPhone.Text;
                    mang.Gender = Convert.ToChar(radio.Text);
                    mang.Password = txtPassword.Text;
                }
            }
            ManagerDB.SaveData(managerList);          
            MessageBox.Show("Manager with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateReportee(RadioButton radio)
        {
            List<Reportee> reporteeList = ReporteeDB.GetData();
            foreach (Reportee rep in reporteeList)
            {
                if (rep.EmpID.Equals(reportee.EmpID))
                {
                    rep.FirstName = txtFname.Text;
                    rep.LastName = txtLname.Text;
                    rep.Email = txtEmail.Text;
                    rep.ContactNumber = MtxtPhone.Text;
                    rep.Gender = Convert.ToChar(radio.Text);
                    rep.Password = txtPassword.Text;
                }
            }
            ReporteeDB.SaveData(reporteeList);
            MessageBox.Show("Reportee with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    RadioButton radioBtn = GetCheckedRadio(Gender);
                    if (radioBtn != null)
                    {
                        if (employee.Equals("Manager"))
                            UpdateManager(radioBtn);
                        else if (employee.Equals("Reportee"))
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
}
