using Microsoft.EntityFrameworkCore;

namespace MYAZ303.Models
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }

    }
}
