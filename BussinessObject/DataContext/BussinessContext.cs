using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace BussinessObject.DataContext
{
    public class BussinessContext : DbContext
    {
        public BussinessContext() { }

        public BussinessContext(DbContextOptions<BussinessContext> options) : base(options) { }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("BangConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
