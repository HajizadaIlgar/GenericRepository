using GenericRepositoryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryAPI.DALs
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
