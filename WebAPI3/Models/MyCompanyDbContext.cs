using Microsoft.EntityFrameworkCore;

namespace WebAPI3.Models
{
    public class MyCompanyDbContext : DbContext
    {
        //connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=TechCareerDb; trusted_connection=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
