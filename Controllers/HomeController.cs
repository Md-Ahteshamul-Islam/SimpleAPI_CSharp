using API_NG_Hatt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_NG_Hatt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public List<Employee> GetEmployee()
        {
            EmployeeDBContext e = new EmployeeDBContext();
            List<Employee> data = new List<Employee>();

            data = e.Employees.ToList();
            return data;
        }
    }
}
