using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemAPI.Models
{
    public class CustomLeaves
    {
        public Nullable<int> id { get; set; }
        public string jan { get; set; }
        public string feb { get; set; }
        public string mar { get; set; }
        public string apr { get; set; }
        public string may { get; set; }
        public string jun { get; set; }
        public string jul { get; set; }
        public string aug { get; set; }
        public string sep { get; set; }
        public string oct { get; set; }
        public string nov { get; set; }
        public string dec { get; set; }
        public string Approved { get; set; }
        public Nullable<int> LeaveId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public Nullable<int> GrantedLeaves { get; set; }
        public Nullable<int> AvailedLeaves { get; set; }
    }
}