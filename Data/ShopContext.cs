using Microsoft.EntityFrameworkCore;
using dokon.Models;

namespace dokon.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
