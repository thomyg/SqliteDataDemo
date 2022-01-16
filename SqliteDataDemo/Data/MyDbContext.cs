using Microsoft.EntityFrameworkCore;

namespace SqliteDataDemo.Data
{
    public class MyDbContext : DbContext
    {
        

        [GenerateUI]
        public DbSet<Car> Cars { get; set; }        
        public DbSet<Ship> Ships { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(GetCars());
            base.OnModelCreating(modelBuilder);
        }

        private List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car { Id = 1, Name = "Black Panter", Built = Convert.ToDateTime("1.1.1970"), Colour = "Black", PlateNumber = "G-BP-1" },
                new Car { Id = 2, Name = "Red Velvet", Built = Convert.ToDateTime("1.6.1990"), Colour = "Red", PlateNumber = "G-RV-1" }
            };
        }
    }
}
