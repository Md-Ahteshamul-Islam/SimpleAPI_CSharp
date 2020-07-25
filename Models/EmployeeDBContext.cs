using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace API_NG_Hatt.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext()
        {
            Database.SetInitializer<DbContext>(new DropCreateDatabaseIfModelChanges<DbContext>());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
    }
}