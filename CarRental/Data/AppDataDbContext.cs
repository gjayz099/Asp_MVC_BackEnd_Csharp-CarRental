using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data
{
    public class AppDataDbContext : DbContext
    {
        public AppDataDbContext(DbContextOptions<AppDataDbContext> options)
            : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
