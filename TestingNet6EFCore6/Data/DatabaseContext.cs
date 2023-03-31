using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestingNet6EFCore6.Models;

namespace TestingNet6EFCore6.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        { }

        // Database Connection Config
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder()
            {
                DataSource = "C:\\Users\\cookc\\source\\repos\\TestingNet6EFCore6\\TestingNet6EFCore6\\Database.db"
            }.ToString();
            var connection = new SqliteConnection(connectionStringBuilder);
            options.UseSqlite(connection);
        }

        // Database Tables
        public DbSet<People> People { get; set; }
        public DbSet<ParentGroup> ParentGroups { get; set; }
        public DbSet<PeopleParentGroup> PeopleParentGroups { get; set; }

        // Additional FluentAPI Definitions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleParentGroup>()
                .HasKey(o => new { o.PersonId, o.ParentGroupId });
        }
    }
}
