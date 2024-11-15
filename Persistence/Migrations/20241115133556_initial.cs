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
                name: "OrderStatuses",
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
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
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
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
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
                    FinalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                name: "UserOperationClaims",
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
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    GuestInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusId1 = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId1",
                        column: x => x.OrderStatusId1,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id");
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
                name: "ShoppingBasket",
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
                    table.PrimaryKey("PK_ShoppingBasket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBasket_Customers_CustomerId",
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
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBasketDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingBasketId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBasketDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBasketDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingBasketId",
                        column: x => x.ShoppingBasketId,
                        principalTable: "ShoppingBasket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Tasarım Kupa, Tabak ve Çanaklar..", "Kitchen Products", null },
                    { 2, null, null, "Tasarım Ev Ürünleri", "Home Decor", null },
                    { 3, null, null, "Bahçe ve Dış Tasarım Ürümleri ", "OutDoor Decor", null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5063), null, "Admin", null },
                    { 2, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5078), null, "Customer", null },
                    { 3, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5087), null, "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Beklemede", "Pending", null },
                    { 2, null, null, "Onaylandı", "Confirmed", null },
                    { 3, null, null, "Kargoya Verildi", "Shipped", null },
                    { 4, null, null, "Teslim Edildi", "Delivered", null },
                    { 5, null, null, "İptal Edildi", "Cancelled", null },
                    { 6, null, null, "İade Edildi", "Returned", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
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
                    { 1, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(1688), null, "customer1@example.com", "+2vS9SiEjuEtdomA+E1iOw==", "Famela", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 }, "1234567890", null, 2 },
                    { 2, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(1865), null, "customer2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 }, "1234512345", null, 2 },
                    { 3, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(2046), null, "guest1@example.com", "XsKf4aJaXsFVtCmJtPLh9A==", "Male", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 }, "2568947898", null, 3 },
                    { 4, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(2218), null, "admin1@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 }, "1234512345", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BillingAddress", "CreatedDate", "DeletedDate", "ShippingAddress", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, "1234 Any St.", null, null, "1234 Any St.", null, 1 },
                    { 2, "4321 Ny St.", null, null, "4321 Ny St.", null, 2 },
                    { 3, "4321 Ny St.", null, null, "4321 Ny St.", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "FinalPrice", "ImageUrl", "Name", "Price", "StockQuantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Description", null, "https://images.pexels.com/photos/11020238/pexels-photo-11020238.jpeg", "Kupa", 500m, 10, null },
                    { 2, 2, null, null, "Description", null, "https://images.pexels.com/photos/6805518/pexels-photo-6805518.jpeg", "Vazo", 300m, 5, null },
                    { 3, 3, null, null, "Description", null, "https://images.pexels.com/photos/9130701/pexels-photo-9130701.jpeg", "Saksı", 500m, 25, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5298), null, 1, null, 4 },
                    { 2, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5311), null, 2, null, 1 },
                    { 3, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5319), null, 3, null, 3 },
                    { 4, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5326), null, 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "GuestInfo", "OrderDate", "OrderStatusId", "OrderStatusId1", "PaymentId", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, null, 1, null, 1, 1m, null },
                    { 2, null, 2, null, null, null, 2, null, 2, 2m, null },
                    { 3, null, 3, null, null, null, 3, null, 3, 3m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "ProductId", "Rating", "Review", "ReviewDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, 5, "Bu kupa harikaa! Çok kullanışlı..", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, 2, null, 2, 5, "Bu vazo harikaa! Evime çok güzel bir hava getirdi.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, 3, null, 3, 5, "Çok güzel bir saksı.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "ShoppingBasket",
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
                    { 2, null, null, 2, 200m, 2, 2, null },
                    { 3, null, null, 3, 500m, 3, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "OrderId", "PaymentDate", "PaymentMethodId", "PaymentStatus", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 500m, null, null, 1, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(3687), 1, 0, null },
                    { 2, 200m, null, null, 2, new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(3724), 2, 0, null },
                    { 3, 100.00m, null, null, 1, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(5570), 1, 1, null },
                    { 4, 200.00m, null, null, 2, new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(5574), 2, 2, null }
                });

            migrationBuilder.InsertData(
                table: "ShoppingBasketDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Price", "ProductId", "Quantity", "ShoppingBasketId", "UpdatedDate" },
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
                name: "IX_Favorites_CustomerId",
                table: "Favorites",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");

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
                name: "IX_Orders_OrderStatusId1",
                table: "Orders",
                column: "OrderStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
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
                name: "IX_ShoppingBasket_CustomerId",
                table: "ShoppingBasket",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBasketDetails_ProductId",
                table: "ShoppingBasketDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBasketDetails_ShoppingBasketId",
                table: "ShoppingBasketDetails",
                column: "ShoppingBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "ShoppingBasketDetails");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingBasket");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
