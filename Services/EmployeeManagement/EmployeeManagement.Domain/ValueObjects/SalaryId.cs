namespace EmployeeManagement.Domain.ValueObjects
{
    public record SalaryId
    {
        public Guid Value { get; }
        private SalaryId(Guid value) => Value = value;

        public static SalaryId From(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);

            if (value == Guid.Empty)
            {
                throw new Exception("SalaryId cannot be empty");
            }

            return new SalaryId(value);
        }
    }
}
