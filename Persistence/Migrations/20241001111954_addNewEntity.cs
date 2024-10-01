using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addNewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 14, 19, 53, 330, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 19, 53, 330, DateTimeKind.Utc).AddTicks(3655), new byte[] { 228, 241, 82, 1, 143, 170, 48, 223, 231, 92, 238, 170, 190, 217, 204, 127, 198, 214, 24, 93, 24, 4, 88, 15, 103, 205, 125, 104, 181, 82, 151, 56, 69, 105, 151, 77, 192, 0, 26, 18, 28, 68, 185, 246, 149, 114, 29, 26, 182, 134, 227, 24, 204, 148, 63, 82, 23, 238, 86, 147, 34, 200, 219, 14 }, new byte[] { 39, 103, 158, 92, 17, 134, 106, 50, 156, 135, 179, 19, 193, 157, 246, 88, 190, 188, 165, 161, 77, 19, 236, 88, 207, 73, 55, 183, 231, 27, 105, 108, 184, 11, 43, 19, 54, 240, 76, 48, 89, 46, 80, 19, 106, 229, 194, 19, 13, 159, 106, 214, 167, 137, 115, 199, 119, 22, 20, 41, 83, 222, 179, 118, 0, 97, 200, 189, 68, 120, 250, 164, 182, 237, 226, 64, 85, 189, 40, 69, 32, 155, 222, 201, 153, 137, 62, 188, 59, 64, 171, 30, 174, 235, 235, 45, 52, 214, 253, 92, 155, 42, 59, 125, 86, 207, 47, 8, 139, 150, 138, 121, 153, 20, 179, 146, 169, 214, 120, 56, 18, 208, 120, 106, 5, 76, 16, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 19, 53, 330, DateTimeKind.Utc).AddTicks(3772), new byte[] { 228, 241, 82, 1, 143, 170, 48, 223, 231, 92, 238, 170, 190, 217, 204, 127, 198, 214, 24, 93, 24, 4, 88, 15, 103, 205, 125, 104, 181, 82, 151, 56, 69, 105, 151, 77, 192, 0, 26, 18, 28, 68, 185, 246, 149, 114, 29, 26, 182, 134, 227, 24, 204, 148, 63, 82, 23, 238, 86, 147, 34, 200, 219, 14 }, new byte[] { 39, 103, 158, 92, 17, 134, 106, 50, 156, 135, 179, 19, 193, 157, 246, 88, 190, 188, 165, 161, 77, 19, 236, 88, 207, 73, 55, 183, 231, 27, 105, 108, 184, 11, 43, 19, 54, 240, 76, 48, 89, 46, 80, 19, 106, 229, 194, 19, 13, 159, 106, 214, 167, 137, 115, 199, 119, 22, 20, 41, 83, 222, 179, 118, 0, 97, 200, 189, 68, 120, 250, 164, 182, 237, 226, 64, 85, 189, 40, 69, 32, 155, 222, 201, 153, 137, 62, 188, 59, 64, 171, 30, 174, 235, 235, 45, 52, 214, 253, 92, 155, 42, 59, 125, 86, 207, 47, 8, 139, 150, 138, 121, 153, 20, 179, 146, 169, 214, 120, 56, 18, 208, 120, 106, 5, 76, 16, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 19, 53, 330, DateTimeKind.Utc).AddTicks(3862), new byte[] { 228, 241, 82, 1, 143, 170, 48, 223, 231, 92, 238, 170, 190, 217, 204, 127, 198, 214, 24, 93, 24, 4, 88, 15, 103, 205, 125, 104, 181, 82, 151, 56, 69, 105, 151, 77, 192, 0, 26, 18, 28, 68, 185, 246, 149, 114, 29, 26, 182, 134, 227, 24, 204, 148, 63, 82, 23, 238, 86, 147, 34, 200, 219, 14 }, new byte[] { 39, 103, 158, 92, 17, 134, 106, 50, 156, 135, 179, 19, 193, 157, 246, 88, 190, 188, 165, 161, 77, 19, 236, 88, 207, 73, 55, 183, 231, 27, 105, 108, 184, 11, 43, 19, 54, 240, 76, 48, 89, 46, 80, 19, 106, 229, 194, 19, 13, 159, 106, 214, 167, 137, 115, 199, 119, 22, 20, 41, 83, 222, 179, 118, 0, 97, 200, 189, 68, 120, 250, 164, 182, 237, 226, 64, 85, 189, 40, 69, 32, 155, 222, 201, 153, 137, 62, 188, 59, 64, 171, 30, 174, 235, 235, 45, 52, 214, 253, 92, 155, 42, 59, 125, 86, 207, 47, 8, 139, 150, 138, 121, 153, 20, 179, 146, 169, 214, 120, 56, 18, 208, 120, 106, 5, 76, 16, 39 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 19, 53, 330, DateTimeKind.Utc).AddTicks(4049), new byte[] { 228, 241, 82, 1, 143, 170, 48, 223, 231, 92, 238, 170, 190, 217, 204, 127, 198, 214, 24, 93, 24, 4, 88, 15, 103, 205, 125, 104, 181, 82, 151, 56, 69, 105, 151, 77, 192, 0, 26, 18, 28, 68, 185, 246, 149, 114, 29, 26, 182, 134, 227, 24, 204, 148, 63, 82, 23, 238, 86, 147, 34, 200, 219, 14 }, new byte[] { 39, 103, 158, 92, 17, 134, 106, 50, 156, 135, 179, 19, 193, 157, 246, 88, 190, 188, 165, 161, 77, 19, 236, 88, 207, 73, 55, 183, 231, 27, 105, 108, 184, 11, 43, 19, 54, 240, 76, 48, 89, 46, 80, 19, 106, 229, 194, 19, 13, 159, 106, 214, 167, 137, 115, 199, 119, 22, 20, 41, 83, 222, 179, 118, 0, 97, 200, 189, 68, 120, 250, 164, 182, 237, 226, 64, 85, 189, 40, 69, 32, 155, 222, 201, 153, 137, 62, 188, 59, 64, 171, 30, 174, 235, 235, 45, 52, 214, 253, 92, 155, 42, 59, 125, 86, 207, 47, 8, 139, 150, 138, 121, 153, 20, 179, 146, 169, 214, 120, 56, 18, 208, 120, 106, 5, 76, 16, 39 } });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_CustomerId",
                table: "Favorites",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 30, 10, 25, 59, 521, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 25, 59, 521, DateTimeKind.Utc).AddTicks(6025), new byte[] { 122, 72, 106, 164, 170, 63, 194, 92, 112, 213, 83, 66, 165, 193, 235, 38, 251, 149, 73, 232, 188, 231, 88, 254, 84, 95, 55, 160, 93, 48, 241, 24, 186, 11, 178, 152, 78, 45, 46, 60, 229, 211, 30, 137, 87, 176, 62, 162, 96, 9, 150, 14, 185, 248, 203, 26, 109, 167, 166, 96, 250, 62, 72, 248 }, new byte[] { 127, 132, 251, 171, 164, 137, 20, 229, 192, 227, 9, 60, 230, 108, 238, 64, 10, 78, 146, 184, 162, 237, 196, 191, 255, 144, 219, 212, 117, 154, 24, 156, 64, 149, 171, 88, 84, 208, 66, 137, 221, 147, 239, 126, 203, 93, 36, 238, 196, 32, 248, 137, 100, 93, 11, 70, 144, 174, 106, 199, 20, 164, 236, 191, 184, 208, 244, 64, 64, 61, 228, 21, 159, 104, 117, 53, 227, 131, 220, 172, 147, 213, 189, 181, 27, 205, 125, 41, 232, 173, 215, 246, 99, 97, 120, 161, 68, 114, 180, 240, 164, 132, 190, 96, 207, 203, 25, 99, 162, 80, 251, 175, 29, 155, 114, 111, 63, 151, 84, 220, 145, 200, 1, 176, 129, 13, 127, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 25, 59, 521, DateTimeKind.Utc).AddTicks(6209), new byte[] { 122, 72, 106, 164, 170, 63, 194, 92, 112, 213, 83, 66, 165, 193, 235, 38, 251, 149, 73, 232, 188, 231, 88, 254, 84, 95, 55, 160, 93, 48, 241, 24, 186, 11, 178, 152, 78, 45, 46, 60, 229, 211, 30, 137, 87, 176, 62, 162, 96, 9, 150, 14, 185, 248, 203, 26, 109, 167, 166, 96, 250, 62, 72, 248 }, new byte[] { 127, 132, 251, 171, 164, 137, 20, 229, 192, 227, 9, 60, 230, 108, 238, 64, 10, 78, 146, 184, 162, 237, 196, 191, 255, 144, 219, 212, 117, 154, 24, 156, 64, 149, 171, 88, 84, 208, 66, 137, 221, 147, 239, 126, 203, 93, 36, 238, 196, 32, 248, 137, 100, 93, 11, 70, 144, 174, 106, 199, 20, 164, 236, 191, 184, 208, 244, 64, 64, 61, 228, 21, 159, 104, 117, 53, 227, 131, 220, 172, 147, 213, 189, 181, 27, 205, 125, 41, 232, 173, 215, 246, 99, 97, 120, 161, 68, 114, 180, 240, 164, 132, 190, 96, 207, 203, 25, 99, 162, 80, 251, 175, 29, 155, 114, 111, 63, 151, 84, 220, 145, 200, 1, 176, 129, 13, 127, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 25, 59, 521, DateTimeKind.Utc).AddTicks(6433), new byte[] { 122, 72, 106, 164, 170, 63, 194, 92, 112, 213, 83, 66, 165, 193, 235, 38, 251, 149, 73, 232, 188, 231, 88, 254, 84, 95, 55, 160, 93, 48, 241, 24, 186, 11, 178, 152, 78, 45, 46, 60, 229, 211, 30, 137, 87, 176, 62, 162, 96, 9, 150, 14, 185, 248, 203, 26, 109, 167, 166, 96, 250, 62, 72, 248 }, new byte[] { 127, 132, 251, 171, 164, 137, 20, 229, 192, 227, 9, 60, 230, 108, 238, 64, 10, 78, 146, 184, 162, 237, 196, 191, 255, 144, 219, 212, 117, 154, 24, 156, 64, 149, 171, 88, 84, 208, 66, 137, 221, 147, 239, 126, 203, 93, 36, 238, 196, 32, 248, 137, 100, 93, 11, 70, 144, 174, 106, 199, 20, 164, 236, 191, 184, 208, 244, 64, 64, 61, 228, 21, 159, 104, 117, 53, 227, 131, 220, 172, 147, 213, 189, 181, 27, 205, 125, 41, 232, 173, 215, 246, 99, 97, 120, 161, 68, 114, 180, 240, 164, 132, 190, 96, 207, 203, 25, 99, 162, 80, 251, 175, 29, 155, 114, 111, 63, 151, 84, 220, 145, 200, 1, 176, 129, 13, 127, 70 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 30, 7, 25, 59, 521, DateTimeKind.Utc).AddTicks(6601), new byte[] { 122, 72, 106, 164, 170, 63, 194, 92, 112, 213, 83, 66, 165, 193, 235, 38, 251, 149, 73, 232, 188, 231, 88, 254, 84, 95, 55, 160, 93, 48, 241, 24, 186, 11, 178, 152, 78, 45, 46, 60, 229, 211, 30, 137, 87, 176, 62, 162, 96, 9, 150, 14, 185, 248, 203, 26, 109, 167, 166, 96, 250, 62, 72, 248 }, new byte[] { 127, 132, 251, 171, 164, 137, 20, 229, 192, 227, 9, 60, 230, 108, 238, 64, 10, 78, 146, 184, 162, 237, 196, 191, 255, 144, 219, 212, 117, 154, 24, 156, 64, 149, 171, 88, 84, 208, 66, 137, 221, 147, 239, 126, 203, 93, 36, 238, 196, 32, 248, 137, 100, 93, 11, 70, 144, 174, 106, 199, 20, 164, 236, 191, 184, 208, 244, 64, 64, 61, 228, 21, 159, 104, 117, 53, 227, 131, 220, 172, 147, 213, 189, 181, 27, 205, 125, 41, 232, 173, 215, 246, 99, 97, 120, 161, 68, 114, 180, 240, 164, 132, 190, 96, 207, 203, 25, 99, 162, 80, 251, 175, 29, 155, 114, 111, 63, 151, 84, 220, 145, 200, 1, 176, 129, 13, 127, 70 } });
        }
    }
}
