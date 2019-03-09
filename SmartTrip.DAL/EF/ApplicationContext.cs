using Microsoft.EntityFrameworkCore;

using SmartTrip.DAL.Entities;

namespace SmartTrip.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected internal DbSet<User> Users { get; set; }
        protected internal DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnRoleCreating(modelBuilder);
            OnUserCreating(modelBuilder);
        }

        private void OnRoleCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Role>().HasMany<User>();
        }
        private void OnUserCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasOne<Role>();
        }
    }
}
