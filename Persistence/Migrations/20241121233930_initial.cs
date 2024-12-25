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
                    { 1, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5980), null, "Admin", null },
                    { 2, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5987), null, "Customer", null },
                    { 3, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5991), null, "Guest", null }
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
                    { 1, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4256), null, "customer1@example.com", "+2vS9SiEjuEtdomA+E1iOw==", "Famela", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 }, "1234567890", null, 2 },
                    { 2, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4365), null, "customer2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 }, "1234512345", null, 2 },
                    { 3, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4478), null, "guest1@example.com", "XsKf4aJaXsFVtCmJtPLh9A==", "Male", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 }, "2568947898", null, 3 },
                    { 4, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4599), null, "admin1@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 }, "1234512345", null, 1 }
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
                    { 3, 3, null, null, "Description", null, "https://images.pexels.com/photos/9130701/pexels-photo-9130701.jpeg", "Saksı", 500m, 25, null },
                    { 4, 1, null, null, "Description", null, "https://websitedemos.net/ceramic-products-store-04/wp-content/uploads/sites/1413/2024/02/ceramic-cup-01-300x300.jpg", "Kupa", 350m, 55, null },
                    { 5, 2, null, null, "Description", null, "https://images.pexels.com/photos/29432556/pexels-photo-29432556/free-photo-of-masada-mumlu-mavi-vazoda-mor-cicekler.jpeg", "Vazo", 750m, 25, null },
                    { 6, 3, null, null, "Description", null, "https://images.pexels.com/photos/21273580/pexels-photo-21273580/free-photo-of-yapraklar-pencereler-camlar-bitkiler.jpeg", "Saksı", 550m, 85, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6073), null, 1, null, 4 },
                    { 2, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6079), null, 2, null, 1 },
                    { 3, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6082), null, 3, null, 3 },
                    { 4, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6085), null, 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "GuestInfo", "OrderDate", "OrderStatusId", "OrderStatusId1", "PaymentId", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, null, 1, null, 1, 1m, null },
                    { 2, null, 2, null, null, null, 2, null, 2, 2m, null },
                    { 3, null, 3, null, null, null, 3, null, 3, 3m, null },
                    { 4, null, 3, null, null, null, 3, null, 3, 8m, null },
                    { 5, null, 2, null, null, null, 3, null, 3, 28m, null },
                    { 6, null, 1, null, null, null, 3, null, 3, 18m, null }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "ProductId", "Rating", "Review", "ReviewDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, 5, "Bu kupa harikaa! Çok kullanışlı..", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, null, 2, null, 2, 5, "Bu vazo harikaa! Evime çok güzel bir hava getirdi.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, null, 3, null, 3, 5, "Çok güzel bir saksı.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, 3, null, 4, 4, "Çok güzel bir kupa ve kullanışlı.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, 3, null, 5, 5, "Çok güzel bir vazo ve çok şık durdu.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, 3, null, 5, 5, "Çok güzel bir saksı çiceklerimle çok uyumlu.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                    { 3, null, null, 3, 500m, 3, 3, null },
                    { 4, null, null, 4, 500m, 4, 3, null },
                    { 5, null, null, 5, 500m, 5, 3, null },
                    { 6, null, null, 6, 500m, 6, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "OrderId", "PaymentDate", "PaymentMethodId", "PaymentStatus", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 500m, null, null, 1, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5271), 1, 0, null },
                    { 2, 200m, null, null, 2, new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5289), 2, 0, null },
                    { 3, 100.00m, null, null, 1, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(6225), 1, 1, null },
                    { 4, 200.00m, null, null, 2, new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(6253), 2, 2, null }
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
