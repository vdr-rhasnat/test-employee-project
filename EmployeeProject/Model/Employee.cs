using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Model
{
    public class Employee
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }
        public string Address { set; get; }
    }
}
