using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebAPILeaveSystem.Models;

namespace WebAPILeaveSystem.Controllers
{
    [Authorize]
    [RoutePrefix("api/Leaves")]
    public class LeavesController : ApiController
    {
        //[BasicAuthentication]
        [Route]
        public HttpResponseMessage GetLeaves()
        {
            //Code used with Basic Authentication

            // string username = Thread.CurrentPrincipal.Identity.Name;

            //using (LeavesEntities leavesEntity = new LeavesEntities())
            //{
            //switch(username.ToLower())
            //{
            //    case "employee":
            //        return Request.CreateResponse(HttpStatusCode.OK, leavesEntity.Leaves.Where(L => L.ManagerName.ToLower() == "namita").ToList());
            //    case "manager":
            //        return Request.CreateResponse(HttpStatusCode.OK, leavesEntity.Leaves.Where(L => L.ManagerName.ToLower() == "raghu").ToList());
            //    default:
            //        return Request.CreateResponse(HttpStatusCode.BadRequest);
            //}
            //}

            //Code with Token authentication
            using (LeavesEntities leavesEntity = new LeavesEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, leavesEntity.Leaves.ToList());
            }
        }

        [Route("{value}")]
        public IEnumerable<Leaf> GetLeaves(String employeeName)
        {
            using (LeavesEntities leaveEntity = new LeavesEntities())
            {
                return leaveEntity.Leaves.Where(L => L.EmployeeName.ToLower() == employeeName.ToLower()).ToList();
            }
        }

        public HttpResponseMessage Post([FromBody] Leaf leaveRequest)
        {
            using (LeavesEntities leaveEntity = new LeavesEntities())
            {
                leaveEntity.Leaves.Add(leaveRequest);
                leaveEntity.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, "New Leave Request Created.");
                //return Ok("New Leave Request Created.");
            }
        }

        [Route("{id}")]
        public HttpResponseMessage Put(int Id, [FromBody] Leaf leaveRequest)
        {
            using (LeavesEntities leaveEntity = new LeavesEntities())
            {
                try
                {
                    var leave = leaveEntity.Leaves.FirstOrDefault(L => L.Id == Id);
                    
                    if(leave == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Leave with Id " + Id + " not found.");
                    }

                    leave.EmployeeName = leaveRequest.EmployeeName;
                    leave.EmployeeEmail = leaveRequest.EmployeeEmail;
                    leave.ManagerName = leaveRequest.ManagerName;
                    leave.ManagerEmail = leaveRequest.ManagerEmail;
                    leave.FromDate = leaveRequest.FromDate;
                    leave.ToDate = leaveRequest.ToDate;
                    leaveEntity.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Leave Request Updated.");
                }
                catch(Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
                
            }
        }


        [Route("{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            using (LeavesEntities leaveEntity = new LeavesEntities())
            {
                var leave = leaveEntity.Leaves.FirstOrDefault(L => L.Id == Id);
                if (leave == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Leave with Id " + Id + " not found.");
                }

                leaveEntity.Leaves.Remove(leaveEntity.Leaves.FirstOrDefault(L => L.Id == Id));
                leaveEntity.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Leave Request Deleted.");
            }
        }

    }
}
