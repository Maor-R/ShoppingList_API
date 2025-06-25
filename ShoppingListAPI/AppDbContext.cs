 using ShoppingListAPI;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace EFCoreExample
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
 
        
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=(local);Database=EFShopingList;Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}