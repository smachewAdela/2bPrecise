using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bPrecise.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bPrecise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEnumerable<Employee> emps
        {
            get
            {
                return Enumerable.Range(1, 5).Select(index => new Employee
                {
                    FirstName = $"Emp {index}",
                    LastName = index.ToString(),
                    Position = index.ToString(),
                    Id = index
                });
            }
        }

        public EmployeeController()
        {

        }

        [HttpGet("list")]
        public IEnumerable<Employee> list()
        {
            return emps;
        }

        [HttpGet("{employeeId}")]
        public Employee getEmployee(int employeeId)
        {
            return emps.FirstOrDefault(x => x.Id == employeeId);
        }
    }
}