using AutoMapper;
using EmployeeManagement.Application.DataTransferObjects;
using EmployeeManagement.Domain.Models;

namespace EmployeeManagement.Application.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<Salary, SalaryDto>().ReverseMap();
    }
}