using EmployeeManagement.Domain.Enums;

namespace EmployeeManagement.Application.DataTransferObjects
{
    public record EmployeeDto(Guid Id, DemographicInformationDto Information, ContactDto InitialContact, EmployeeStatus Status);
}
