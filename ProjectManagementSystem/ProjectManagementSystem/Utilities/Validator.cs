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
            if (txtbox.Text == "")
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
        //public static bool IsValidId(TextBox textbox)
        //{
        //    if (textbox.Text.First() == 'M' || textbox.Text.First() == 'R' || textbox.Text.First() == 'A')
        //        return true;
        //    return false;
        //}
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
        //public static string GetDesignation(string Id)
        //{
        //    char c = Id.First();
        //    if (c == 'M')
        //        return "Manager";
        //    else if (c == 'R')
        //        return "Reportee";
        //    else if (c == 'A')
        //        return "Admin";
        //    else
        //        throw new CustomMadeException(Id + " is an invalid Id");
        //}
        public static object IsValidInputId(string text,string Id)
        {
            if(text.Equals("Admin"))
            {
                foreach (Admin admin in AdminDB.GetData())
                {
                    if (admin.EmpID.Equals(Id))
                        return admin;
                }
            }
            else if(text.Equals("Manager"))
            {
                foreach(Manager manager in ManagerDB.GetData())
                {
                    if (manager.EmpID.Equals(Id))
                        return manager;
                }
            }
            else if (text.Equals("Reportee"))
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
    }
}
