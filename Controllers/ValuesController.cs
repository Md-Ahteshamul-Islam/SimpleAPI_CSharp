using API_NG_Hatt.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace API_NG_Hatt.Controllers
{

    public class ValuesController : ApiController
    {

        EmployeeDBContext e;
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //    EmployeeDBContext e = new EmployeeDBContext();
        //    List<Employee> data = new List<Employee>();

        //    data = e.Employees.ToList();
        //    return new string[] { "value1", "value2" };
        //}
        public HttpResponseMessage Get()
        {
            //return new string[] { "value1", "value2" };
            List<Employee> dt = new List<Employee>();
            //List<EmployeeDetails> dt = new List<EmployeeDetails>();
            //dt = e.EmployeeDetails.ToList();
            e = new EmployeeDBContext();
            dt = e.Employees.ToList();


            HttpResponseMessage response = null;
            string json = string.Empty;

            json = JsonConvert.SerializeObject(dt);
            response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // Info.  
            return response;
        }

        // GET api/values/5
        public HttpResponseMessage Get(int EmployeeID)
        {
            e = new EmployeeDBContext();
            var EmpInfo = e.Employees.Where(m=>m.EmployeeID == EmployeeID);


            HttpResponseMessage response = null;
            string json = string.Empty;

            json = JsonConvert.SerializeObject(EmpInfo);
            response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");
            
            return response;
        }

        // POST api/values
        public void Post(string FullName, string EMPCode, string Mobile, string Position)
        {
            Employee emp = new Employee();
            e = new EmployeeDBContext();
            //EmployeeDBContext e2 = new EmployeeDBContext();
            emp.FullName = FullName;
            emp.EMPCode = EMPCode;
            emp.Mobile = Mobile;
            emp.Position = Position;
            //emp.Department = e2.Departments.Where(m => m.DepartmentID == 1);
            e.Employees.Add(emp);
            e.SaveChanges();
        }
        public void Post( Employee Employee)
        {
            e = new EmployeeDBContext();
            e.Employees.Add(Employee);
            e.SaveChanges();
        }

        // PUT api/values/5
        public void Put(Employee Employee)
        {
            //e = new EmployeeDBContext();
            //e.Employees.AddOrUpdate(Employee);
            //e.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            e = new EmployeeDBContext();
            var employer = new Employee { EmployeeID = id };
            e.Employees.Attach(employer);
            e.Employees.Remove(employer);
            e.SaveChanges();
        }
    }
}
