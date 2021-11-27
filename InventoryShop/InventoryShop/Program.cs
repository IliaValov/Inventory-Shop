using System.Configuration;
using InventoryShop.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace InventoryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new NpgsqlConnection(ConfigurationManager.AppSettings["ConnectionStrings:DefaultConnection"]);

            var options = new DbContextOptionsBuilder<InventoryShopDbContext>()
                 .UseNpgsql(connection)
                 .Options;

            //using(var dbContext = new InventoryShopDbContext(options))
            //{

            //}
        }
    }
}
