using Microsoft.EntityFrameworkCore;

namespace SpiceRack.EntityFrameworkCore.Repository
{
    public class DatabaseContext : DbContext
    {
        public string DefaultConnectionStringName { get; set; }
        public string ConnectionString { get; set; }

        public DatabaseContext()
        {
            DefaultConnectionStringName = "DatabaseContext";
        }

        public DatabaseContext(string defautConnectionStringName,string connectionString = "")
        {
            DefaultConnectionStringName = defautConnectionStringName;

            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            else
            {
                optionsBuilder.UseSqlServer(new ConnectionStringManager().Get(DefaultConnectionStringName));
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual void SeedProductionData()
        {
        }

        public virtual void SeedDebugData()
        {
        }
    }
}