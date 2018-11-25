using Microsoft.EntityFrameworkCore;
using UnitOfWorkProject.Models;

namespace UnitOfWorkProject.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
    }
}