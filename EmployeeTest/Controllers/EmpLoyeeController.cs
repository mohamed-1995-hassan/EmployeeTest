using EmployeeTest.Business.IService;
using EmployeeTest.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpLoyeeController : ControllerBase
    {
        

        private readonly IEmployeeService _employeeService;

        public EmpLoyeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("AddEmployee")]
        [HttpPost]
        public void AddEmployee([FromBody] Employee emp)
        {
            _employeeService.insertEmployee(emp);
        }

        [Route("FindEmployee")]
        [HttpGet]
        public Employee FindEmployee([FromQuery] int id) => _employeeService.FindEmployee(id);

        [Route("DeleteEmployee")]
        [HttpPost]
        public void DeleteEmployee([FromQuery] int id) => _employeeService.DeleteEmployee(id);

        [Route("Update")]
        [HttpPost]
        public void Update([FromQuery] int id , [FromBody] Employee emp) => _employeeService.Update(id,emp);
    }
}
