using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class usersports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Sport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "UserSports",
                columns: new[] { "Id", "Sport", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 2, 10 },
                    { 3, 8, 10 },
                    { 4, 4, 11 },
                    { 5, 1, 11 },
                    { 6, 6, 12 },
                    { 7, 7, 13 },
                    { 8, 2, 13 },
                    { 9, 8, 13 },
                    { 10, 1, 14 },
                    { 11, 5, 14 },
                    { 12, 2, 15 },
                    { 13, 3, 16 },
                    { 14, 8, 16 },
                    { 15, 7, 16 },
                    { 16, 1, 17 },
                    { 17, 3, 17 },
                    { 18, 4, 18 },
                    { 19, 2, 19 },
                    { 20, 6, 19 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserSports_UserId",
                table: "UserSports",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSports");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 16, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 17, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 17, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 16, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 18, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 18, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 12, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 16, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 17, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 17, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 16, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8N7a5QS40QvEfhil9AUBArJk9ZW4sUc/qr8ZWBh0/JY=", "ZxfCk42eQqYDH+CtmhYY+RU89fRqrfQKANFln8CpuGJOJaauRY4XzUxDEwllesyeCR6V3/4dAxlM99hgQj+J2Q==" });
        }
    }
}
