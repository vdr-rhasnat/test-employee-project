using EmployeeProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public string EmployeeDbPath { get; private set; }

        public EmployeeDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            //EmployeeDbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}Employee.db";
            EmployeeDbPath = "D:/db/Employee.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={EmployeeDbPath}");
    }
}
