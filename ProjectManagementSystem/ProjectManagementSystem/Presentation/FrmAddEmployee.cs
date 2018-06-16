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
    public partial class FrmAddEmployee : Form
    {
        Manager manager;
        Reportee reportee;
        string employee;
        public FrmAddEmployee(string emp)
        {
            employee = emp;
            InitializeComponent();
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            if (employee.Equals("Manager"))
            {
                manager = new Manager();
                txtId.Text = manager.EmpID;
            }
            else if(employee.Equals("Reportee"))
            {
                reportee = new Reportee();
                txtId.Text = reportee.EmpID;
            }
        }

        private bool IsValidData()
        {
            return Validator.IsValidName(txtFname) && Validator.IsValidName(txtLname) && 
                Validator.IsValidEmail(txtEmail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddManager(RadioButton radio)
        {
            List<Manager> managerList = ManagerDB.GetData();
            manager.FirstName = txtFname.Text;
            manager.LastName = txtLname.Text;
            manager.Email = txtEmail.Text;
            manager.ContactNumber = MtxtPhone.Text;
            manager.Gender = Convert.ToChar(radio.Text);
            manager.Password = txtPassword.Text;
            managerList.Add(manager);
            ManagerDB.SaveData(managerList);
            MessageBox.Show("Manager with Id " + txtId.Text + " Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddReportee(RadioButton radio)
        {
            List<Reportee> reporteeList = ReporteeDB.GetData();
            reportee.FirstName = txtFname.Text;
            reportee.LastName = txtLname.Text;
            reportee.Email = txtEmail.Text;
            reportee.ContactNumber = MtxtPhone.Text;
            reportee.Gender = Convert.ToChar(radio.Text);
            reportee.Password = txtPassword.Text;
            reporteeList.Add(reportee);
            ReporteeDB.SaveData(reporteeList);
            MessageBox.Show("Reportee with Id " + txtId.Text + " Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    RadioButton radioBtn = GetCheckedRadio(Gender);
                    if (radioBtn != null)
                    {
                        if (employee.Equals("Manager"))
                            AddManager(radioBtn);
                        else if (employee.Equals("Reportee"))
                            AddReportee(radioBtn);
                        this.Close();
                    }
                    else
                        throw new CustomMadeException("Please select a gender.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
