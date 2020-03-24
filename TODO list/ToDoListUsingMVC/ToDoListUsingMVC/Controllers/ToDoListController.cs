using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListUsingMVC.Models;

namespace ToDoListUsingMVC.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        public ActionResult Index()
        {
            List<TODOItem> todoItemList = new List<TODOItem>();
            using (MyDBEntities myDBEntity = new MyDBEntities())
            {
                todoItemList = myDBEntity.TODOItems.Where(item => item.Status == "Open").ToList();
            };
            return View(todoItemList);
        }

        
        // GET: ToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //create an object of ToDoItem
                TODOItem toDoItem = new TODOItem()
                {
                    Description = collection["Description"],
                    Status = collection["Status"]
                };
                //add new item to list;
                using (MyDBEntities myDBEntity = new MyDBEntities())
                {
                    myDBEntity.TODOItems.Add(toDoItem);
                    myDBEntity.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

       
        [HttpPost]
        public ActionResult Edit(FormCollection formCollection)
        {
            try
            {
               MyDBEntities myDBEntity = new MyDBEntities();

                string[] idArray = new string[] { }; 
                string[] statusArray = new string[] { };
                
                foreach (string key in formCollection.AllKeys)
                {
                    //retrieve id and status values from form array
                    if (key.Contains("itemChk"))
                    {
                        statusArray = formCollection[key].Replace("true,false","true").Split(',');
                    }
                    else if (key.Contains("Id"))
                    {
                        idArray = formCollection[key].Split(',');
                    }
                }
                //iterate thru status array as it will always have highest values.
                int lentgh = statusArray.Length;
                if (lentgh > 0)
                {
                    for (int i = 0; i < statusArray.Length; i++)
                    {
                        int ID = Convert.ToInt32(idArray[i]);
                        if (statusArray[i].ToLower() == "true")
                        {
                            TODOItem tODOItem = myDBEntity.TODOItems.SingleOrDefault(item => item.Id == ID);
                            tODOItem.Status = "Completed";
                        }
                    }
                }
                myDBEntity.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        
        public ActionResult Delete(int id)
        {
            try
            {
                using (MyDBEntities myDBEntity = new MyDBEntities())
                {
                    //get item from list by id
                    TODOItem tODOItem = myDBEntity.TODOItems.FirstOrDefault(tdi => tdi.Id == id);
                    if(tODOItem != null)
                    {
                        myDBEntity.TODOItems.Remove(tODOItem);
                        myDBEntity.SaveChanges();
                    }
                };
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
