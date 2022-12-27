using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NPKProgress.Models;

namespace NPKProgress.Data.Configurations
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Patient)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.PatientId);

            builder.HasOne(x => x.Disease)
                .WithMany(x => x.Attendances)
                .HasForeignKey(x => x.Diagnosis);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(x => x.Diagnosis)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(x => x.PatientId)
                .HasMaxLength(36)
                .IsRequired();
        }
    }
}
