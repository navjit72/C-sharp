using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Reportee : Employee
    {
        public string EmpID { get; }
        public Project Project { get; set; }
        private static int idCount = 100;

        public Reportee()
        {
            idCount += 1;
            EmpID = "R" + idCount;
        }
    }
}
