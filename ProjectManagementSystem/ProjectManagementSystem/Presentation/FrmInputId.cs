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
    public partial class FrmInputId : Form
    {
        Manager manager;
        Reportee reportee;
        Project project;
        string parameter;
        string operation;
        FrmAdminDashboard admin;

        public FrmInputId(string text,string op,Admin adminObj)
        {
            parameter = text;
            operation = op;
            admin = new FrmAdminDashboard(adminObj);
            InitializeComponent();
            lblParameter.Text = parameter;
        }

        private void Delete(Object obj)
        {
            if(parameter.Equals("Manager"))
            {
                manager = (Manager)obj;
                List<Manager> managerList = ManagerDB.GetData();
                managerList.Remove(manager);
                ManagerDB.SaveData(managerList);
            }
            else if (parameter.Equals("Reportee"))
            {
                reportee = (Reportee)obj;
                List<Reportee> reporteeList = ReporteeDB.GetData();
                reporteeList.Remove(reportee);
                ReporteeDB.SaveData(reporteeList);
                
            }
            else if (parameter.Equals("Project"))
            {
                project = (Project)obj;
                List<Project> projectList = ProjectDB.GetData();
                projectList.Remove(project);
                ProjectDB.SaveData(projectList);
            }
        }

        private void Update(Object obj)
        {
            if (parameter.Equals("Manager") || parameter.Equals("Reportee"))
            {
                this.Close();
                FrmUpdateEmployee updateEmp = new FrmUpdateEmployee(parameter, obj);
                updateEmp.MdiParent = admin;
                updateEmp.Show();
            }
            else
            {
                project = (Project)obj;
                this.Close();
                FrmUpdateProject updateProject = new FrmUpdateProject(project);
                updateProject.MdiParent = admin;
                updateProject.Show();
            }
        }

        private void Search(Object obj)
        {
            if (parameter.Equals("Manager") || parameter.Equals("Reportee"))
            {

                this.Close();
                FrmSearchEmployee searchEmp = new FrmSearchEmployee(parameter, obj);
                searchEmp.MdiParent = admin;
                searchEmp.Show();
            }

            else
            {
                project = (Project)obj;
                this.Close();
                FrmSearchProject searchProject = new FrmSearchProject(project);
                searchProject.ShowDialog();
                searchProject.MdiParent = admin;
                searchProject.Show();
            }
    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Object obj = Validator.IsValidInputId(parameter, txtId.Text);
                if (obj != null)
                {
                    if (operation.Equals("update"))
                    {
                        Update(obj);
                    }
                    else if (operation.Equals("delete"))
                    {
                        Delete(obj);
                        MessageBox.Show(parameter + " is deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if (operation.Equals("search"))
                    {
                        Search(obj);
                    }
                }
                else
                    throw new CustomMadeException("No " + parameter + " with the id " + txtId.Text + " exists");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
