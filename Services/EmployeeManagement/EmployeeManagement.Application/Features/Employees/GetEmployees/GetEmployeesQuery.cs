
using EmployeeManagement.Application.DataTransferObjects;

namespace EmployeeManagement.Application.Features.Employees.GetEmployees;

public record GetEmployeesQuery(PaginationRequest PaginationRequest) : IQuery<GetEmployeesResult>;

public record GetEmployeesResult(PaginatedResult<EmployeeDto> Employees);