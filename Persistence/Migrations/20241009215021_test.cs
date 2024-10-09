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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 848, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 848, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 0, 22, 33, 849, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 22, 33, 848, DateTimeKind.Utc).AddTicks(8587), new byte[] { 43, 102, 223, 53, 145, 22, 219, 133, 88, 136, 190, 81, 25, 97, 91, 171, 172, 34, 104, 184, 127, 171, 60, 102, 18, 251, 91, 12, 194, 27, 149, 204, 115, 169, 47, 77, 9, 115, 70, 164, 99, 152, 180, 245, 142, 115, 80, 242, 211, 86, 25, 249, 198, 165, 207, 249, 104, 60, 224, 10, 97, 39, 181, 86 }, new byte[] { 73, 223, 233, 251, 183, 30, 238, 53, 147, 57, 129, 72, 208, 78, 114, 50, 248, 161, 163, 92, 12, 35, 133, 98, 18, 59, 69, 168, 10, 17, 250, 161, 121, 185, 71, 161, 176, 83, 145, 124, 187, 42, 75, 23, 237, 144, 161, 112, 67, 206, 37, 90, 200, 148, 90, 103, 59, 222, 0, 133, 33, 253, 133, 180, 37, 96, 238, 39, 114, 247, 111, 132, 96, 61, 58, 245, 227, 18, 150, 8, 215, 9, 98, 105, 176, 127, 243, 200, 201, 39, 181, 251, 250, 155, 37, 84, 252, 220, 15, 114, 14, 147, 245, 146, 111, 240, 2, 34, 113, 100, 176, 47, 221, 81, 15, 98, 174, 9, 8, 206, 219, 74, 49, 152, 201, 246, 10, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 22, 33, 848, DateTimeKind.Utc).AddTicks(8795), new byte[] { 43, 102, 223, 53, 145, 22, 219, 133, 88, 136, 190, 81, 25, 97, 91, 171, 172, 34, 104, 184, 127, 171, 60, 102, 18, 251, 91, 12, 194, 27, 149, 204, 115, 169, 47, 77, 9, 115, 70, 164, 99, 152, 180, 245, 142, 115, 80, 242, 211, 86, 25, 249, 198, 165, 207, 249, 104, 60, 224, 10, 97, 39, 181, 86 }, new byte[] { 73, 223, 233, 251, 183, 30, 238, 53, 147, 57, 129, 72, 208, 78, 114, 50, 248, 161, 163, 92, 12, 35, 133, 98, 18, 59, 69, 168, 10, 17, 250, 161, 121, 185, 71, 161, 176, 83, 145, 124, 187, 42, 75, 23, 237, 144, 161, 112, 67, 206, 37, 90, 200, 148, 90, 103, 59, 222, 0, 133, 33, 253, 133, 180, 37, 96, 238, 39, 114, 247, 111, 132, 96, 61, 58, 245, 227, 18, 150, 8, 215, 9, 98, 105, 176, 127, 243, 200, 201, 39, 181, 251, 250, 155, 37, 84, 252, 220, 15, 114, 14, 147, 245, 146, 111, 240, 2, 34, 113, 100, 176, 47, 221, 81, 15, 98, 174, 9, 8, 206, 219, 74, 49, 152, 201, 246, 10, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 22, 33, 848, DateTimeKind.Utc).AddTicks(8909), new byte[] { 43, 102, 223, 53, 145, 22, 219, 133, 88, 136, 190, 81, 25, 97, 91, 171, 172, 34, 104, 184, 127, 171, 60, 102, 18, 251, 91, 12, 194, 27, 149, 204, 115, 169, 47, 77, 9, 115, 70, 164, 99, 152, 180, 245, 142, 115, 80, 242, 211, 86, 25, 249, 198, 165, 207, 249, 104, 60, 224, 10, 97, 39, 181, 86 }, new byte[] { 73, 223, 233, 251, 183, 30, 238, 53, 147, 57, 129, 72, 208, 78, 114, 50, 248, 161, 163, 92, 12, 35, 133, 98, 18, 59, 69, 168, 10, 17, 250, 161, 121, 185, 71, 161, 176, 83, 145, 124, 187, 42, 75, 23, 237, 144, 161, 112, 67, 206, 37, 90, 200, 148, 90, 103, 59, 222, 0, 133, 33, 253, 133, 180, 37, 96, 238, 39, 114, 247, 111, 132, 96, 61, 58, 245, 227, 18, 150, 8, 215, 9, 98, 105, 176, 127, 243, 200, 201, 39, 181, 251, 250, 155, 37, 84, 252, 220, 15, 114, 14, 147, 245, 146, 111, 240, 2, 34, 113, 100, 176, 47, 221, 81, 15, 98, 174, 9, 8, 206, 219, 74, 49, 152, 201, 246, 10, 247 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 9, 21, 22, 33, 848, DateTimeKind.Utc).AddTicks(9056), new byte[] { 43, 102, 223, 53, 145, 22, 219, 133, 88, 136, 190, 81, 25, 97, 91, 171, 172, 34, 104, 184, 127, 171, 60, 102, 18, 251, 91, 12, 194, 27, 149, 204, 115, 169, 47, 77, 9, 115, 70, 164, 99, 152, 180, 245, 142, 115, 80, 242, 211, 86, 25, 249, 198, 165, 207, 249, 104, 60, 224, 10, 97, 39, 181, 86 }, new byte[] { 73, 223, 233, 251, 183, 30, 238, 53, 147, 57, 129, 72, 208, 78, 114, 50, 248, 161, 163, 92, 12, 35, 133, 98, 18, 59, 69, 168, 10, 17, 250, 161, 121, 185, 71, 161, 176, 83, 145, 124, 187, 42, 75, 23, 237, 144, 161, 112, 67, 206, 37, 90, 200, 148, 90, 103, 59, 222, 0, 133, 33, 253, 133, 180, 37, 96, 238, 39, 114, 247, 111, 132, 96, 61, 58, 245, 227, 18, 150, 8, 215, 9, 98, 105, 176, 127, 243, 200, 201, 39, 181, 251, 250, 155, 37, 84, 252, 220, 15, 114, 14, 147, 245, 146, 111, 240, 2, 34, 113, 100, 176, 47, 221, 81, 15, 98, 174, 9, 8, 206, 219, 74, 49, 152, 201, 246, 10, 247 } });
        }
    }
}
