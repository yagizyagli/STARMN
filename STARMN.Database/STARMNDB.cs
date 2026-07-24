using Microsoft.EntityFrameworkCore;
using STARMN.Database.Entities;

namespace STARMN.Database
{
    public class STARMNDB:DbContext
    {
        public STARMNDB(DbContextOptions<STARMNDB> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Basket> Basket { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


    }
}
