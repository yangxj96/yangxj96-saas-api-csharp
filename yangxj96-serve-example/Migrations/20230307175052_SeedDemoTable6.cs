using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yangxj96_serve_example.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoTable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Demos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(797), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(807), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(808), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(810), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(811), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(813), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(814), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(849), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(851), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(853), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(854), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(855), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(856), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(858), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(859), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(860), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(861), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(863), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(864), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(865), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(866), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(867), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(868), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(869), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(870), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(872), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(873), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(874), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(875), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(876), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(877), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(878), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(879), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(880), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(881), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(883), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(884), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(885), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(886), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(887), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(888), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(889), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(890), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(891), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(892), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(893), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(894), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(895), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(896), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(897), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(898), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(899), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(900), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(901), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(902), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(903), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(904), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(926), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(927), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(928), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(929), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(930), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(931), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(932), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(933), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(935), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(937), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(938), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(939), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(940), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(941), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(942), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(943), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(944), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(945), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(946), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(947), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(948), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(949), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(950), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(951), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(952), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(953), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(954), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(955), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(957), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(958), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(959), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(960), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(961), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(962), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(963), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(964), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(965), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(966), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(967), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(968), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(969), false });

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IsDeleted" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 50, 52, 311, DateTimeKind.Local).AddTicks(970), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Demos");

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 533, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 8, 1, 48, 59, 534, DateTimeKind.Local).AddTicks(15));
        }
    }
}
