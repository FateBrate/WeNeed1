using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "City", "Description", "IsPublic", "JoinCode", "Name", "Sport", "TeamPicture" },
                values: new object[,]
                {
                    { 9001, 16, "Tuzla", "Tim s najoštrijim napadima.", true, null, "Team Beta", 2, null },
                    { 9002, 13, "Zenica", "Tim s najoštrijim napadima.", true, null, "Team Gama", 2, null },
                    { 9003, 11, "Tuzla", "Tim s najoštrijim napadima.", true, null, "Team Delta", 2, null },
                    { 9004, 11, "Tuzla", "Tim s najoštrijim napadima.", true, null, "Team Zeta", 8, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture", "Rating", "Role", "UserName" },
                values: new object[] { 20, "inas.bajrak@gmail.com", "Inas", "Bajrak", "45aKFpif8fRfH7nYRwYU83K+YvF9TpeYigMjgq/NVds=", "k5hIBTbRTk9lj7qD3zkbqlgrB4sAsqBAuBIxZnFi8/vg5wz1/TN2md0pw9Yls865NqVKHcdzmsIxQwb9Ul2rNA==", "065555555", null, 4.2999999999999998, 2, "inas" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "City", "Description", "IsPublic", "JoinCode", "Name", "Sport", "TeamPicture" },
                values: new object[] { 9000, 20, "Mostar", "Tim s najoštrijim napadima.", true, null, "Team Alfa", 5, null });

            migrationBuilder.InsertData(
                table: "UserTeams",
                columns: new[] { "TeamId", "UserId", "IsCaptain" },
                values: new object[,]
                {
                    { 9001, 11, false },
                    { 9002, 11, false },
                    { 9003, 11, true },
                    { 9004, 11, true },
                    { 9001, 12, false },
                    { 9002, 12, false },
                    { 9003, 12, false },
                    { 9004, 12, false },
                    { 9001, 13, false },
                    { 9002, 13, true },
                    { 9003, 13, false },
                    { 9004, 13, false },
                    { 9001, 14, false },
                    { 9003, 14, false },
                    { 9004, 14, false },
                    { 9001, 15, false },
                    { 9002, 15, false },
                    { 9001, 16, true },
                    { 9002, 16, false },
                    { 9003, 16, false },
                    { 9004, 16, false },
                    { 9001, 17, false },
                    { 9003, 17, false },
                    { 9004, 17, false },
                    { 9001, 18, false },
                    { 9002, 18, false },
                    { 9003, 18, false },
                    { 9004, 18, false },
                    { 9003, 19, false },
                    { 9001, 20, false },
                    { 9002, 20, false },
                    { 9003, 20, false },
                    { 9004, 20, false },
                    { 9000, 12, false },
                    { 9000, 13, false },
                    { 9000, 14, false },
                    { 9000, 15, false },
                    { 9000, 16, false },
                    { 9000, 17, false },
                    { 9000, 18, false },
                    { 9000, 19, false },
                    { 9000, 20, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 19 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 19 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9000, 20 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9001, 20 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9002, 20 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9003, 20 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 9004, 20 });

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9001);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9002);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9003);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9004);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==" });
        }
    }
}
