using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yangxj96_serve_example.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Demos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Demos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 41, 56, 328, DateTimeKind.Local).AddTicks(7523));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Demos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Demos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3078));
        }
    }
}
