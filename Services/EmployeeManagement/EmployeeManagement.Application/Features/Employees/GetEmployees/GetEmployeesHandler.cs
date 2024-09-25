using AutoMapper;
using EmployeeManagement.Application.Data;
using EmployeeManagement.Application.DataTransferObjects;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Application.Features.Employees.GetEmployees;

public class GetEmployeesHandler(IApplicationDbContext dbContext, IMapper mapper) : IQueryHandler<GetEmployeesQuery, GetEmployeesResult>
{
    public async Task<GetEmployeesResult> Handle(GetEmployeesQuery query, CancellationToken cancellationToken)
    {
        var pageIndex = query.PaginationRequest.PageIndex;
        var pageSize = query.PaginationRequest.PageSize;

        var totalCount = await dbContext.Employees.LongCountAsync(cancellationToken);

        var employees = await dbContext.Employees
            .Include(e => e.Salaries)
            .OrderBy(e => e.Id.Value)
            .Skip(pageSize * pageIndex)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return new GetEmployeesResult(new PaginatedResult<EmployeeDto>(pageIndex, pageSize, totalCount,
            mapper.Map<IEnumerable<EmployeeDto>>(employees)));
    }
}