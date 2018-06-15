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
        Manager manager;
        string operation;

        public FrmProject(string op)
        {
            operation = op;
            InitializeComponent();
        }

        private Manager FindManager()
        {
            Manager man = (Manager)Validator.IsValidInputId(typeof(Manager), txtProjectManager.Text);
            if (man != null)
                return man;
            return null;
        }

        private bool IsAnyChangeMade()
        {
            if (txtProjectname.Text.Equals(project.ProjectName))
                if (ProjectStatus.Text.Equals(project.ProjectStatus))
                    if (txtProjectManager.Text != "")
                    {
                        manager = FindManager();
                        if (manager != null)
                        {
                            if (project.ProjectManager != null)
                            {
                                if (txtProjectManager.Text.Equals(project.ProjectManager.EmpID))
                                    return false;
                            }
                            else
                                return true;
                        }
                        else
                            throw new CustomMadeException("No manager with Id " + txtProjectManager.Text + " found");
                    }
            return true;
        }

        private void UpdateProject()
        {
            if (IsAnyChangeMade() && txtProjectManager.Text!="")
            {
                project.ProjectName = txtProjectname.Text;
                project.ProjectManager = manager;
                if (ProjectStatus.Text != "")
                    project.ProjectStatus = ProjectStatus.Text;
                else
                {
                    ProjectStatus.SelectedIndex = 0;
                    project.ProjectStatus = ProjectStatus.Text;
                }
                MessageBox.Show("Project with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Changes made in the project inofrmation.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            try
            {
                project = (Project)Validator.IsValidInputId(typeof(Project), toolStripTxtId.Text);
                if (project != null)
                {
                    txtId.Text = project.ProjectID;
                    txtProjectname.Text = project.ProjectName;
                    if (project.ProjectStatus.Equals("Ongoing"))
                        ProjectStatus.SelectedIndex = 0;
                    else if (project.ProjectStatus.Equals("Finished"))
                        ProjectStatus.SelectedIndex = 1;
                    if (project.ProjectManager != null)
                        txtProjectManager.Text = project.ProjectManager.EmpID;
                }
                else
                    throw new CustomMadeException("No project with id " + toolStripTxtId.Text + " found.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operation.Equals("Search"))
            {
                txtProjectname.ReadOnly = true;
                txtProjectManager.ReadOnly = true;
                ProjectStatus.Enabled = false;
            }     
        }

    }
}
