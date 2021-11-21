using EmployeeTest.DataAccess.IRepositories;
using EmployeeTest.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.DataAccess.Repositories
{
  public  class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _employeeDBContext;

        public EmployeeRepository(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }

        public EmployeeRepository()
        {
            
        }

        public void insertEmployee(Employee emp)
        {
            _employeeDBContext.employees.Add(emp);
            _employeeDBContext.SaveChanges();
        }

        public Employee FindEmployee(int EmployeeId) => _employeeDBContext.employees.Find(EmployeeId);

        public void DeleteEmployee(int EmployeeId)
        {
            Employee employee = FindEmployee(EmployeeId);
            _employeeDBContext.employees.Remove(employee);
            _employeeDBContext.SaveChanges();
        }

        public void Update(int EmployeeId,Employee emp)
        {
            Employee employee = FindEmployee(EmployeeId);
            employee.Age = emp.Age;
            employee.EmployeeName = emp.EmployeeName;
            _employeeDBContext.Update(employee);
            _employeeDBContext.SaveChanges();
        }
  }
}
