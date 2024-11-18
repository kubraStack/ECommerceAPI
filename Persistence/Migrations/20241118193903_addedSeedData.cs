using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "GuestInfo", "OrderDate", "OrderStatusId", "OrderStatusId1", "PaymentId", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, null, 3, null, null, null, 3, null, 3, 8m, null },
                    { 5, null, 2, null, null, null, 3, null, 3, 28m, null },
                    { 6, null, 1, null, null, null, 3, null, 3, 18m, null }
                });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "FinalPrice", "ImageUrl", "Name", "Price", "StockQuantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, 1, null, null, "Description", null, "https://websitedemos.net/ceramic-products-store-04/wp-content/uploads/sites/1413/2024/02/ceramic-cup-01-300x300.jpg", "Kupa", 350m, 55, null },
                    { 5, 2, null, null, "Description", null, "https://images.pexels.com/photos/29432556/pexels-photo-29432556/free-photo-of-masada-mumlu-mavi-vazoda-mor-cicekler.jpeg", "Vazo", 750m, 25, null },
                    { 6, 3, null, null, "Description", null, "https://images.pexels.com/photos/21273580/pexels-photo-21273580/free-photo-of-yapraklar-pencereler-camlar-bitkiler.jpeg", "Saksı", 550m, 85, null }
                });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 18, 22, 39, 2, 950, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(4614), new byte[] { 42, 18, 9, 178, 22, 53, 79, 190, 239, 8, 248, 124, 41, 229, 44, 171, 130, 34, 3, 132, 199, 225, 83, 108, 109, 90, 120, 171, 244, 25, 136, 86, 126, 96, 202, 72, 5, 84, 250, 247, 4, 242, 127, 20, 228, 129, 170, 96, 42, 137, 194, 143, 173, 154, 210, 118, 100, 238, 168, 46, 70, 233, 153, 180 }, new byte[] { 209, 170, 1, 45, 25, 200, 95, 190, 149, 202, 13, 171, 35, 97, 18, 2, 192, 206, 212, 133, 98, 253, 39, 221, 119, 50, 155, 219, 145, 64, 47, 189, 160, 178, 206, 147, 12, 10, 52, 214, 36, 65, 20, 176, 127, 196, 117, 28, 218, 17, 184, 125, 84, 46, 88, 143, 123, 184, 161, 108, 180, 221, 146, 246, 61, 16, 222, 225, 38, 68, 57, 175, 138, 244, 235, 4, 13, 243, 170, 219, 173, 147, 155, 199, 59, 89, 42, 121, 242, 32, 126, 162, 215, 60, 205, 165, 179, 177, 233, 99, 118, 223, 125, 38, 83, 242, 18, 166, 159, 85, 249, 14, 152, 177, 218, 56, 173, 229, 219, 59, 215, 120, 109, 164, 137, 52, 82, 50 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(4712), new byte[] { 42, 18, 9, 178, 22, 53, 79, 190, 239, 8, 248, 124, 41, 229, 44, 171, 130, 34, 3, 132, 199, 225, 83, 108, 109, 90, 120, 171, 244, 25, 136, 86, 126, 96, 202, 72, 5, 84, 250, 247, 4, 242, 127, 20, 228, 129, 170, 96, 42, 137, 194, 143, 173, 154, 210, 118, 100, 238, 168, 46, 70, 233, 153, 180 }, new byte[] { 209, 170, 1, 45, 25, 200, 95, 190, 149, 202, 13, 171, 35, 97, 18, 2, 192, 206, 212, 133, 98, 253, 39, 221, 119, 50, 155, 219, 145, 64, 47, 189, 160, 178, 206, 147, 12, 10, 52, 214, 36, 65, 20, 176, 127, 196, 117, 28, 218, 17, 184, 125, 84, 46, 88, 143, 123, 184, 161, 108, 180, 221, 146, 246, 61, 16, 222, 225, 38, 68, 57, 175, 138, 244, 235, 4, 13, 243, 170, 219, 173, 147, 155, 199, 59, 89, 42, 121, 242, 32, 126, 162, 215, 60, 205, 165, 179, 177, 233, 99, 118, 223, 125, 38, 83, 242, 18, 166, 159, 85, 249, 14, 152, 177, 218, 56, 173, 229, 219, 59, 215, 120, 109, 164, 137, 52, 82, 50 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(4794), new byte[] { 42, 18, 9, 178, 22, 53, 79, 190, 239, 8, 248, 124, 41, 229, 44, 171, 130, 34, 3, 132, 199, 225, 83, 108, 109, 90, 120, 171, 244, 25, 136, 86, 126, 96, 202, 72, 5, 84, 250, 247, 4, 242, 127, 20, 228, 129, 170, 96, 42, 137, 194, 143, 173, 154, 210, 118, 100, 238, 168, 46, 70, 233, 153, 180 }, new byte[] { 209, 170, 1, 45, 25, 200, 95, 190, 149, 202, 13, 171, 35, 97, 18, 2, 192, 206, 212, 133, 98, 253, 39, 221, 119, 50, 155, 219, 145, 64, 47, 189, 160, 178, 206, 147, 12, 10, 52, 214, 36, 65, 20, 176, 127, 196, 117, 28, 218, 17, 184, 125, 84, 46, 88, 143, 123, 184, 161, 108, 180, 221, 146, 246, 61, 16, 222, 225, 38, 68, 57, 175, 138, 244, 235, 4, 13, 243, 170, 219, 173, 147, 155, 199, 59, 89, 42, 121, 242, 32, 126, 162, 215, 60, 205, 165, 179, 177, 233, 99, 118, 223, 125, 38, 83, 242, 18, 166, 159, 85, 249, 14, 152, 177, 218, 56, 173, 229, 219, 59, 215, 120, 109, 164, 137, 52, 82, 50 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 2, 950, DateTimeKind.Utc).AddTicks(4871), new byte[] { 42, 18, 9, 178, 22, 53, 79, 190, 239, 8, 248, 124, 41, 229, 44, 171, 130, 34, 3, 132, 199, 225, 83, 108, 109, 90, 120, 171, 244, 25, 136, 86, 126, 96, 202, 72, 5, 84, 250, 247, 4, 242, 127, 20, 228, 129, 170, 96, 42, 137, 194, 143, 173, 154, 210, 118, 100, 238, 168, 46, 70, 233, 153, 180 }, new byte[] { 209, 170, 1, 45, 25, 200, 95, 190, 149, 202, 13, 171, 35, 97, 18, 2, 192, 206, 212, 133, 98, 253, 39, 221, 119, 50, 155, 219, 145, 64, 47, 189, 160, 178, 206, 147, 12, 10, 52, 214, 36, 65, 20, 176, 127, 196, 117, 28, 218, 17, 184, 125, 84, 46, 88, 143, 123, 184, 161, 108, 180, 221, 146, 246, 61, 16, 222, 225, 38, 68, 57, 175, 138, 244, 235, 4, 13, 243, 170, 219, 173, 147, 155, 199, 59, 89, 42, 121, 242, 32, 126, 162, 215, 60, 205, 165, 179, 177, 233, 99, 118, 223, 125, 38, 83, 242, 18, 166, 159, 85, 249, 14, 152, 177, 218, 56, 173, 229, 219, 59, 215, 120, 109, 164, 137, 52, 82, 50 } });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OrderId", "Price", "ProductId", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, null, null, 4, 500m, 4, 3, null },
                    { 5, null, null, 5, 500m, 5, 3, null },
                    { 6, null, null, 6, 500m, 6, 3, null }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "ProductId", "Rating", "Review", "ReviewDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, null, 3, null, 4, 4, "Çok güzel bir kupa ve kullanışlı.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, 3, null, 5, 5, "Çok güzel bir vazo ve çok şık durdu.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, 3, null, 5, 5, "Çok güzel bir saksı çiceklerimle çok uyumlu.", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 15, 16, 35, 55, 648, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(1688), new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(1865), new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(2046), new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 11, 15, 13, 35, 55, 648, DateTimeKind.Utc).AddTicks(2218), new byte[] { 142, 73, 186, 225, 24, 87, 241, 135, 40, 54, 232, 86, 7, 205, 238, 157, 97, 241, 51, 51, 237, 104, 32, 235, 64, 135, 68, 178, 245, 10, 195, 209, 165, 207, 255, 210, 207, 48, 120, 23, 70, 156, 38, 31, 233, 87, 245, 11, 112, 185, 176, 30, 216, 243, 183, 118, 187, 40, 67, 115, 36, 248, 248, 14 }, new byte[] { 112, 111, 10, 139, 219, 198, 148, 133, 210, 114, 132, 33, 44, 78, 224, 165, 190, 141, 177, 232, 121, 96, 88, 88, 207, 192, 44, 240, 242, 26, 113, 124, 220, 82, 90, 238, 34, 161, 114, 248, 54, 145, 38, 162, 160, 132, 43, 236, 140, 90, 25, 231, 11, 57, 147, 48, 164, 83, 24, 102, 174, 142, 152, 58, 142, 95, 56, 248, 28, 34, 249, 232, 25, 124, 173, 169, 96, 161, 231, 224, 157, 118, 167, 64, 151, 108, 167, 21, 106, 238, 48, 110, 234, 132, 161, 28, 120, 157, 84, 187, 45, 5, 9, 49, 16, 206, 109, 141, 152, 78, 213, 119, 178, 52, 187, 161, 195, 76, 138, 227, 114, 20, 80, 6, 20, 10, 165, 204 } });
        }
    }
}
