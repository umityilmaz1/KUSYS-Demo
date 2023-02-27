using Microsoft.EntityFrameworkCore;
using Model.Base;
using Model.Entity;

namespace Repository.Context
{
    public class KUSYSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
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
            var addedEntries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added)).Cast<BaseEntity>();

            foreach (BaseEntity addedEntry in addedEntries)
            {
                addedEntry.CreatedDate = DateTime.Now;
            }
        }
        private void SetUpdateDateOfUpdatedEntries()
        {
            var updatedEntries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Modified)).Cast<BaseEntity>();

            foreach (BaseEntity updatedEntry in updatedEntries)
            {
                updatedEntry.UpdatedDate = DateTime.Now;
            }
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
