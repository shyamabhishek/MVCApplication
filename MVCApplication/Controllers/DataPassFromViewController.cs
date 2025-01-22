using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class DataPassFromViewController : Controller
    {
        // GET: DataPassFromView
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostDataUsingParameters(string firstname, string lastname, string address, string phonenumber, string email)
        {

            return firstname + " " + lastname + " " + address + " " + phonenumber + " " + email;
        }
        [HttpPost]
        public string PostDataUsingRequest()
        {
            string firstname = Request["firstname"];
            string lastname = Request["lastname"];
            string address = Request["address"];
            string phonenumber = Request["phonenumber"];
            string email = Request["email"];
            return firstname + " " + lastname + " " + address
                + " " + phonenumber + " " + email;
        }
        [HttpPost]
        public string PostDataUsingFormCollection(FormCollection form)
        {
            string firstname = form["firstname"];
            string lastname = form["lastname"];
            string address = form["address"];
            string phonenumber = form["phonenumber"];
            string email = form["email"];

            return firstname + " " + lastname + " " + address
                + " " + phonenumber + " " + email;
        }
        [HttpPost]
        public string PostDataUsingStronglyType(Employee employee)
        {
            return employee.EmpName + " " + employee.Email + " " + employee.Phone + " " +
                employee.Dept;
        }
    }
}