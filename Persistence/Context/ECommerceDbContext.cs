using Core.DataAccess;
using Core.Utilities.Hashing;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
        public ECommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartDetail> ShoppingCartDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User - Customer
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.UserType)
                .IsRequired();
                entity.HasOne(u => u.Customer)
                    .WithOne(c => c.User)
                    .HasForeignKey<Customer>(c => c.UserId);
            });

            // UserOperationClaim - User & OperationClaim
            modelBuilder.Entity<UserOperationClaim>(entity =>
            {
                entity.HasOne(uoc => uoc.User)
                    .WithMany(u => u.UserOperationClaims)
                    .HasForeignKey(uoc => uoc.UserId);

                entity.HasOne(uoc => uoc.OperationClaim)
                    .WithMany(oc => oc.UserOperationClaims)
                    .HasForeignKey(uoc => uoc.OperationClaimId);
            });

            // Customer - Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(o => o.Customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId);

                entity.HasOne(o => o.OrderStatus)
                    .WithMany(os => os.Orders)
                    .HasForeignKey(o => o.OrderStatusId);

                entity.HasOne(o => o.Payment)
                    .WithOne(p => p.Order)
                    .HasForeignKey<Payment>(o => o.OrderId);
            });

            // Customer - ProductReview
            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasOne(pr => pr.Customer)
                    .WithMany(c => c.ProductReviews)
                    .HasForeignKey(pr => pr.CustomerId);
            });

            // Customer - Favorite
            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasOne(f => f.Customer)
                    .WithMany(c => c.Favorites)
                    .HasForeignKey(f => f.CustomerId);

                entity.HasOne(f => f.Product)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(f => f.ProductId);
            });

            // Customer - ShoppingCart
            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasOne(sc => sc.Customer)
                    .WithOne(c => c.ShoppingCart)
                    .HasForeignKey<ShoppingCart>(sc => sc.CustomerId);
            });

            // Order - OrderDetail
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasOne(od => od.Order)
                    .WithMany(o => o.OrderDetails)
                    .HasForeignKey(od => od.OrderId);
            });

            // PaymentMethod - Payment
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasOne(p => p.PaymentMethod)
                    .WithMany(pm => pm.Payments)
                    .HasForeignKey(p => p.PaymentMethodId);
            });

            // Category - Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId);
            });

            // Product - ShoppingCartDetail
            modelBuilder.Entity<ShoppingCartDetail>(entity =>
            {
                entity.HasOne(scd => scd.Product)
                    .WithMany(p => p.ShoppingCartDetails)
                    .HasForeignKey(scd => scd.ProductId);

                entity.HasOne(scd => scd.ShoppingCart)
                    .WithMany(sc => sc.ShoppingCartDetails)
                    .HasForeignKey(scd => scd.ShoppingCartId);
            });

            // Global Query Filter for Soft Delete (IsDeleted)
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
           

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCartConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCartDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductReviewConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new UserOperationClaimConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            // Seed data for PaymentMethod
            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod { Id = 1, Name = "Credit Card", Description = "Kredi Kartı İle Ödeme" },
                new PaymentMethod { Id = 2, Name = "Wire Transfer/EFT", Description = "Havale/EFT İle Ödeme" },
                new PaymentMethod { Id = 3, Name = "Mobile Payment", Description = "Mobil Ödeme" },
                new PaymentMethod { Id = 4, Name = "Payment At Door", Description = "Kapıda Ödeme" }
            );

            // Seed data for OrderStatus
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, Name = "Pending", Description = "Beklemede" },
                new OrderStatus { Id = 2, Name = "Confirmed", Description = "Onaylandı" },
                new OrderStatus { Id = 3, Name = "Shipped", Description = "Kargoya Verildi" },
                new OrderStatus { Id = 4, Name = "Delivered", Description = "Teslim Edildi" },
                new OrderStatus { Id = 5, Name = "Cancelled", Description = "İptal Edildi" },
                new OrderStatus { Id = 6, Name = "Returned", Description = "İade Edildi" }
            );

            //password hash
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("string", out passwordHash, out passwordSalt);
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Entity>();

            foreach (var item in datas)
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
