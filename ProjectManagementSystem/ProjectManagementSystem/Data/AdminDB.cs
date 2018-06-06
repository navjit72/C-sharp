using ProjectManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Data
{
    public class AdminDB
    {
        private static List<Admin> AdminList = new List<Admin>()
        {
            new Admin("Navjit","Kaur",'F',"kaur.navjit72@gmailcom","2345566654","navjit")
        };

        public static List<Admin> GetData()
        {
            return AdminList;
        }

        public static void SaveData(List<Admin> list)
        {
            AdminList = list;
        }
    }
}
