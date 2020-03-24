using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoListWebAPI.Models;

namespace ToDoListWebAPI.Controllers
{
    [RoutePrefix("api/ToDoList")]
    public class ToDoListController : ApiController
    {
        
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            //Get list of TODO list itmes from DB
            using(ToDoListModel toDoListModel = new ToDoListModel())
            {
                return Request.CreateResponse(HttpStatusCode.OK, toDoListModel.TODOItems.Where(item => item.Status != "Completed").ToList());      
            }
        }

        
        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]TODOItem newTODOItem)
        {
            using(ToDoListModel toDo = new ToDoListModel())
            {
                toDo.TODOItems.Add(newTODOItem);
                toDo.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "New task added.");
            }
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]TODOItem newTODOItem)
        {
            using (ToDoListModel toDo = new ToDoListModel())
            {
                try {
                    //lets get what task is being updated.
                    TODOItem itemToBeUpdated = toDo.TODOItems.SingleOrDefault(item => item.Id == id);
                    if (itemToBeUpdated == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Task with " + id + " not found.");
                    }
                    //if found then let's update

                    itemToBeUpdated.Status = newTODOItem.Status;
                    toDo.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Task status has been updated");
                }
                catch(Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "There is some problem with updating task status");
                }
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            using (ToDoListModel toDo = new ToDoListModel())
            {
                //find item in our model
                TODOItem itemToBeDeleted = toDo.TODOItems.SingleOrDefault(item => item.Id == id);
                //check if item found
                if(itemToBeDeleted == null)
                {
                    //return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Task with " + id + " not found.");\
                    return BadRequest();
                }
                toDo.TODOItems.Remove(itemToBeDeleted);
                toDo.SaveChanges();
                //return Request.CreateResponse(HttpStatusCode.OK, "Task was deleted.");
                return Ok();
            }
        }
    }
}