using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 16, 30, 54, 575, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 30, 54, 575, DateTimeKind.Utc).AddTicks(1844), new byte[] { 35, 21, 248, 100, 92, 12, 128, 250, 153, 32, 18, 108, 36, 160, 29, 8, 38, 14, 192, 192, 171, 51, 208, 66, 40, 213, 89, 85, 151, 200, 30, 254, 228, 28, 79, 224, 211, 36, 230, 222, 191, 214, 107, 227, 133, 234, 80, 75, 197, 79, 249, 237, 29, 122, 200, 206, 152, 208, 86, 41, 131, 127, 255, 56 }, new byte[] { 136, 189, 52, 27, 142, 186, 150, 231, 90, 249, 223, 235, 66, 192, 16, 248, 99, 11, 118, 151, 222, 167, 44, 41, 224, 183, 165, 245, 98, 130, 17, 21, 172, 190, 64, 73, 72, 248, 59, 36, 101, 231, 247, 9, 165, 129, 204, 12, 70, 148, 67, 252, 164, 138, 230, 65, 252, 216, 165, 206, 10, 111, 166, 147, 207, 175, 143, 96, 153, 8, 83, 75, 94, 212, 21, 116, 12, 198, 113, 95, 217, 20, 84, 68, 62, 23, 96, 6, 150, 253, 226, 158, 132, 145, 0, 254, 192, 116, 30, 110, 38, 15, 209, 207, 7, 217, 204, 119, 137, 23, 218, 185, 199, 160, 122, 186, 6, 5, 137, 198, 212, 207, 154, 124, 99, 189, 192, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 30, 54, 575, DateTimeKind.Utc).AddTicks(1990), new byte[] { 35, 21, 248, 100, 92, 12, 128, 250, 153, 32, 18, 108, 36, 160, 29, 8, 38, 14, 192, 192, 171, 51, 208, 66, 40, 213, 89, 85, 151, 200, 30, 254, 228, 28, 79, 224, 211, 36, 230, 222, 191, 214, 107, 227, 133, 234, 80, 75, 197, 79, 249, 237, 29, 122, 200, 206, 152, 208, 86, 41, 131, 127, 255, 56 }, new byte[] { 136, 189, 52, 27, 142, 186, 150, 231, 90, 249, 223, 235, 66, 192, 16, 248, 99, 11, 118, 151, 222, 167, 44, 41, 224, 183, 165, 245, 98, 130, 17, 21, 172, 190, 64, 73, 72, 248, 59, 36, 101, 231, 247, 9, 165, 129, 204, 12, 70, 148, 67, 252, 164, 138, 230, 65, 252, 216, 165, 206, 10, 111, 166, 147, 207, 175, 143, 96, 153, 8, 83, 75, 94, 212, 21, 116, 12, 198, 113, 95, 217, 20, 84, 68, 62, 23, 96, 6, 150, 253, 226, 158, 132, 145, 0, 254, 192, 116, 30, 110, 38, 15, 209, 207, 7, 217, 204, 119, 137, 23, 218, 185, 199, 160, 122, 186, 6, 5, 137, 198, 212, 207, 154, 124, 99, 189, 192, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 30, 54, 575, DateTimeKind.Utc).AddTicks(2101), new byte[] { 35, 21, 248, 100, 92, 12, 128, 250, 153, 32, 18, 108, 36, 160, 29, 8, 38, 14, 192, 192, 171, 51, 208, 66, 40, 213, 89, 85, 151, 200, 30, 254, 228, 28, 79, 224, 211, 36, 230, 222, 191, 214, 107, 227, 133, 234, 80, 75, 197, 79, 249, 237, 29, 122, 200, 206, 152, 208, 86, 41, 131, 127, 255, 56 }, new byte[] { 136, 189, 52, 27, 142, 186, 150, 231, 90, 249, 223, 235, 66, 192, 16, 248, 99, 11, 118, 151, 222, 167, 44, 41, 224, 183, 165, 245, 98, 130, 17, 21, 172, 190, 64, 73, 72, 248, 59, 36, 101, 231, 247, 9, 165, 129, 204, 12, 70, 148, 67, 252, 164, 138, 230, 65, 252, 216, 165, 206, 10, 111, 166, 147, 207, 175, 143, 96, 153, 8, 83, 75, 94, 212, 21, 116, 12, 198, 113, 95, 217, 20, 84, 68, 62, 23, 96, 6, 150, 253, 226, 158, 132, 145, 0, 254, 192, 116, 30, 110, 38, 15, 209, 207, 7, 217, 204, 119, 137, 23, 218, 185, 199, 160, 122, 186, 6, 5, 137, 198, 212, 207, 154, 124, 99, 189, 192, 88 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 13, 30, 54, 575, DateTimeKind.Utc).AddTicks(2209), new byte[] { 35, 21, 248, 100, 92, 12, 128, 250, 153, 32, 18, 108, 36, 160, 29, 8, 38, 14, 192, 192, 171, 51, 208, 66, 40, 213, 89, 85, 151, 200, 30, 254, 228, 28, 79, 224, 211, 36, 230, 222, 191, 214, 107, 227, 133, 234, 80, 75, 197, 79, 249, 237, 29, 122, 200, 206, 152, 208, 86, 41, 131, 127, 255, 56 }, new byte[] { 136, 189, 52, 27, 142, 186, 150, 231, 90, 249, 223, 235, 66, 192, 16, 248, 99, 11, 118, 151, 222, 167, 44, 41, 224, 183, 165, 245, 98, 130, 17, 21, 172, 190, 64, 73, 72, 248, 59, 36, 101, 231, 247, 9, 165, 129, 204, 12, 70, 148, 67, 252, 164, 138, 230, 65, 252, 216, 165, 206, 10, 111, 166, 147, 207, 175, 143, 96, 153, 8, 83, 75, 94, 212, 21, 116, 12, 198, 113, 95, 217, 20, 84, 68, 62, 23, 96, 6, 150, 253, 226, 158, 132, 145, 0, 254, 192, 116, 30, 110, 38, 15, 209, 207, 7, 217, 204, 119, 137, 23, 218, 185, 199, 160, 122, 186, 6, 5, 137, 198, 212, 207, 154, 124, 99, 189, 192, 88 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 24, 0, 995, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 994, DateTimeKind.Utc).AddTicks(9969), new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(111), new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(225), new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(321), new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });
        }
    }
}
