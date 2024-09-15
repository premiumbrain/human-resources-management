using EmployeeManagement.Domain.Models;
using EmployeeManagement.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Infrastructure.Data.Configurations
{
    public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasConversion(sId => sId.Value, dbId => SalaryId.From(dbId));

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(s => s.EmployeeId);

            builder.Property(s => s.GrossAmount).IsRequired();
            builder.Property(s => s.NetAmount).IsRequired();
            builder.Property(s => s.Month).IsRequired();
            builder.Property(s => s.Year).IsRequired();
        }
    }
}
