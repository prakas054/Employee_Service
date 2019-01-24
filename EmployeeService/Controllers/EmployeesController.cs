using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities ent = new EmployeeDBEntities())
            {
                return ent.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities ent = new EmployeeDBEntities())
            {
                return ent.Employees.FirstOrDefault(e => e.ID == id );
            }
        }
    }
}
