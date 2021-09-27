using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje
{
    public class DBInteractor : DbContext
    {
        public DBInteractor()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //           optionsBuilder.UseSqlite(@"Data Source = Proje.db;");
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Proje.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Proje.Models.User> User { get; set; }

    }
}

