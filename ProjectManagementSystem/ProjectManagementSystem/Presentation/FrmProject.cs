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
    public partial class FrmProject : Form
    {
        Project project;
        string operation;

        public FrmProject(string op)
        {
            operation = op;
            InitializeComponent();
        }

        private Manager FindManager()
        {
            Manager manager = (Manager)Validator.IsValidInputId(typeof(Manager), txtProjectManager.Text);
            if (manager != null)
                return manager;
            else
                throw new CustomMadeException("No manager with Id " + txtProjectManager.Text + " found");
        }

        private void UpdateProject()
        {
            project.ProjectName = txtProjectname.Text;
            if (txtProjectManager.Text != "")
                project.ProjectManager = FindManager();
            else
                project.ProjectManager = null;
            if (ProjectStatus.Text != "")
               project.ProjectStatus = ProjectStatus.Text;
            else
            {
                ProjectStatus.SelectedIndex = 0;
                project.ProjectStatus = ProjectStatus.Text;
            }
            MessageBox.Show("Project with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (operation.Equals("Search"))
                this.Close();
            else
            {
                try
                {
                    if (Validator.IsValidData(txtProjectname))
                    {
                        UpdateProject();
                        this.Close();
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
            project = (Project)Validator.IsValidInputId(typeof(Project), toolStripTxtId.Text);
            txtId.Text = project.ProjectID;
            txtProjectname.Text = project.ProjectName;
            if (project.ProjectStatus.Equals("Ongoing"))
                ProjectStatus.SelectedIndex = 0;
            else if (project.ProjectStatus.Equals("Finished"))
                ProjectStatus.SelectedIndex = 1;
            if(project.ProjectManager!=null)
                txtProjectManager.Text = project.ProjectManager.EmpID;
            if(operation.Equals("Search"))
            {
                txtProjectname.ReadOnly = true;
                txtProjectManager.ReadOnly = true;
                ProjectStatus.Enabled = false;
            }
        }

    }
}
