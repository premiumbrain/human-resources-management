using EmployeeManagement.Domain.Enums;
using EmployeeManagement.Domain.Models;
using EmployeeManagement.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasConversion(eId => eId.Value, dbId => EmployeeId.From(dbId));

            builder.HasMany(e => e.Salaries)
                .WithOne()
                .HasForeignKey(si => si.EmployeeId);

            builder.ComplexProperty(e => e.Information,
                ib =>
                {
                    ib.Property(i => i.FirstName)
                        .IsRequired();
                    ib.Property(i => i.LastName)
                        .IsRequired();
                    ib.Property(i => i.Nationality)
                        .IsRequired();
                    ib.Property(i => i.Gender)
                        .IsRequired();
                });

            builder.ComplexProperty(e => e.InitialContact,
                icb =>
                {
                    icb.Property(c => c.EmailAddress);
                    icb.Property(c => c.PhoneNumber);
                    icb.Property(c => c.AddressLine);
                    icb.Property(c => c.Country);
                    icb.Property(c => c.State);
                    icb.Property(c => c.ZipCode);
                });

            builder.Property(e => e.Status)
                .HasDefaultValue(EmployeeStatus.Suspended)
                .HasConversion(
                    s => s.ToString(),
                    dbStatus => (EmployeeStatus)Enum.Parse(typeof(EmployeeStatus), dbStatus));
        }
    }
}
