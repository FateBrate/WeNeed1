using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class reccomender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportsCenterRecommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseSportsCenterId = table.Column<int>(type: "int", nullable: false),
                    RecommendedSportsCenterId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsCenterRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportsCenterRecommendations_SportsCenters_BaseSportsCenterId",
                        column: x => x.BaseSportsCenterId,
                        principalTable: "SportsCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportsCenterRecommendations_SportsCenters_RecommendedSportsCenterId",
                        column: x => x.RecommendedSportsCenterId,
                        principalTable: "SportsCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 2, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 7, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 7, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 8, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 8, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 8, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7/LPKrQI6/9El9Ao5NcH1E1sKfVQXEIEiZT2ymANJc8=", "DlzfufN7l4DYuDxxosqjUFQV+H22/3rbaTbNptCdIrIr4DDVhCLNhcwy4G7QoIUUHj3wEjIx6InvVTcSqW8kMw==" });

            migrationBuilder.CreateIndex(
                name: "IX_SportsCenterRecommendations_BaseSportsCenterId",
                table: "SportsCenterRecommendations",
                column: "BaseSportsCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsCenterRecommendations_RecommendedSportsCenterId",
                table: "SportsCenterRecommendations",
                column: "RecommendedSportsCenterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportsCenterRecommendations");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 29, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 28, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 28, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 2, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 27, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 29, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 2, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 29, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 29, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 30, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 30, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 1, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 1, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "weBaadugztjYCXrAGA1oM2lBazulCe9hMchqrm1JLo4=", "DNepXSq7rumwLA0UU3imqFOgho1zYQqDXBGRB4cb+4xkF4tBHZdgZz4agheX4SCOWeW90oyU68ufKeasZH/fDA==" });
        }
    }
}
