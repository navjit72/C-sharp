using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Business
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }

        public Employee() { }
        public Employee(string fname, string lname, char gender, 
            string email, string phone, string pass)
        {
            FirstName = fname;
            LastName = lname;
            Gender = gender;
            Email = email;
            ContactNumber = phone;
            Password = pass;
        }
    }
}
