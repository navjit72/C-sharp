using ProjectManagementSystem.Business;
using ProjectManagementSystem.Data;
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
    public partial class FrmAddReporteeToProject : Form
    {
        List<Reportee> reporteeList;

        public FrmAddReporteeToProject()
        {
            reporteeList = ReporteeDB.GetData();
            InitializeComponent();
        }

        private void FrmAddReporteeToProject_Load(object sender, EventArgs e)
        {
            foreach(Reportee reportee in reporteeList)
            {
                if (reportee.Project == null)
                    reporteeComboBox.Items.Add(reportee.EmpID);
            }
        }
    }
}
