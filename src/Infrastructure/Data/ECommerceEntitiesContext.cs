using Microsoft.EntityFrameworkCore;
using Microsoft.eShopWeb.ApplicationCore.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Data
{
    public class ECommerceEntitiesContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPaymentMethod> CustomerPaymentMethods { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RefInvoiceStatusCode> RefInvoiceStatusCodes { get; set; }
        public DbSet<RefOrderItemStatusCode> RefOrderItemStatusCodes { get; set; }
        public DbSet<RefOrderStatusCode> RefOrderStatusCodes { get; set; }
        public DbSet<RefPaymentMethod> RefPaymentMethods { get; set; }
        public DbSet<RefProductType> RefProductTypes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }

       
        // we override the OnModelCreating method here.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentItem>()
                .HasKey(si => new { si.ShipmentId, si.OrderItemId });

            modelBuilder.Entity<ShipmentItem>()
                .HasOne(p => p.Shipment)
                .WithMany(b => b.ShipmentItems);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=ECommerceStoreDB;Integrated Security=True");
        }
    }
}
