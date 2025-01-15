using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class SessionMTController : Controller
    {
        // GET: SessionMT
        public ActionResult Index()
        {
            List<string> myListCollection = new List<string>()
            { "java", "Python", "c#", "React"};
            List<EmployeeOld> myList = new List<EmployeeOld>();
            EmployeeOld emp = new EmployeeOld
            {
                Name = "Shyam",
                age = 25,
                email = "shyam@gmail.com",
                phone = 123456789098
            };
            myList.Add(emp);
            ViewBag.MyProp = "Shyam";
            ViewBag.MyProp1 = 20;
            ViewBag.MyProp2 = true;
            ViewBag.MyList = myListCollection;
            ViewBag.MyModelList = myList;
            return View();
        }
        public ActionResult About()
        {

            ViewData["MyKey"] = "Shyam";
            ViewData["MyKey1"] = 30;
            ViewData["MyKey2"] = true;
            List<string> myListCollection = new List<string>()
            { "java", "Python", "c#", "React"};
            ViewData["MyKey3"] = myListCollection;
            List<EmployeeOld> myList = new List<EmployeeOld>();
            EmployeeOld emp = new EmployeeOld
            {
                Name = "Shyam",
                age = 25,
                email = "shyam@gmail.com",
                phone = 123456789098
            };
            myList.Add(emp);
            ViewData["MyKey4"] = myList;

            return View();
        }
    }
}