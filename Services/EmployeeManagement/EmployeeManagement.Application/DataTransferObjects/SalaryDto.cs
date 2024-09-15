namespace EmployeeManagement.Application.DataTransferObjects
{
    public record SalaryDto(Guid Id, Guid EmployeeId, decimal GrossAmount, decimal NetAmount, string Month, string Year);
}
