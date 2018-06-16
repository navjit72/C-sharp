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
    public partial class FormReportee : Form
    {
        Reportee reportee;
        Reportee reportee2;
        List<string> resultList;
        List<Reportee> reporteeList = new List<Reportee>();
        public FormReportee()
        {
            InitializeComponent();
        }

        private void cmbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue.Items.Clear();
            cmbCriteriaValue.Text = "";
            if (cmbCriteria.Text.Equals("Reportee Id"))
            {
                resultList = Validator.GetAllReporteeIds();
            }
            else if (cmbCriteria.Text.Equals("Reportee First Name"))
            {
                resultList = Validator.GetAllReporteeFirstNames();
            }
            else if (cmbCriteria.Text.Equals("Reportee Last Name"))
            {
                resultList = Validator.GetAllReporteeLastNames();
            }
            else if (cmbCriteria.Text.Equals("Reportee Email"))
            {
                resultList = Validator.GetAllReporteeEmails();
            }
            if (resultList.Count != 0)
                foreach (string text in resultList)
                {
                    cmbCriteriaValue.Items.Add(text);
                }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cmbCriteriaValue.Text.Equals(""))
            {
                if (cmbCriteria.Text.Equals("Reportee Id"))
                {
                    List<Reportee> tempList = new List<Reportee>();
                    reportee = (Reportee)Validator.IsValidInputId(typeof(Reportee), cmbCriteriaValue.Text);
                    if (reportee != null)
                    {
                        tempList.Add(reportee);
                        reporteeList = tempList;
                    }
                }
                else if (cmbCriteria.Text.Equals("Reportee First Name"))
                {
                    reporteeList = Validator.SearchReporteeByFirstName(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Reportee Last Name"))
                {
                    reporteeList = Validator.SearchReporteeByLastName(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Reportee Email"))
                {
                    reporteeList = Validator.SearchReporteeByEmail(cmbCriteriaValue.Text);
                }
                if (reporteeList.Count != 0)
                    dGVReportee.DataSource = reporteeList;
            }
            else
                MessageBox.Show("No records found.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbCriteria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue2.Items.Clear();
            cmbCriteriaValue2.Text = "";
            if (cmbCriteria2.Text.Equals("Reportee Id"))
            {
                resultList = Validator.GetAllReporteeIds();
            }
            else if (cmbCriteria2.Text.Equals("Reportee First Name"))
            {
                resultList = Validator.GetAllReporteeFirstNames();
            }
            else if (cmbCriteria2.Text.Equals("Reportee Last Name"))
            {
                resultList = Validator.GetAllReporteeLastNames();
            }
            else if (cmbCriteria2.Text.Equals("Reportee Email"))
            {
                resultList = Validator.GetAllReporteeEmails();
            }
            if (resultList.Count != 0)
                foreach (string text in resultList)
                {
                    cmbCriteriaValue2.Items.Add(text);
                }
        }

        private void RefreshData()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            MtxtPhone.Text = "";
            RadioFemale.Checked = false;
            RadioMale.Checked = false;
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            RefreshData();
            if (cmbCriteriaValue2.Text.Equals(""))
                MessageBox.Show("Please select a Value for " + cmbCriteria2.Text, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cmbTxtId.Items.Clear();
            cmbTxtId.Text = "";
            List<Reportee> reporteeList2 = new List<Reportee>();
            if (cmbCriteria2.Text.Equals("Reportee Id"))
            {
                reportee2 = (Reportee)Validator.IsValidInputId(typeof(Reportee), cmbCriteriaValue2.Text);
                if (reportee2 != null)
                {
                    cmbTxtId.Items.Add(reportee2.EmpID);
                    cmbTxtId.SelectedIndex = 0;
                }
            }
            else
            {
                if (cmbCriteria2.Text.Equals("Reportee First Name"))
                {
                    reporteeList2 = Validator.SearchReporteeByFirstName(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Reportee Last Name"))
                {
                    reporteeList2 = Validator.SearchReporteeByLastName(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Reportee Email"))
                {
                    reporteeList2 = Validator.SearchReporteeByEmail(cmbCriteriaValue2.Text);
                }
                if (reporteeList2.Count == 0)
                    MessageBox.Show("Nothing to display.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Reportee rep in reporteeList2)
                    cmbTxtId.Items.Add(rep.EmpID);
            }          
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

        private bool IsValidData()
        {
            return Validator.IsValidEmail(txtEmail) || Validator.IsValidName(txtFname)
                || Validator.IsValidName(txtLname);
        }

        private bool IsAnyChangeMade(Employee emp)
        {
            if (txtFname.Text.Equals(emp.FirstName))
                if (txtLname.Text.Equals(emp.LastName))
                    if (txtEmail.Text.Equals(emp.Email))
                        if (txtPassword.Text.Equals(emp.Password))
                            if (Convert.ToChar(GetCheckedRadio(Gender).Text).Equals(emp.Gender))
                                return false;
            return true;
        }
        private void UpdateReportee(RadioButton radio)
        {
            reportee2 = (Reportee)Validator.IsValidInputId(typeof(Reportee), cmbTxtId.Text);
            if (IsAnyChangeMade(reportee2))
            {
                reportee2.FirstName = txtFname.Text;
                reportee2.LastName = txtLname.Text;
                reportee2.Email = txtEmail.Text;
                reportee2.ContactNumber = MtxtPhone.Text;
                reportee2.Gender = Convert.ToChar(radio.Text);
                reportee2.Password = txtPassword.Text;
                MessageBox.Show("Reportee with Id " + cmbTxtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Changes made in the reportee inofrmation.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    RadioButton radioBtn = GetCheckedRadio(Gender);
                    if (radioBtn != null)
                    {
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

        private void cmbTxtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportee2 = (Reportee)Validator.IsValidInputId(typeof(Reportee), cmbTxtId.Text);
            txtFname.Text = reportee2.FirstName;
            txtLname.Text = reportee2.LastName;
            txtEmail.Text = reportee2.Email;
            MtxtPhone.Text = reportee2.ContactNumber;
            txtPassword.Text = reportee2.Password;
            if (reportee2.Gender == 'F')
                RadioFemale.Checked = true;
            else if (reportee2.Gender == 'M')
                RadioMale.Checked = true;
        } 
    }
}
