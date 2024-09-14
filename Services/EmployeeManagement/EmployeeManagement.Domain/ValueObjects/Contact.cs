namespace EmployeeManagement.Domain.ValueObjects
{
    public record Contact
    {
        public string EmailAddress { get; } = default!;
        public string? PhoneNumber { get; } = default!;
        public string? AddressLine { get; } = default!;
        public string? Country { get; } = default!;
        public string? State { get; } = default!;
        public string? ZipCode { get; } = default!;

        protected Contact(string emailAddress, string phoneNumber, string addressLine, string country, string state, string zipCode)
        {
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            AddressLine = addressLine;
            Country = country;
            State = state;
            ZipCode = zipCode;
        }

        public static Contact From(string emailAddress, string phoneNumber, string addressLine, string country, string state, string zipCode)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(emailAddress);

            return new Contact(emailAddress, phoneNumber, addressLine, country, state, zipCode);
        }
    }
}
