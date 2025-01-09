using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public long phone { get; set; }

        public Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Shyam",
                age = 25,
                email = "shyam@gmail.com",
                phone = 1234567890
            };
        }
    }
}