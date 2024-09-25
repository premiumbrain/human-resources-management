using AutoMapper;
using Common.Pagination;
using EmployeeManagement.API.Endpoints.Employee;
using EmployeeManagement.Application.Features.Employees.GetEmployees;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<GetEmployeesResponse>> Get([AsParameters] PaginationRequest request)
        {
            var result = await sender.Send(new GetEmployeesQuery(request));

            var response = mapper.Map<GetEmployeesResponse>(result);

            return Ok(response);
        }
    }
}
