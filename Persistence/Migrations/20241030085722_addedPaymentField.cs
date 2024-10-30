using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedPaymentField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "PaymentDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 16, 22, 47, 12, 498, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 16, 19, 47, 12, 498, DateTimeKind.Utc).AddTicks(5915));

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
    }
}
