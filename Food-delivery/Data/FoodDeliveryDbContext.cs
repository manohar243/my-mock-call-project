using Food_delivery.Models; // Assuming FoodPost is in this namespace
using Food_delivery.Models.Domain;
using Microsoft.EntityFrameworkCore; // Required for DbContext and DbSet

namespace Food_delivery.Data
{
    public class FoodDeliveryDbContext : DbContext
    {
        public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options)
            : base(options)
        {
        }

        public DbSet<FoodPost> FoodPosts { get; set; } = null!;
    }
}
