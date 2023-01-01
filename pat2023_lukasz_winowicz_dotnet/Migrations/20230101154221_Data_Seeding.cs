using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace pat2023lukaszwinowiczdotnet.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1949, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haruki", false, "Murakami" },
                    { 2, new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.R.R.", false, "Tolkien" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "ISBN", "PublicationDate", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "In 1Q84 ...", "XXX123", new DateTime(1988, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.2m, "1Q84 Tom 1" },
                    { 2, "In 1Q84 ...", "XXX124", new DateTime(1989, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5m, "1Q84 Tom 2" },
                    { 3, "Bilbo was...", "XXX125", new DateTime(1925, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.5m, "Hobbit" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

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
