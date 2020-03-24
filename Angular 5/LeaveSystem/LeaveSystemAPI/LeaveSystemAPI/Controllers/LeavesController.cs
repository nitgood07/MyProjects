using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using LeaveSystemAPI.Models;

namespace LeaveSystemAPI.Controllers
{
    public class LeavesController : ApiController
    {

        private string _jan = "";
        private string _feb = "";
        private string _mar = "";
        private string _apr = "";
        private string _may = "";
        private string _jun = "";
        private string _jul = "";
        private string _aug = "";
        private string _sep = "";
        private string _oct = "";
        private string _nov = "";
        private string _dec = "";

        public HttpResponseMessage GetAllLeaves() {
            //method to get all leaves for all employees view.
            List<CustomLeaves> customLeaves = new List<CustomLeaves>();

            using(APIModelEntities entity = new APIModelEntities())
            {
                //Get Leave table records.
                List<Leaf> _leaves = entity.Leaves.ToList();
               //run a loop to get total approved leaves 

                foreach(Leaf _l in _leaves)
                {
                    List<Leave_Requests> LR = entity.Leave_Requests.Where(lr => lr.LeaveId == _l.Id).ToList();

                    //find out how many leave requests were found for this employee.
                    if (LR.Count > 0)
                    {
                        //run a loop on leave Request object and populate leave months.
                        foreach (Leave_Requests _lr in LR)
                        {
                            //check if leave request was approved
                            if(_lr.Approved == "Y")
                            {
                                //populate months for start and end dates
                                //for all leave requestes
                                string monthName = Convert.ToDateTime(_lr.StartDate).ToString("MMM");
                                PopulateMonthName(monthName);
                                monthName = Convert.ToDateTime(_lr.EndDate).ToString("MMM");
                                PopulateMonthName(monthName);
                            }
                        }
                        //add this to custom leave object
                        customLeaves.Add(PopulateCustomLeave("Leave", _l));
                    }
                    else{
                        //no leave request found
                        //simply populate custom leave object
                        customLeaves.Add(PopulateCustomLeave("NoLeave", _l));
                    }
                    
                }

                //return list of custom object
                return Request.CreateResponse(HttpStatusCode.OK, customLeaves);   
            }
        }

       
        private CustomLeaves PopulateCustomLeave(string type, Leaf leave)
        {
            CustomLeaves customLeaves = new CustomLeaves();
            if(type == "Leave")
            {
                customLeaves.jan = _jan;
                customLeaves.feb = _feb;
                customLeaves.mar = _mar;
                customLeaves.apr = _apr;
                customLeaves.may = _may;
                customLeaves.jun = _jun;
                customLeaves.jul = _jul;
                customLeaves.aug = _aug;
                customLeaves.sep = _sep;
                customLeaves.oct = _oct;
                customLeaves.nov = _nov;
                customLeaves.dec = _dec;

               
                //blank all prepopulated month values.
                _jan = "";
                _feb = "";
                _mar = "";
                _apr = "";
                _may = "";
                _jun = "";
                _jul = "";
                _aug = "";
                _sep = "";
                _oct = "";
                _nov = "";
                _dec = "";

            }
            customLeaves.EmployeeName = leave.EmployeeName;
            customLeaves.EmployeeEmail = leave.EmployeeEmail;
            customLeaves.ManagerName = leave.ManagerName;
            customLeaves.ManagerEmail = leave.ManagerEmail;
            customLeaves.GrantedLeaves = leave.GrantedLeaves;
            customLeaves.AvailedLeaves = leave.AvailedLeaves;
            customLeaves.LeaveId = leave.Id;

            return customLeaves;
        }

        private void PopulateMonthName(string monthName)
        {
            switch (monthName.ToLower())
            {
                case "jan":
                    _jan = "Y";
                    break;
                case "feb":
                    _feb = "Y";
                    break;
                case "mar":
                    _mar = "Y";
                    break;
                case "apr":
                    _apr = "Y";
                    break;
                case "may":
                    _may = "Y";
                    break;
                case "jun":
                    _jun = "Y";
                    break;
                case "jul":
                    _jul = "Y";
                    break;
                case "aug":
                    _aug = "Y";
                    break;
                case "sep":
                    _sep = "Y";
                    break;
                case "oct":
                    _oct = "Y";
                    break;
                case "nov":
                    _nov = "Y";
                    break;
                case "dec":
                    _dec = "Y";
                    break;
            }
        }

        public HttpResponseMessage GetLeavesForAnEmployee(int EmployeeId)
        {
            //method to get leaves for an employee view.
            using (APIModelEntities entity = new APIModelEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entity.GetLeavesForAnEmployee(EmployeeId).ToList());
            }
        }

        public HttpResponseMessage GetLeavesForAMonth(int Month)
        {
            //method to get all emoloyee leaves for current month view.
            using (APIModelEntities entity = new APIModelEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, entity.GetLeavesForAMonth(Month).ToList());
            }
        }
    }
}
