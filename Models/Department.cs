using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_NG_Hatt.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}