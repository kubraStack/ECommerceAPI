using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedProductDtoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 24, 18, 27, 16, 241, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(3251), new byte[] { 1, 246, 141, 142, 127, 191, 10, 254, 87, 232, 62, 63, 84, 21, 158, 54, 250, 13, 113, 211, 172, 96, 60, 139, 226, 15, 52, 102, 67, 192, 180, 168, 59, 167, 37, 21, 127, 102, 150, 215, 45, 158, 185, 250, 232, 82, 157, 119, 195, 191, 127, 30, 168, 163, 221, 238, 190, 118, 226, 41, 150, 128, 182, 15 }, new byte[] { 17, 147, 139, 191, 152, 29, 103, 130, 74, 228, 131, 213, 70, 131, 81, 215, 61, 228, 145, 181, 111, 253, 192, 68, 118, 195, 247, 135, 76, 128, 207, 11, 11, 95, 247, 29, 223, 207, 126, 111, 1, 157, 149, 16, 7, 34, 176, 69, 109, 128, 25, 202, 41, 74, 119, 218, 92, 13, 190, 44, 158, 213, 97, 74, 61, 3, 119, 14, 245, 50, 100, 30, 91, 89, 49, 135, 173, 96, 130, 108, 84, 235, 86, 177, 163, 30, 177, 152, 150, 29, 117, 150, 137, 139, 173, 110, 83, 77, 56, 92, 118, 232, 199, 223, 106, 236, 118, 25, 204, 192, 44, 109, 159, 55, 40, 53, 239, 111, 171, 112, 88, 64, 50, 109, 36, 164, 207, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(3402), new byte[] { 1, 246, 141, 142, 127, 191, 10, 254, 87, 232, 62, 63, 84, 21, 158, 54, 250, 13, 113, 211, 172, 96, 60, 139, 226, 15, 52, 102, 67, 192, 180, 168, 59, 167, 37, 21, 127, 102, 150, 215, 45, 158, 185, 250, 232, 82, 157, 119, 195, 191, 127, 30, 168, 163, 221, 238, 190, 118, 226, 41, 150, 128, 182, 15 }, new byte[] { 17, 147, 139, 191, 152, 29, 103, 130, 74, 228, 131, 213, 70, 131, 81, 215, 61, 228, 145, 181, 111, 253, 192, 68, 118, 195, 247, 135, 76, 128, 207, 11, 11, 95, 247, 29, 223, 207, 126, 111, 1, 157, 149, 16, 7, 34, 176, 69, 109, 128, 25, 202, 41, 74, 119, 218, 92, 13, 190, 44, 158, 213, 97, 74, 61, 3, 119, 14, 245, 50, 100, 30, 91, 89, 49, 135, 173, 96, 130, 108, 84, 235, 86, 177, 163, 30, 177, 152, 150, 29, 117, 150, 137, 139, 173, 110, 83, 77, 56, 92, 118, 232, 199, 223, 106, 236, 118, 25, 204, 192, 44, 109, 159, 55, 40, 53, 239, 111, 171, 112, 88, 64, 50, 109, 36, 164, 207, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(3492), new byte[] { 1, 246, 141, 142, 127, 191, 10, 254, 87, 232, 62, 63, 84, 21, 158, 54, 250, 13, 113, 211, 172, 96, 60, 139, 226, 15, 52, 102, 67, 192, 180, 168, 59, 167, 37, 21, 127, 102, 150, 215, 45, 158, 185, 250, 232, 82, 157, 119, 195, 191, 127, 30, 168, 163, 221, 238, 190, 118, 226, 41, 150, 128, 182, 15 }, new byte[] { 17, 147, 139, 191, 152, 29, 103, 130, 74, 228, 131, 213, 70, 131, 81, 215, 61, 228, 145, 181, 111, 253, 192, 68, 118, 195, 247, 135, 76, 128, 207, 11, 11, 95, 247, 29, 223, 207, 126, 111, 1, 157, 149, 16, 7, 34, 176, 69, 109, 128, 25, 202, 41, 74, 119, 218, 92, 13, 190, 44, 158, 213, 97, 74, 61, 3, 119, 14, 245, 50, 100, 30, 91, 89, 49, 135, 173, 96, 130, 108, 84, 235, 86, 177, 163, 30, 177, 152, 150, 29, 117, 150, 137, 139, 173, 110, 83, 77, 56, 92, 118, 232, 199, 223, 106, 236, 118, 25, 204, 192, 44, 109, 159, 55, 40, 53, 239, 111, 171, 112, 88, 64, 50, 109, 36, 164, 207, 175 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 27, 16, 241, DateTimeKind.Utc).AddTicks(3583), new byte[] { 1, 246, 141, 142, 127, 191, 10, 254, 87, 232, 62, 63, 84, 21, 158, 54, 250, 13, 113, 211, 172, 96, 60, 139, 226, 15, 52, 102, 67, 192, 180, 168, 59, 167, 37, 21, 127, 102, 150, 215, 45, 158, 185, 250, 232, 82, 157, 119, 195, 191, 127, 30, 168, 163, 221, 238, 190, 118, 226, 41, 150, 128, 182, 15 }, new byte[] { 17, 147, 139, 191, 152, 29, 103, 130, 74, 228, 131, 213, 70, 131, 81, 215, 61, 228, 145, 181, 111, 253, 192, 68, 118, 195, 247, 135, 76, 128, 207, 11, 11, 95, 247, 29, 223, 207, 126, 111, 1, 157, 149, 16, 7, 34, 176, 69, 109, 128, 25, 202, 41, 74, 119, 218, 92, 13, 190, 44, 158, 213, 97, 74, 61, 3, 119, 14, 245, 50, 100, 30, 91, 89, 49, 135, 173, 96, 130, 108, 84, 235, 86, 177, 163, 30, 177, 152, 150, 29, 117, 150, 137, 139, 173, 110, 83, 77, 56, 92, 118, 232, 199, 223, 106, 236, 118, 25, 204, 192, 44, 109, 159, 55, 40, 53, 239, 111, 171, 112, 88, 64, 50, 109, 36, 164, 207, 175 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 22, 2, 39, 29, 643, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4256), new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4365), new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4478), new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 21, 23, 39, 29, 643, DateTimeKind.Utc).AddTicks(4599), new byte[] { 201, 106, 66, 73, 206, 51, 236, 239, 166, 194, 96, 10, 127, 81, 187, 85, 142, 99, 14, 103, 173, 112, 53, 122, 216, 195, 70, 220, 122, 92, 20, 248, 107, 33, 42, 36, 9, 182, 170, 11, 233, 36, 18, 211, 206, 94, 155, 59, 210, 242, 174, 168, 141, 94, 170, 182, 225, 253, 92, 130, 101, 131, 180, 181 }, new byte[] { 12, 4, 1, 146, 193, 158, 220, 143, 174, 87, 221, 207, 192, 223, 107, 104, 12, 193, 242, 36, 182, 127, 154, 255, 144, 42, 159, 191, 133, 75, 184, 52, 161, 78, 191, 97, 6, 205, 87, 5, 158, 132, 44, 131, 70, 114, 31, 92, 125, 120, 238, 78, 150, 86, 160, 144, 128, 196, 212, 191, 47, 24, 250, 5, 89, 228, 3, 118, 60, 55, 209, 227, 200, 232, 54, 111, 122, 56, 153, 27, 197, 180, 196, 123, 182, 33, 243, 174, 43, 203, 241, 125, 242, 135, 58, 192, 69, 46, 163, 192, 128, 163, 133, 121, 81, 195, 20, 192, 233, 46, 22, 240, 252, 120, 64, 105, 241, 222, 128, 111, 155, 219, 109, 130, 236, 164, 8, 11 } });
        }
    }
}
