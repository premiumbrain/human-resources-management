using EmployeeManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; }
        DbSet<Salary> Salaries { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
