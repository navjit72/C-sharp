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
    public partial class FrmSearchEmployee : Form
    {
        Manager manager;
        Reportee reportee;
        string employee;
        public FrmSearchEmployee(string text,Object obj)
        {
            employee = text;
            if (employee.Equals("Manager"))
                manager = (Manager)obj;
            else if (employee.Equals("Reportee"))
                reportee = (Reportee)obj;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchEmployee_Load(object sender, EventArgs e)
        {
            if (employee.Equals("Manager"))
            {
                txtId.Text = manager.EmpID;
                txtFname.Text = manager.FirstName;
                txtLname.Text = manager.LastName;
                txtEmail.Text = manager.Email;
                MtxtPhone.Text = manager.ContactNumber;
                txtPassword.Text = manager.Password;
                txtGender.Text = Convert.ToString(manager.Gender);
            }
            else if (employee.Equals("Reportee"))
            {
                txtId.Text = reportee.EmpID;
                txtFname.Text = reportee.FirstName;
                txtLname.Text = reportee.LastName;
                txtEmail.Text = reportee.Email;
                MtxtPhone.Text = reportee.ContactNumber;
                txtPassword.Text = reportee.Password;
                txtGender.Text = Convert.ToString(reportee.Gender);
            }
        }
    }
}
