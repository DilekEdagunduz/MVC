using Microsoft.EntityFrameworkCore;

namespace MVCContext.Models.ORM
{
    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database =MVC_Context ; Trusted_Connection = True;");
        }

        public DbSet<Suppliers> Suppliers { get; set; }


        public DbSet<Products> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
