﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperations_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartDetail_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Kozmetik ürünleri kategorisi", "Kozmetik", null },
                    { 2, null, null, "Cilt bakım ürünleri kategorisi", "Cilt Bakım", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7163), null, "Admin", null },
                    { 2, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7171), null, "Customer", null },
                    { 3, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7219), null, "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Beklemede", "Pending", null },
                    { 2, null, null, "Onaylandı", "Confirmed", null },
                    { 3, null, null, "Kargoya Verildi", "Shipped", null },
                    { 4, null, null, "Teslim Edildi", "Delivered", null },
                    { 5, null, null, "İptal Edildi", "Cancelled", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Kredi Kartı İle Ödeme", "Credit Card", null },
                    { 2, null, null, "Havale/EFT İle Ödeme", "Wire Transfer/EFT", null },
                    { 3, null, null, "Mobil Ödeme", "Mobile Payment", null },
                    { 4, null, null, "Kapıda Ödeme", "Payment At Door", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "Gender", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "UpdatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5341), null, "customer1@example.com", "+2vS9SiEjuEtdomA+E1iOw==", "Famela", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 }, "1234567890", null, 2 },
                    { 2, new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5504), null, "customer2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 }, "1234512345", null, 2 },
                    { 3, new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5610), null, "guest1@example.com", "XsKf4aJaXsFVtCmJtPLh9A==", "Male", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 }, "2568947898", null, 3 },
                    { 99, new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5767), null, "admin1@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 }, "1234512345", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BillingAddress", "CreatedDate", "DeletedDate", "ShippingAddress", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "1234 Any St.", null, null, "1234 Any St.", null, 1 },
                    { 2, "4321 Ny St.", null, null, "4321 Ny St.", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Description", "https://images.pexels.com/photos/4938197/pexels-photo-4938197.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Eyeliner", 500m, 10, null },
                    { 2, 2, null, null, "Description", "https://images.pexels.com/photos/9748717/pexels-photo-9748717.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "C Vitaminli Krem", 300m, 5, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7418), null, 1, null, 99 },
                    { 2, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7424), null, 2, null, 1 },
                    { 3, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7429), null, 3, null, 3 },
                    { 4, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7433), null, 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "OrderDate", "OrderDetailId", "OrderStatusId", "PaymentId", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 1, 0m, null },
                    { 2, null, 2, null, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 2, 7m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "ProductId", "Rating", "Review", "ReviewDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, 5, "Bu eyeliner harikaa!", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, 2, null, 2, 5, "Bu ruj harikaa!", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, null },
                    { 2, null, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OrderId", "Price", "ProductId", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, 1, 100m, 1, 1, null },
                    { 2, null, null, 2, 200m, 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "OrderId", "PaymentDate", "PaymentMethodId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 500m, null, null, 1, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(6571), 1, null },
                    { 2, 200m, null, null, 2, new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(6593), 2, null }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCartDetail",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Price", "ProductId", "Quantity", "ShoppingCartId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, 500.0, 1, 1, 1, null },
                    { 2, null, null, 300.0, 2, 2, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_CustomerId",
                table: "ProductReviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartDetail_ProductId",
                table: "ShoppingCartDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartDetail_ShoppingCartId",
                table: "ShoppingCartDetail",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_CustomerId",
                table: "ShoppingCarts",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserOperations_OperationClaimId",
                table: "UserOperations",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperations_UserId",
                table: "UserOperations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "ShoppingCartDetail");

            migrationBuilder.DropTable(
                name: "UserOperations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}