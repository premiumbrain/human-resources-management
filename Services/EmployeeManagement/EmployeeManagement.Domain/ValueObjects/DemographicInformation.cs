namespace EmployeeManagement.Domain.ValueObjects
{
    public record DemographicInformation
    {
        public string FirstName { get; } = default!;
        public string LastName { get; } = default!;
        public string Nationality { get; } = default!;
        public string Gender { get; } = default!;

        protected DemographicInformation(string firstName, string lastName, string nationality, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            Gender = gender;
        }

        public static DemographicInformation From(string firstName, string lastName, string nationality, string gender)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(nationality);
            ArgumentException.ThrowIfNullOrWhiteSpace(gender);

            return new DemographicInformation(firstName, lastName, nationality, gender);
        }
    }
}
