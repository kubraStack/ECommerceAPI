using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 1, 47, 34, 771, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 47, 34, 771, DateTimeKind.Utc).AddTicks(6494), new byte[] { 104, 245, 32, 147, 55, 248, 102, 241, 248, 2, 31, 176, 41, 38, 115, 102, 9, 81, 252, 205, 56, 197, 169, 160, 12, 49, 108, 214, 241, 223, 49, 11, 89, 102, 131, 207, 15, 176, 124, 73, 66, 93, 217, 164, 12, 216, 113, 151, 99, 252, 3, 190, 6, 89, 199, 154, 49, 173, 13, 162, 164, 44, 230, 76 }, new byte[] { 181, 166, 123, 37, 237, 95, 152, 116, 219, 98, 146, 48, 254, 140, 57, 111, 105, 157, 166, 206, 192, 193, 54, 127, 225, 45, 190, 157, 91, 123, 77, 27, 147, 166, 97, 242, 76, 162, 25, 230, 152, 222, 194, 164, 151, 59, 56, 253, 228, 66, 134, 58, 166, 53, 234, 55, 86, 240, 23, 197, 124, 83, 104, 67, 240, 80, 60, 213, 57, 9, 162, 180, 21, 71, 131, 74, 185, 180, 162, 189, 152, 128, 238, 215, 45, 74, 117, 183, 21, 8, 192, 32, 100, 209, 17, 107, 121, 223, 136, 195, 117, 93, 42, 82, 41, 139, 87, 138, 207, 103, 76, 189, 227, 255, 102, 198, 148, 22, 200, 165, 146, 144, 0, 151, 31, 133, 186, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 47, 34, 771, DateTimeKind.Utc).AddTicks(6718), new byte[] { 104, 245, 32, 147, 55, 248, 102, 241, 248, 2, 31, 176, 41, 38, 115, 102, 9, 81, 252, 205, 56, 197, 169, 160, 12, 49, 108, 214, 241, 223, 49, 11, 89, 102, 131, 207, 15, 176, 124, 73, 66, 93, 217, 164, 12, 216, 113, 151, 99, 252, 3, 190, 6, 89, 199, 154, 49, 173, 13, 162, 164, 44, 230, 76 }, new byte[] { 181, 166, 123, 37, 237, 95, 152, 116, 219, 98, 146, 48, 254, 140, 57, 111, 105, 157, 166, 206, 192, 193, 54, 127, 225, 45, 190, 157, 91, 123, 77, 27, 147, 166, 97, 242, 76, 162, 25, 230, 152, 222, 194, 164, 151, 59, 56, 253, 228, 66, 134, 58, 166, 53, 234, 55, 86, 240, 23, 197, 124, 83, 104, 67, 240, 80, 60, 213, 57, 9, 162, 180, 21, 71, 131, 74, 185, 180, 162, 189, 152, 128, 238, 215, 45, 74, 117, 183, 21, 8, 192, 32, 100, 209, 17, 107, 121, 223, 136, 195, 117, 93, 42, 82, 41, 139, 87, 138, 207, 103, 76, 189, 227, 255, 102, 198, 148, 22, 200, 165, 146, 144, 0, 151, 31, 133, 186, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 47, 34, 771, DateTimeKind.Utc).AddTicks(6778), new byte[] { 104, 245, 32, 147, 55, 248, 102, 241, 248, 2, 31, 176, 41, 38, 115, 102, 9, 81, 252, 205, 56, 197, 169, 160, 12, 49, 108, 214, 241, 223, 49, 11, 89, 102, 131, 207, 15, 176, 124, 73, 66, 93, 217, 164, 12, 216, 113, 151, 99, 252, 3, 190, 6, 89, 199, 154, 49, 173, 13, 162, 164, 44, 230, 76 }, new byte[] { 181, 166, 123, 37, 237, 95, 152, 116, 219, 98, 146, 48, 254, 140, 57, 111, 105, 157, 166, 206, 192, 193, 54, 127, 225, 45, 190, 157, 91, 123, 77, 27, 147, 166, 97, 242, 76, 162, 25, 230, 152, 222, 194, 164, 151, 59, 56, 253, 228, 66, 134, 58, 166, 53, 234, 55, 86, 240, 23, 197, 124, 83, 104, 67, 240, 80, 60, 213, 57, 9, 162, 180, 21, 71, 131, 74, 185, 180, 162, 189, 152, 128, 238, 215, 45, 74, 117, 183, 21, 8, 192, 32, 100, 209, 17, 107, 121, 223, 136, 195, 117, 93, 42, 82, 41, 139, 87, 138, 207, 103, 76, 189, 227, 255, 102, 198, 148, 22, 200, 165, 146, 144, 0, 151, 31, 133, 186, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 22, 47, 34, 771, DateTimeKind.Utc).AddTicks(6925), new byte[] { 104, 245, 32, 147, 55, 248, 102, 241, 248, 2, 31, 176, 41, 38, 115, 102, 9, 81, 252, 205, 56, 197, 169, 160, 12, 49, 108, 214, 241, 223, 49, 11, 89, 102, 131, 207, 15, 176, 124, 73, 66, 93, 217, 164, 12, 216, 113, 151, 99, 252, 3, 190, 6, 89, 199, 154, 49, 173, 13, 162, 164, 44, 230, 76 }, new byte[] { 181, 166, 123, 37, 237, 95, 152, 116, 219, 98, 146, 48, 254, 140, 57, 111, 105, 157, 166, 206, 192, 193, 54, 127, 225, 45, 190, 157, 91, 123, 77, 27, 147, 166, 97, 242, 76, 162, 25, 230, 152, 222, 194, 164, 151, 59, 56, 253, 228, 66, 134, 58, 166, 53, 234, 55, 86, 240, 23, 197, 124, 83, 104, 67, 240, 80, 60, 213, 57, 9, 162, 180, 21, 71, 131, 74, 185, 180, 162, 189, 152, 128, 238, 215, 45, 74, 117, 183, 21, 8, 192, 32, 100, 209, 17, 107, 121, 223, 136, 195, 117, 93, 42, 82, 41, 139, 87, 138, 207, 103, 76, 189, 227, 255, 102, 198, 148, 22, 200, 165, 146, 144, 0, 151, 31, 133, 186, 78 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 50, 20, 372, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 50, 20, 372, DateTimeKind.Utc).AddTicks(3402), new byte[] { 232, 53, 52, 17, 14, 215, 79, 140, 25, 162, 67, 250, 102, 182, 10, 140, 233, 183, 231, 155, 217, 140, 61, 171, 45, 211, 73, 194, 93, 231, 56, 219, 130, 83, 37, 168, 101, 106, 220, 206, 118, 126, 222, 224, 254, 114, 15, 111, 189, 192, 7, 180, 72, 210, 20, 59, 174, 216, 184, 212, 71, 141, 108, 29 }, new byte[] { 134, 216, 68, 198, 117, 38, 197, 210, 78, 57, 107, 123, 202, 68, 175, 46, 212, 1, 84, 198, 220, 122, 185, 242, 250, 236, 126, 245, 252, 80, 154, 40, 13, 208, 157, 42, 148, 11, 19, 32, 174, 18, 67, 100, 18, 105, 55, 133, 96, 83, 117, 81, 51, 54, 228, 139, 69, 244, 239, 250, 102, 49, 128, 47, 187, 111, 126, 17, 247, 26, 54, 254, 100, 44, 168, 234, 198, 94, 245, 146, 93, 176, 8, 169, 123, 231, 63, 37, 97, 108, 115, 46, 78, 5, 147, 8, 94, 106, 24, 32, 190, 66, 147, 129, 172, 155, 120, 32, 153, 29, 213, 122, 79, 173, 247, 51, 33, 227, 24, 54, 101, 123, 55, 179, 112, 114, 13, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 50, 20, 372, DateTimeKind.Utc).AddTicks(3623), new byte[] { 232, 53, 52, 17, 14, 215, 79, 140, 25, 162, 67, 250, 102, 182, 10, 140, 233, 183, 231, 155, 217, 140, 61, 171, 45, 211, 73, 194, 93, 231, 56, 219, 130, 83, 37, 168, 101, 106, 220, 206, 118, 126, 222, 224, 254, 114, 15, 111, 189, 192, 7, 180, 72, 210, 20, 59, 174, 216, 184, 212, 71, 141, 108, 29 }, new byte[] { 134, 216, 68, 198, 117, 38, 197, 210, 78, 57, 107, 123, 202, 68, 175, 46, 212, 1, 84, 198, 220, 122, 185, 242, 250, 236, 126, 245, 252, 80, 154, 40, 13, 208, 157, 42, 148, 11, 19, 32, 174, 18, 67, 100, 18, 105, 55, 133, 96, 83, 117, 81, 51, 54, 228, 139, 69, 244, 239, 250, 102, 49, 128, 47, 187, 111, 126, 17, 247, 26, 54, 254, 100, 44, 168, 234, 198, 94, 245, 146, 93, 176, 8, 169, 123, 231, 63, 37, 97, 108, 115, 46, 78, 5, 147, 8, 94, 106, 24, 32, 190, 66, 147, 129, 172, 155, 120, 32, 153, 29, 213, 122, 79, 173, 247, 51, 33, 227, 24, 54, 101, 123, 55, 179, 112, 114, 13, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 50, 20, 372, DateTimeKind.Utc).AddTicks(3842), new byte[] { 232, 53, 52, 17, 14, 215, 79, 140, 25, 162, 67, 250, 102, 182, 10, 140, 233, 183, 231, 155, 217, 140, 61, 171, 45, 211, 73, 194, 93, 231, 56, 219, 130, 83, 37, 168, 101, 106, 220, 206, 118, 126, 222, 224, 254, 114, 15, 111, 189, 192, 7, 180, 72, 210, 20, 59, 174, 216, 184, 212, 71, 141, 108, 29 }, new byte[] { 134, 216, 68, 198, 117, 38, 197, 210, 78, 57, 107, 123, 202, 68, 175, 46, 212, 1, 84, 198, 220, 122, 185, 242, 250, 236, 126, 245, 252, 80, 154, 40, 13, 208, 157, 42, 148, 11, 19, 32, 174, 18, 67, 100, 18, 105, 55, 133, 96, 83, 117, 81, 51, 54, 228, 139, 69, 244, 239, 250, 102, 49, 128, 47, 187, 111, 126, 17, 247, 26, 54, 254, 100, 44, 168, 234, 198, 94, 245, 146, 93, 176, 8, 169, 123, 231, 63, 37, 97, 108, 115, 46, 78, 5, 147, 8, 94, 106, 24, 32, 190, 66, 147, 129, 172, 155, 120, 32, 153, 29, 213, 122, 79, 173, 247, 51, 33, 227, 24, 54, 101, 123, 55, 179, 112, 114, 13, 134 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 50, 20, 372, DateTimeKind.Utc).AddTicks(4072), new byte[] { 232, 53, 52, 17, 14, 215, 79, 140, 25, 162, 67, 250, 102, 182, 10, 140, 233, 183, 231, 155, 217, 140, 61, 171, 45, 211, 73, 194, 93, 231, 56, 219, 130, 83, 37, 168, 101, 106, 220, 206, 118, 126, 222, 224, 254, 114, 15, 111, 189, 192, 7, 180, 72, 210, 20, 59, 174, 216, 184, 212, 71, 141, 108, 29 }, new byte[] { 134, 216, 68, 198, 117, 38, 197, 210, 78, 57, 107, 123, 202, 68, 175, 46, 212, 1, 84, 198, 220, 122, 185, 242, 250, 236, 126, 245, 252, 80, 154, 40, 13, 208, 157, 42, 148, 11, 19, 32, 174, 18, 67, 100, 18, 105, 55, 133, 96, 83, 117, 81, 51, 54, 228, 139, 69, 244, 239, 250, 102, 49, 128, 47, 187, 111, 126, 17, 247, 26, 54, 254, 100, 44, 168, 234, 198, 94, 245, 146, 93, 176, 8, 169, 123, 231, 63, 37, 97, 108, 115, 46, 78, 5, 147, 8, 94, 106, 24, 32, 190, 66, 147, 129, 172, 155, 120, 32, 153, 29, 213, 122, 79, 173, 247, 51, 33, 227, 24, 54, 101, 123, 55, 179, 112, 114, 13, 134 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
