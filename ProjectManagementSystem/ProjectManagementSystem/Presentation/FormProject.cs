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
    public partial class FormProject : Form
    {
        List<string> resultList;
        List<Project> projectList = new List<Project>();
        
        List<string> projectStatus = new List<string>();
        Project project;
        Project project2;
        Manager manager;

        public FormProject()
        {
            projectStatus.Add("Ongoing");
            projectStatus.Add("Finished");
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!cmbCriteriaValue.Text.Equals(""))
            {
                if (cmbCriteria.Text.Equals("Project Id"))
                {
                    List<Project> tempList = new List<Project>();
                    project = (Project)Validator.IsValidInputId(typeof(Project), cmbCriteriaValue.Text);
                    if (project != null)
                    {
                        tempList.Add(project);
                        projectList = tempList;
                    }
                }
                else if (cmbCriteria.Text.Equals("Project Name"))
                {
                    projectList = Validator.SearchProjectByName(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Project Status"))
                {
                    projectList = Validator.SearchProjectByStatus(cmbCriteriaValue.Text);
                }
                else if (cmbCriteria.Text.Equals("Project Manager"))
                {
                    projectList = Validator.SearchProjectByManager(cmbCriteriaValue.Text);
                }
                if (projectList.Count != 0)
                    dGVProject.DataSource = projectList;
            }
            else
                MessageBox.Show("No records found.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue.Items.Clear();
            cmbCriteriaValue.Text = "";
            if(cmbCriteria.Text.Equals("Project Id"))
            {
                resultList = Validator.GetAllProjectIds();
            }
            else if(cmbCriteria.Text.Equals("Project Name"))
            {
                resultList = Validator.GetAllProjectNames();
            }
            else if(cmbCriteria.Text.Equals("Project Status"))
            {
                resultList = projectStatus;
            }
            else if(cmbCriteria.Text.Equals("Project Manager"))
            {
                resultList = Validator.GetAllManagerIds();
            }
            if(resultList.Count!=0)
                foreach(string text in resultList)
                {
                    cmbCriteriaValue.Items.Add(text);
                }
        }

        private Manager FindManager()
        {
            Manager man = (Manager)Validator.IsValidInputId(typeof(Manager), txtProjectManager.Text);
            if (man != null)
                return man;
            return null;
        }

        private void RefreshData()
        {
            txtProjectname.Text = "";
            txtProjectManager.Text = "";
            cmbStatus.Text = "";
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            RefreshData();
            if (cmbCriteriaValue2.Text.Equals(""))
                MessageBox.Show("Please select a Value for " + cmbCriteria2.Text, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cmbTxtId.Items.Clear();
            cmbTxtId.Text = "";
            List<Project> projectList2 = new List<Project>();
            if (cmbCriteria2.Text.Equals("Project Id"))
            {
                project2 = (Project)Validator.IsValidInputId(typeof(Project), cmbCriteriaValue2.Text);
                if (project2 != null)
                {
                    cmbTxtId.Items.Add(project2.ProjectID);
                    cmbTxtId.SelectedIndex = 0;
                }
            }
            else
            { 
                if (cmbCriteria2.Text.Equals("Project Name"))
                {
                    projectList2 = Validator.SearchProjectByName(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Project Status"))
                {
                    projectList2 = Validator.SearchProjectByStatus(cmbCriteriaValue2.Text);
                }
                else if (cmbCriteria2.Text.Equals("Project Manager"))
                {
                    projectList2 = Validator.SearchProjectByManager(cmbCriteriaValue2.Text);
                }
                if (projectList2.Count == 0)
                    MessageBox.Show("Nothing to display.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (Project proj in projectList2)
                cmbTxtId.Items.Add(proj.ProjectID);
        }

        private bool IsAnyChangeMade()
        {
            if (txtProjectname.Text.Equals(project2.ProjectName))
                if (cmbStatus.Text.Equals(project2.ProjectStatus))
                    if (txtProjectManager.Text != "")
                    {
                        manager = FindManager();
                        if (manager != null)
                        {
                            if (project2.ProjectManager != null)
                            {
                                if (txtProjectManager.Text.Equals(project2.ProjectManager.EmpID))
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
            if (IsAnyChangeMade() && txtProjectManager.Text != "")
            {
                project2.ProjectName = txtProjectname.Text;
                project2.ProjectManager = manager;
                if (cmbStatus.Text != "")
                    project2.ProjectStatus = cmbStatus.Text;
                else
                {
                    cmbStatus.SelectedIndex = 0;
                    project2.ProjectStatus = cmbStatus.Text;
                }
                MessageBox.Show("Project with Id " + cmbTxtId.Text + " Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Changes made in the project inofrmation.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnOk_Click(object sender, EventArgs e)
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

        private void cmbCriteria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCriteriaValue2.Items.Clear();
            cmbCriteriaValue2.Text = "";
            if (cmbCriteria2.Text.Equals("Project Id"))
            {
                resultList = Validator.GetAllProjectIds();
            }
            else if (cmbCriteria2.Text.Equals("Project Name"))
            {
                resultList = Validator.GetAllProjectNames();
            }
            else if (cmbCriteria2.Text.Equals("Project Status"))
            {
                resultList = projectStatus;
            }
            else if (cmbCriteria2.Text.Equals("Project Manager"))
            {
                resultList = Validator.GetAllManagerIds();
            }
            if (resultList.Count != 0)
                foreach (string text in resultList)
                {
                    cmbCriteriaValue2.Items.Add(text);
                }
        }

        private void cmbTxtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            project2 = (Project)Validator.IsValidInputId(typeof(Project), cmbTxtId.Text);
            txtProjectname.Text = project2.ProjectName;
            if (project2.ProjectStatus.Equals("Ongoing"))
                cmbStatus.SelectedIndex = 0;
            else if (project2.ProjectStatus.Equals("Finished"))
                cmbStatus.SelectedIndex = 1;
            if (project2.ProjectManager != null)
                txtProjectManager.Text = project2.ProjectManager.EmpID;
        }
    }
}
