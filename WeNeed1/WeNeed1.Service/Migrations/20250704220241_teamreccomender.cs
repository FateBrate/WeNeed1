using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class teamreccomender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportsTeamRecommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseTeamId = table.Column<int>(type: "int", nullable: false),
                    RecommendedTeamId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsTeamRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportsTeamRecommendations_Teams_BaseTeamId",
                        column: x => x.BaseTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportsTeamRecommendations_Teams_RecommendedTeamId",
                        column: x => x.RecommendedTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 3, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 3, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 7, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 8, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 8, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 2, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 7, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 7, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 4, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 4, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 5, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 5, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 6, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 7, 6, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "2ROG1meimBDJ9JAkbqEbtrIylKTSn9kdkW4fJNUHWA0=", "l+B0B8CPtChu4eg/fj6I7vObFS8bBE/OK9PNf7GDiYq7WSFT3CvYc9AU2Ux7jXQnSyMB/pu+9yQB5wcsrt5wAA==" });

            migrationBuilder.CreateIndex(
                name: "IX_SportsTeamRecommendations_BaseTeamId",
                table: "SportsTeamRecommendations",
                column: "BaseTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsTeamRecommendations_RecommendedTeamId",
                table: "SportsTeamRecommendations",
                column: "RecommendedTeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportsTeamRecommendations");

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
        }
    }
}
