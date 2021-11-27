using InventoryShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryShop.Data
{
    public class InventoryShopDbContext : DbContext
    {
        //public InventoryShopDbContext(DbContextOptions options) : base(options)
        //{
        //}

        //protected InventoryShopDbContext()
        //{
        //}

        public DbSet<Item> Items { get; set; }

        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<ShopItemPrice> ShopItemPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5433;User Id=postgres;Password=Parola123;Database=InventoryShopDb;");
        }
    }
}
