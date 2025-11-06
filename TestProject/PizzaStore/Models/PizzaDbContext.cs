using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Models
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions options) :base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}
