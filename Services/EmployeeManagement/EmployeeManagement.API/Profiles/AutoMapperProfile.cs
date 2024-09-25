using AutoMapper;
using EmployeeManagement.API.Endpoints.Employee;
using EmployeeManagement.Application.Features.Employees.GetEmployees;

namespace EmployeeManagement.API.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<GetEmployeesResult, GetEmployeesResponse>().ReverseMap();
    }
}