using Common.Pagination;
using EmployeeManagement.Application.DataTransferObjects;

namespace EmployeeManagement.API.Endpoints.Employee;

public record GetEmployeesResponse(PaginatedResult<EmployeeDto> Employees);