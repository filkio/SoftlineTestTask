using Microsoft.EntityFrameworkCore;
using SoftlineTestTask.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftlineTestTask.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EmployeesDb;Trusted_Connection=True;");
        }
    }
}
