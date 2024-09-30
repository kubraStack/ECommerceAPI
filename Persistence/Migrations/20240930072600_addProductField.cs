using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addProductField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FinalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "FinalPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "FinalPrice",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "UserOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 11, 2, 2, 204, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5341), new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5504), new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5610), new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 8, 2, 2, 204, DateTimeKind.Utc).AddTicks(5767), new byte[] { 25, 181, 68, 152, 64, 10, 179, 125, 56, 74, 250, 174, 216, 224, 249, 138, 154, 115, 170, 37, 26, 136, 193, 246, 171, 232, 66, 153, 45, 1, 97, 126, 228, 137, 249, 182, 75, 70, 24, 118, 195, 113, 226, 49, 221, 152, 139, 210, 64, 43, 231, 173, 254, 145, 69, 106, 78, 73, 250, 155, 50, 15, 79, 154 }, new byte[] { 173, 177, 173, 115, 98, 73, 231, 150, 140, 200, 206, 28, 74, 36, 242, 204, 232, 188, 172, 116, 223, 81, 202, 219, 232, 43, 27, 148, 35, 82, 168, 47, 176, 196, 179, 243, 217, 160, 229, 85, 188, 156, 229, 113, 252, 135, 254, 116, 51, 85, 19, 146, 106, 195, 227, 242, 228, 104, 43, 198, 70, 142, 53, 90, 102, 179, 201, 45, 104, 150, 235, 234, 176, 103, 121, 99, 214, 138, 193, 29, 33, 5, 60, 154, 195, 117, 232, 204, 12, 97, 92, 208, 221, 41, 137, 121, 195, 28, 155, 161, 80, 120, 174, 110, 3, 6, 79, 33, 123, 213, 245, 17, 243, 5, 62, 243, 127, 50, 15, 159, 141, 224, 10, 73, 244, 197, 232, 93 } });
        }
    }
}
