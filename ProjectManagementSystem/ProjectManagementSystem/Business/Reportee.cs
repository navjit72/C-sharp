using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Reportee
    {
        public string EmpID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public long ContactNumber { get; set; }
        public string Password { get; set; }
        public List<Project> ProjectList { get; set; }
        private static int idCount = 100;

        public Reportee()
        {
            idCount += 1;
            EmpID = "R" + idCount;
        }
    }
}
