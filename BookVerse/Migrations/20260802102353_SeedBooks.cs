using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookVerse.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "CoverImage", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "James Clear", "Self Help", "atomic-habits.jpg", "A practical guide to building good habits.", 5.0, "Atomic Habits" },
                    { 2, "Robert Kiyosaki", "Finance", "rich-dad-poor-dad.jpg", "A book about money, investing and financial education.", 5.0, "Rich Dad Poor Dad" },
                    { 3, "A.P.J. Abdul Kalam", "Biography", "wings-of-fire.jpg", "The inspiring autobiography of A.P.J. Abdul Kalam.", 5.0, "Wings of Fire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
