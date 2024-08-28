using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperations { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //OrderStatus tablosuna durumları ekleniyor.
            modelBuilder.Entity<OrderStatus>().HasData(
                //seed data
                new OrderStatus { Id = 1, Name = "Pending", Description = "Beklemede"},
                new OrderStatus { Id = 2, Name = "Confirmed", Description = "Onaylandı"},
                new OrderStatus { Id = 3, Name = "Shipped", Description = "Kargoya Verildi" },
                new OrderStatus { Id = 4, Name = "Delivered", Description = "Teslim Edildi" },
                new OrderStatus { Id = 5, Name = "Cancelled", Description = "İptal Edildi" }
            );
            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, Name = "Credit Card", Description = "Kredi Kartı İle Ödeme"},
                new PaymentMethod { Id = 2, Name = "Wire Transfer/EFT", Description = "Havale/EFT İle Ödeme"},
                new PaymentMethod { Id = 3, Name = "Mobile Payment", Description = "Mobil Ödeme"},
                new PaymentMethod { Id = 4, Name = "Payment At Door", Description = "Kapıda Ödeme"}
            );
        }

        
    }
}
