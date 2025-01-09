using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class StudentsController : Controller
    {
        public string GetMyString()
        {
            return "This is my string method called ";
        }
        public string GetMyStringWithParameter(int id, string name)
        {
            return "This is my ID : " + id + " "+ "name :  " + name;
        }
        public ActionResult MyView()
        {
            return View("MyFirstView");
        }public ActionResult MySecondMethod()
        {
            Employee myemployee = new Employee();
            var data = myemployee.GetEmployee();
            return View(data);
        }
    }
}