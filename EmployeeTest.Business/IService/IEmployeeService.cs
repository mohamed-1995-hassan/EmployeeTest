using EmployeeTest.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Business.IService
{
   public interface IEmployeeService
    {
        public void insertEmployee(Employee emp);
        public Employee FindEmployee(int EmployeeId);
        public void DeleteEmployee(int EmployeeId);
        public void Update(int EmployeeId, Employee emp);
    }
}
