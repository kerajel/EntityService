using EntityWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityWeb.DatabaseContext
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options) { }
        public DbSet<Entity> Entities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>().HasKey(c => c.Id);
        }
    }
}
