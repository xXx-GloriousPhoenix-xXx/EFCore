using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=WorkPlace;Database=EFLearn;Trusted_Connection=true;TrustServerCertificate=true;";
        public EFContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
