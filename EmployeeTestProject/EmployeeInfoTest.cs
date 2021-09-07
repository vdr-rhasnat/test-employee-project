using EmployeeProject;
using EmployeeProject.EmployeeRepository;
using EmployeeProject.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemanticComparison;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTestProject
{
    [TestClass]
    public class EmployeeInfoTest
    {
        EmployeeDBContext _context = new EmployeeDBContext();
        EmployeeService employeeService = new EmployeeService();
        [TestMethod]
        public void TestEmployeeByName()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Shawon",
                Type = "permanent",
                Address = "Bashundhara"
            };

            var emp = employeeService.GetEmployeeByName("Shawon");
            var expectedEmployee = new Likeness<Employee, Employee>(employee);
            Assert.AreEqual(expectedEmployee, emp);
        }

        [TestMethod]
        public void TestEmployeeByType()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Shawon",
                Type = "permanent",
                Address = "Bashundhara"
            };

            var emp = employeeService.GetEmployeeByType("permanent");
            var expectedEmployee = new Likeness<Employee, Employee>(employee);
            Assert.AreEqual(expectedEmployee, emp);
        }

        [TestMethod]
        public void TestEmployeeById()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Shawon",
                Type = "permanent",
                Address = "Bashundhara"
            };

            var emp = employeeService.GetEmployeeById(1);
            var expectedEmployee = new Likeness<Employee, Employee>(employee);
            Assert.AreEqual(expectedEmployee, emp);
        }
        [TestMethod]
        public void TestEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    Id =1,
                    Name = "Shawon",
                    Type = "permanent",
                    Address = "Bashundhara"
                },
                new Employee
                {
                    Id =2,
                    Name = "Raihan",
                    Type = "Permanent",
                    Address = "Mirpur"
                },
                new Employee
                {
                    Id =3,
                    Name = "Shovo",
                    Type = "Contractual",
                    Address = "Uttara"
                },
                new Employee
                {
                    Id =4,
                    Name = "Mishal",
                    Type = "Permanent",
                    Address = "Kuril"
                },
                new Employee
                {
                    Id =5,
                    Name = "Jibon",
                    Type = "Contractual",
                    Address = "Dhaka"
                }
            };
            var emp = employeeService.GetEmployees();
            var expectedEmployee = new Likeness<List<Employee>, List<Employee>>(employees);
            Assert.AreEqual(expectedEmployee, emp);
        }
    }
}
