using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model.Base;
using Model.Entity;

namespace Repository.Context
{
    public class KUSYSContext : DbContext
    {
        string _defaultConnectionStringName = "Default";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                          .AddJsonFile("appsettings.json")
                                                          .Build();

            var connectionString = configuration.GetConnectionString(_defaultConnectionStringName);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
        public override int SaveChanges()
        {
            SetCreateDateOfAddedEntries();
            SetUpdateDateOfUpdatedEntries();
            return base.SaveChanges();
        }

        private void SetCreateDateOfAddedEntries()
        {
            var addedEntries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added));

            foreach (var addedEntry in addedEntries)
            {
                addedEntry.CurrentValues[nameof(Student.CreatedDate)] = DateTime.Now;
            }
        }
        private void SetUpdateDateOfUpdatedEntries()
        {
            var updatedEntries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Modified));

            foreach (var updatedEntry in updatedEntries)
            {
                updatedEntry.CurrentValues[nameof(Student.UpdatedDate)] = DateTime.Now;
            }
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
