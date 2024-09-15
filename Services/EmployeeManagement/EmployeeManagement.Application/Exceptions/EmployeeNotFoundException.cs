using Common.Exceptions;

namespace EmployeeManagement.Application.Exceptions
{
    public class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(Guid id) : base("Employee", id)
        {
        }
    }
}
