using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTODOITEM2.Models;

namespace MVCTODOITEM2.Controllers
{
    public class TODOItemController : Controller
    {
        // GET: TODOItem
        public ActionResult Index()
        {
            List<TODOItem> ItemList = new List<TODOItem>();
            //Return list of todo items
            using(TODOITEMEntity tODOITEMEntity = new TODOITEMEntity())
            {
                ItemList =  tODOITEMEntity.TODOItems.Where(item => item.Status != "Completed").ToList();
            }
            return View(ItemList);
        }

       

        // GET: TODOItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TODOItem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //first create a new object using form collection
                    //then pass the object to model to create.
                    TODOItem newTODOItem = new TODOItem();
                    newTODOItem.Description = collection["Description"];
                    newTODOItem.Status = collection["Status"];
                    //Lets invoke DB entity
                    using (TODOITEMEntity tODOITEMEntity = new TODOITEMEntity())
                    {
                        tODOITEMEntity.TODOItems.Add(newTODOItem);
                        tODOITEMEntity.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                //Handle catch situation
                return View();
            }
        }

       

        //POST: TODOItem/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                using (TODOITEMEntity tODOITEMEntity = new TODOITEMEntity())
                {
                    //let's grab checked items
                    //loop thru items that were checked.
                    // pass them to model to update status.
                    string[] idArray = new string[] { };
                    string[] checkArray = new string[] { };
                    foreach (var key in collection.AllKeys)
                    {
                        if (key.ToLower().Contains("id"))
                        {
                            idArray = collection[key].Split(',');
                        }
                        if (key.Contains("itemChk"))
                        {
                            //first replace "true,false" with only true as form submit 
                            //true followed by false for check box
                            checkArray = collection[key].Replace("true,false", "true").Split(',');
                        }
                    }
                    int checkArrayLenght = checkArray.Length;
                    //run a loop on check array
                    for (int i = 0; i < checkArrayLenght; i++)
                    {
                        int ID = Convert.ToInt32(idArray[i]);
                        //check if check box was selected
                        if(checkArray[i].ToLower() == "true")
                        {
                             TODOItem itemToBeUpdated =  tODOITEMEntity.TODOItems.SingleOrDefault(item => item.Id == ID);
                            itemToBeUpdated.Status = "Completed";
                        }
                    }
                    tODOITEMEntity.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

       
        public ActionResult Delete(int id)
        {
            try
            {
                //let's grab the object using passed id
                //pass that object to be removed from db
                using (TODOITEMEntity tODOITEMEntity = new TODOITEMEntity())
                {
                    var itemToBeDeleted = tODOITEMEntity.TODOItems.SingleOrDefault(item => item.Id == id);
                    if(itemToBeDeleted == null)
                    {
                        //throw a exception
                    }
                    //else
                    tODOITEMEntity.TODOItems.Remove(itemToBeDeleted);
                    tODOITEMEntity.SaveChanges();
                    return RedirectToAction("Index");
                }
                    
            }
            catch
            {
                //handle
                return RedirectToAction("Index");
            }
        }
    }
}
