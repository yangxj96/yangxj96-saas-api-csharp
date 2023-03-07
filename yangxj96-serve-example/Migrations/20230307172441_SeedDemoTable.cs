using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yangxj96_serve_example.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Demos",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "name" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
