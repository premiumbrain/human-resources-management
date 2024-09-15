using EmployeeManagement.Application.Data;
using EmployeeManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmployeeManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Salary> Salaries => Set<Salary>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
