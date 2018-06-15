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
        Type t;
        List<Manager> managerList;
        List<Reportee> reporteeList;
        List<Project> projectList;

        public FrmInputId(Type x,Admin adminObj)
        {
            t = x;
            InitializeComponent();
        }

        private void Delete(Object obj)
        {
            if(obj.GetType()==typeof(Manager))
            {
                manager = (Manager)obj;
                if (manager.ProjectList.Count == 0)
                {
                    managerList = ManagerDB.GetData();
                    managerList.Remove(manager);
                    ManagerDB.SaveData(managerList);
                }
                else
                    throw new CustomMadeException("Failed to delete manager " + txtId.Text + " as it has projects.");
            }
            else if (obj.GetType()==typeof(Reportee))
            {
                reportee = (Reportee)obj;
                if (reportee.Project == null)
                {
                    reporteeList = ReporteeDB.GetData();
                    reporteeList.Remove(reportee);
                    ReporteeDB.SaveData(reporteeList);
                }
                else
                    throw new CustomMadeException("Failed to delete reportee " + txtId.Text + " as it has project assigned.");

            }
            else if (obj.GetType()==typeof(Project))
            {
                project = (Project)obj;
                manager = Validator.FindManagerByProject(project);
                reporteeList = Validator.FindReporteesByProject(project);
                projectList = ProjectDB.GetData();
                projectList.Remove(project);
                ProjectDB.SaveData(projectList);
                foreach(Project proj in manager.ProjectList)
                {
                    if (proj.ProjectID.Equals(project.ProjectID))
                    {
                        manager.ProjectList.Remove(proj);
                        break;
                    }
                }
                foreach(Reportee rep in reporteeList)
                {
                    rep.Project = null;
                }              
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
                Object obj = Validator.IsValidInputId(t, txtId.Text);
                if (obj != null)
                {
                        Delete(obj);
                        MessageBox.Show(t.Name + " is deleted successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                }
                else
                    throw new CustomMadeException("No " + t.Name + " with the id " + txtId.Text + " exists");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
