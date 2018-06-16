using ProjectManagementSystem.Business;
using ProjectManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem.Utilities
{
    public class Validator
    {
        public static bool IsDataPresent(TextBox txtbox)
        {
            if (txtbox.Text.Equals(""))
            {
                txtbox.Clear();
                txtbox.Focus();
                throw new CustomMadeException(txtbox.Tag + " is a required field.");
            }
            return true;
        }

        public static bool IsFormatValid(TextBox txtbox)
        {
            bool flag = false;
            for (int i = 0; i < txtbox.TextLength; i++)
            {
                if (!Char.IsDigit(txtbox.Text.ElementAt(i)) && !Char.IsLetter(txtbox.Text.ElementAt(i)))
                    flag = true;
            }
            if (flag)
            {
                txtbox.Clear();
                txtbox.Focus();
                throw new CustomMadeException(txtbox.Tag + " should be alphanumeric.");
            }
            return true;
        }

        public static bool IsValidData(TextBox textbox)
        {
            if (IsDataPresent(textbox))
                if (IsFormatValid(textbox))
                    return true;
            return false;
        }
        public static bool IsValidEmail(TextBox textbox)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(textbox.Text);
            if (match.Success)
                return true;
            else
            {
                textbox.Clear();
                textbox.Focus();
                throw new CustomMadeException(textbox.Tag + " is not in valid Format ex-someone@example.com");
            }
        }

        public static bool IsValidName(TextBox textbox)
        {
            bool flag = false;
            if (IsDataPresent(textbox))
            { 
                for (int i = 0; i < textbox.TextLength; i++)
                {
                    if (!Char.IsLetter(textbox.Text.ElementAt(i)))
                        flag = true;
                }
                if (flag)
                {
                    textbox.Clear();
                    textbox.Focus();
                    throw new CustomMadeException(textbox.Tag + " must contain only alphabets without space.");
                }
                return true;
            }
            return false;
        }

        public static object IsValidInputId(Type t,string Id)
        {
            if(t == typeof(Admin))
            {
                foreach (Admin admin in AdminDB.GetData())
                {
                    if (admin.EmpID.Equals(Id))
                        return admin;
                }
            }
            else if(t == typeof(Manager))
            {
                foreach(Manager manager in ManagerDB.GetData())
                {
                    if (manager.EmpID.Equals(Id))
                        return manager;
                }
            }
            else if (t == typeof(Reportee))
            {
                foreach (Reportee reportee in ReporteeDB.GetData())
                {
                    if (reportee.EmpID.Equals(Id))
                        return reportee;
                }
            }
            else
            {
                foreach (Project project in ProjectDB.GetData())
                {
                    if (project.ProjectID.Equals(Id))
                        return project;
                }
            }
            return null;
        }

        public static List<string> GetAllProjectIds()
        {
            List<string> projectList = new List<string>();
            foreach(Project project in ProjectDB.GetData())
            {
                projectList.Add(project.ProjectID);
            }
            return projectList;
        }

        public static List<string> GetAllProjectNames()
        {
            List<string> projectList = new List<string>();
            foreach (Project project in ProjectDB.GetData())
            {
                projectList.Add(project.ProjectName);
            }
            return projectList;
        }

        public static List<string> GetAllProjectManagerNames()
        {
            List<string> projectList = new List<string>();
            foreach (Project project in ProjectDB.GetData())
            {
                if(project.ProjectManager!=null)
                    projectList.Add(project.ProjectManager.FirstName);
            }
            return projectList;
        }

        public static List<string> GetAllManagerIds()
        {
            List<string> managerList = new List<string>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                managerList.Add(manager.EmpID);
            }
            return managerList;
        }

        public static List<string> GetAllManagerFirstNames()
        {
            List<string> managerList = new List<string>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                managerList.Add(manager.FirstName);
            }
            return managerList;
        }

        public static List<string> GetAllManagerLastNames()
        {
            List<string> managerList = new List<string>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                managerList.Add(manager.LastName);
            }
            return managerList;
        }

        public static List<string> GetAllManagerEmails()
        {
            List<string> managerList = new List<string>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                managerList.Add(manager.Email);
            }
            return managerList;
        }

        //public static List<string> GetAllManagerContacts()
        //{
        //    List<string> managerList = new List<string>();
        //    foreach (Manager manager in ManagerDB.GetData())
        //    {
        //        managerList.Add(manager.ContactNumber);
        //    }
        //    return managerList;
        //}

        public static List<string> GetAllReporteeIds()
        {
            List<string> reporteeList = new List<string>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                reporteeList.Add(rep.EmpID);
            }
            return reporteeList;
        }

        public static List<string> GetAllReporteeFirstNames()
        {
            List<string> reporteeList = new List<string>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                reporteeList.Add(rep.FirstName);
            }
            return reporteeList;
        }

        public static List<string> GetAllReporteeLastNames()
        {
            List<string> reporteeList = new List<string>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                reporteeList.Add(rep.LastName);
            }
            return reporteeList;
        }

        public static List<string> GetAllReporteeEmails()
        {
            List<string> reporteeList = new List<string>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                reporteeList.Add(rep.Email);
            }
            return reporteeList;
        }

        //public static Manager FindManagerByProject(Project project)
        //{
        //    foreach(Manager manager in ManagerDB.GetData())
        //    {
        //        if (manager.ProjectList.Contains(project))
        //            return manager;
        //    }
        //    return null;
        //}

        //public static List<Reportee> FindReporteesByProject(Project project)
        //{
        //    List<Reportee> reporteeList = new List<Reportee>();
        //    foreach(Reportee reportee in ReporteeDB.GetData())
        //    {
        //        if (reportee.Project == project)
        //            reporteeList.Add(reportee);
        //    }
        //    return reporteeList;
        //}
        public static List<Reportee> FindReporteesWithNoProject()
        {
            List<Reportee> reporteeList = new List<Reportee>();
            foreach(Reportee rep in ReporteeDB.GetData())
            {
                if (rep.Project == null)
                    reporteeList.Add(rep);
            }
            return reporteeList;
        }

        public static List<Project> SearchProjectByName(string name)
        {
            List<Project> projectList = new List<Project>();
            foreach(Project project in ProjectDB.GetData())
            {
                if (project.ProjectName.Equals(name))
                    projectList.Add(project);
            }
            return projectList;
        }

        public static List<Project> SearchProjectByManager(string managerId)
        {
            List<Project> projectList = new List<Project>();
            foreach (Project project in ProjectDB.GetData())
            {
                if(project.ProjectManager!=null)
                    if (project.ProjectManager.EmpID.Equals(managerId))
                        projectList.Add(project);
            }
            return projectList;
        }
        public static List<Project> SearchProjectByStatus(string status)
        {
            List<Project> projectList = new List<Project>();
            foreach (Project project in ProjectDB.GetData())
            {
                if (project.ProjectStatus.Equals(status))
                    projectList.Add(project);
            }
            return projectList;
        }

        public static List<Reportee> SearchReporteeByFirstName(string name)
        {
            List<Reportee> reporteeList = new List<Reportee>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                if (rep.FirstName.Equals(name))
                    reporteeList.Add(rep);
            }
            return reporteeList;
        }

        public static List<Reportee> SearchReporteeByLastName(string name)
        {
            List<Reportee> reporteeList = new List<Reportee>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                if (rep.LastName.Equals(name))
                    reporteeList.Add(rep);
            }
            return reporteeList;
        }
        public static List<Reportee> SearchReporteeByEmail(string email)
        {
            List<Reportee> reporteeList = new List<Reportee>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                if (rep.Email.Equals(email))
                    reporteeList.Add(rep);
            }
            return reporteeList;
        }
        //public static List<Reportee> SearchReporteeByContact(string phone)
        //{
        //    List<Reportee> reporteeList = new List<Reportee>();
        //    foreach (Reportee rep in ReporteeDB.GetData())
        //    {
        //        if (rep.ContactNumber.Equals(phone))
        //            reporteeList.Add(rep);
        //    }
        //    return reporteeList;
        //}
        public static List<Reportee> SearchReporteeByProject(string projectId)
        {
            List<Reportee> reporteeList = new List<Reportee>();
            foreach (Reportee rep in ReporteeDB.GetData())
            {
                if(rep.Project!=null)
                    if (rep.Project.ProjectID.Equals(projectId))
                        reporteeList.Add(rep);
            }
            return reporteeList;
        }

        public static List<Manager> SearchManagerByFirstName(string name)
        {
            List<Manager> managerList = new List<Manager>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                if (manager.FirstName.Equals(name))
                    managerList.Add(manager);
            }
            return managerList;
        }
        public static List<Manager> SearchManagerByLastName(string name)
        {
            List<Manager> managerList = new List<Manager>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                if (manager.LastName.Equals(name))
                    managerList.Add(manager);
            }
            return managerList;
        }
        public static List<Manager> SearchManagerByEmail(string email)
        {
            List<Manager> managerList = new List<Manager>();
            foreach (Manager manager in ManagerDB.GetData())
            {
                if (manager.Email.Equals(email))
                    managerList.Add(manager);
            }
            return managerList;
        }
        //public static List<Manager> SearchManagerByContact(string phone)
        //{
        //    List<Manager> managerList = new List<Manager>();
        //    foreach (Manager manager in ManagerDB.GetData())
        //    {
        //        if (manager.ContactNumber.Equals(phone))
        //            managerList.Add(manager);
        //    }
        //    return managerList;
        //}
        public static Manager SearchManagerByProject(string projectId)
        {
            foreach (Manager man in ManagerDB.GetData())
            {
                List<Project> projList = man.ProjectList;
                if (projList.Count != 0)
                {
                    foreach (Project proj in projList)
                    {
                        if (proj.ProjectID.Equals(projectId))
                        {
                            return man;
                        }
                    }
                }                  
            }
            return null;
        }
    }
}
