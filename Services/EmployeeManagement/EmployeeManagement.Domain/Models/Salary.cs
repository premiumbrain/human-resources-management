using EmployeeManagement.Domain.Abstractions;
using EmployeeManagement.Domain.ValueObjects;

namespace EmployeeManagement.Domain.Models
{
    public class Salary : Entity<SalaryId>
    {
        public EmployeeId EmployeeId { get; private set; } = default!;
        public decimal GrossAmount { get; private set; } = default!;
        public decimal NetAmount { get; private set; } = default!;
        public string Month { get; private set; } = default!;
        public string Year { get; private set; } = default!;
        
        internal Salary(EmployeeId employeeId, decimal grossAmount, decimal netAmount, string month, string year)
        {
            Id = SalaryId.From(Guid.NewGuid());
            EmployeeId = employeeId;
            GrossAmount = grossAmount;
            NetAmount = netAmount;
            Month = month;
            Year = year;
        }
    }
}
