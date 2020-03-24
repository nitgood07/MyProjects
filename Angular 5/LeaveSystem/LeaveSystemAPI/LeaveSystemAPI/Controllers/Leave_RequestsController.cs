using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LeaveSystemAPI.Models;

namespace LeaveSystemAPI.Controllers
{
    public class Leave_RequestsController : ApiController
    {
        // GET: api/Leave_Requests
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Leave_Requests/5
        public IHttpActionResult Get(int id)
        {
            //Method will return only one selected leave.
            using (APIModelEntities entity = new APIModelEntities())
            {
                Leave_Requests lr = entity.Leave_Requests.FirstOrDefault(L => L.Id == id);
                if(lr != null)
                {
                    return Ok(lr);
                }
                else
                {
                    return NotFound();
                }
                
            }
        }

        // POST: api/Leave_Requests
        public IHttpActionResult Post([FromBody] Leave_Requests lr)
        {
            try
            {
                using (APIModelEntities entity = new APIModelEntities())
                {
                    entity.Leave_Requests.Add(lr);
                    entity.SaveChanges();
                    return Created(new Uri(Request.RequestUri + lr.Id.ToString()), lr);
                }
            }
            catch(Exception Ex)
            {
                return BadRequest(Ex.Message);
            }
        }

        // PUT: api/Leave_Requests/5
        public HttpResponseMessage Put(int id, [FromBody]Leave_Requests lrUpdated)
        {
            using (APIModelEntities entity = new APIModelEntities())
            {
                try
                {
                    var lrOriginal = entity.Leave_Requests.FirstOrDefault(Lr => Lr.Id == id);

                    if (lrOriginal == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Leave record with Id " + id + " not found.");
                    }

                    lrOriginal.StartDate = lrUpdated.StartDate;
                    lrOriginal.EndDate = lrUpdated.EndDate;
                    lrOriginal.Approved = lrUpdated.Approved;
                    
                    ///TODO: Need to write logic to manage total granted leaves and availed leaves.
                    ///

                    entity.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Leave record Updated.");
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                }

            }
        }

        // DELETE: api/Leave_Requests/5
        public IHttpActionResult Delete(int id)
        {
            using (APIModelEntities entity = new APIModelEntities())
            {
                var lr = entity.Leave_Requests.FirstOrDefault(Lr => Lr.Id == id);
                if (lr == null)
                {
                    return NotFound();
                }
                entity.Leave_Requests.Remove(lr);
                entity.SaveChanges();
                return Ok();
            }
        }
    }
}
