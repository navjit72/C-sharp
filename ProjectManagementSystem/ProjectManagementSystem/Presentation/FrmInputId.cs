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

        public FrmInputId(string text,string op)
        {
            parameter = text;
            operation = op;
            InitializeComponent();
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
                        if (parameter.Equals("Manager") || parameter.Equals("Reportee"))
                        {
                            this.Close();
                            FrmUpdateEmployee updateEmp = new FrmUpdateEmployee(parameter, obj);
                            updateEmp.ShowDialog();
                        }
                        else
                        {
                            project = (Project)obj;
                            this.Close();
                            FrmUpdateProject updateProject = new FrmUpdateProject(project);
                            updateProject.ShowDialog();
                        }
                    }
                    else if(operation.Equals("delete"))
                    {
                        Delete(obj);
                        MessageBox.Show(parameter + " is deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else if(operation.Equals("search"))
                    {
                        if(parameter.Equals("Manager") || parameter.Equals("Reportee"))
                        {
                            this.Close();
                            FrmSearchEmployee searchEmp = new FrmSearchEmployee(parameter, obj);
                            searchEmp.ShowDialog();
                        }
                        else
                        {
                            project = (Project)obj;
                            this.Close();
                            FrmSearchProject searchProject = new FrmSearchProject(project);
                            searchProject.ShowDialog();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
