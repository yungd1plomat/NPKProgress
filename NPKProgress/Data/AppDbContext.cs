using Microsoft.EntityFrameworkCore;
using NPKProgress.Data.Configurations;
using NPKProgress.Models;

namespace NPKProgress.Data
{
    public class AppDbContext : DbContext
    {
        // Пациенты
        public DbSet<Patient> Patients { get; set; }

        // Посещения
        public DbSet<Attendance> Attendances { get; set; }

        // Диагнозы (из МКБ-10)
        public DbSet<Disease> Diseases { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new AttendanceConfiguration());
        }
    }
}
