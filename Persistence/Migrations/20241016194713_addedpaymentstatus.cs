using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedpaymentstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PaymentDate", "PaymentStatus" },
                values: new object[] { new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(4984), 0 });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PaymentDate", "PaymentStatus" },
                values: new object[] { new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5004), 0 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "OrderId", "PaymentDate", "PaymentMethodId", "PaymentStatus", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, 100.00m, null, null, 1, new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(5913), 1, 1, null },
                    { 4, 200.00m, null, null, 2, new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(5915), 2, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(3814), new byte[] { 111, 68, 33, 23, 213, 183, 54, 217, 195, 24, 12, 236, 131, 46, 82, 131, 81, 166, 145, 22, 88, 5, 109, 92, 17, 188, 215, 218, 15, 8, 255, 205, 52, 145, 235, 5, 4, 230, 111, 40, 11, 178, 26, 114, 8, 81, 166, 31, 46, 204, 213, 2, 193, 54, 242, 208, 86, 196, 123, 254, 110, 68, 98, 86 }, new byte[] { 90, 159, 57, 248, 93, 223, 131, 165, 126, 160, 238, 108, 22, 152, 193, 187, 202, 59, 203, 70, 148, 46, 148, 109, 62, 136, 37, 181, 120, 142, 24, 210, 203, 104, 245, 134, 90, 239, 223, 165, 35, 51, 177, 59, 10, 84, 136, 43, 119, 138, 237, 17, 206, 126, 116, 100, 50, 218, 103, 201, 185, 58, 201, 23, 136, 5, 140, 196, 177, 16, 117, 52, 36, 45, 14, 112, 69, 64, 220, 195, 198, 207, 234, 230, 78, 195, 239, 239, 62, 246, 169, 96, 38, 215, 65, 194, 66, 24, 141, 136, 124, 71, 68, 147, 54, 164, 234, 208, 30, 106, 6, 211, 47, 90, 177, 144, 93, 51, 250, 144, 198, 151, 124, 220, 7, 46, 142, 212 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(3940), new byte[] { 111, 68, 33, 23, 213, 183, 54, 217, 195, 24, 12, 236, 131, 46, 82, 131, 81, 166, 145, 22, 88, 5, 109, 92, 17, 188, 215, 218, 15, 8, 255, 205, 52, 145, 235, 5, 4, 230, 111, 40, 11, 178, 26, 114, 8, 81, 166, 31, 46, 204, 213, 2, 193, 54, 242, 208, 86, 196, 123, 254, 110, 68, 98, 86 }, new byte[] { 90, 159, 57, 248, 93, 223, 131, 165, 126, 160, 238, 108, 22, 152, 193, 187, 202, 59, 203, 70, 148, 46, 148, 109, 62, 136, 37, 181, 120, 142, 24, 210, 203, 104, 245, 134, 90, 239, 223, 165, 35, 51, 177, 59, 10, 84, 136, 43, 119, 138, 237, 17, 206, 126, 116, 100, 50, 218, 103, 201, 185, 58, 201, 23, 136, 5, 140, 196, 177, 16, 117, 52, 36, 45, 14, 112, 69, 64, 220, 195, 198, 207, 234, 230, 78, 195, 239, 239, 62, 246, 169, 96, 38, 215, 65, 194, 66, 24, 141, 136, 124, 71, 68, 147, 54, 164, 234, 208, 30, 106, 6, 211, 47, 90, 177, 144, 93, 51, 250, 144, 198, 151, 124, 220, 7, 46, 142, 212 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(4021), new byte[] { 111, 68, 33, 23, 213, 183, 54, 217, 195, 24, 12, 236, 131, 46, 82, 131, 81, 166, 145, 22, 88, 5, 109, 92, 17, 188, 215, 218, 15, 8, 255, 205, 52, 145, 235, 5, 4, 230, 111, 40, 11, 178, 26, 114, 8, 81, 166, 31, 46, 204, 213, 2, 193, 54, 242, 208, 86, 196, 123, 254, 110, 68, 98, 86 }, new byte[] { 90, 159, 57, 248, 93, 223, 131, 165, 126, 160, 238, 108, 22, 152, 193, 187, 202, 59, 203, 70, 148, 46, 148, 109, 62, 136, 37, 181, 120, 142, 24, 210, 203, 104, 245, 134, 90, 239, 223, 165, 35, 51, 177, 59, 10, 84, 136, 43, 119, 138, 237, 17, 206, 126, 116, 100, 50, 218, 103, 201, 185, 58, 201, 23, 136, 5, 140, 196, 177, 16, 117, 52, 36, 45, 14, 112, 69, 64, 220, 195, 198, 207, 234, 230, 78, 195, 239, 239, 62, 246, 169, 96, 38, 215, 65, 194, 66, 24, 141, 136, 124, 71, 68, 147, 54, 164, 234, 208, 30, 106, 6, 211, 47, 90, 177, 144, 93, 51, 250, 144, 198, 151, 124, 220, 7, 46, 142, 212 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(4169), new byte[] { 111, 68, 33, 23, 213, 183, 54, 217, 195, 24, 12, 236, 131, 46, 82, 131, 81, 166, 145, 22, 88, 5, 109, 92, 17, 188, 215, 218, 15, 8, 255, 205, 52, 145, 235, 5, 4, 230, 111, 40, 11, 178, 26, 114, 8, 81, 166, 31, 46, 204, 213, 2, 193, 54, 242, 208, 86, 196, 123, 254, 110, 68, 98, 86 }, new byte[] { 90, 159, 57, 248, 93, 223, 131, 165, 126, 160, 238, 108, 22, 152, 193, 187, 202, 59, 203, 70, 148, 46, 148, 109, 62, 136, 37, 181, 120, 142, 24, 210, 203, 104, 245, 134, 90, 239, 223, 165, 35, 51, 177, 59, 10, 84, 136, 43, 119, 138, 237, 17, 206, 126, 116, 100, 50, 218, 103, 201, 185, 58, 201, 23, 136, 5, 140, 196, 177, 16, 117, 52, 36, 45, 14, 112, 69, 64, 220, 195, 198, 207, 234, 230, 78, 195, 239, 239, 62, 246, 169, 96, 38, 215, 65, 194, 66, 24, 141, 136, 124, 71, 68, 147, 54, 164, 234, 208, 30, 106, 6, 211, 47, 90, 177, 144, 93, 51, 250, 144, 198, 151, 124, 220, 7, 46, 142, 212 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 11, 4, 41, 40, 256, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 41, 40, 256, DateTimeKind.Utc).AddTicks(3391), new byte[] { 63, 182, 55, 12, 157, 166, 149, 29, 206, 226, 4, 147, 106, 62, 62, 183, 35, 193, 84, 135, 75, 27, 255, 110, 88, 31, 55, 99, 182, 148, 116, 43, 65, 92, 192, 72, 162, 233, 118, 102, 83, 114, 23, 142, 104, 104, 6, 12, 72, 212, 186, 32, 183, 235, 202, 115, 92, 245, 239, 111, 40, 226, 138, 233 }, new byte[] { 15, 208, 176, 18, 166, 138, 241, 220, 138, 95, 140, 76, 83, 10, 191, 122, 27, 52, 17, 9, 118, 22, 10, 70, 192, 5, 194, 160, 94, 248, 226, 89, 13, 238, 67, 44, 20, 174, 184, 224, 38, 106, 86, 37, 47, 82, 255, 10, 94, 216, 143, 0, 125, 151, 128, 146, 49, 138, 72, 232, 75, 175, 174, 94, 34, 132, 85, 175, 176, 185, 223, 89, 100, 242, 236, 96, 40, 20, 117, 144, 158, 4, 26, 144, 247, 183, 115, 39, 64, 74, 76, 207, 141, 137, 145, 34, 234, 86, 205, 235, 221, 211, 180, 147, 128, 94, 39, 40, 44, 210, 87, 148, 200, 188, 137, 13, 174, 205, 118, 141, 92, 5, 117, 15, 98, 112, 32, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 41, 40, 256, DateTimeKind.Utc).AddTicks(3492), new byte[] { 63, 182, 55, 12, 157, 166, 149, 29, 206, 226, 4, 147, 106, 62, 62, 183, 35, 193, 84, 135, 75, 27, 255, 110, 88, 31, 55, 99, 182, 148, 116, 43, 65, 92, 192, 72, 162, 233, 118, 102, 83, 114, 23, 142, 104, 104, 6, 12, 72, 212, 186, 32, 183, 235, 202, 115, 92, 245, 239, 111, 40, 226, 138, 233 }, new byte[] { 15, 208, 176, 18, 166, 138, 241, 220, 138, 95, 140, 76, 83, 10, 191, 122, 27, 52, 17, 9, 118, 22, 10, 70, 192, 5, 194, 160, 94, 248, 226, 89, 13, 238, 67, 44, 20, 174, 184, 224, 38, 106, 86, 37, 47, 82, 255, 10, 94, 216, 143, 0, 125, 151, 128, 146, 49, 138, 72, 232, 75, 175, 174, 94, 34, 132, 85, 175, 176, 185, 223, 89, 100, 242, 236, 96, 40, 20, 117, 144, 158, 4, 26, 144, 247, 183, 115, 39, 64, 74, 76, 207, 141, 137, 145, 34, 234, 86, 205, 235, 221, 211, 180, 147, 128, 94, 39, 40, 44, 210, 87, 148, 200, 188, 137, 13, 174, 205, 118, 141, 92, 5, 117, 15, 98, 112, 32, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 41, 40, 256, DateTimeKind.Utc).AddTicks(3549), new byte[] { 63, 182, 55, 12, 157, 166, 149, 29, 206, 226, 4, 147, 106, 62, 62, 183, 35, 193, 84, 135, 75, 27, 255, 110, 88, 31, 55, 99, 182, 148, 116, 43, 65, 92, 192, 72, 162, 233, 118, 102, 83, 114, 23, 142, 104, 104, 6, 12, 72, 212, 186, 32, 183, 235, 202, 115, 92, 245, 239, 111, 40, 226, 138, 233 }, new byte[] { 15, 208, 176, 18, 166, 138, 241, 220, 138, 95, 140, 76, 83, 10, 191, 122, 27, 52, 17, 9, 118, 22, 10, 70, 192, 5, 194, 160, 94, 248, 226, 89, 13, 238, 67, 44, 20, 174, 184, 224, 38, 106, 86, 37, 47, 82, 255, 10, 94, 216, 143, 0, 125, 151, 128, 146, 49, 138, 72, 232, 75, 175, 174, 94, 34, 132, 85, 175, 176, 185, 223, 89, 100, 242, 236, 96, 40, 20, 117, 144, 158, 4, 26, 144, 247, 183, 115, 39, 64, 74, 76, 207, 141, 137, 145, 34, 234, 86, 205, 235, 221, 211, 180, 147, 128, 94, 39, 40, 44, 210, 87, 148, 200, 188, 137, 13, 174, 205, 118, 141, 92, 5, 117, 15, 98, 112, 32, 166 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 41, 40, 256, DateTimeKind.Utc).AddTicks(3624), new byte[] { 63, 182, 55, 12, 157, 166, 149, 29, 206, 226, 4, 147, 106, 62, 62, 183, 35, 193, 84, 135, 75, 27, 255, 110, 88, 31, 55, 99, 182, 148, 116, 43, 65, 92, 192, 72, 162, 233, 118, 102, 83, 114, 23, 142, 104, 104, 6, 12, 72, 212, 186, 32, 183, 235, 202, 115, 92, 245, 239, 111, 40, 226, 138, 233 }, new byte[] { 15, 208, 176, 18, 166, 138, 241, 220, 138, 95, 140, 76, 83, 10, 191, 122, 27, 52, 17, 9, 118, 22, 10, 70, 192, 5, 194, 160, 94, 248, 226, 89, 13, 238, 67, 44, 20, 174, 184, 224, 38, 106, 86, 37, 47, 82, 255, 10, 94, 216, 143, 0, 125, 151, 128, 146, 49, 138, 72, 232, 75, 175, 174, 94, 34, 132, 85, 175, 176, 185, 223, 89, 100, 242, 236, 96, 40, 20, 117, 144, 158, 4, 26, 144, 247, 183, 115, 39, 64, 74, 76, 207, 141, 137, 145, 34, 234, 86, 205, 235, 221, 211, 180, 147, 128, 94, 39, 40, 44, 210, 87, 148, 200, 188, 137, 13, 174, 205, 118, 141, 92, 5, 117, 15, 98, 112, 32, 166 } });
        }
    }
}
