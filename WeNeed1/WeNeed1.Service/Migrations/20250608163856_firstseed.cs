using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeNeed1.Service.Migrations
{
    /// <inheritdoc />
    public partial class firstseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfilePicture", "Rating", "Role", "UserName" },
                values: new object[,]
                {
                    { 5, "jasmin.smajic@gmail.com", "Jasmin", "Smajic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "061111111", null, null, 1, "jasmin" },
                    { 6, "fatih.drek@gmail.com", "Fatih", "Drek", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "062222222", null, null, 1, "fatih" },
                    { 7, "mehmed.dervisic@gmail.com", "Mehmed", "Dervisic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "063333333", null, null, 1, "mehmed" },
                    { 8, "amra.hadzic@gmail.com", "Amra", "Hadzic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "064444444", null, null, 1, "amra" },
                    { 9, "tarik.kljucanin@gmail.com", "Tarik", "Kljucanin", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "065555555", null, null, 1, "tarik" },
                    { 10, "haris.orahovcic@gmail.com", "Haris", "Orahovcic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "066666666", null, 4.7000000000000002, 2, "haris" },
                    { 11, "selma.kovacevic@gmail.com", "Selma", "Kovacevic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "067777777", null, 4.9000000000000004, 2, "selma" },
                    { 12, "adnan.avdic@gmail.com", "Adnan", "Avdic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "068888888", null, 4.2999999999999998, 2, "adnan" },
                    { 13, "lejla.mujic@gmail.com", "Lejla", "Mujic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "069999999", null, 4.7999999999999998, 2, "lejla" },
                    { 14, "nermin.besic@gmail.com", "Nermin", "Besic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "060000000", null, 4.5, 2, "nermin" },
                    { 15, "amir.hodzic@gmail.com", "Amir", "Hodzic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "061111111", null, 4.2000000000000002, 2, "amir" },
                    { 16, "sara.jusic@gmail.com", "Sara", "Jusic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "062222222", null, 4.7000000000000002, 2, "sara" },
                    { 17, "denis.kovac@gmail.com", "Denis", "Kovac", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "063333333", null, 4.4000000000000004, 2, "denis" },
                    { 18, "mina.babic@gmail.com", "Mina", "Babic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "064444444", null, 4.5999999999999996, 2, "mina" },
                    { 19, "tarik.smajic@gmail.com", "Tarik", "Smajic", "QgetM2NzVbiBFXS7ciuivfNAaloVkAQPQ4SWreW4T6s=", "wJkXGsr8Y4T5US3RecydIOMFJyAi4vND5JLwxLQftTowpZ3YcEtknwVohHwaLDyO++Hj4OXuH0r0/bihX17tlQ==", "065555555", null, 4.2999999999999998, 2, "tarik" }
                });

            migrationBuilder.InsertData(
                table: "SportsCenters",
                columns: new[] { "Id", "Address", "Description", "EndTime", "Image", "ManagerId", "Name", "StartTime" },
                values: new object[,]
                {
                    { 5, "Armije BiH", "Dvorana u Donjem Vakufu", new TimeSpan(0, 23, 0, 0, 0), null, 5, "Sportska Dvorana Donji Vakuf", new TimeSpan(0, 10, 0, 0, 0) },
                    { 6, "Zmaja od Bosne bb", "Moderno opremljen sportski centar u Sarajevu", new TimeSpan(0, 23, 0, 0, 0), null, 6, "Centar za Sport i Rekreaciju Sarajevo", new TimeSpan(0, 10, 0, 0, 0) },
                    { 7, "Aleksina Međa 45", "Savremena arena za različite sportove", new TimeSpan(0, 23, 0, 0, 0), null, 7, "Sportska Arena Mostar", new TimeSpan(0, 10, 0, 0, 0) },
                    { 8, "Meše Selimovića 88", "Multifunkcionalni prostor za rekreaciju", new TimeSpan(0, 23, 0, 0, 0), null, 8, "Sportski Centar Tuzla", new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, "Crkvice bb", "Najmoderniji sportski centar u Zenici", new TimeSpan(0, 23, 0, 0, 0), null, 9, "FitZone Zenica", new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "Description", "IsPublic", "JoinCode", "Name", "Sport", "TeamPicture" },
                values: new object[,]
                {
                    { 101, 10, "Najjači futsal tim u gradu.", true, null, "Jaguars", 3, null },
                    { 102, 10, "Elitna ekipa za odbojku na pijesku.", false, "JOIN2", "Desert Foxes", 5, null },
                    { 103, 11, "Zaljubljenici u košarku, zajedno na terenu.", true, null, "Sky Dunkers", 2, null },
                    { 104, 11, "Teniski klub za sve uzrast.", false, "JOIN4", "Urban Hawks", 8, null },
                    { 105, 12, "Najbolji odbojkaški tim u gradu.", true, null, "Volley Ninjas", 4, null },
                    { 106, 12, "Akcija i strast prema rukometu.", false, "JOIN6", "Handball Heroes", 7, null },
                    { 107, 13, "Brzina i snaga u futsalu.", true, null, "Thunderballs", 3, null },
                    { 108, 13, "Tim za taktičku košarku", false, "JOIN8", "Court Kings", 2, null },
                    { 109, 14, "Vladari terena na pijesku..", true, null, "Beach Storm", 5, null },
                    { 1010, 14, "Šampioni mini fudbala.", false, "JOIN10", "Field Blazers", 6, null },
                    { 1011, 15, "Odbojkaška izvrsnost i timski duh.", true, null, "The Smashers", 4, null },
                    { 1012, 15, "Furija na rukometnom terenu.", false, "JOIN12", "Net Raiders", 7, null }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "MatchDate", "Result", "Status", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 101 },
                    { 2, new DateTime(2025, 7, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), "2:1", 2, 102 },
                    { 3, new DateTime(2025, 7, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 103 },
                    { 4, new DateTime(2025, 7, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), "3:3", 2, 101 },
                    { 5, new DateTime(2025, 7, 20, 19, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 104 },
                    { 6, new DateTime(2025, 7, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), "1:0", 2, 105 },
                    { 7, new DateTime(2025, 7, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 106 },
                    { 8, new DateTime(2025, 7, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "0:2", 2, 107 },
                    { 9, new DateTime(2025, 8, 1, 18, 15, 0, 0, DateTimeKind.Unspecified), null, 1, 108 },
                    { 10, new DateTime(2025, 8, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), "4:1", 2, 109 },
                    { 11, new DateTime(2025, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1010 },
                    { 12, new DateTime(2025, 8, 10, 15, 45, 0, 0, DateTimeKind.Unspecified), "2:2", 2, 1011 },
                    { 13, new DateTime(2025, 8, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 3, 1012 },
                    { 14, new DateTime(2025, 8, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "1:1", 2, 101 },
                    { 15, new DateTime(2025, 8, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 102 },
                    { 16, new DateTime(2025, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "0:3", 2, 103 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "Created", "Rating", "SportsCenterId", "UserId" },
                values: new object[,]
                {
                    { 101, "Sjajno iskustvo, teren je bio vrhunski pripremljen!.", new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 4.5m, 5, 10 },
                    { 102, "Osoblje je bilo ljubazno i susretljivo. Preporučujem svima!", new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), 5.0m, 6, 11 },
                    { 103, "Odlična atmosfera i dobro održavani tereni.", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 3.8m, 7, 12 },
                    { 104, "Rezervacija je prošla glatko i bez ikakvih problema.", new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 4.2m, 8, 13 },
                    { 105, "Malo skuplje, ali vrijedno svake marke..", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 3.5m, 9, 14 },
                    { 106, "Fantastic experience overall.", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 4.8m, 6, 10 },
                    { 107, "Tereni su bili čisti, ali svlačionice bi mogle biti bolje.", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 4.7m, 7, 11 },
                    { 108, "Kvalitet opreme je bio iznad očekivanja.", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 4.0m, 8, 12 },
                    { 109, "Could use better lighting at night.", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 3.9m, 9, 13 },
                    { 1010, "Definitivno ću se ponovo vratiti!", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 5.0m, 5, 14 }
                });

            migrationBuilder.InsertData(
                table: "SportsFields",
                columns: new[] { "Id", "Capacity", "Description", "Image", "Name", "PricePerHour", "SportType", "SportsCenterId" },
                values: new object[,]
                {
                    { 100, 10, "Vanjski teren za mali fudbal", null, "Teren 1 - Donji Vakuf", 20m, "Fudbal", 5 },
                    { 101, 10, "Unutrašnji teren za košarku", null, "Teren 2 - Donji Vakuf", 25m, "Košarka", 5 },
                    { 102, 4, "Teniski teren sa tvrdom podlogom", null, "Teren 1 - Sarajevo", 30m, "Tenis", 6 },
                    { 103, 12, "Umjetna trava, reflektori za noćne termine", null, "Teren 2 - Sarajevo", 35m, "Fudbal", 6 },
                    { 104, 10, "Teren sa parketom i tribinama", null, "Teren 1 - Mostar", 22m, "Košarka", 7 },
                    { 105, 8, "Unutrašnji teren za odbojku", null, "Teren 2 - Mostar", 20m, "Odbojka", 7 },
                    { 106, 14, "Moderno opremljen fudbalski teren", null, "Teren 1 - Tuzla", 28m, "Fudbal", 8 },
                    { 107, 2, "Teren sa zemljanom podlogom", null, "Teren 2 - Tuzla", 18m, "Tenis", 8 },
                    { 108, 10, "Vanjski teren, odličan za ljetne termine", null, "Teren 1 - Zenica", 24m, "Košarka", 9 },
                    { 109, 12, "Teren sa vještačkom travom i reflektorima", null, "Teren 2 - Zenica", 32m, "Fudbal", 9 }
                });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "Name", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 101, "Crni Lavovi", 101, null },
                    { 102, "Bijeli Vukovi", 101, null },
                    { 103, "Pješčani Šampioni", 102, null },
                    { 104, "Zlatne Zvijezde", 102, null },
                    { 105, "Nebeski Skakači", 103, null },
                    { 106, "Ulični Letaci", 103, null },
                    { 107, "Teniski Majstori", 104, null },
                    { 108, "Brzi Servisi", 104, null },
                    { 109, "Odbojkaške Nindže", 105, null },
                    { 1010, "Skakači", 105, null },
                    { 1011, "Rukometni Ratnici", 106, null },
                    { 1012, "Zidari Odbrane", 106, null },
                    { 1013, "Munje", 107, null },
                    { 1014, "Gromovi", 107, null },
                    { 1015, "Dvoranski Kraljevi", 108, null },
                    { 1016, "Taktičari", 108, null },
                    { 1017, "Plažni Vojnici", 109, null },
                    { 1018, "Pješčane Laste", 109, null },
                    { 1019, "Fudbalski Osvajači", 1010, null },
                    { 1020, "Zeleni Tereni", 1010, null },
                    { 1021, "Odbojkaške Zvijezde", 1011, null },
                    { 1022, "Blokeri", 1011, null },
                    { 1023, "Mrežni Napadači", 1012, null },
                    { 1024, "Ofanzivaši", 1012, null }
                });

            migrationBuilder.InsertData(
                table: "UserTeams",
                columns: new[] { "TeamId", "UserId", "IsCaptain" },
                values: new object[,]
                {
                    { 101, 10, true },
                    { 102, 10, true },
                    { 105, 10, false },
                    { 101, 11, false },
                    { 103, 11, true },
                    { 104, 11, true },
                    { 106, 11, false },
                    { 101, 12, false },
                    { 105, 12, true },
                    { 106, 12, true },
                    { 107, 12, false },
                    { 102, 13, false },
                    { 107, 13, true },
                    { 108, 13, true },
                    { 103, 14, false },
                    { 109, 14, true },
                    { 1010, 14, true },
                    { 1011, 14, false },
                    { 101, 15, false },
                    { 104, 15, false },
                    { 109, 15, false },
                    { 1011, 15, true },
                    { 1012, 15, true },
                    { 101, 16, false },
                    { 104, 16, false },
                    { 101, 17, false },
                    { 104, 17, false },
                    { 101, 18, false },
                    { 104, 18, false },
                    { 101, 19, false },
                    { 104, 19, false }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "Created", "MatchId", "UserId" },
                values: new object[,]
                {
                    { 101, "Sjajna utakmica, baš uzbudljivo!", new DateTime(2025, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 102, "What a comeback in the last 10 minutes!", new DateTime(2025, 7, 6, 20, 15, 0, 0, DateTimeKind.Unspecified), 2, 11 },
                    { 103, "Ne mogu vjerovati da je završilo neriješeno.", new DateTime(2025, 7, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 104, "Great effort by both teams.", new DateTime(2025, 7, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), 4, 13 },
                    { 105, "Bravo za pobjedu, nastavimo ovako!", new DateTime(2025, 7, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 6, 14 },
                    { 106, "Tough game, but well played.", new DateTime(2025, 7, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 8, 10 },
                    { 107, "Izvrsni servisi danas!", new DateTime(2025, 7, 29, 21, 15, 0, 0, DateTimeKind.Unspecified), 8, 11 },
                    { 108, "Amazing teamwork and strategy.", new DateTime(2025, 8, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, 12 },
                    { 109, "Čestitke na visokoj pobjedi!", new DateTime(2025, 8, 4, 20, 30, 0, 0, DateTimeKind.Unspecified), 10, 13 },
                    { 1010, "Close game, both teams showed heart.", new DateTime(2025, 8, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 14, 14 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CancellationReason", "EndTime", "SportsFieldId", "StartTime", "Status", "TotalPrice", "UserId" },
                values: new object[,]
                {
                    { 201, null, new DateTime(2025, 6, 8, 11, 0, 0, 0, DateTimeKind.Local), 100, new DateTime(2025, 6, 8, 10, 0, 0, 0, DateTimeKind.Local), 2, 20m, 10 },
                    { 202, "Nevrijeme", new DateTime(2025, 6, 9, 13, 0, 0, 0, DateTimeKind.Local), 101, new DateTime(2025, 6, 9, 12, 0, 0, 0, DateTimeKind.Local), 3, 25m, 12 },
                    { 203, null, new DateTime(2025, 6, 8, 15, 0, 0, 0, DateTimeKind.Local), 102, new DateTime(2025, 6, 8, 14, 0, 0, 0, DateTimeKind.Local), 1, 30m, 13 },
                    { 204, null, new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), 103, new DateTime(2025, 6, 8, 17, 0, 0, 0, DateTimeKind.Local), 4, 35m, 14 },
                    { 205, null, new DateTime(2025, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), 104, new DateTime(2025, 6, 7, 16, 0, 0, 0, DateTimeKind.Local), 2, 22m, 11 },
                    { 206, "Nevrijeme", new DateTime(2025, 6, 6, 14, 0, 0, 0, DateTimeKind.Local), 105, new DateTime(2025, 6, 6, 13, 0, 0, 0, DateTimeKind.Local), 3, 20m, 12 },
                    { 207, null, new DateTime(2025, 6, 8, 19, 0, 0, 0, DateTimeKind.Local), 106, new DateTime(2025, 6, 8, 18, 0, 0, 0, DateTimeKind.Local), 1, 28m, 13 },
                    { 208, null, new DateTime(2025, 6, 8, 21, 0, 0, 0, DateTimeKind.Local), 107, new DateTime(2025, 6, 8, 20, 0, 0, 0, DateTimeKind.Local), 4, 18m, 14 },
                    { 209, null, new DateTime(2025, 6, 10, 15, 0, 0, 0, DateTimeKind.Local), 108, new DateTime(2025, 6, 10, 14, 0, 0, 0, DateTimeKind.Local), 1, 24m, 10 },
                    { 2010, null, new DateTime(2025, 6, 9, 16, 0, 0, 0, DateTimeKind.Local), 109, new DateTime(2025, 6, 9, 15, 0, 0, 0, DateTimeKind.Local), 2, 32m, 11 },
                    { 2011, "Kvar na mreži", new DateTime(2025, 6, 11, 11, 0, 0, 0, DateTimeKind.Local), 100, new DateTime(2025, 6, 11, 10, 0, 0, 0, DateTimeKind.Local), 3, 20m, 12 },
                    { 2012, null, new DateTime(2025, 6, 5, 13, 0, 0, 0, DateTimeKind.Local), 101, new DateTime(2025, 6, 5, 12, 0, 0, 0, DateTimeKind.Local), 4, 25m, 13 },
                    { 2013, null, new DateTime(2025, 6, 7, 11, 0, 0, 0, DateTimeKind.Local), 102, new DateTime(2025, 6, 7, 10, 0, 0, 0, DateTimeKind.Local), 1, 30m, 14 },
                    { 2014, null, new DateTime(2025, 6, 8, 12, 0, 0, 0, DateTimeKind.Local), 103, new DateTime(2025, 6, 8, 11, 0, 0, 0, DateTimeKind.Local), 2, 35m, 10 },
                    { 2015, "Kvar na grijanju", new DateTime(2025, 6, 9, 14, 0, 0, 0, DateTimeKind.Local), 104, new DateTime(2025, 6, 9, 13, 0, 0, 0, DateTimeKind.Local), 3, 22m, 11 },
                    { 2016, null, new DateTime(2025, 6, 8, 15, 0, 0, 0, DateTimeKind.Local), 105, new DateTime(2025, 6, 8, 14, 0, 0, 0, DateTimeKind.Local), 4, 20m, 12 },
                    { 2017, null, new DateTime(2025, 6, 10, 18, 0, 0, 0, DateTimeKind.Local), 106, new DateTime(2025, 6, 10, 17, 0, 0, 0, DateTimeKind.Local), 2, 28m, 13 },
                    { 2018, null, new DateTime(2025, 6, 7, 19, 0, 0, 0, DateTimeKind.Local), 107, new DateTime(2025, 6, 7, 18, 0, 0, 0, DateTimeKind.Local), 1, 18m, 14 },
                    { 2019, "Nevrijeme", new DateTime(2025, 6, 8, 20, 0, 0, 0, DateTimeKind.Local), 108, new DateTime(2025, 6, 8, 19, 0, 0, 0, DateTimeKind.Local), 3, 24m, 11 },
                    { 2020, null, new DateTime(2025, 6, 9, 21, 0, 0, 0, DateTimeKind.Local), 109, new DateTime(2025, 6, 9, 20, 0, 0, 0, DateTimeKind.Local), 4, 32m, 12 },
                    { 2021, null, new DateTime(2025, 6, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 6, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 10 },
                    { 2022, null, new DateTime(2025, 6, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 6, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 30m, 11 },
                    { 2023, null, new DateTime(2025, 6, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 30m, 12 },
                    { 2024, null, new DateTime(2025, 6, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 6, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 13 },
                    { 2025, "Otkazano", new DateTime(2025, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 30m, 14 },
                    { 2026, null, new DateTime(2025, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 30m, 10 },
                    { 2027, null, new DateTime(2025, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 11 },
                    { 2028, null, new DateTime(2025, 5, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 5, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, 30m, 12 },
                    { 2029, null, new DateTime(2025, 5, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 5, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 30m, 13 },
                    { 2030, null, new DateTime(2025, 5, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2025, 5, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 14 },
                    { 2031, null, new DateTime(2026, 3, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2026, 3, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 30m, 10 },
                    { 2032, null, new DateTime(2026, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2026, 6, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 11 },
                    { 2033, null, new DateTime(2024, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2024, 9, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, 30m, 12 },
                    { 2034, "Nevrijeme", new DateTime(2024, 11, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2024, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 30m, 13 },
                    { 2035, null, new DateTime(2024, 12, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 102, new DateTime(2024, 12, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 30m, 14 },
                    { 2036, null, new DateTime(2025, 6, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 6, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 10 },
                    { 2037, null, new DateTime(2025, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 35m, 11 },
                    { 2038, null, new DateTime(2025, 6, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 6, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, 35m, 12 },
                    { 2039, null, new DateTime(2025, 6, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 6, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 13 },
                    { 2040, "Otkazano", new DateTime(2025, 6, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 35m, 14 },
                    { 2041, null, new DateTime(2025, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 35m, 10 },
                    { 2042, null, new DateTime(2025, 7, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 11 },
                    { 2043, null, new DateTime(2025, 5, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 5, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 4, 35m, 12 },
                    { 2044, null, new DateTime(2025, 5, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 5, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 35m, 13 },
                    { 2045, null, new DateTime(2025, 5, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2025, 5, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 14 },
                    { 2046, null, new DateTime(2026, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2026, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 35m, 10 },
                    { 2047, null, new DateTime(2026, 7, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2026, 7, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 11 },
                    { 2048, null, new DateTime(2024, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2024, 8, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 4, 35m, 12 },
                    { 2049, "Nevrijeme", new DateTime(2024, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2024, 10, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), 3, 35m, 13 },
                    { 2050, null, new DateTime(2024, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 103, new DateTime(2024, 12, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 2, 35m, 14 }
                });

            migrationBuilder.InsertData(
                table: "UsersSquad",
                columns: new[] { "SquadId", "UserId" },
                values: new object[,]
                {
                    { 101, 10 },
                    { 103, 10 },
                    { 1010, 10 },
                    { 102, 11 },
                    { 105, 11 },
                    { 107, 11 },
                    { 1012, 11 },
                    { 102, 12 },
                    { 109, 12 },
                    { 1011, 12 },
                    { 1014, 12 },
                    { 104, 13 },
                    { 1013, 13 },
                    { 1015, 13 },
                    { 1016, 13 },
                    { 106, 14 },
                    { 1017, 14 },
                    { 1019, 14 },
                    { 102, 15 },
                    { 102, 17 },
                    { 101, 18 },
                    { 101, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 102, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 105, 10 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 103, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 106, 11 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 105, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 106, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 107, 12 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 102, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 107, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 108, 13 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 103, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 109, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1010, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1011, 14 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 109, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1011, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 1012, 15 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 16 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 17 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 18 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 101, 19 });

            migrationBuilder.DeleteData(
                table: "UserTeams",
                keyColumns: new[] { "TeamId", "UserId" },
                keyValues: new object[] { 104, 19 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 101, 10 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 103, 10 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1010, 10 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 102, 11 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 105, 11 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 107, 11 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1012, 11 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 102, 12 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 109, 12 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1011, 12 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1014, 12 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 104, 13 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1013, 13 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1015, 13 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1016, 13 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 106, 14 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1017, 14 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 1019, 14 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 102, 15 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 102, 17 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 101, 18 });

            migrationBuilder.DeleteData(
                table: "UsersSquad",
                keyColumns: new[] { "SquadId", "UserId" },
                keyValues: new object[] { 101, 19 });

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "SportsFields",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SportsCenters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
