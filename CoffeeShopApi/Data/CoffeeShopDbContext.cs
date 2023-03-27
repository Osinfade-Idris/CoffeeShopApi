using CoffeeShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopApi.Data
{
    public class CoffeeShopDbContext:DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext>options):base(options)
        {
            
        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
