using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookListingMicroService.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "bookId", "author", "availability", "bookCondition", "genre", "title" },
                values: new object[,]
                {
                    { 1L, "James Clear", "Yes", "Good", "Self Help book", "Atomic Habits" },
                    { 2L, "Ayn Rand", "Yes", "Good", "Philosophical fiction", "The Fountainhead" },
                    { 3L, "Robert Kiyosaki and Sharon Lechter", "Yes", "Good", "Personal finance", "Rich Dad Poor Dad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "bookId",
                keyValue: 3L);
        }
    }
}
