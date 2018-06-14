using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public class Admin : Employee
    {
        public string EmpID { get; }
        private static int idCount = 100;

        public Admin(string fname,string lname,char gender,string email,
            string phone,string pass) :base(fname,lname,gender,email,phone,pass)
        {
            idCount += 1;
            EmpID = "A" + idCount;
        }
    }
}
