using Microsoft.EntityFrameworkCore;

namespace ApiProdutify.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product.Product> ProductsNew { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=products.db");
        base.OnConfiguring(optionsBuilder);
    }
} 