using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Employees;

namespace NewEmployee.App
{
    class EmployeeContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}
