﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Project
    {
        public string ProjectID { get; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public int Progress { get; set; }
        public Manager ProjectManager { get; set; }
        public List<Reportee> ReporteeList { get; set; }
        private static int idCount = 100;

        public Project()
        {
            idCount += 1;
            ProjectID = ""+idCount;
            Progress = 0;
        }
    }
}
