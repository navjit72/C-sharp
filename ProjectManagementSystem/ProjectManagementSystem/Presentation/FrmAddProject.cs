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
    public partial class FrmAddProject : Form
    {
        Project project;
        public FrmAddProject()
        {
            project = new Project();
            InitializeComponent();
        }

        private void FrmAddProject_Load(object sender, EventArgs e)
        {
            txtId.Text = project.ProjectID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Manager FindManager()
        {
            Manager manager =(Manager)Validator.IsValidInputId(typeof(Manager), txtProjectManager.Text);
            if (manager != null)
                return manager;
            else
                throw new CustomMadeException("No manager with Id " + txtProjectManager.Text + " found");
        }

        private void AddProject()
        {
            List<Project> projectList = ProjectDB.GetData();
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
            projectList.Add(project);
            ProjectDB.SaveData(projectList);
            MessageBox.Show("Project with Id " + txtId.Text + " Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            { 
                if(Validator.IsValidData(txtProjectname))
                {
                    AddProject();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
    }
}
