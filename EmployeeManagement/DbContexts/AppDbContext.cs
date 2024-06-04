using EmployeeManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}