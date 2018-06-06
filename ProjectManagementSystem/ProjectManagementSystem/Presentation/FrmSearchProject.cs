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
    public partial class FrmSearchProject : Form
    {
        Project project;
        public FrmSearchProject(Project proj)
        {
            InitializeComponent();
            project = proj;
        }

        private void FrmSearchProject_Load(object sender, EventArgs e)
        {
            txtId.Text = project.ProjectID;
            txtProjectname.Text = project.ProjectName;
            txtStatus.Text = project.ProjectStatus;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
