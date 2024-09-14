using EmployeeManagement.Domain.Abstractions;
using EmployeeManagement.Domain.Models;

namespace EmployeeManagement.Domain.Events
{
    public record EmployeeCreatedEvent(Employee Employee) : IDomainEvent;
}
