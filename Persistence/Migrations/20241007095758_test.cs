using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
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
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
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
                    { 1, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3738), null, "Admin", null },
                    { 2, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3744), null, "Customer", null },
                    { 3, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3747), null, "Guest", null }
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
                    { 5, null, null, "İptal Edildi", "Cancelled", null },
                    { 6, null, null, "İade Edildi", "Returned", null }
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
                    { 1, new DateTime(2024, 10, 7, 9, 57, 58, 39, DateTimeKind.Utc).AddTicks(2083), null, "customer1@example.com", "+2vS9SiEjuEtdomA+E1iOw==", "Famela", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 12, 190, 100, 234, 171, 145, 157, 103, 152, 216, 89, 178, 12, 137, 39, 237, 79, 57, 75, 181, 109, 124, 27, 76, 205, 76, 80, 83, 207, 60, 26, 124, 218, 186, 107, 210, 159, 173, 125, 220, 145, 29, 23, 87, 3, 124, 86, 62, 196, 162, 2, 12, 70, 26, 200, 31, 101, 232, 143, 110, 52, 20, 249, 155 }, new byte[] { 187, 54, 163, 136, 115, 220, 194, 157, 186, 205, 219, 92, 197, 226, 52, 137, 199, 192, 208, 182, 39, 191, 240, 215, 209, 200, 234, 109, 105, 217, 193, 39, 12, 246, 14, 202, 184, 94, 192, 108, 117, 13, 127, 152, 72, 24, 179, 236, 199, 174, 210, 11, 227, 132, 174, 169, 55, 164, 25, 38, 242, 48, 184, 131, 132, 220, 157, 6, 97, 85, 4, 190, 161, 9, 92, 201, 200, 86, 105, 234, 66, 55, 34, 110, 18, 142, 229, 230, 136, 223, 55, 152, 147, 182, 249, 85, 100, 30, 98, 57, 195, 237, 68, 101, 147, 209, 118, 70, 133, 184, 15, 9, 204, 102, 119, 13, 203, 239, 18, 236, 221, 109, 68, 253, 213, 108, 244, 1 }, "1234567890", null, 2 },
                    { 2, new DateTime(2024, 10, 7, 9, 57, 58, 39, DateTimeKind.Utc).AddTicks(2277), null, "customer2@example.com", "lx191yNB5UTgUeNqX1QIZQ==", "Male", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 12, 190, 100, 234, 171, 145, 157, 103, 152, 216, 89, 178, 12, 137, 39, 237, 79, 57, 75, 181, 109, 124, 27, 76, 205, 76, 80, 83, 207, 60, 26, 124, 218, 186, 107, 210, 159, 173, 125, 220, 145, 29, 23, 87, 3, 124, 86, 62, 196, 162, 2, 12, 70, 26, 200, 31, 101, 232, 143, 110, 52, 20, 249, 155 }, new byte[] { 187, 54, 163, 136, 115, 220, 194, 157, 186, 205, 219, 92, 197, 226, 52, 137, 199, 192, 208, 182, 39, 191, 240, 215, 209, 200, 234, 109, 105, 217, 193, 39, 12, 246, 14, 202, 184, 94, 192, 108, 117, 13, 127, 152, 72, 24, 179, 236, 199, 174, 210, 11, 227, 132, 174, 169, 55, 164, 25, 38, 242, 48, 184, 131, 132, 220, 157, 6, 97, 85, 4, 190, 161, 9, 92, 201, 200, 86, 105, 234, 66, 55, 34, 110, 18, 142, 229, 230, 136, 223, 55, 152, 147, 182, 249, 85, 100, 30, 98, 57, 195, 237, 68, 101, 147, 209, 118, 70, 133, 184, 15, 9, 204, 102, 119, 13, 203, 239, 18, 236, 221, 109, 68, 253, 213, 108, 244, 1 }, "1234512345", null, 2 },
                    { 3, new DateTime(2024, 10, 7, 9, 57, 58, 39, DateTimeKind.Utc).AddTicks(2395), null, "guest1@example.com", "XsKf4aJaXsFVtCmJtPLh9A==", "Male", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 12, 190, 100, 234, 171, 145, 157, 103, 152, 216, 89, 178, 12, 137, 39, 237, 79, 57, 75, 181, 109, 124, 27, 76, 205, 76, 80, 83, 207, 60, 26, 124, 218, 186, 107, 210, 159, 173, 125, 220, 145, 29, 23, 87, 3, 124, 86, 62, 196, 162, 2, 12, 70, 26, 200, 31, 101, 232, 143, 110, 52, 20, 249, 155 }, new byte[] { 187, 54, 163, 136, 115, 220, 194, 157, 186, 205, 219, 92, 197, 226, 52, 137, 199, 192, 208, 182, 39, 191, 240, 215, 209, 200, 234, 109, 105, 217, 193, 39, 12, 246, 14, 202, 184, 94, 192, 108, 117, 13, 127, 152, 72, 24, 179, 236, 199, 174, 210, 11, 227, 132, 174, 169, 55, 164, 25, 38, 242, 48, 184, 131, 132, 220, 157, 6, 97, 85, 4, 190, 161, 9, 92, 201, 200, 86, 105, 234, 66, 55, 34, 110, 18, 142, 229, 230, 136, 223, 55, 152, 147, 182, 249, 85, 100, 30, 98, 57, 195, 237, 68, 101, 147, 209, 118, 70, 133, 184, 15, 9, 204, 102, 119, 13, 203, 239, 18, 236, 221, 109, 68, 253, 213, 108, 244, 1 }, "2568947898", null, 3 },
                    { 99, new DateTime(2024, 10, 7, 9, 57, 58, 39, DateTimeKind.Utc).AddTicks(2501), null, "admin1@example.com", "aNbdnOzUNuGnMPCOxe7GbA==", "Male", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 12, 190, 100, 234, 171, 145, 157, 103, 152, 216, 89, 178, 12, 137, 39, 237, 79, 57, 75, 181, 109, 124, 27, 76, 205, 76, 80, 83, 207, 60, 26, 124, 218, 186, 107, 210, 159, 173, 125, 220, 145, 29, 23, 87, 3, 124, 86, 62, 196, 162, 2, 12, 70, 26, 200, 31, 101, 232, 143, 110, 52, 20, 249, 155 }, new byte[] { 187, 54, 163, 136, 115, 220, 194, 157, 186, 205, 219, 92, 197, 226, 52, 137, 199, 192, 208, 182, 39, 191, 240, 215, 209, 200, 234, 109, 105, 217, 193, 39, 12, 246, 14, 202, 184, 94, 192, 108, 117, 13, 127, 152, 72, 24, 179, 236, 199, 174, 210, 11, 227, 132, 174, 169, 55, 164, 25, 38, 242, 48, 184, 131, 132, 220, 157, 6, 97, 85, 4, 190, 161, 9, 92, 201, 200, 86, 105, 234, 66, 55, 34, 110, 18, 142, 229, 230, 136, 223, 55, 152, 147, 182, 249, 85, 100, 30, 98, 57, 195, 237, 68, 101, 147, 209, 118, 70, 133, 184, 15, 9, 204, 102, 119, 13, 203, 239, 18, 236, 221, 109, 68, 253, 213, 108, 244, 1 }, "1234512345", null, 1 }
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
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "FinalPrice", "ImageUrl", "Name", "Price", "StockQuantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Description", null, "https://images.pexels.com/photos/4938197/pexels-photo-4938197.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Eyeliner", 500m, 10, null },
                    { 2, 2, null, null, "Description", null, "https://images.pexels.com/photos/9748717/pexels-photo-9748717.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "C Vitaminli Krem", 300m, 5, null }
                });

            migrationBuilder.InsertData(
                table: "UserOperations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3877), null, 1, null, 99 },
                    { 2, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3883), null, 2, null, 1 },
                    { 3, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3887), null, 3, null, 3 },
                    { 4, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3891), null, 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "OrderDate", "OrderStatusId", "PaymentId", "ProductId", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, 1, 1, null, 1m, null },
                    { 2, null, 2, null, null, 2, 2, null, 2m, null }
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
                    { 1, 500m, null, null, 1, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3446), 1, null },
                    { 2, 200m, null, null, 2, new DateTime(2024, 10, 7, 12, 57, 58, 39, DateTimeKind.Local).AddTicks(3465), 2, null }
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
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

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
                name: "Favorites");

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
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
