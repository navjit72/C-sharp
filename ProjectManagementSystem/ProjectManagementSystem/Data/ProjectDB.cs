using ProjectManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data
{
    public class ProjectDB
    {
        private static List<Project> ProjectList = new List<Project>();

        public static List<Project> GetData()
        {
            return ProjectList;
        }

        public static void SaveData(List<Project> list)
        {
            ProjectList = list;
        }
    }
}
