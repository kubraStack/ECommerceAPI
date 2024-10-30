using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class changesShoppingCartName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 11, 57, 21, 554, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(3500), new byte[] { 84, 109, 105, 239, 25, 157, 209, 163, 47, 32, 107, 34, 106, 111, 253, 69, 208, 34, 71, 135, 232, 146, 48, 227, 239, 54, 12, 217, 48, 89, 106, 76, 172, 200, 101, 237, 129, 216, 178, 118, 10, 51, 68, 67, 84, 202, 142, 183, 78, 255, 46, 76, 255, 133, 153, 186, 138, 234, 72, 114, 113, 82, 106, 214 }, new byte[] { 187, 44, 177, 151, 19, 91, 5, 44, 33, 164, 63, 237, 74, 20, 226, 211, 222, 78, 106, 102, 161, 162, 221, 11, 210, 7, 22, 217, 8, 41, 39, 92, 191, 34, 208, 82, 209, 175, 72, 134, 6, 177, 0, 171, 203, 10, 242, 94, 126, 7, 91, 121, 3, 41, 101, 182, 138, 1, 77, 73, 8, 120, 84, 120, 71, 42, 208, 147, 129, 184, 101, 9, 200, 234, 160, 69, 30, 59, 25, 81, 29, 201, 153, 133, 236, 0, 245, 136, 54, 171, 142, 217, 32, 13, 137, 127, 166, 179, 202, 249, 199, 92, 24, 80, 86, 198, 146, 44, 12, 246, 83, 243, 163, 115, 127, 30, 87, 24, 233, 50, 214, 35, 156, 3, 71, 145, 10, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(3630), new byte[] { 84, 109, 105, 239, 25, 157, 209, 163, 47, 32, 107, 34, 106, 111, 253, 69, 208, 34, 71, 135, 232, 146, 48, 227, 239, 54, 12, 217, 48, 89, 106, 76, 172, 200, 101, 237, 129, 216, 178, 118, 10, 51, 68, 67, 84, 202, 142, 183, 78, 255, 46, 76, 255, 133, 153, 186, 138, 234, 72, 114, 113, 82, 106, 214 }, new byte[] { 187, 44, 177, 151, 19, 91, 5, 44, 33, 164, 63, 237, 74, 20, 226, 211, 222, 78, 106, 102, 161, 162, 221, 11, 210, 7, 22, 217, 8, 41, 39, 92, 191, 34, 208, 82, 209, 175, 72, 134, 6, 177, 0, 171, 203, 10, 242, 94, 126, 7, 91, 121, 3, 41, 101, 182, 138, 1, 77, 73, 8, 120, 84, 120, 71, 42, 208, 147, 129, 184, 101, 9, 200, 234, 160, 69, 30, 59, 25, 81, 29, 201, 153, 133, 236, 0, 245, 136, 54, 171, 142, 217, 32, 13, 137, 127, 166, 179, 202, 249, 199, 92, 24, 80, 86, 198, 146, 44, 12, 246, 83, 243, 163, 115, 127, 30, 87, 24, 233, 50, 214, 35, 156, 3, 71, 145, 10, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(3751), new byte[] { 84, 109, 105, 239, 25, 157, 209, 163, 47, 32, 107, 34, 106, 111, 253, 69, 208, 34, 71, 135, 232, 146, 48, 227, 239, 54, 12, 217, 48, 89, 106, 76, 172, 200, 101, 237, 129, 216, 178, 118, 10, 51, 68, 67, 84, 202, 142, 183, 78, 255, 46, 76, 255, 133, 153, 186, 138, 234, 72, 114, 113, 82, 106, 214 }, new byte[] { 187, 44, 177, 151, 19, 91, 5, 44, 33, 164, 63, 237, 74, 20, 226, 211, 222, 78, 106, 102, 161, 162, 221, 11, 210, 7, 22, 217, 8, 41, 39, 92, 191, 34, 208, 82, 209, 175, 72, 134, 6, 177, 0, 171, 203, 10, 242, 94, 126, 7, 91, 121, 3, 41, 101, 182, 138, 1, 77, 73, 8, 120, 84, 120, 71, 42, 208, 147, 129, 184, 101, 9, 200, 234, 160, 69, 30, 59, 25, 81, 29, 201, 153, 133, 236, 0, 245, 136, 54, 171, 142, 217, 32, 13, 137, 127, 166, 179, 202, 249, 199, 92, 24, 80, 86, 198, 146, 44, 12, 246, 83, 243, 163, 115, 127, 30, 87, 24, 233, 50, 214, 35, 156, 3, 71, 145, 10, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 57, 21, 554, DateTimeKind.Utc).AddTicks(3868), new byte[] { 84, 109, 105, 239, 25, 157, 209, 163, 47, 32, 107, 34, 106, 111, 253, 69, 208, 34, 71, 135, 232, 146, 48, 227, 239, 54, 12, 217, 48, 89, 106, 76, 172, 200, 101, 237, 129, 216, 178, 118, 10, 51, 68, 67, 84, 202, 142, 183, 78, 255, 46, 76, 255, 133, 153, 186, 138, 234, 72, 114, 113, 82, 106, 214 }, new byte[] { 187, 44, 177, 151, 19, 91, 5, 44, 33, 164, 63, 237, 74, 20, 226, 211, 222, 78, 106, 102, 161, 162, 221, 11, 210, 7, 22, 217, 8, 41, 39, 92, 191, 34, 208, 82, 209, 175, 72, 134, 6, 177, 0, 171, 203, 10, 242, 94, 126, 7, 91, 121, 3, 41, 101, 182, 138, 1, 77, 73, 8, 120, 84, 120, 71, 42, 208, 147, 129, 184, 101, 9, 200, 234, 160, 69, 30, 59, 25, 81, 29, 201, 153, 133, 236, 0, 245, 136, 54, 171, 142, 217, 32, 13, 137, 127, 166, 179, 202, 249, 199, 92, 24, 80, 86, 198, 146, 44, 12, 246, 83, 243, 163, 115, 127, 30, 87, 24, 233, 50, 214, 35, 156, 3, 71, 145, 10, 134 } });
        }
    }
}
