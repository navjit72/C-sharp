using ProjectManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data
{
    public class ReporteeDB
    {
        private static List<Reportee> ReporteeList = new List<Reportee>();

        public static List<Reportee> GetData()
        {
            return ReporteeList;
        }

        public static void SaveData(List<Reportee> list)
        {
            ReporteeList = list;
        }
    }
}
