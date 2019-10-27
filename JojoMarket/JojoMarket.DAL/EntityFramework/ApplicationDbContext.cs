using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JojoMarket.DAL.Entities;


namespace JojoMarket.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        

    }
}
