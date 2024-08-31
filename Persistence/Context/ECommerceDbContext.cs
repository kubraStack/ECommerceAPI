using Core.DataAccess;
using Core.Utilities.Hashing;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.SeedData.BaseUserConfiguration;
using Persistence.SeedData.Category;
using Persistence.SeedData.OperationClaim;
using Persistence.SeedData.Order;
using Persistence.SeedData.Payment;
using Persistence.SeedData.Product;
using Persistence.SeedData.ShoppingCart;
using Persistence.SeedData.User;
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
            //Category
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products) // Bir Kategori - Çok Ürün
                .WithOne(p => p.Category) 
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); //Kategori silindiğinde, ilişkili ürünlerde silinir.

            // Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(p => p.Category)
                .WithMany(c => c.Products) //Bir ürün bir kategori
                .HasForeignKey(p => p.CategoryId); // Ürünler bir kategoriye ait olmalı.

                entity.HasMany(p => p.ProductReviews)
                .WithOne(pr => pr.Product)
                .HasForeignKey(pr => pr.ProductId);
            });

            //ProductReview
            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasOne(pr => pr.Customer)
                .WithMany(c => c.ProductReviews)
                .HasForeignKey(pr => pr.CustomerId);    

                entity.HasOne(pr => pr.Product)
                .WithMany(p => p.ProductReviews)
                .HasForeignKey(pr => pr.ProductId);
            });

            //Customer

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.Id);


                entity.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

                entity.HasMany(c => c.ProductReviews)
                .WithOne(pr => pr.Customer)
                .HasForeignKey(pr => pr.CustomerId);
                
            });

            //Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.OrderStatus)
                .WithMany()
                .HasForeignKey(o => o.OrderStatusId);

                entity.HasMany(o => o.Payments)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId);

                entity.HasMany(o => o.OrderDetail)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId);
            });

            //OrderStatus


            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new  CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCartConfiguration());   
            modelBuilder.ApplyConfiguration(new ShoppingCartDetailConfiguration()); 
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductReviewConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BaseUserConfiguration());

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

            //password hash
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("string", out passwordHash, out passwordSalt);
        }


        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //Entities için CreatedDate ve UpdatedDate zaman damgalarının otomatik ayarlanması
            var dates = ChangeTracker.Entries<Entity>();
            foreach (var item in dates)
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdatedDate = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        
    }
}
