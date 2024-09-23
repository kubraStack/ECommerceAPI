using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deleteToEncrytText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 12, 11, 9, 32, 417, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 9, 32, 416, DateTimeKind.Utc).AddTicks(9410), "+2vS9SiEjuEtdomA+E1iOw==", "evKlCl7mIBJkEqQf5ueGMg==", new byte[] { 55, 203, 207, 84, 119, 209, 122, 137, 237, 40, 21, 71, 115, 202, 245, 54, 99, 245, 220, 217, 167, 209, 109, 207, 4, 13, 194, 121, 144, 188, 141, 195, 68, 231, 193, 25, 135, 218, 228, 124, 8, 10, 196, 169, 190, 146, 166, 101, 154, 78, 115, 183, 219, 25, 63, 7, 42, 247, 7, 178, 193, 55, 211, 42 }, new byte[] { 72, 175, 165, 246, 179, 178, 167, 21, 155, 64, 19, 184, 34, 211, 138, 201, 135, 15, 60, 232, 155, 18, 208, 167, 246, 81, 51, 57, 90, 4, 198, 166, 100, 72, 170, 143, 116, 1, 2, 84, 168, 213, 1, 106, 115, 109, 94, 227, 92, 198, 109, 93, 113, 66, 194, 75, 111, 203, 126, 210, 62, 193, 21, 253, 129, 72, 133, 219, 80, 118, 227, 39, 4, 74, 0, 0, 76, 113, 34, 137, 13, 52, 119, 51, 78, 190, 132, 210, 53, 187, 106, 50, 143, 26, 51, 215, 62, 206, 137, 48, 43, 79, 110, 210, 205, 1, 202, 115, 13, 194, 197, 210, 124, 35, 166, 134, 135, 215, 196, 79, 124, 145, 112, 140, 198, 192, 249, 200 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 9, 32, 416, DateTimeKind.Utc).AddTicks(9494), "lx191yNB5UTgUeNqX1QIZQ==", "ESeBAof1D3qOrdvr0NsjqQ==", new byte[] { 55, 203, 207, 84, 119, 209, 122, 137, 237, 40, 21, 71, 115, 202, 245, 54, 99, 245, 220, 217, 167, 209, 109, 207, 4, 13, 194, 121, 144, 188, 141, 195, 68, 231, 193, 25, 135, 218, 228, 124, 8, 10, 196, 169, 190, 146, 166, 101, 154, 78, 115, 183, 219, 25, 63, 7, 42, 247, 7, 178, 193, 55, 211, 42 }, new byte[] { 72, 175, 165, 246, 179, 178, 167, 21, 155, 64, 19, 184, 34, 211, 138, 201, 135, 15, 60, 232, 155, 18, 208, 167, 246, 81, 51, 57, 90, 4, 198, 166, 100, 72, 170, 143, 116, 1, 2, 84, 168, 213, 1, 106, 115, 109, 94, 227, 92, 198, 109, 93, 113, 66, 194, 75, 111, 203, 126, 210, 62, 193, 21, 253, 129, 72, 133, 219, 80, 118, 227, 39, 4, 74, 0, 0, 76, 113, 34, 137, 13, 52, 119, 51, 78, 190, 132, 210, 53, 187, 106, 50, 143, 26, 51, 215, 62, 206, 137, 48, 43, 79, 110, 210, 205, 1, 202, 115, 13, 194, 197, 210, 124, 35, 166, 134, 135, 215, 196, 79, 124, 145, 112, 140, 198, 192, 249, 200 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 9, 32, 416, DateTimeKind.Utc).AddTicks(9564), "XsKf4aJaXsFVtCmJtPLh9A==", "jp8wRnLaDCWzCeqYjo2dOQ==", new byte[] { 55, 203, 207, 84, 119, 209, 122, 137, 237, 40, 21, 71, 115, 202, 245, 54, 99, 245, 220, 217, 167, 209, 109, 207, 4, 13, 194, 121, 144, 188, 141, 195, 68, 231, 193, 25, 135, 218, 228, 124, 8, 10, 196, 169, 190, 146, 166, 101, 154, 78, 115, 183, 219, 25, 63, 7, 42, 247, 7, 178, 193, 55, 211, 42 }, new byte[] { 72, 175, 165, 246, 179, 178, 167, 21, 155, 64, 19, 184, 34, 211, 138, 201, 135, 15, 60, 232, 155, 18, 208, 167, 246, 81, 51, 57, 90, 4, 198, 166, 100, 72, 170, 143, 116, 1, 2, 84, 168, 213, 1, 106, 115, 109, 94, 227, 92, 198, 109, 93, 113, 66, 194, 75, 111, 203, 126, 210, 62, 193, 21, 253, 129, 72, 133, 219, 80, 118, 227, 39, 4, 74, 0, 0, 76, 113, 34, 137, 13, 52, 119, 51, 78, 190, 132, 210, 53, 187, 106, 50, 143, 26, 51, 215, 62, 206, 137, 48, 43, 79, 110, 210, 205, 1, 202, 115, 13, 194, 197, 210, 124, 35, 166, 134, 135, 215, 196, 79, 124, 145, 112, 140, 198, 192, 249, 200 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 12, 8, 9, 32, 416, DateTimeKind.Utc).AddTicks(9684), "aNbdnOzUNuGnMPCOxe7GbA==", "zWkKiFF1SEkTjhIMvlgAfg==", new byte[] { 55, 203, 207, 84, 119, 209, 122, 137, 237, 40, 21, 71, 115, 202, 245, 54, 99, 245, 220, 217, 167, 209, 109, 207, 4, 13, 194, 121, 144, 188, 141, 195, 68, 231, 193, 25, 135, 218, 228, 124, 8, 10, 196, 169, 190, 146, 166, 101, 154, 78, 115, 183, 219, 25, 63, 7, 42, 247, 7, 178, 193, 55, 211, 42 }, new byte[] { 72, 175, 165, 246, 179, 178, 167, 21, 155, 64, 19, 184, 34, 211, 138, 201, 135, 15, 60, 232, 155, 18, 208, 167, 246, 81, 51, 57, 90, 4, 198, 166, 100, 72, 170, 143, 116, 1, 2, 84, 168, 213, 1, 106, 115, 109, 94, 227, 92, 198, 109, 93, 113, 66, 194, 75, 111, 203, 126, 210, 62, 193, 21, 253, 129, 72, 133, 219, 80, 118, 227, 39, 4, 74, 0, 0, 76, 113, 34, 137, 13, 52, 119, 51, 78, 190, 132, 210, 53, 187, 106, 50, 143, 26, 51, 215, 62, 206, 137, 48, 43, 79, 110, 210, 205, 1, 202, 115, 13, 194, 197, 210, 124, 35, 166, 134, 135, 215, 196, 79, 124, 145, 112, 140, 198, 192, 249, 200 } });
        }
    }
}
