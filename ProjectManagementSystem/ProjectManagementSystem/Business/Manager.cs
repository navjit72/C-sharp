using ProjectManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Manager : Employee
    {
        public string EmpID { get; }
        public List<Project> ProjectList { get; set; }
        private static int idCount=100;

        public Manager()
        {
            idCount += 1;
            EmpID = "M" + idCount;
        }
    }
}
