using ProjectManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data
{
    public class ManagerDB
    {
        private static List<Manager> ManagerList = new List<Manager>();

        public static List<Manager> GetData()
        {
            return ManagerList;
        }

        public static void SaveData(List<Manager> list)
        {
            ManagerList = list;
        }
    }
}
