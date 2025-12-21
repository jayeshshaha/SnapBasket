using API.Entities;
using Microsoft.EntityFrameworkCore;
namespace API.Data;

public class StoreContext(DbContextOptions<StoreContext> dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Product> Products { get; set; }
}