using System;
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
                    { 1, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6230), null, "Admin", null },
                    { 2, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6240), null, "Customer", null },
                    { 3, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6246), null, "Guest", null }
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
                    { 1, new DateTime(2024, 9, 24, 7, 33, 23, 202, DateTimeKind.Utc).AddTicks(4048), null, "customer1@example.com", "+2vS9SiEjuEtdomA+E1iOw==", "Famela", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 245, 174, 146, 235, 25, 13, 17, 27, 140, 195, 153, 106, 61, 144, 181, 158, 59, 119, 210, 15, 88, 33, 51, 196, 0, 244, 240, 241, 25, 206, 164, 92, 91, 33, 27, 146, 235, 119, 145, 84, 172, 222, 119, 47, 44, 30, 114, 74, 89, 181, 123, 153, 19, 78, 2, 211, 9, 115, 175, 66, 31, 87, 130, 21 }, new byte[] { 87, 20, 76, 43, 151, 224, 7, 156, 7, 220, 63, 15, 51, 248, 128, 245, 149, 27, 167, 215, 167, 78, 136, 19, 73, 199, 101, 241, 117, 152, 104, 13, 209, 230, 235, 148, 165, 21, 157, 241, 37, 182, 221, 12, 198, 163, 34, 141, 155, 169, 214, 153, 115, 122, 96, 47, 235, 138, 49, 223, 29, 250, 92, 229, 76, 101, 15, 183, 174, 168, 224, 59, 100, 7, 49, 42, 145, 6, 131, 42, 210, 25, 127, 194, 95, 80, 143, 142, 100, 83, 27, 203, 0, 204, 220, 198, 81, 29, 158, 4, 24, 59, 169, 101, 193, 160, 86, 205, 201, 159, 165, 46, 187, 100, 185, 84, 252, 12, 6, 46, 255, 64, 14, 118, 211, 185, 125, 159 }, "1234567890", null, 2 },
                    { 2, new DateTime(2024, 9, 24, 7, 33, 23, 202, DateTimeKind.Utc).AddTicks(4298), null, "customer2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 245, 174, 146, 235, 25, 13, 17, 27, 140, 195, 153, 106, 61, 144, 181, 158, 59, 119, 210, 15, 88, 33, 51, 196, 0, 244, 240, 241, 25, 206, 164, 92, 91, 33, 27, 146, 235, 119, 145, 84, 172, 222, 119, 47, 44, 30, 114, 74, 89, 181, 123, 153, 19, 78, 2, 211, 9, 115, 175, 66, 31, 87, 130, 21 }, new byte[] { 87, 20, 76, 43, 151, 224, 7, 156, 7, 220, 63, 15, 51, 248, 128, 245, 149, 27, 167, 215, 167, 78, 136, 19, 73, 199, 101, 241, 117, 152, 104, 13, 209, 230, 235, 148, 165, 21, 157, 241, 37, 182, 221, 12, 198, 163, 34, 141, 155, 169, 214, 153, 115, 122, 96, 47, 235, 138, 49, 223, 29, 250, 92, 229, 76, 101, 15, 183, 174, 168, 224, 59, 100, 7, 49, 42, 145, 6, 131, 42, 210, 25, 127, 194, 95, 80, 143, 142, 100, 83, 27, 203, 0, 204, 220, 198, 81, 29, 158, 4, 24, 59, 169, 101, 193, 160, 86, 205, 201, 159, 165, 46, 187, 100, 185, 84, 252, 12, 6, 46, 255, 64, 14, 118, 211, 185, 125, 159 }, "1234512345", null, 2 },
                    { 3, new DateTime(2024, 9, 24, 7, 33, 23, 202, DateTimeKind.Utc).AddTicks(4476), null, "guest1@example.com", "XsKf4aJaXsFVtCmJtPLh9A==", "Male", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 245, 174, 146, 235, 25, 13, 17, 27, 140, 195, 153, 106, 61, 144, 181, 158, 59, 119, 210, 15, 88, 33, 51, 196, 0, 244, 240, 241, 25, 206, 164, 92, 91, 33, 27, 146, 235, 119, 145, 84, 172, 222, 119, 47, 44, 30, 114, 74, 89, 181, 123, 153, 19, 78, 2, 211, 9, 115, 175, 66, 31, 87, 130, 21 }, new byte[] { 87, 20, 76, 43, 151, 224, 7, 156, 7, 220, 63, 15, 51, 248, 128, 245, 149, 27, 167, 215, 167, 78, 136, 19, 73, 199, 101, 241, 117, 152, 104, 13, 209, 230, 235, 148, 165, 21, 157, 241, 37, 182, 221, 12, 198, 163, 34, 141, 155, 169, 214, 153, 115, 122, 96, 47, 235, 138, 49, 223, 29, 250, 92, 229, 76, 101, 15, 183, 174, 168, 224, 59, 100, 7, 49, 42, 145, 6, 131, 42, 210, 25, 127, 194, 95, 80, 143, 142, 100, 83, 27, 203, 0, 204, 220, 198, 81, 29, 158, 4, 24, 59, 169, 101, 193, 160, 86, 205, 201, 159, 165, 46, 187, 100, 185, 84, 252, 12, 6, 46, 255, 64, 14, 118, 211, 185, 125, 159 }, "2568947898", null, 3 },
                    { 99, new DateTime(2024, 9, 24, 7, 33, 23, 202, DateTimeKind.Utc).AddTicks(4610), null, "admin1@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 245, 174, 146, 235, 25, 13, 17, 27, 140, 195, 153, 106, 61, 144, 181, 158, 59, 119, 210, 15, 88, 33, 51, 196, 0, 244, 240, 241, 25, 206, 164, 92, 91, 33, 27, 146, 235, 119, 145, 84, 172, 222, 119, 47, 44, 30, 114, 74, 89, 181, 123, 153, 19, 78, 2, 211, 9, 115, 175, 66, 31, 87, 130, 21 }, new byte[] { 87, 20, 76, 43, 151, 224, 7, 156, 7, 220, 63, 15, 51, 248, 128, 245, 149, 27, 167, 215, 167, 78, 136, 19, 73, 199, 101, 241, 117, 152, 104, 13, 209, 230, 235, 148, 165, 21, 157, 241, 37, 182, 221, 12, 198, 163, 34, 141, 155, 169, 214, 153, 115, 122, 96, 47, 235, 138, 49, 223, 29, 250, 92, 229, 76, 101, 15, 183, 174, 168, 224, 59, 100, 7, 49, 42, 145, 6, 131, 42, 210, 25, 127, 194, 95, 80, 143, 142, 100, 83, 27, 203, 0, 204, 220, 198, 81, 29, 158, 4, 24, 59, 169, 101, 193, 160, 86, 205, 201, 159, 165, 46, 187, 100, 185, 84, 252, 12, 6, 46, 255, 64, 14, 118, 211, 185, 125, 159 }, "1234512345", null, 1 }
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
                    { 1, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6390), null, 1, null, 99 },
                    { 2, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6398), null, 2, null, 1 },
                    { 3, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6403), null, 3, null, 3 },
                    { 4, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(6409), null, 3, null, 2 }
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
                    { 1, 500m, null, null, 1, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(5597), 1, null },
                    { 2, 200m, null, null, 2, new DateTime(2024, 9, 24, 10, 33, 23, 202, DateTimeKind.Local).AddTicks(5664), 2, null }
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
