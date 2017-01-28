using System.Linq;
using Core.Startup.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core.Startup.Data
{
    public class StartupDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public StartupDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

             modelBuilder.Entity<Todo>()
                .ToTable("Todo");
           
        }
    }
}
