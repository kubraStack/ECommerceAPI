using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addEncrypt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 994, DateTimeKind.Utc).AddTicks(9969), "+2vS9SiEjuEtdomA+E1iOw==", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(111), "lx191yNB5UTgUeNqX1QIZQ==", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(225), "XsKf4aJaXsFVtCmJtPLh9A==", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 24, 0, 995, DateTimeKind.Utc).AddTicks(321), "aNbdnOzUNuGnMPCOxe7GbA==", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 94, 83, 176, 241, 12, 109, 248, 223, 113, 179, 176, 92, 243, 125, 128, 77, 139, 72, 49, 5, 86, 127, 97, 238, 170, 88, 183, 246, 6, 149, 198, 190, 13, 20, 40, 224, 91, 58, 112, 255, 54, 43, 53, 103, 6, 146, 233, 217, 79, 76, 175, 230, 9, 49, 110, 52, 206, 205, 145, 171, 206, 134, 70, 109 }, new byte[] { 201, 86, 133, 79, 54, 4, 157, 41, 160, 105, 41, 120, 69, 137, 4, 133, 250, 104, 76, 87, 234, 141, 124, 223, 82, 157, 31, 84, 201, 102, 15, 52, 238, 117, 30, 171, 213, 76, 5, 70, 139, 118, 60, 184, 23, 216, 21, 192, 222, 97, 248, 187, 14, 9, 8, 72, 130, 192, 171, 138, 78, 107, 239, 239, 23, 205, 68, 175, 161, 32, 180, 173, 106, 105, 14, 49, 199, 193, 82, 213, 78, 134, 87, 74, 149, 135, 63, 35, 185, 203, 130, 193, 81, 45, 118, 186, 244, 228, 98, 37, 13, 79, 91, 129, 181, 131, 112, 183, 86, 64, 175, 155, 240, 111, 89, 248, 217, 39, 58, 28, 95, 169, 219, 144, 113, 37, 135, 224 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 17, 10, 10, 50, 782, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 10, 50, 782, DateTimeKind.Utc).AddTicks(6086), "Alina", "Jast", new byte[] { 97, 237, 164, 169, 94, 40, 205, 33, 77, 55, 122, 79, 2, 164, 249, 29, 122, 100, 222, 228, 243, 93, 139, 1, 215, 49, 147, 166, 124, 199, 237, 90, 237, 160, 201, 125, 145, 22, 52, 110, 99, 57, 151, 136, 113, 147, 39, 72, 132, 153, 63, 191, 34, 102, 236, 115, 122, 162, 170, 251, 184, 155, 139, 35 }, new byte[] { 158, 12, 121, 160, 36, 209, 168, 53, 2, 47, 66, 217, 215, 197, 252, 172, 184, 119, 51, 230, 75, 46, 15, 171, 41, 59, 44, 135, 112, 170, 16, 192, 184, 30, 141, 52, 59, 43, 161, 185, 42, 44, 30, 35, 231, 166, 46, 243, 200, 210, 196, 56, 64, 43, 33, 42, 183, 111, 71, 35, 39, 227, 234, 60, 65, 132, 203, 45, 225, 78, 255, 137, 21, 230, 228, 202, 178, 50, 112, 201, 151, 46, 136, 63, 127, 48, 249, 32, 20, 136, 119, 208, 69, 45, 187, 237, 51, 90, 118, 196, 113, 179, 118, 228, 107, 86, 61, 13, 98, 82, 112, 147, 119, 101, 153, 112, 106, 165, 59, 248, 52, 178, 61, 69, 245, 177, 50, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 10, 50, 782, DateTimeKind.Utc).AddTicks(6120), "Jonathan", "Corwin", new byte[] { 97, 237, 164, 169, 94, 40, 205, 33, 77, 55, 122, 79, 2, 164, 249, 29, 122, 100, 222, 228, 243, 93, 139, 1, 215, 49, 147, 166, 124, 199, 237, 90, 237, 160, 201, 125, 145, 22, 52, 110, 99, 57, 151, 136, 113, 147, 39, 72, 132, 153, 63, 191, 34, 102, 236, 115, 122, 162, 170, 251, 184, 155, 139, 35 }, new byte[] { 158, 12, 121, 160, 36, 209, 168, 53, 2, 47, 66, 217, 215, 197, 252, 172, 184, 119, 51, 230, 75, 46, 15, 171, 41, 59, 44, 135, 112, 170, 16, 192, 184, 30, 141, 52, 59, 43, 161, 185, 42, 44, 30, 35, 231, 166, 46, 243, 200, 210, 196, 56, 64, 43, 33, 42, 183, 111, 71, 35, 39, 227, 234, 60, 65, 132, 203, 45, 225, 78, 255, 137, 21, 230, 228, 202, 178, 50, 112, 201, 151, 46, 136, 63, 127, 48, 249, 32, 20, 136, 119, 208, 69, 45, 187, 237, 51, 90, 118, 196, 113, 179, 118, 228, 107, 86, 61, 13, 98, 82, 112, 147, 119, 101, 153, 112, 106, 165, 59, 248, 52, 178, 61, 69, 245, 177, 50, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 10, 50, 782, DateTimeKind.Utc).AddTicks(6164), "Ziyaretçi", "Guest", new byte[] { 97, 237, 164, 169, 94, 40, 205, 33, 77, 55, 122, 79, 2, 164, 249, 29, 122, 100, 222, 228, 243, 93, 139, 1, 215, 49, 147, 166, 124, 199, 237, 90, 237, 160, 201, 125, 145, 22, 52, 110, 99, 57, 151, 136, 113, 147, 39, 72, 132, 153, 63, 191, 34, 102, 236, 115, 122, 162, 170, 251, 184, 155, 139, 35 }, new byte[] { 158, 12, 121, 160, 36, 209, 168, 53, 2, 47, 66, 217, 215, 197, 252, 172, 184, 119, 51, 230, 75, 46, 15, 171, 41, 59, 44, 135, 112, 170, 16, 192, 184, 30, 141, 52, 59, 43, 161, 185, 42, 44, 30, 35, 231, 166, 46, 243, 200, 210, 196, 56, 64, 43, 33, 42, 183, 111, 71, 35, 39, 227, 234, 60, 65, 132, 203, 45, 225, 78, 255, 137, 21, 230, 228, 202, 178, 50, 112, 201, 151, 46, 136, 63, 127, 48, 249, 32, 20, 136, 119, 208, 69, 45, 187, 237, 51, 90, 118, 196, 113, 179, 118, 228, 107, 86, 61, 13, 98, 82, 112, 147, 119, 101, 153, 112, 106, 165, 59, 248, 52, 178, 61, 69, 245, 177, 50, 236 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 10, 50, 782, DateTimeKind.Utc).AddTicks(6171), "Admin", "Yönetici", new byte[] { 97, 237, 164, 169, 94, 40, 205, 33, 77, 55, 122, 79, 2, 164, 249, 29, 122, 100, 222, 228, 243, 93, 139, 1, 215, 49, 147, 166, 124, 199, 237, 90, 237, 160, 201, 125, 145, 22, 52, 110, 99, 57, 151, 136, 113, 147, 39, 72, 132, 153, 63, 191, 34, 102, 236, 115, 122, 162, 170, 251, 184, 155, 139, 35 }, new byte[] { 158, 12, 121, 160, 36, 209, 168, 53, 2, 47, 66, 217, 215, 197, 252, 172, 184, 119, 51, 230, 75, 46, 15, 171, 41, 59, 44, 135, 112, 170, 16, 192, 184, 30, 141, 52, 59, 43, 161, 185, 42, 44, 30, 35, 231, 166, 46, 243, 200, 210, 196, 56, 64, 43, 33, 42, 183, 111, 71, 35, 39, 227, 234, 60, 65, 132, 203, 45, 225, 78, 255, 137, 21, 230, 228, 202, 178, 50, 112, 201, 151, 46, 136, 63, 127, 48, 249, 32, 20, 136, 119, 208, 69, 45, 187, 237, 51, 90, 118, 196, 113, 179, 118, 228, 107, 86, 61, 13, 98, 82, 112, 147, 119, 101, 153, 112, 106, 165, 59, 248, 52, 178, 61, 69, 245, 177, 50, 236 } });
        }
    }
}
