using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class changedShoppingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingCartId",
                table: "ShoppingBasketDetails");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingBasketDetails",
                newName: "ShoppingBasketId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingBasketDetails_ShoppingCartId",
                table: "ShoppingBasketDetails",
                newName: "IX_ShoppingBasketDetails_ShoppingBasketId");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 30, 14, 3, 44, 186, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(8134), new byte[] { 249, 25, 152, 141, 233, 155, 134, 5, 39, 6, 215, 112, 58, 165, 143, 189, 154, 162, 122, 133, 211, 132, 34, 101, 198, 34, 188, 41, 135, 44, 119, 37, 45, 11, 156, 51, 167, 101, 78, 208, 81, 35, 87, 171, 58, 196, 216, 49, 219, 67, 170, 73, 118, 250, 142, 76, 98, 118, 131, 129, 47, 46, 38, 206 }, new byte[] { 56, 28, 39, 243, 65, 60, 118, 127, 202, 118, 215, 65, 211, 78, 9, 88, 26, 94, 175, 178, 94, 154, 112, 166, 211, 44, 62, 73, 79, 109, 79, 189, 113, 220, 28, 71, 136, 248, 64, 95, 29, 212, 253, 228, 27, 208, 202, 167, 122, 119, 122, 128, 215, 133, 126, 51, 95, 207, 149, 186, 195, 105, 196, 218, 206, 22, 78, 154, 45, 229, 203, 20, 0, 184, 30, 114, 134, 159, 243, 209, 125, 189, 180, 125, 14, 154, 22, 176, 234, 93, 97, 150, 136, 86, 102, 70, 66, 121, 188, 166, 170, 221, 153, 51, 33, 183, 222, 43, 4, 27, 115, 85, 180, 207, 93, 231, 188, 237, 5, 213, 215, 13, 9, 78, 160, 234, 29, 223 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(8231), new byte[] { 249, 25, 152, 141, 233, 155, 134, 5, 39, 6, 215, 112, 58, 165, 143, 189, 154, 162, 122, 133, 211, 132, 34, 101, 198, 34, 188, 41, 135, 44, 119, 37, 45, 11, 156, 51, 167, 101, 78, 208, 81, 35, 87, 171, 58, 196, 216, 49, 219, 67, 170, 73, 118, 250, 142, 76, 98, 118, 131, 129, 47, 46, 38, 206 }, new byte[] { 56, 28, 39, 243, 65, 60, 118, 127, 202, 118, 215, 65, 211, 78, 9, 88, 26, 94, 175, 178, 94, 154, 112, 166, 211, 44, 62, 73, 79, 109, 79, 189, 113, 220, 28, 71, 136, 248, 64, 95, 29, 212, 253, 228, 27, 208, 202, 167, 122, 119, 122, 128, 215, 133, 126, 51, 95, 207, 149, 186, 195, 105, 196, 218, 206, 22, 78, 154, 45, 229, 203, 20, 0, 184, 30, 114, 134, 159, 243, 209, 125, 189, 180, 125, 14, 154, 22, 176, 234, 93, 97, 150, 136, 86, 102, 70, 66, 121, 188, 166, 170, 221, 153, 51, 33, 183, 222, 43, 4, 27, 115, 85, 180, 207, 93, 231, 188, 237, 5, 213, 215, 13, 9, 78, 160, 234, 29, 223 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(8337), new byte[] { 249, 25, 152, 141, 233, 155, 134, 5, 39, 6, 215, 112, 58, 165, 143, 189, 154, 162, 122, 133, 211, 132, 34, 101, 198, 34, 188, 41, 135, 44, 119, 37, 45, 11, 156, 51, 167, 101, 78, 208, 81, 35, 87, 171, 58, 196, 216, 49, 219, 67, 170, 73, 118, 250, 142, 76, 98, 118, 131, 129, 47, 46, 38, 206 }, new byte[] { 56, 28, 39, 243, 65, 60, 118, 127, 202, 118, 215, 65, 211, 78, 9, 88, 26, 94, 175, 178, 94, 154, 112, 166, 211, 44, 62, 73, 79, 109, 79, 189, 113, 220, 28, 71, 136, 248, 64, 95, 29, 212, 253, 228, 27, 208, 202, 167, 122, 119, 122, 128, 215, 133, 126, 51, 95, 207, 149, 186, 195, 105, 196, 218, 206, 22, 78, 154, 45, 229, 203, 20, 0, 184, 30, 114, 134, 159, 243, 209, 125, 189, 180, 125, 14, 154, 22, 176, 234, 93, 97, 150, 136, 86, 102, 70, 66, 121, 188, 166, 170, 221, 153, 51, 33, 183, 222, 43, 4, 27, 115, 85, 180, 207, 93, 231, 188, 237, 5, 213, 215, 13, 9, 78, 160, 234, 29, 223 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 30, 11, 3, 44, 186, DateTimeKind.Utc).AddTicks(8424), new byte[] { 249, 25, 152, 141, 233, 155, 134, 5, 39, 6, 215, 112, 58, 165, 143, 189, 154, 162, 122, 133, 211, 132, 34, 101, 198, 34, 188, 41, 135, 44, 119, 37, 45, 11, 156, 51, 167, 101, 78, 208, 81, 35, 87, 171, 58, 196, 216, 49, 219, 67, 170, 73, 118, 250, 142, 76, 98, 118, 131, 129, 47, 46, 38, 206 }, new byte[] { 56, 28, 39, 243, 65, 60, 118, 127, 202, 118, 215, 65, 211, 78, 9, 88, 26, 94, 175, 178, 94, 154, 112, 166, 211, 44, 62, 73, 79, 109, 79, 189, 113, 220, 28, 71, 136, 248, 64, 95, 29, 212, 253, 228, 27, 208, 202, 167, 122, 119, 122, 128, 215, 133, 126, 51, 95, 207, 149, 186, 195, 105, 196, 218, 206, 22, 78, 154, 45, 229, 203, 20, 0, 184, 30, 114, 134, 159, 243, 209, 125, 189, 180, 125, 14, 154, 22, 176, 234, 93, 97, 150, 136, 86, 102, 70, 66, 121, 188, 166, 170, 221, 153, 51, 33, 183, 222, 43, 4, 27, 115, 85, 180, 207, 93, 231, 188, 237, 5, 213, 215, 13, 9, 78, 160, 234, 29, 223 } });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingBasketId",
                table: "ShoppingBasketDetails",
                column: "ShoppingBasketId",
                principalTable: "ShoppingBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingBasketId",
                table: "ShoppingBasketDetails");

            migrationBuilder.RenameColumn(
                name: "ShoppingBasketId",
                table: "ShoppingBasketDetails",
                newName: "ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingBasketDetails_ShoppingBasketId",
                table: "ShoppingBasketDetails",
                newName: "IX_ShoppingBasketDetails_ShoppingCartId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBasketDetails_ShoppingBasket_ShoppingCartId",
                table: "ShoppingBasketDetails",
                column: "ShoppingCartId",
                principalTable: "ShoppingBasket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
