using Microsoft.EntityFrameworkCore;

namespace WebAPI4.DAL
{
    public class MyCompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyCompanyDb;Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }

    }

}
