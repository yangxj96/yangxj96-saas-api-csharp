﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yangxj96_serve_example.Repository;

#nullable disable

namespace yangxj96_serve_example.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230307173618_SeedDemoTable2")]
    partial class SeedDemoTable2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("yangxj96_serve_example.Model.Demo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Demos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2873),
                            Description = "Description1",
                            Name = "Name1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2883),
                            Description = "Description2",
                            Name = "Name2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2885),
                            Description = "Description3",
                            Name = "Name3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2886),
                            Description = "Description4",
                            Name = "Name4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2888),
                            Description = "Description5",
                            Name = "Name5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2890),
                            Description = "Description6",
                            Name = "Name6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2892),
                            Description = "Description7",
                            Name = "Name7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2893),
                            Description = "Description8",
                            Name = "Name8"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2895),
                            Description = "Description9",
                            Name = "Name9"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2897),
                            Description = "Description10",
                            Name = "Name10"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2899),
                            Description = "Description11",
                            Name = "Name11"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2901),
                            Description = "Description12",
                            Name = "Name12"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2902),
                            Description = "Description13",
                            Name = "Name13"
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2904),
                            Description = "Description14",
                            Name = "Name14"
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2906),
                            Description = "Description15",
                            Name = "Name15"
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2907),
                            Description = "Description16",
                            Name = "Name16"
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2909),
                            Description = "Description17",
                            Name = "Name17"
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2911),
                            Description = "Description18",
                            Name = "Name18"
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2912),
                            Description = "Description19",
                            Name = "Name19"
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2914),
                            Description = "Description20",
                            Name = "Name20"
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2916),
                            Description = "Description21",
                            Name = "Name21"
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2917),
                            Description = "Description22",
                            Name = "Name22"
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2919),
                            Description = "Description23",
                            Name = "Name23"
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2920),
                            Description = "Description24",
                            Name = "Name24"
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2922),
                            Description = "Description25",
                            Name = "Name25"
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2923),
                            Description = "Description26",
                            Name = "Name26"
                        },
                        new
                        {
                            Id = 27,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2925),
                            Description = "Description27",
                            Name = "Name27"
                        },
                        new
                        {
                            Id = 28,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2926),
                            Description = "Description28",
                            Name = "Name28"
                        },
                        new
                        {
                            Id = 29,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2928),
                            Description = "Description29",
                            Name = "Name29"
                        },
                        new
                        {
                            Id = 30,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2929),
                            Description = "Description30",
                            Name = "Name30"
                        },
                        new
                        {
                            Id = 31,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2931),
                            Description = "Description31",
                            Name = "Name31"
                        },
                        new
                        {
                            Id = 32,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2932),
                            Description = "Description32",
                            Name = "Name32"
                        },
                        new
                        {
                            Id = 33,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2934),
                            Description = "Description33",
                            Name = "Name33"
                        },
                        new
                        {
                            Id = 34,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2956),
                            Description = "Description34",
                            Name = "Name34"
                        },
                        new
                        {
                            Id = 35,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2958),
                            Description = "Description35",
                            Name = "Name35"
                        },
                        new
                        {
                            Id = 36,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2960),
                            Description = "Description36",
                            Name = "Name36"
                        },
                        new
                        {
                            Id = 37,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2961),
                            Description = "Description37",
                            Name = "Name37"
                        },
                        new
                        {
                            Id = 38,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2963),
                            Description = "Description38",
                            Name = "Name38"
                        },
                        new
                        {
                            Id = 39,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2964),
                            Description = "Description39",
                            Name = "Name39"
                        },
                        new
                        {
                            Id = 40,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2966),
                            Description = "Description40",
                            Name = "Name40"
                        },
                        new
                        {
                            Id = 41,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2967),
                            Description = "Description41",
                            Name = "Name41"
                        },
                        new
                        {
                            Id = 42,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2969),
                            Description = "Description42",
                            Name = "Name42"
                        },
                        new
                        {
                            Id = 43,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2970),
                            Description = "Description43",
                            Name = "Name43"
                        },
                        new
                        {
                            Id = 44,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2972),
                            Description = "Description44",
                            Name = "Name44"
                        },
                        new
                        {
                            Id = 45,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2973),
                            Description = "Description45",
                            Name = "Name45"
                        },
                        new
                        {
                            Id = 46,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2975),
                            Description = "Description46",
                            Name = "Name46"
                        },
                        new
                        {
                            Id = 47,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2976),
                            Description = "Description47",
                            Name = "Name47"
                        },
                        new
                        {
                            Id = 48,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2978),
                            Description = "Description48",
                            Name = "Name48"
                        },
                        new
                        {
                            Id = 49,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2979),
                            Description = "Description49",
                            Name = "Name49"
                        },
                        new
                        {
                            Id = 50,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2981),
                            Description = "Description50",
                            Name = "Name50"
                        },
                        new
                        {
                            Id = 51,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2982),
                            Description = "Description51",
                            Name = "Name51"
                        },
                        new
                        {
                            Id = 52,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2984),
                            Description = "Description52",
                            Name = "Name52"
                        },
                        new
                        {
                            Id = 53,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2985),
                            Description = "Description53",
                            Name = "Name53"
                        },
                        new
                        {
                            Id = 54,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2987),
                            Description = "Description54",
                            Name = "Name54"
                        },
                        new
                        {
                            Id = 55,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2988),
                            Description = "Description55",
                            Name = "Name55"
                        },
                        new
                        {
                            Id = 56,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2990),
                            Description = "Description56",
                            Name = "Name56"
                        },
                        new
                        {
                            Id = 57,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2992),
                            Description = "Description57",
                            Name = "Name57"
                        },
                        new
                        {
                            Id = 58,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2993),
                            Description = "Description58",
                            Name = "Name58"
                        },
                        new
                        {
                            Id = 59,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2995),
                            Description = "Description59",
                            Name = "Name59"
                        },
                        new
                        {
                            Id = 60,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2996),
                            Description = "Description60",
                            Name = "Name60"
                        },
                        new
                        {
                            Id = 61,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2997),
                            Description = "Description61",
                            Name = "Name61"
                        },
                        new
                        {
                            Id = 62,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(2999),
                            Description = "Description62",
                            Name = "Name62"
                        },
                        new
                        {
                            Id = 63,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3001),
                            Description = "Description63",
                            Name = "Name63"
                        },
                        new
                        {
                            Id = 64,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3002),
                            Description = "Description64",
                            Name = "Name64"
                        },
                        new
                        {
                            Id = 65,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3004),
                            Description = "Description65",
                            Name = "Name65"
                        },
                        new
                        {
                            Id = 66,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3006),
                            Description = "Description66",
                            Name = "Name66"
                        },
                        new
                        {
                            Id = 67,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3007),
                            Description = "Description67",
                            Name = "Name67"
                        },
                        new
                        {
                            Id = 68,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3009),
                            Description = "Description68",
                            Name = "Name68"
                        },
                        new
                        {
                            Id = 69,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3010),
                            Description = "Description69",
                            Name = "Name69"
                        },
                        new
                        {
                            Id = 70,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3012),
                            Description = "Description70",
                            Name = "Name70"
                        },
                        new
                        {
                            Id = 71,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3013),
                            Description = "Description71",
                            Name = "Name71"
                        },
                        new
                        {
                            Id = 72,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3015),
                            Description = "Description72",
                            Name = "Name72"
                        },
                        new
                        {
                            Id = 73,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3016),
                            Description = "Description73",
                            Name = "Name73"
                        },
                        new
                        {
                            Id = 74,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3018),
                            Description = "Description74",
                            Name = "Name74"
                        },
                        new
                        {
                            Id = 75,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3019),
                            Description = "Description75",
                            Name = "Name75"
                        },
                        new
                        {
                            Id = 76,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3021),
                            Description = "Description76",
                            Name = "Name76"
                        },
                        new
                        {
                            Id = 77,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3022),
                            Description = "Description77",
                            Name = "Name77"
                        },
                        new
                        {
                            Id = 78,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3024),
                            Description = "Description78",
                            Name = "Name78"
                        },
                        new
                        {
                            Id = 79,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3025),
                            Description = "Description79",
                            Name = "Name79"
                        },
                        new
                        {
                            Id = 80,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3027),
                            Description = "Description80",
                            Name = "Name80"
                        },
                        new
                        {
                            Id = 81,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3028),
                            Description = "Description81",
                            Name = "Name81"
                        },
                        new
                        {
                            Id = 82,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3030),
                            Description = "Description82",
                            Name = "Name82"
                        },
                        new
                        {
                            Id = 83,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3053),
                            Description = "Description83",
                            Name = "Name83"
                        },
                        new
                        {
                            Id = 84,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3055),
                            Description = "Description84",
                            Name = "Name84"
                        },
                        new
                        {
                            Id = 85,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3057),
                            Description = "Description85",
                            Name = "Name85"
                        },
                        new
                        {
                            Id = 86,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3058),
                            Description = "Description86",
                            Name = "Name86"
                        },
                        new
                        {
                            Id = 87,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3060),
                            Description = "Description87",
                            Name = "Name87"
                        },
                        new
                        {
                            Id = 88,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3061),
                            Description = "Description88",
                            Name = "Name88"
                        },
                        new
                        {
                            Id = 89,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3063),
                            Description = "Description89",
                            Name = "Name89"
                        },
                        new
                        {
                            Id = 90,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3064),
                            Description = "Description90",
                            Name = "Name90"
                        },
                        new
                        {
                            Id = 91,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3066),
                            Description = "Description91",
                            Name = "Name91"
                        },
                        new
                        {
                            Id = 92,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3067),
                            Description = "Description92",
                            Name = "Name92"
                        },
                        new
                        {
                            Id = 93,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3069),
                            Description = "Description93",
                            Name = "Name93"
                        },
                        new
                        {
                            Id = 94,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3070),
                            Description = "Description94",
                            Name = "Name94"
                        },
                        new
                        {
                            Id = 95,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3072),
                            Description = "Description95",
                            Name = "Name95"
                        },
                        new
                        {
                            Id = 96,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3073),
                            Description = "Description96",
                            Name = "Name96"
                        },
                        new
                        {
                            Id = 97,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3074),
                            Description = "Description97",
                            Name = "Name97"
                        },
                        new
                        {
                            Id = 98,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3076),
                            Description = "Description98",
                            Name = "Name98"
                        },
                        new
                        {
                            Id = 99,
                            CreatedDate = new DateTime(2023, 3, 8, 1, 36, 18, 134, DateTimeKind.Local).AddTicks(3078),
                            Description = "Description99",
                            Name = "Name99"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
