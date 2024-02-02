using Microsoft.EntityFrameworkCore;
using viepedia_product_service.Models;

namespace viepedia_product_service.Data
{    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}
