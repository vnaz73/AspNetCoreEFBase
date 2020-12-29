using Microsoft.EntityFrameworkCore;
using System;

namespace AsptCodeFirst
{

    class Department

    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DOF { get; set; }

    }
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    class EFOrganazationDB: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Organization;Trusted_Connection=True;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //EFOrganazationDB efCntx = new EFOrganazationDB();
            //List<Department> deps = efCntx.Departments.ToList();

            //Department d = new Department()
            //{
            //    Description = "Development",
            //    Name = "Dev"
            //};

            //efCntx.Departments.Add(d);
            //efCntx.SaveChanges();
        }
    }
}
