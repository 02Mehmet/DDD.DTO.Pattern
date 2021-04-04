using Microsoft.EntityFrameworkCore;
using QLTEQ.Domain.Customers;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.Domain.Products;
using QLTEQ.DTOPattern.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.Infrastructure
{
    public class postgrecontext : DbContext
    {
        public postgrecontext(DbContextOptions<postgrecontext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Product1> Product1s { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OutboxMessage> OutboxMessages { get; set; }

        //public DbSet<InternalCommand> InternalCommands { get; set; }

        //public DbSet<SampleProject.Domain.Payments.Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseNpgsql("Server=127.0.0.1; port=5991; user id = postgres; password = 02Mehmet; database=QLTEQDB2; pooling = true");
            //}
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Address).Assembly);
        }
    }
}
