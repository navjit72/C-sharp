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
        FrmAdminDashboard admin;

        public FrmInputId(Type x,Admin adminObj)
        {
            admin = new FrmAdminDashboard(adminObj);
            t = x;
            InitializeComponent();
        }

        private void Delete(Object obj)
        {
            if(obj.GetType()==typeof(Manager))
            {
                manager = (Manager)obj;
                List<Manager> managerList = ManagerDB.GetData();
                managerList.Remove(manager);
                ManagerDB.SaveData(managerList);
            }
            else if (obj.GetType()==typeof(Reportee))
            {
                reportee = (Reportee)obj;
                List<Reportee> reporteeList = ReporteeDB.GetData();
                reporteeList.Remove(reportee);
                ReporteeDB.SaveData(reporteeList);
                
            }
            else if (obj.GetType()==typeof(Project))
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
