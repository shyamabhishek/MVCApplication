using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class TempDataDemoController : Controller
    {
        // GET: TempDataDemo
        public ActionResult Index()
        {
            TempData["myKey"] = "This is my action method";
            return View();
        }
        public ActionResult About()
        {
            //var tempDataval = TempData["myKey"];
            var tempDataval = TempData.Peek("myKey");
            //Session.Abandon();
            TempData.Keep("myKey");
            return View();
        }
        public ActionResult Contact()
        {
            var tempDataval = TempData["myKey"];
            return View();
        }
    }
}