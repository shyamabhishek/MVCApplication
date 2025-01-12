using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HelperDemoController : Controller
    {
        // GET: HelperDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact(string name=null)
        {
            return View();
        }
        public ActionResult StronglyTypeDemo()
        {
            Employee emp = new Employee()
            {
                IsEmployee = true,
                Name ="Testing",
                email = "test@test.com"
            };
            return View(emp);
        }
        [HttpPost]
        public void StronglyTypeDemo(Employee emp)
        {

        }
    }
}