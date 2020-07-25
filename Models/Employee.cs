using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_NG_Hatt.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string EMPCode { get; set; }
        public string Mobile { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; }
    }
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string EMPCode { get; set; }
        public string Mobile { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}