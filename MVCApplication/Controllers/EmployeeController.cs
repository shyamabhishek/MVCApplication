using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVCApplication.Controllers
{
    [RoutePrefix("Employee")] //place common url in here
    public class EmployeeController : Controller
    {
        [Route("")]
        //[Route("Employee")] //normal routing
        public ActionResult GetAllEmployee()
        {
            var employeeList = GetEmpList();
            return View(employeeList);
        }
        [Route("{id:int:min(5)}")]
        //[Route("{id : int}")] //common url in the RoutePrefix, (int is for other int than id is entered in url handelling)
        //[Route("Employee/{id}")]
        public ActionResult GetEmployee(int id)
        {
            var employee = GetEmpList().FirstOrDefault(x => x.EmpId == id);
            return View(employee);
        }
        //string entered in url error handeling
        [Route("{id}")]
        public string MyString(string myid)
        {
            return myid;
        }

        //public ActionResult GetEmployeeByName(string id)
        //{
        //    var employee = GetEmpList().FirstOrDefault(x => x.EmpName == id);
        //    return View(employee);
        //}
        [Route("address/{id}")]
        //[Route("Employee/address/{id}")]
        public ActionResult GetEmployeeAddress(int id)
        {
            //we can use select and above query instead of where
            var employee = GetEmpList().Where(x => x.EmpId == id).Select(x => x.Address).FirstOrDefault();
            return View(employee);
        }
        [Route("~/helpus")] //override routes
        public ActionResult HelpUs()
        {
            return View();
        }
        private List<Employee> GetEmpList()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmpId = 1,
                    EmpName = "Emp 1",
                    Dept = "IT",
                    Email = "emp1@gmail.com",
                    Phone = 123456789,
                    Address = new Address()
                    {
                        HomeAddress = "Home1",
                        City = "Pune",
                        State ="Maharastra",
                        Country ="India",
                        ZipCode ="12345"
                    }

                },
                new Employee()
                {
                    EmpId = 2,
                    EmpName = "Emp 2",
                    Dept = "Admin",
                    Email = "emp2@gmail.com",
                    Phone = 123456789,
                    Address = new Address()
                    {
                        HomeAddress = "Home2",
                        City = "Delhi",
                        State ="Delhi",
                        Country ="India",
                        ZipCode ="111111"
                    }

                },
                new Employee()
                {
                    EmpId = 3,
                    EmpName = "Emp 3",
                    Dept = "HR",
                    Email = "emp3@gmail.com",
                    Phone = 123456789,
                    Address = new Address()
                    {
                        HomeAddress = "Home3",
                        City = "Bengaluru",
                        State ="Karnatka",
                        Country ="India",
                        ZipCode ="2222222"
                    }

                }
            };

        }
    }
}