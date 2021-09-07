using EmployeeProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.EmployeeRepository
{
    public class EmployeeService
    {
        EmployeeDBContext _context = new EmployeeDBContext();
        public List<Employee> SaveEmployee()
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
            foreach (var employee in employees)
            {
                _context.Add(employee);
                _context.SaveChanges();
            }
            return employees;
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _context.Employees.Find(Id);
        }

        public Employee GetEmployeeByName(String Name)
        {
            return _context.Employees.FirstOrDefault(x=>x.Name == Name);
        }

        public Employee GetEmployeeByType(String Type)
        {
            return _context.Employees.FirstOrDefault(x => x.Type == Type);
        }
    }
}
