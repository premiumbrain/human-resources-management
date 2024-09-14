using EmployeeManagement.Domain.Abstractions;
using EmployeeManagement.Domain.Enums;
using EmployeeManagement.Domain.Events;
using EmployeeManagement.Domain.ValueObjects;

namespace EmployeeManagement.Domain.Models
{
    public class Employee : Aggregate<EmployeeId>
    {
        private readonly List<Salary> _salaries = new();
        public IReadOnlyList<Salary> Salaries => _salaries.AsReadOnly();
        public DemographicInformation Information { get; private set; } = default!;
        public Contact InitialContact { get; private set; } = default!;
        public EmployeeStatus Status { get; private set; } = EmployeeStatus.Suspended;

        public static Employee Create(EmployeeId id, DemographicInformation information, Contact initialContact)
        {
            var employee = new Employee
            {
                Id = id,
                Information = information,
                InitialContact = initialContact,
                Status = EmployeeStatus.Suspended
            };

            employee.AddDomainEvent(new EmployeeCreatedEvent(employee));

            return employee;
        }

        public void Update(DemographicInformation information, Contact initialContact)
        {
            Information = information;
            InitialContact = initialContact;

            AddDomainEvent(new EmployeeUpdatedEvent(this));
        }
    }
}
