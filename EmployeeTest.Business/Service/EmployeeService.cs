using EmployeeTest.Business.IService;
using EmployeeTest.DataAccess.IRepositories;
using EmployeeTest.DataAccess.Models;
using EmployeeTest.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Business.Service
{
   public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void insertEmployee(Employee emp)
        {
            _employeeRepository.insertEmployee(emp);
        }


        public Employee FindEmployee(int EmployeeId) => _employeeRepository.FindEmployee(EmployeeId);
        
        public void DeleteEmployee(int EmployeeId) =>_employeeRepository.DeleteEmployee(EmployeeId);


        public void Update(int EmployeeId, Employee emp) => _employeeRepository.Update(EmployeeId, emp);


    }
}
