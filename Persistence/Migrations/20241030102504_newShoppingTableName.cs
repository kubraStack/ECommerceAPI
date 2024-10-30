using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newShoppingTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "ShoppingCartDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingBasket");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_CustomerId",
                table: "ShoppingBasket",
                newName: "IX_ShoppingBasket_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingBasket",
                table: "ShoppingBasket",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ShoppingBasketDetails",
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
                    table.PrimaryKey("PK_ShoppingBasketDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingBasketDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingBasket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.InsertData(
                table: "ShoppingBasketDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Price", "ProductId", "Quantity", "ShoppingCartId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, 500.0, 1, 1, 1, null },
                    { 2, null, null, 300.0, 2, 2, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 25, 3, 808, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(2154), new byte[] { 122, 202, 214, 49, 188, 49, 93, 184, 112, 137, 90, 238, 36, 246, 203, 111, 243, 183, 191, 118, 8, 6, 169, 241, 108, 110, 113, 166, 48, 40, 172, 177, 175, 189, 197, 168, 13, 194, 56, 119, 143, 43, 87, 166, 200, 51, 166, 63, 149, 2, 142, 152, 58, 106, 199, 202, 44, 113, 57, 16, 17, 200, 102, 154 }, new byte[] { 104, 6, 0, 143, 46, 160, 136, 196, 182, 214, 102, 159, 213, 216, 169, 239, 34, 66, 89, 162, 51, 25, 118, 169, 59, 120, 129, 85, 97, 137, 225, 209, 188, 221, 183, 93, 176, 106, 83, 96, 244, 89, 250, 159, 188, 161, 44, 202, 78, 35, 31, 25, 60, 150, 95, 9, 142, 193, 130, 58, 59, 72, 169, 33, 148, 116, 110, 50, 181, 112, 155, 77, 63, 236, 152, 67, 19, 198, 34, 75, 219, 87, 189, 175, 163, 115, 253, 91, 8, 238, 55, 74, 93, 171, 125, 255, 1, 53, 16, 82, 192, 106, 170, 59, 163, 225, 196, 88, 207, 79, 21, 199, 150, 18, 99, 215, 208, 71, 212, 147, 237, 101, 33, 215, 231, 237, 124, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(2309), new byte[] { 122, 202, 214, 49, 188, 49, 93, 184, 112, 137, 90, 238, 36, 246, 203, 111, 243, 183, 191, 118, 8, 6, 169, 241, 108, 110, 113, 166, 48, 40, 172, 177, 175, 189, 197, 168, 13, 194, 56, 119, 143, 43, 87, 166, 200, 51, 166, 63, 149, 2, 142, 152, 58, 106, 199, 202, 44, 113, 57, 16, 17, 200, 102, 154 }, new byte[] { 104, 6, 0, 143, 46, 160, 136, 196, 182, 214, 102, 159, 213, 216, 169, 239, 34, 66, 89, 162, 51, 25, 118, 169, 59, 120, 129, 85, 97, 137, 225, 209, 188, 221, 183, 93, 176, 106, 83, 96, 244, 89, 250, 159, 188, 161, 44, 202, 78, 35, 31, 25, 60, 150, 95, 9, 142, 193, 130, 58, 59, 72, 169, 33, 148, 116, 110, 50, 181, 112, 155, 77, 63, 236, 152, 67, 19, 198, 34, 75, 219, 87, 189, 175, 163, 115, 253, 91, 8, 238, 55, 74, 93, 171, 125, 255, 1, 53, 16, 82, 192, 106, 170, 59, 163, 225, 196, 88, 207, 79, 21, 199, 150, 18, 99, 215, 208, 71, 212, 147, 237, 101, 33, 215, 231, 237, 124, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(2429), new byte[] { 122, 202, 214, 49, 188, 49, 93, 184, 112, 137, 90, 238, 36, 246, 203, 111, 243, 183, 191, 118, 8, 6, 169, 241, 108, 110, 113, 166, 48, 40, 172, 177, 175, 189, 197, 168, 13, 194, 56, 119, 143, 43, 87, 166, 200, 51, 166, 63, 149, 2, 142, 152, 58, 106, 199, 202, 44, 113, 57, 16, 17, 200, 102, 154 }, new byte[] { 104, 6, 0, 143, 46, 160, 136, 196, 182, 214, 102, 159, 213, 216, 169, 239, 34, 66, 89, 162, 51, 25, 118, 169, 59, 120, 129, 85, 97, 137, 225, 209, 188, 221, 183, 93, 176, 106, 83, 96, 244, 89, 250, 159, 188, 161, 44, 202, 78, 35, 31, 25, 60, 150, 95, 9, 142, 193, 130, 58, 59, 72, 169, 33, 148, 116, 110, 50, 181, 112, 155, 77, 63, 236, 152, 67, 19, 198, 34, 75, 219, 87, 189, 175, 163, 115, 253, 91, 8, 238, 55, 74, 93, 171, 125, 255, 1, 53, 16, 82, 192, 106, 170, 59, 163, 225, 196, 88, 207, 79, 21, 199, 150, 18, 99, 215, 208, 71, 212, 147, 237, 101, 33, 215, 231, 237, 124, 163 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 25, 3, 808, DateTimeKind.Utc).AddTicks(2563), new byte[] { 122, 202, 214, 49, 188, 49, 93, 184, 112, 137, 90, 238, 36, 246, 203, 111, 243, 183, 191, 118, 8, 6, 169, 241, 108, 110, 113, 166, 48, 40, 172, 177, 175, 189, 197, 168, 13, 194, 56, 119, 143, 43, 87, 166, 200, 51, 166, 63, 149, 2, 142, 152, 58, 106, 199, 202, 44, 113, 57, 16, 17, 200, 102, 154 }, new byte[] { 104, 6, 0, 143, 46, 160, 136, 196, 182, 214, 102, 159, 213, 216, 169, 239, 34, 66, 89, 162, 51, 25, 118, 169, 59, 120, 129, 85, 97, 137, 225, 209, 188, 221, 183, 93, 176, 106, 83, 96, 244, 89, 250, 159, 188, 161, 44, 202, 78, 35, 31, 25, 60, 150, 95, 9, 142, 193, 130, 58, 59, 72, 169, 33, 148, 116, 110, 50, 181, 112, 155, 77, 63, 236, 152, 67, 19, 198, 34, 75, 219, 87, 189, 175, 163, 115, 253, 91, 8, 238, 55, 74, 93, 171, 125, 255, 1, 53, 16, 82, 192, 106, 170, 59, 163, 225, 196, 88, 207, 79, 21, 199, 150, 18, 99, 215, 208, 71, 212, 147, 237, 101, 33, 215, 231, 237, 124, 163 } });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBasketDetails_ProductId",
                table: "ShoppingBasketDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBasketDetails_ShoppingCartId",
                table: "ShoppingBasketDetails",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBasket_Customers_CustomerId",
                table: "ShoppingBasket",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBasket_Customers_CustomerId",
                table: "ShoppingBasket");

            migrationBuilder.DropTable(
                name: "ShoppingBasketDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingBasket",
                table: "ShoppingBasket");

            migrationBuilder.RenameTable(
                name: "ShoppingBasket",
                newName: "ShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingBasket_CustomerId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ShoppingCartDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartDetails_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 336, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 336, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 336, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 336, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 336, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 10, 20, 54, 337, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 10, 20, 54, 337, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.InsertData(
                table: "ShoppingCartDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Price", "ProductId", "Quantity", "ShoppingCartId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, 500.0, 1, 1, 1, null },
                    { 2, null, null, 300.0, 2, 2, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 337, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 337, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 337, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 13, 20, 54, 337, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 20, 54, 336, DateTimeKind.Utc).AddTicks(7029), new byte[] { 187, 181, 92, 117, 15, 152, 180, 55, 156, 183, 50, 44, 135, 1, 23, 211, 11, 116, 36, 217, 147, 29, 118, 198, 240, 20, 156, 242, 50, 233, 201, 187, 58, 37, 11, 229, 215, 110, 188, 129, 224, 124, 98, 205, 13, 24, 81, 127, 100, 184, 5, 225, 116, 110, 105, 194, 56, 161, 40, 165, 53, 6, 255, 200 }, new byte[] { 27, 76, 115, 3, 45, 117, 62, 228, 30, 95, 102, 22, 151, 25, 62, 164, 19, 28, 132, 25, 77, 72, 48, 131, 157, 118, 56, 73, 214, 61, 64, 183, 74, 73, 62, 163, 115, 81, 119, 135, 92, 78, 200, 54, 182, 112, 193, 21, 168, 159, 165, 158, 21, 93, 68, 220, 223, 131, 175, 218, 44, 101, 50, 172, 175, 11, 180, 249, 41, 224, 138, 40, 182, 176, 88, 78, 145, 54, 245, 39, 89, 145, 93, 89, 18, 43, 241, 249, 91, 127, 3, 172, 180, 218, 52, 187, 90, 202, 119, 15, 144, 246, 222, 31, 29, 182, 216, 127, 200, 29, 7, 4, 72, 189, 175, 58, 177, 88, 92, 177, 104, 205, 186, 131, 144, 121, 78, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 20, 54, 336, DateTimeKind.Utc).AddTicks(7176), new byte[] { 187, 181, 92, 117, 15, 152, 180, 55, 156, 183, 50, 44, 135, 1, 23, 211, 11, 116, 36, 217, 147, 29, 118, 198, 240, 20, 156, 242, 50, 233, 201, 187, 58, 37, 11, 229, 215, 110, 188, 129, 224, 124, 98, 205, 13, 24, 81, 127, 100, 184, 5, 225, 116, 110, 105, 194, 56, 161, 40, 165, 53, 6, 255, 200 }, new byte[] { 27, 76, 115, 3, 45, 117, 62, 228, 30, 95, 102, 22, 151, 25, 62, 164, 19, 28, 132, 25, 77, 72, 48, 131, 157, 118, 56, 73, 214, 61, 64, 183, 74, 73, 62, 163, 115, 81, 119, 135, 92, 78, 200, 54, 182, 112, 193, 21, 168, 159, 165, 158, 21, 93, 68, 220, 223, 131, 175, 218, 44, 101, 50, 172, 175, 11, 180, 249, 41, 224, 138, 40, 182, 176, 88, 78, 145, 54, 245, 39, 89, 145, 93, 89, 18, 43, 241, 249, 91, 127, 3, 172, 180, 218, 52, 187, 90, 202, 119, 15, 144, 246, 222, 31, 29, 182, 216, 127, 200, 29, 7, 4, 72, 189, 175, 58, 177, 88, 92, 177, 104, 205, 186, 131, 144, 121, 78, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 20, 54, 336, DateTimeKind.Utc).AddTicks(7297), new byte[] { 187, 181, 92, 117, 15, 152, 180, 55, 156, 183, 50, 44, 135, 1, 23, 211, 11, 116, 36, 217, 147, 29, 118, 198, 240, 20, 156, 242, 50, 233, 201, 187, 58, 37, 11, 229, 215, 110, 188, 129, 224, 124, 98, 205, 13, 24, 81, 127, 100, 184, 5, 225, 116, 110, 105, 194, 56, 161, 40, 165, 53, 6, 255, 200 }, new byte[] { 27, 76, 115, 3, 45, 117, 62, 228, 30, 95, 102, 22, 151, 25, 62, 164, 19, 28, 132, 25, 77, 72, 48, 131, 157, 118, 56, 73, 214, 61, 64, 183, 74, 73, 62, 163, 115, 81, 119, 135, 92, 78, 200, 54, 182, 112, 193, 21, 168, 159, 165, 158, 21, 93, 68, 220, 223, 131, 175, 218, 44, 101, 50, 172, 175, 11, 180, 249, 41, 224, 138, 40, 182, 176, 88, 78, 145, 54, 245, 39, 89, 145, 93, 89, 18, 43, 241, 249, 91, 127, 3, 172, 180, 218, 52, 187, 90, 202, 119, 15, 144, 246, 222, 31, 29, 182, 216, 127, 200, 29, 7, 4, 72, 189, 175, 58, 177, 88, 92, 177, 104, 205, 186, 131, 144, 121, 78, 33 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 20, 54, 336, DateTimeKind.Utc).AddTicks(7421), new byte[] { 187, 181, 92, 117, 15, 152, 180, 55, 156, 183, 50, 44, 135, 1, 23, 211, 11, 116, 36, 217, 147, 29, 118, 198, 240, 20, 156, 242, 50, 233, 201, 187, 58, 37, 11, 229, 215, 110, 188, 129, 224, 124, 98, 205, 13, 24, 81, 127, 100, 184, 5, 225, 116, 110, 105, 194, 56, 161, 40, 165, 53, 6, 255, 200 }, new byte[] { 27, 76, 115, 3, 45, 117, 62, 228, 30, 95, 102, 22, 151, 25, 62, 164, 19, 28, 132, 25, 77, 72, 48, 131, 157, 118, 56, 73, 214, 61, 64, 183, 74, 73, 62, 163, 115, 81, 119, 135, 92, 78, 200, 54, 182, 112, 193, 21, 168, 159, 165, 158, 21, 93, 68, 220, 223, 131, 175, 218, 44, 101, 50, 172, 175, 11, 180, 249, 41, 224, 138, 40, 182, 176, 88, 78, 145, 54, 245, 39, 89, 145, 93, 89, 18, 43, 241, 249, 91, 127, 3, 172, 180, 218, 52, 187, 90, 202, 119, 15, 144, 246, 222, 31, 29, 182, 216, 127, 200, 29, 7, 4, 72, 189, 175, 58, 177, 88, 92, 177, 104, 205, 186, 131, 144, 121, 78, 33 } });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartDetails_ProductId",
                table: "ShoppingCartDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartDetails_ShoppingCartId",
                table: "ShoppingCartDetails",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerId",
                table: "ShoppingCarts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
