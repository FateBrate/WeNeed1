using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class finalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "SportsCenters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SportsCenters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SportsCenters",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "SportsCenters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "SportsCenters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.InsertData(
                table: "MatchAttendances",
                columns: new[] { "MatchId", "UserId", "IsAttending" },
                values: new object[,]
                {
                    { 2, 10, true },
                    { 2, 11, true },
                    { 4, 10, true },
                    { 4, 12, true },
                    { 6, 12, true },
                    { 6, 13, true },
                    { 8, 13, true },
                    { 8, 14, true },
                    { 10, 14, true },
                    { 10, 15, true },
                    { 12, 11, true },
                    { 12, 15, true },
                    { 14, 10, true },
                    { 14, 15, true },
                    { 16, 12, true },
                    { 16, 13, true }
                });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Description", "Name", "Street" },
                values: new object[] { "Bugojno", "Dvorana u Bugojnu", "Sportska Dvorana Bugojno", "Zelenih Beretki 12" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Description", "Name", "Street" },
                values: new object[] { "Trebinje", "Sportski centar u Trebinju", "Centar za Sport Trebinje", "Obala Kulina Bana 7" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Description", "Name", "Street" },
                values: new object[] { "Sarajevo", "Savremeni sportski kompleks u Sarajevu", "Arena Sarajevo", "Ivana Gorana Kovačića 6" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Description", "Name", "Street" },
                values: new object[] { "Mostar", "Moderna dvorana u Mostaru", "Sportska Arena Mostar", "Zelenih Beretki 24" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Street" },
                values: new object[] { "Zenica", "Zelenih Beretki 66" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "City", "Description", "IsPublic", "JoinCode", "Name", "Sport", "TeamPicture" },
                values: new object[,]
                {
                    { 1013, 10, "Mostar", "Strastveni tim futsal entuzijasta.", true, null, "Futsal Wolves", 3, null },
                    { 1014, 10, "Mostar", "Dominacija na pijesku.", false, "JOIN14", "Sand Blazers", 5, null },
                    { 1015, 11, "Travnik", "Visoko leteći košarkaški tim.", true, null, "Airball Masters", 2, null },
                    { 1016, 11, "Travnik", "Stručnjaci za teniske duele.", false, "JOIN16", "Net Aces", 8, null },
                    { 1017, 12, "Sarajevo", "Vladari mreže u Sarajevu.", true, null, "Volley Kings", 4, null },
                    { 1018, 12, "Sarajevo", "Nepobjedivi rukometni tim.", false, "JOIN18", "Handball Titans", 7, null },
                    { 1019, 13, "Sarajevo", "Brzi napadi i čvrsta odbrana.", true, null, "Futsal Tornado", 3, null },
                    { 1020, 13, "Zenica", "Eksplozivan stil igre pod obručima.", false, "JOIN20", "Basket Blitz", 2, null },
                    { 1021, 14, "Zenica", "Specijalisti za beach volley turnire.", true, null, "Sand Kings", 5, null },
                    { 1022, 14, "Tuzla", "Neprekidna akcija na malim terenima.", false, "JOIN22", "Mini Football Force", 6, null },
                    { 1023, 15, "Tuzla", "Grmljavina na mreži.", true, null, "VolleyStorm", 4, null },
                    { 1024, 15, "Tuzla", "Tim s najoštrijim napadima.", false, "JOIN24", "Throwmasters", 7, null }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture", "Rating", "Role", "UserName" },
                values: new object[,]
                {
                    { 900, "lejla.softic@gmail.com", "Kasim", "Softic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "068888888", null, null, 1, "kasim" },
                    { 901, "elma.karic@gmail.com", "Elmma", "Karic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "066666666", null, null, 1, "elmma" },
                    { 902, "dino.begovic@gmail.com", "Dino", "Begovic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "067777777", null, null, 1, "dino" },
                    { 903, "adnan.suljic@gmail.com", "Adnan", "Suljic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "069999999", null, null, 1, "adnann" },
                    { 904, "emina.celik@gmail.com", "Emina", "Celik", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000001", null, null, 1, "eminna" },
                    { 905, "mirza.cengic@gmail.com", "Mirza", "Cengic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000002", null, null, 1, "mirzaa" },
                    { 906, "alma.salihovic@gmail.com", "Alma", "Salihovic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000003", null, null, 1, "almaa" },
                    { 907, "emirr.avdic@gmail.com", "Emirr", "Avdic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000004", null, null, 1, "emirr" },
                    { 908, "ajla.redzic@gmail.com", "Ajla", "Redzic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000005", null, null, 1, "ajlaa" },
                    { 909, "tarik.selimovic@gmail.com", "Tarikk", "Selimovic", "3EFEQlQZjf3kG0XeIHypLAeDV4eSoUqzgusQKPym8XI=", "qHezRy4tctFldw+F9iJFGLbnG0Ft8UaeitvSMk3V5yYHxNkWdxxcXgxzJlYsiLR8OuBY0hyvwrzUOdhbDj6+4g==", "061000006", null, null, 1, "tselimovic" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "MatchDate", "Result", "Status", "TeamId" },
                values: new object[,]
                {
                    { 17, new DateTime(2025, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "2:2", 2, 1013 },
                    { 18, new DateTime(2025, 9, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1013 },
                    { 19, new DateTime(2025, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), "1:0", 2, 1014 },
                    { 20, new DateTime(2025, 9, 10, 19, 15, 0, 0, DateTimeKind.Unspecified), null, 1, 1014 },
                    { 21, new DateTime(2025, 9, 12, 16, 45, 0, 0, DateTimeKind.Unspecified), "0:0", 2, 1015 },
                    { 22, new DateTime(2025, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1015 },
                    { 23, new DateTime(2025, 9, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), "4:2", 2, 1016 },
                    { 24, new DateTime(2025, 9, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1016 },
                    { 25, new DateTime(2025, 9, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), "3:1", 2, 1017 },
                    { 26, new DateTime(2025, 9, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1017 },
                    { 27, new DateTime(2025, 9, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "2:4", 2, 1018 },
                    { 28, new DateTime(2025, 9, 30, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 1018 },
                    { 29, new DateTime(2025, 10, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), "1:1", 2, 1019 },
                    { 30, new DateTime(2025, 10, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1019 },
                    { 31, new DateTime(2025, 10, 7, 17, 15, 0, 0, DateTimeKind.Unspecified), "0:2", 2, 1020 },
                    { 32, new DateTime(2025, 10, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1020 },
                    { 33, new DateTime(2025, 10, 12, 19, 45, 0, 0, DateTimeKind.Unspecified), "3:0", 2, 1021 },
                    { 34, new DateTime(2025, 10, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 1, 1021 },
                    { 35, new DateTime(2025, 10, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "2:2", 2, 1022 },
                    { 36, new DateTime(2025, 10, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1022 },
                    { 37, new DateTime(2025, 10, 22, 20, 15, 0, 0, DateTimeKind.Unspecified), "5:1", 2, 1023 },
                    { 38, new DateTime(2025, 10, 25, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 1023 },
                    { 39, new DateTime(2025, 10, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "1:3", 2, 1024 },
                    { 40, new DateTime(2025, 10, 30, 17, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 1024 }
                });

            migrationBuilder.InsertData(
                table: "SportsCenters",
                columns: new[] { "Id", "City", "Description", "EndTime", "Image", "ManagerId", "Name", "StartTime", "Street" },
                values: new object[,]
                {
                    { 900, "Travnik", "Sportska dvorana u Travniku", new TimeSpan(0, 23, 0, 0, 0), null, 900, "Arena Travnik", new TimeSpan(0, 10, 0, 0, 0), "Bosanska 13" },
                    { 901, "Brčko", "Sportska hala u Brčkom", new TimeSpan(0, 23, 0, 0, 0), null, 901, "Dvorana Brčko", new TimeSpan(0, 10, 0, 0, 0), "Trg Mladih 21" },
                    { 902, "Goražde", "Multifunkcionalni centar u Goraždu", new TimeSpan(0, 23, 0, 0, 0), null, 902, "Sportski Centar Goražde", new TimeSpan(0, 10, 0, 0, 0), "Ribarska 5" },
                    { 903, "Doboj", "Sportski prostor u Doboju", new TimeSpan(0, 23, 0, 0, 0), null, 903, "Rekreativni Centar Doboj", new TimeSpan(0, 10, 0, 0, 0), "Stjepana Radića 9" },
                    { 904, "Banja Luka", "Savremeni sportski kompleks", new TimeSpan(0, 23, 0, 0, 0), null, 904, "Centar Banja Luka", new TimeSpan(0, 10, 0, 0, 0), "Kralja Petra I 17" },
                    { 905, "Gradačac", "Centar za sport i rekreaciju", new TimeSpan(0, 23, 0, 0, 0), null, 905, "Gradačac Arena", new TimeSpan(0, 10, 0, 0, 0), "Branilaca grada 3" },
                    { 906, "Bijeljina", "Fitness i sportski centar u Bijeljini", new TimeSpan(0, 23, 0, 0, 0), null, 906, "Bijeljina FitZone", new TimeSpan(0, 10, 0, 0, 0), "Njegoševa 44" },
                    { 907, "Konjic", "Sportska dvorana u Konjicu", new TimeSpan(0, 23, 0, 0, 0), null, 907, "Konjic Sports Hall", new TimeSpan(0, 10, 0, 0, 0), "Varda 11" },
                    { 908, "Bihać", "Moderna sportska arena u Bihaću", new TimeSpan(0, 23, 0, 0, 0), null, 908, "Bihać Sports Arena", new TimeSpan(0, 10, 0, 0, 0), "Una bb" },
                    { 909, "Travnik", "Novi centar za sport i rekreaciju", new TimeSpan(0, 23, 0, 0, 0), null, 909, "Travnik Sports Hub", new TimeSpan(0, 10, 0, 0, 0), "Hasana Brkića 8" }
                });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "Name", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1025, "Crvene Strijele", 1013, null },
                    { 1026, "Zlatni Orlovi", 1013, null },
                    { 1027, "Ledeni Tigrovi", 1014, null },
                    { 1028, "Sivi Vjetrovi", 1014, null },
                    { 1029, "Plavi Talasi", 1015, null },
                    { 1030, "Vatreni Klizači", 1015, null },
                    { 1031, "Sjene Ulice", 1016, null },
                    { 1032, "Noćni Jahači", 1016, null },
                    { 1033, "Tihi Ubice", 1017, null },
                    { 1034, "Brze Strele", 1017, null },
                    { 1035, "Bijeli Medvjedi", 1018, null },
                    { 1036, "Leteći Zmajevi", 1019, null },
                    { 1037, "Plameni Šampioni", 1019, null },
                    { 1038, "Graditelji Igre", 1020, null },
                    { 1039, "Zlatni Asovi", 1020, null },
                    { 1040, "Timski Strijelci", 1021, null },
                    { 1041, "Munjeviti Servisi", 1022, null },
                    { 1042, "Lavlje Srce", 1023, null },
                    { 1043, "Nezaustavljivi", 1023, null },
                    { 1044, "Taktički Umovi", 1024, null }
                });

            migrationBuilder.InsertData(
                table: "UserTeams",
                columns: new[] { "TeamId", "UserId", "IsCaptain" },
                values: new object[,]
                {
                    { 1013, 10, true },
                    { 1014, 10, true },
                    { 1023, 10, false },
                    { 1013, 11, false },
                    { 1014, 11, false },
                    { 1015, 11, true },
                    { 1016, 11, true },
                    { 1024, 11, false },
                    { 1013, 12, false },
                    { 1015, 12, false },
                    { 1017, 12, true },
                    { 1018, 12, true },
                    { 1013, 13, false },
                    { 1016, 13, false },
                    { 1019, 13, true },
                    { 1020, 13, true },
                    { 1013, 14, false },
                    { 1017, 14, false },
                    { 1021, 14, true },
                    { 1022, 14, true },
                    { 1013, 15, false },
                    { 1018, 15, false },
                    { 1023, 15, true },
                    { 1024, 15, true },
                    { 1013, 16, false },
                    { 1019, 16, false },
                    { 1013, 17, false },
                    { 1020, 17, false },
                    { 1013, 18, false },
                    { 1021, 18, false },
                    { 1013, 19, false },
                    { 1022, 19, false }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "Created", "Rating", "SportsCenterId", "UserId" },
                values: new object[,]
                {
                    { 1011, "Vrlo čist i dobro organizovan centar.", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 4.6m, 900, 15 },
                    { 1012, "Sve je bilo odlično, osim parkinga.", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 3.9m, 901, 10 },
                    { 1013, "Topla preporuka za sve sportiste.", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), 4.7m, 902, 11 },
                    { 1014, "Ljubazno osoblje i dobra oprema.", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 4.2m, 903, 12 },
                    { 1015, "Sve u svemu, pozitivno iskustvo.", new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 4.0m, 904, 13 },
                    { 1016, "Malo skuplje, ali teren je fantastičan.", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 3.8m, 905, 14 },
                    { 1017, "Sve preporuke! Odlična organizacija.", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 4.9m, 906, 14 },
                    { 1018, "Zadovoljan uslugom i ambijentom.", new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 4.3m, 907, 14 },
                    { 1019, "Tereni odlični, ali nema kafića u blizini.", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 3.7m, 908, 12 },
                    { 1020, "Sjajno iskustvo! Definitivno dolazim opet.", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 5.0m, 909, 11 }
                });

            migrationBuilder.InsertData(
                table: "SportsFields",
                columns: new[] { "Id", "Capacity", "Description", "Image", "Name", "PricePerHour", "SportType", "SportsCenterId" },
                values: new object[,]
                {
                    { 200, 10, "Natkriveni teren pogodan za sve vremenske uslove.", null, "Teren 1 - Travnik", 25m, "Košarka", 900 },
                    { 201, 12, "Teren sa reflektorima i vještačkom travom.", null, "Teren 1 - Brčko", 30m, "Fudbal", 901 },
                    { 202, 4, "Teren sa crvenom šljakom idealan za rekreativce.", null, "Teren 1 - Goražde", 20m, "Tenis", 902 },
                    { 203, 6, "Teren za odbojku na pijesku, otvoreni tip.", null, "Teren 1 - Doboj", 18m, "Odbojka", 903 },
                    { 204, 10, "Dvoranski teren, klimatiziran prostor.", null, "Teren 1 - Banja Luka", 27m, "Košarka", 904 },
                    { 205, 10, "Mini teren pogodan za futsal i treninge.", null, "Teren 1 - Gradačac", 22m, "Fudbal", 905 },
                    { 206, 2, "Moderno opremljeni teren sa LED osvjetljenjem.", null, "Teren 1 - Bijeljina", 28m, "Tenis", 906 },
                    { 207, 10, "Teren uz rijeku, odličan ambijent za igru.", null, "Teren 1 - Konjic", 23m, "Košarka", 907 },
                    { 208, 14, "Teren sa prirodnom travom i tribinama.", null, "Teren 1 - Bihać", 35m, "Fudbal", 908 },
                    { 209, 8, "Multifunkcionalni teren u modernom ambijentu.", null, "Teren 1 - Travnik Hub", 26m, "Košarka", 909 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CancellationReason", "EndTime", "SportsFieldId", "StartTime", "Status", "TotalPrice", "TransactionId", "UserId" },
                values: new object[,]
                {
                    { 2051, null, new DateTime(2026, 1, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 200, new DateTime(2026, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, 25m, null, 10 },
                    { 2052, null, new DateTime(2025, 9, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 201, new DateTime(2025, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, null, 11 },
                    { 2053, null, new DateTime(2024, 6, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 202, new DateTime(2024, 6, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 20m, null, 12 },
                    { 2054, "Nedostatak igrača", new DateTime(2024, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), 203, new DateTime(2024, 11, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 18m, null, 13 },
                    { 2055, null, new DateTime(2026, 3, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 204, new DateTime(2026, 3, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 1, 27m, null, 14 },
                    { 2056, null, new DateTime(2025, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 205, new DateTime(2025, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 22m, null, 14 },
                    { 2057, null, new DateTime(2024, 5, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 206, new DateTime(2024, 5, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), 4, 28m, null, 13 },
                    { 2058, "Loše vrijeme", new DateTime(2024, 8, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 207, new DateTime(2024, 8, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 23m, null, 12 },
                    { 2059, null, new DateTime(2026, 2, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 208, new DateTime(2026, 2, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 35m, null, 11 },
                    { 2060, null, new DateTime(2025, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), 209, new DateTime(2025, 12, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, 26m, null, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "MatchAttendances",
                keyColumns: new[] { "MatchId", "UserId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1014, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1023, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1014, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1015, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1016, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1024, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1015, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1017, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1018, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1016, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1019, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1020, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1017, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1021, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1022, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1018, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1023, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1024, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1019, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1020, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1021, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1013, 19 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1022, 19 });

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DropColumn(
                name: "City",
                table: "SportsCenters");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "SportsCenters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SportsCenters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SportsCenters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "SportsCenters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Armije BiH", "Dvorana u Donjem Vakufu", "Sportska Dvorana Donji Vakuf" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Zmaja od Bosne bb", "Moderno opremljen sportski centar u Sarajevu", "Centar za Sport i Rekreaciju Sarajevo" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Aleksina Međa 45", "Savremena arena za različite sportove", "Sportska Arena Mostar" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Meše Selimovića 88", "Multifunkcionalni prostor za rekreaciju", "Sportski Centar Tuzla" });

            migrationBuilder.UpdateData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 9,
                column: "Address",
                value: "Crkvice bb");

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
        }
    }
}
