using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPILeaveSystem.Models;

namespace WebAPILeaveSystem
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (LeavesEntities leaveEntity = new LeavesEntities())
            {
                return leaveEntity.Users.Any(un => un.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && un.Password == password);
            }
        }
    }
}