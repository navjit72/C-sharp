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
    public partial class FrmUpdateProject : Form
    {
        Project project;
        public FrmUpdateProject(Project proj)
        {
            InitializeComponent();
            project = proj;
        }

        private void FrmUpdateProject_Load(object sender, EventArgs e)
        {
            txtId.Text = project.ProjectID;
            txtProjectname.Text = project.ProjectName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProject()
        {
            List<Project> projectList = ProjectDB.GetData();
            foreach(Project project in projectList)
            {
                if(project.ProjectID.Equals(txtId.Text))
                {
                    project.ProjectName = txtProjectname.Text;
                    if (ProjectStatus.Text != "")
                        project.ProjectStatus = ProjectStatus.Text;
                    else
                    {
                        ProjectStatus.SelectedIndex = 0;
                        project.ProjectStatus = ProjectStatus.Text;
                    }
                }
            }
            ProjectDB.SaveData(projectList);
            MessageBox.Show("Project with Id " + txtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
}
