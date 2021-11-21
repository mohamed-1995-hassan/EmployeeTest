using EmployeeTest.Business.Service;
using EmployeeTest.DataAccess.IRepositories;
using EmployeeTest.DataAccess.Models;
using EmployeeTest.DataAccess.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace EmployeeTestProject
{
    public class EmployeeShould
    {
        private readonly Mock<IEmployeeRepository> _repo;
        private readonly EmployeeService _service;
        private readonly List<Employee> emps;

       public EmployeeShould()
       {
            _repo = new Mock<IEmployeeRepository>();
            _service = new EmployeeService(_repo.Object);
            emps = new List<Employee> { new Employee {EmployeeId=1,EmployeeName="Ahmed",Age=45 },
            new Employee {EmployeeId=2,EmployeeName="Kareem",Age=19 }
            };
       }

        [Fact]
        public void InsertSuccessfully()
        {
            //Arrange
            Employee emp = new Employee{EmployeeName="mohamed",Age=25};
            _repo.Setup(row => row.insertEmployee(emp)).Callback(()=>emps.Add(emp));
            //Act
            _service.insertEmployee(emp);
            //Assert
            Assert.Contains(emp, emps);
        }
        [Fact]
        public void DeletedSuccessfully()
        {
            //Arrange
            int id =1;
            Employee employee = emps.FirstOrDefault(row => row.EmployeeId == id);
            _repo.Setup(row => row.DeleteEmployee(id)).Callback(
                () => emps.Remove(employee));
            //Act
            _service.DeleteEmployee(id);
            //Assert
            Assert.DoesNotContain(employee, emps);


        }
        [Fact]
        public void RetriveSuccessfully()
        {
            int id = 1;
            Employee employee = emps.FirstOrDefault(row => row.EmployeeId == id);
            //Arrange
            _repo.Setup(row => row.FindEmployee(id)).Returns(employee);
            //Act
            _service.FindEmployee(id);
            //Assert
            Assert.NotNull(employee);

        }
    }
}
