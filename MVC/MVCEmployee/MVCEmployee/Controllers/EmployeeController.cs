using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmployee.Models;

namespace MVCEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (MyDatabaseEntities dbContext = new MyDatabaseEntities())
            {
                List<tblEmployee> employees = dbContext.tblEmployees.ToList();
                return View(employees);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_post()
        {
            if (ModelState.IsValid)
            {
                tblEmployee newEmployee = new tblEmployee();
                TryUpdateModel(newEmployee);
                //if(ValidateModel(newEmployee))
                using (MyDatabaseEntities dbContext = new MyDatabaseEntities())
                {
                    dbContext.tblEmployees.Add(newEmployee);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit(int Id)
        {
            using (MyDatabaseEntities dbContext = new MyDatabaseEntities())
            {
                tblEmployee editEmployee = dbContext.tblEmployees.SingleOrDefault(emp => emp.Id == Id);
                return View(editEmployee);
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int Id)
        {
            using (MyDatabaseEntities dbContext = new MyDatabaseEntities())
            {
                var editEmployee = dbContext.tblEmployees.FirstOrDefault(emp => emp.Id == Id);
                //Populate values from Formcollection
                UpdateModel(editEmployee,new string[] {"Id","Name","Gender","DateOfBirth"});
                
                if (ModelState.IsValid)
                {
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Id);
            }
           
           
        }
    }
}