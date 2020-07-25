using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API_NG_Hatt.Models;

namespace API_NG_Hatt.DAL
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployee()
        {
            EmployeeDBContext e = new EmployeeDBContext();
            return e.Employees.ToList();
        }
    }
}