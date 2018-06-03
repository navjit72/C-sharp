using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Project
    {
        public int ProjectID { get; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public int Progress { get; set; }
        private static int idCount = 100;

        public Project()
        {
            idCount += 1;
            ProjectID = idCount;
            Progress = 0;
        }
    }
}
