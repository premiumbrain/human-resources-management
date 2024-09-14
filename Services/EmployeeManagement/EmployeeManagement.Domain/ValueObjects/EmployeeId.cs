namespace EmployeeManagement.Domain.ValueObjects
{
    public record EmployeeId
    {
        public Guid Value { get; }
        private EmployeeId(Guid value) => Value = value;

        public static EmployeeId From(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);

            if (value == Guid.Empty)
            {
                throw new Exception("EmployeeId cannot be empty");
            }

            return new EmployeeId(value);
        }
    }
}
