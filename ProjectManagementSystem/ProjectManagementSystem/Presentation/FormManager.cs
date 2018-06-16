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
    public partial class FormManager : Form
    {
        Manager manager;
        Manager manager2;
        List<string> resultList;
        List<Manager> managerList = new List<Manager>();
        public FormManager()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cmbCriteriaValue.Text.Equals(""))
            {
                if (cmbCriteria.Text.Equals("Manager Id"))
                {
                    List<Manager> tempList = new List<Manager>();
                    manager = (Manager)Validator.IsValidInputId(typeof(Manager), cmbCriteriaValue.Text);
                    if (manager != null)
                    {
                        tempList.Add(manager);
                        managerList = tempList;
                    }
                }
                else if (cmbCriteria.Text.Equals("Manager First Name"))
                {
                    managerList = Validator.SearchManagerByFirstName(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Manager Last Name"))
                {
                    managerList = Validator.SearchManagerByLastName(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Manager Email"))
                {
                    managerList = Validator.SearchManagerByEmail(cmbCriteriaValue.Text);
                }
                if (managerList.Count != 0)
                    dGVManager.DataSource = managerList;
            }
            else
                MessageBox.Show("No records found.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue.Items.Clear();
            cmbCriteriaValue.Text = "";
            if (cmbCriteria.Text.Equals("Manager Id"))
            {
                resultList = Validator.GetAllManagerIds();
            }
            else if (cmbCriteria.Text.Equals("Manager First Name"))
            {
                resultList = Validator.GetAllManagerFirstNames();
            }
            else if (cmbCriteria.Text.Equals("Manager Last Name"))
            {
                resultList = Validator.GetAllManagerLastNames();
            }
            else if (cmbCriteria.Text.Equals("Manager Email"))
            {
                resultList = Validator.GetAllManagerEmails();
            }
            if (resultList.Count != 0)
                foreach (string text in resultList)
                {
                    cmbCriteriaValue.Items.Add(text);
                }
        }

        private void cmbCriteria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue2.Items.Clear();
            cmbCriteriaValue2.Text = "";
            if (cmbCriteria2.Text.Equals("Manager Id"))
            {
                resultList = Validator.GetAllManagerIds();
            }
            else if (cmbCriteria2.Text.Equals("Manager First Name"))
            {
                resultList = Validator.GetAllManagerFirstNames();
            }
            else if (cmbCriteria2.Text.Equals("Manager Last Name"))
            {
                resultList = Validator.GetAllManagerLastNames();
            }
            else if (cmbCriteria2.Text.Equals("Manager Email"))
            {
                resultList = Validator.GetAllManagerEmails();
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
            if(cmbCriteriaValue2.Text.Equals(""))
                MessageBox.Show("Please select a Value for " + cmbCriteria2.Text, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cmbTxtId.Items.Clear();
            cmbTxtId.Text = "";
            List<Manager> managerList2 = new List<Manager>();
            if (cmbCriteria2.Text.Equals("Manager Id"))
            {
                manager2 = (Manager)Validator.IsValidInputId(typeof(Manager), cmbCriteriaValue2.Text);
                if (manager2 != null)
                {
                    cmbTxtId.Items.Add(manager2.EmpID);
                    cmbTxtId.SelectedIndex = 0;
                }
            }
            else
            {
                if (cmbCriteria2.Text.Equals("Manager First Name"))
                {
                    managerList2 = Validator.SearchManagerByFirstName(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Manager Last Name"))
                {
                    managerList2 = Validator.SearchManagerByLastName(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Manager Email"))
                {
                    managerList2 = Validator.SearchManagerByEmail(cmbCriteriaValue2.Text);
                }
                if (managerList2.Count == 0)
                    MessageBox.Show("Nothing to display.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Manager man in managerList2)
                    cmbTxtId.Items.Add(man.EmpID);
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

        private void UpdateManager(RadioButton radio)
        {
            manager2 = (Manager)Validator.IsValidInputId(typeof(Manager), cmbTxtId.Text);
            if (IsAnyChangeMade(manager2))
            {
                manager2.FirstName = txtFname.Text;
                manager2.LastName = txtLname.Text;
                manager2.Email = txtEmail.Text;
                manager2.ContactNumber = MtxtPhone.Text;
                manager2.Gender = Convert.ToChar(radio.Text);
                manager2.Password = txtPassword.Text;
                MessageBox.Show("Manager with Id " + cmbTxtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Changes made in the manager inofrmation.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        UpdateManager(radioBtn);
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
            manager2 = (Manager)Validator.IsValidInputId(typeof(Manager), cmbTxtId.Text);
            txtFname.Text = manager2.FirstName;
            txtLname.Text = manager2.LastName;
            txtEmail.Text = manager2.Email;
            MtxtPhone.Text = manager2.ContactNumber;
            txtPassword.Text = manager2.Password;
            if (manager2.Gender == 'F')
                RadioFemale.Checked = true;
            else if (manager2.Gender == 'M')
                RadioMale.Checked = true;
        }
    }
}
