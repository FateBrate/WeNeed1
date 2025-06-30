using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class teamcity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Teams",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 11, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 11, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 16, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 10, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 12, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 15, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 12, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 12, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 13, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 14, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                column: "City",
                value: "Mostar");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                column: "City",
                value: "Mostar");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                column: "City",
                value: "Travnik");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                column: "City",
                value: "Travnik");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                column: "City",
                value: "Sarajevo");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                column: "City",
                value: "Sarajevo");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                column: "City",
                value: "Sarajevo");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                column: "City",
                value: "Zenica");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                column: "City",
                value: "Zenica");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1010,
                column: "City",
                value: "Tuzla");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1011,
                column: "City",
                value: "Tuzla");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1012,
                column: "City",
                value: "Tuzla");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eo2GuDhzexN1H9L1ETi4ehX6RmdaJm5KKcKTFbPzLdo=", "RsZOQ6Xpr0ebU83NGpW25FB5iogS5H0YdcN6NOvmy3qANEqAHnWuzhz2kaWUTcZmYOZ+X2AsQP8Z8aXOjyxzsg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 9, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 6, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 6, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 11, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 11, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 5, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 7, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 9, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 10, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 7, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 7, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 8, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 8, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 9, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 9, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==" });
        }
    }
}
