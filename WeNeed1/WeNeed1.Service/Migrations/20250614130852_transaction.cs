using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class transaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Reservations",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 10, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 15, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 12, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 14, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 17, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 13, 17, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 16, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 12, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 12, 13, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 18, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 20, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 16, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 14, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 15, 16, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 15, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 17, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 17, 10, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 11, 13, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 11, 12, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 10, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 12, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 11, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 15, 14, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 13, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 15, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 14, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 16, 18, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 16, 17, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 13, 19, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 13, 18, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 14, 20, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 14, 19, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "EndTime", "StartTime", "TransactionId" },
                values: new object[] { new DateTime(2025, 6, 15, 21, 0, 0, 0, DateTimeKind.Local), new DateTime(2025, 6, 15, 20, 0, 0, 0, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2021,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2022,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2023,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2024,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2025,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2026,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2027,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2028,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2029,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2030,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2031,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2032,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2033,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2034,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2035,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2036,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2037,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2038,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2039,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2040,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2041,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2042,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2043,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2044,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2045,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2046,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2047,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2048,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2049,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2050,
                column: "TransactionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Created",
                value: new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ztZMA8Pb3PO8CLcBG3WvUA0L9qUEQnQgjJ/zfxR06ec=", "JLt3lq1DwRDFN0a/r+siHnWJc25iI0bPtVodTdP8ukyi9pMmDGT34BnaPwabuystf82kGGIXeZBS5ezWwoGpkw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Reservations");

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
    }
}
