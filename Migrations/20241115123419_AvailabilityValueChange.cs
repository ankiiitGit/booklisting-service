using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookListingMicroService.Migrations
{
    /// <inheritdoc />
    public partial class AvailabilityValueChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 1L,
                column: "availability",
                value: "Available");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 2L,
                column: "availability",
                value: "Available");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 3L,
                column: "availability",
                value: "Available");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 1L,
                column: "availability",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 2L,
                column: "availability",
                value: "Yes");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 3L,
                column: "availability",
                value: "Yes");
        }
    }
}
