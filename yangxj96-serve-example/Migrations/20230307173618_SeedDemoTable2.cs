using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace yangxj96_serve_example.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2873), "Description1", "Name1" });

            migrationBuilder.InsertData(
                table: "Demos",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2883), "Description2", "Name2" },
                    { 3, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2885), "Description3", "Name3" },
                    { 4, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2886), "Description4", "Name4" },
                    { 5, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2888), "Description5", "Name5" },
                    { 6, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2890), "Description6", "Name6" },
                    { 7, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2892), "Description7", "Name7" },
                    { 8, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2893), "Description8", "Name8" },
                    { 9, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2895), "Description9", "Name9" },
                    { 10, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2897), "Description10", "Name10" },
                    { 11, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2899), "Description11", "Name11" },
                    { 12, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2901), "Description12", "Name12" },
                    { 13, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2902), "Description13", "Name13" },
                    { 14, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2904), "Description14", "Name14" },
                    { 15, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2906), "Description15", "Name15" },
                    { 16, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2907), "Description16", "Name16" },
                    { 17, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2909), "Description17", "Name17" },
                    { 18, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2911), "Description18", "Name18" },
                    { 19, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2912), "Description19", "Name19" },
                    { 20, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2914), "Description20", "Name20" },
                    { 21, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2916), "Description21", "Name21" },
                    { 22, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2917), "Description22", "Name22" },
                    { 23, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2919), "Description23", "Name23" },
                    { 24, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2920), "Description24", "Name24" },
                    { 25, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2922), "Description25", "Name25" },
                    { 26, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2923), "Description26", "Name26" },
                    { 27, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2925), "Description27", "Name27" },
                    { 28, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2926), "Description28", "Name28" },
                    { 29, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2928), "Description29", "Name29" },
                    { 30, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2929), "Description30", "Name30" },
                    { 31, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2931), "Description31", "Name31" },
                    { 32, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2932), "Description32", "Name32" },
                    { 33, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2934), "Description33", "Name33" },
                    { 34, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2956), "Description34", "Name34" },
                    { 35, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2958), "Description35", "Name35" },
                    { 36, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2960), "Description36", "Name36" },
                    { 37, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2961), "Description37", "Name37" },
                    { 38, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2963), "Description38", "Name38" },
                    { 39, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2964), "Description39", "Name39" },
                    { 40, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2966), "Description40", "Name40" },
                    { 41, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2967), "Description41", "Name41" },
                    { 42, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2969), "Description42", "Name42" },
                    { 43, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2970), "Description43", "Name43" },
                    { 44, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2972), "Description44", "Name44" },
                    { 45, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2973), "Description45", "Name45" },
                    { 46, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2975), "Description46", "Name46" },
                    { 47, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2976), "Description47", "Name47" },
                    { 48, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2978), "Description48", "Name48" },
                    { 49, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2979), "Description49", "Name49" },
                    { 50, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2981), "Description50", "Name50" },
                    { 51, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2982), "Description51", "Name51" },
                    { 52, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2984), "Description52", "Name52" },
                    { 53, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2985), "Description53", "Name53" },
                    { 54, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2987), "Description54", "Name54" },
                    { 55, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2988), "Description55", "Name55" },
                    { 56, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2990), "Description56", "Name56" },
                    { 57, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2992), "Description57", "Name57" },
                    { 58, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2993), "Description58", "Name58" },
                    { 59, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2995), "Description59", "Name59" },
                    { 60, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2996), "Description60", "Name60" },
                    { 61, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2997), "Description61", "Name61" },
                    { 62, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2999), "Description62", "Name62" },
                    { 63, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3001), "Description63", "Name63" },
                    { 64, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3002), "Description64", "Name64" },
                    { 65, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3004), "Description65", "Name65" },
                    { 66, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3006), "Description66", "Name66" },
                    { 67, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3007), "Description67", "Name67" },
                    { 68, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3009), "Description68", "Name68" },
                    { 69, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3010), "Description69", "Name69" },
                    { 70, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3012), "Description70", "Name70" },
                    { 71, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3013), "Description71", "Name71" },
                    { 72, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3015), "Description72", "Name72" },
                    { 73, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3016), "Description73", "Name73" },
                    { 74, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3018), "Description74", "Name74" },
                    { 75, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3019), "Description75", "Name75" },
                    { 76, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3021), "Description76", "Name76" },
                    { 77, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3022), "Description77", "Name77" },
                    { 78, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3024), "Description78", "Name78" },
                    { 79, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3025), "Description79", "Name79" },
                    { 80, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3027), "Description80", "Name80" },
                    { 81, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3028), "Description81", "Name81" },
                    { 82, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3030), "Description82", "Name82" },
                    { 83, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3053), "Description83", "Name83" },
                    { 84, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3055), "Description84", "Name84" },
                    { 85, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3057), "Description85", "Name85" },
                    { 86, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3058), "Description86", "Name86" },
                    { 87, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3060), "Description87", "Name87" },
                    { 88, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3061), "Description88", "Name88" },
                    { 89, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3063), "Description89", "Name89" },
                    { 90, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3064), "Description90", "Name90" },
                    { 91, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3066), "Description91", "Name91" },
                    { 92, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3067), "Description92", "Name92" },
                    { 93, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3069), "Description93", "Name93" },
                    { 94, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3070), "Description94", "Name94" },
                    { 95, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3072), "Description95", "Name95" },
                    { 96, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3073), "Description96", "Name96" },
                    { 97, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3074), "Description97", "Name97" },
                    { 98, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3076), "Description98", "Name98" },
                    { 99, new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3078), "Description99", "Name99" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.UpdateData(
                table: "Demos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "name" });
        }
    }
}
