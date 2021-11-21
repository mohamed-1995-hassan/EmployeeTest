using EmployeeTest.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.DataAccess.IRepositories
{
   public interface IEmployeeRepository
   {
        void insertEmployee(Employee emp);
        Employee FindEmployee(int EmployeeId);
        void DeleteEmployee(int EmployeeId);
        void Update(int EmployeeId, Employee emp);
   }
}
