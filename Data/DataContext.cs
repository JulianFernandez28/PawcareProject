using Microsoft.EntityFrameworkCore;
using Pawcare.Models;

namespace Pawcare.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); ;
            modelBuilder.Entity<Dog>()
                .HasOne(d => d.Client)
                .WithMany(c => c.Dogs)
                .IsRequired(false);
        }

        public DbSet<Dog>? Dogs { get; set; }
        public DbSet<Cliente>? Clients { get; set; }
        public DbSet<Race>? Races { get; set; }
        public DbSet<Deworming>? Dewormings { get; set; }
        public DbSet<EsteticDates>? EsteticDates { get; set; }
        public DbSet<MedicalDate>? MedicalDates { get; set; }
        public DbSet<MedicalRecords>? MedicalRecords { get; set; }
        public DbSet<Reminders>? Reminders { get; set; }
        public DbSet<Vacinnes>? Vacinnes { get; set; }

    }
}
