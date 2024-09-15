namespace EmployeeManagement.Application.DataTransferObjects
{
    public record ContactDto(string EmailAddress, string PhoneNumber, string AddressLine, string Country, string State, string ZipCode);
}
