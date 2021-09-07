using EmployeeProject.EmployeeRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controller
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService _employeeService = new EmployeeService();
        

        [Route("Employee/SaveEmployee")]
        [HttpGet]
        public IActionResult SaveEmployee()
        {
            var employeeList = this._employeeService.SaveEmployee();
            return Ok(employeeList);
        }

        [Route("Employee/GetEmployee")]
        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employeeList = this._employeeService.GetEmployees();
            return Ok(employeeList);
        }

        [Route("Employee/GetEmployeeById")]
        [HttpGet]
        public IActionResult GetEmployeeById(int Id)
        {
            var employee = this._employeeService.GetEmployeeById(Id);
            return Ok(employee);
        }

        [Route("Employee/GetEmployeeByName")]
        [HttpGet]
        public IActionResult GetEmployeeByName(string Name)
        {
            var employee = this._employeeService.GetEmployeeByName(Name);
            return Ok(employee);
        }

        [Route("Employee/GetEmployeeByType")]
        [HttpGet]
        public IActionResult GetEmployeeByType(string Type)
        {
            var employee = this._employeeService.GetEmployeeByType(Type);
            return Ok(employee);
        }

    }
}
