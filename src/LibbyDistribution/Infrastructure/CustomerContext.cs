using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentIssue> EquipmentIssues { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RetailCustomer> RetailCustomers { get; set; }
        public DbSet<RetailOrder> RetailOrders { get; set; }
        public DbSet<RetailOrderDetail> RetailOrderDetails { get; set; }
        public DbSet<SalesAgent> SalesAgents { get; set; }
        public DbSet<WholesaleCustomer> WholesaleCustomers { get; set; }
        public DbSet<WholesaleOrder> WholesaleOrders { get; set; }
        public DbSet<WholesaleOrderDetail> WholesaleOrderDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WholesaleOrder>()
                .HasOne(w => w.WholesaleCustomer)
                .WithMany(m => m.MyWholesaleOrders)
                .OnDelete(DeleteBehavior.SetNull);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
