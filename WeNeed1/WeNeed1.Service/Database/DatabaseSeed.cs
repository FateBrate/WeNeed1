using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database;

public partial class WeNeed1Context : DbContext
{
     private void SeedUsers(ModelBuilder modelBuilder)
    {
        var password = "12345678";
        CreatePasswordHash(password, out string hash, out string salt);
        var profilePicture = File.ReadAllBytes("profilePictureSeed.png");

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 5,
                FirstName = "Jasmin",
                LastName = "Smajic",
                Email = "jasmin.smajic@gmail.com",
                UserName = "jasmin",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061111111",
                Role = Role.MANAGER,
                ProfilePicture = profilePicture
            },
            new User
            {
                Id = 6,
                FirstName = "Fatih",
                LastName = "Drek",
                Email = "fatih.drek@gmail.com",
                UserName = "fatih",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "062222222",
                Role = Role.MANAGER,
                ProfilePicture = profilePicture
            },
            new User
            {
                Id = 7,
                FirstName = "Mehmed",
                LastName = "Dervisic",
                Email = "mehmed.dervisic@gmail.com",
                UserName = "mehmed",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "063333333",
                Role = Role.MANAGER,
                ProfilePicture = profilePicture
            },
            new User
            {
                Id = 8,
                FirstName = "Amra",
                LastName = "Hadzic",
                Email = "amra.hadzic@gmail.com",
                UserName = "amra",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "064444444",
                Role = Role.MANAGER,
                ProfilePicture = profilePicture
            },
            new User
            {
                Id = 9,
                FirstName = "Tarik",
                LastName = "Kljucanin",
                Email = "tarik.kljucanin@gmail.com",
                UserName = "tarik",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "065555555",
                Role = Role.MANAGER,
                ProfilePicture = profilePicture
            },

            // Players
            new User
            {
                Id = 10,
                FirstName = "Haris",
                LastName = "Orahovcic",
                Email = "haris.orahovcic@gmail.com",
                UserName = "haris",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "066666666",
                Role = Role.PLAYER,
                ProfilePicture = profilePicture,
                Rating = 4.7
            },
            new User
            {
                Id = 11,
                FirstName = "Selma",
                LastName = "Kovacevic",
                Email = "selma.kovacevic@gmail.com",
                UserName = "selma",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "067777777",
                Role = Role.PLAYER,
                ProfilePicture = profilePicture,
                Rating = 4.9
            },
            new User
            {
                Id = 12,
                FirstName = "Adnan",
                LastName = "Avdic",
                Email = "adnan.avdic@gmail.com",
                UserName = "adnan",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "068888888",
                Role = Role.PLAYER,
                ProfilePicture = profilePicture,
                Rating = 4.3
            },
            new User
            {
                Id = 13,
                FirstName = "Lejla",
                LastName = "Mujic",
                Email = "lejla.mujic@gmail.com",
                UserName = "lejla",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "069999999",
                Role = Role.PLAYER,
                ProfilePicture = profilePicture,
                Rating = 4.8
            },
            new User
            {
                Id = 14,
                FirstName = "Nermin",
                LastName = "Besic",
                Email = "nermin.besic@gmail.com",
                UserName = "nermin",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "060000000",
                Role = Role.PLAYER,
                ProfilePicture = profilePicture,
                Rating = 4.5
            },
                new User
                {
                    Id = 15,
                    FirstName = "Amir",
                    LastName = "Hodzic",
                    Email = "amir.hodzic@gmail.com",
                    UserName = "amir",
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    PhoneNumber = "061111111",
                    Role = Role.PLAYER,
                    ProfilePicture = profilePicture,
                    Rating = 4.2
                },
    new User
    {
        Id = 16,
        FirstName = "Sara",
        LastName = "Jusic",
        Email = "sara.jusic@gmail.com",
        UserName = "sara",
        PasswordHash = hash,
        PasswordSalt = salt,
        PhoneNumber = "062222222",
        Role = Role.PLAYER,
        ProfilePicture = profilePicture,
        Rating = 4.7
    },
    new User
    {
        Id = 17,
        FirstName = "Denis",
        LastName = "Kovac",
        Email = "denis.kovac@gmail.com",
        UserName = "denis",
        PasswordHash = hash,
        PasswordSalt = salt,
        PhoneNumber = "063333333",
        Role = Role.PLAYER,
        ProfilePicture = profilePicture,
        Rating = 4.4
    },
    new User
    {
        Id = 18,
        FirstName = "Mina",
        LastName = "Babic",
        Email = "mina.babic@gmail.com",
        UserName = "mina",
        PasswordHash = hash,
        PasswordSalt = salt,
        PhoneNumber = "064444444",
        Role = Role.PLAYER,
        ProfilePicture = profilePicture,
        Rating = 4.6
    },
    new User
    {
        Id = 19,
        FirstName = "Tarik",
        LastName = "Smajic",
        Email = "tarik.smajic@gmail.com",
        UserName = "tarik",
        PasswordHash = hash,
        PasswordSalt = salt,
        PhoneNumber = "065555555",
        Role = Role.PLAYER,
        ProfilePicture = profilePicture,
        Rating = 4.3
    }

        );
    }

    private void SeedSportCenters(ModelBuilder modelBuilder)
    {
        var placeholderImage = File.ReadAllBytes("sportCenterImageSeed.jpg");
        modelBuilder.Entity<SportsCenter>().HasData(
            new SportsCenter
            {
                Id = 5,
                Name = "Sportska Dvorana Donji Vakuf",
                Address = "Armije BiH",
                Description = "Dvorana u Donjem Vakufu",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 5,
                Image = placeholderImage
            },
            new SportsCenter
            {
                Id = 6,
                Name = "Centar za Sport i Rekreaciju Sarajevo",
                Address = "Zmaja od Bosne bb",
                Description = "Moderno opremljen sportski centar u Sarajevu",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 6,
                Image = placeholderImage
            },
            new SportsCenter
            {
                Id = 7,
                Name = "Sportska Arena Mostar",
                Address = "Aleksina Međa 45",
                Description = "Savremena arena za različite sportove",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 7,
                Image = placeholderImage
            },
            new SportsCenter
            {
                Id = 8,
                Name = "Sportski Centar Tuzla",
                Address = "Meše Selimovića 88",
                Description = "Multifunkcionalni prostor za rekreaciju",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 8,
                Image = placeholderImage
            },
            new SportsCenter
            {
                Id = 9,
                Name = "FitZone Zenica",
                Address = "Crkvice bb",
                Description = "Najmoderniji sportski centar u Zenici",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 9,
                Image = placeholderImage
            });
    }

    private void SeedSportFields(ModelBuilder modelBuilder)
    {
        var image = File.ReadAllBytes("sportfieldImageSeed.jpg");
        modelBuilder.Entity<SportsField>().HasData(
        new SportsField
        {
            Id = 100,
            Name = "Teren 1 - Donji Vakuf",
            SportType = "Fudbal",
            Description = "Vanjski teren za mali fudbal",
            Capacity = 10,
            PricePerHour = 20,
            SportsCenterId = 5,
            Image = image
        },
        new SportsField
        {
            Id = 101,
            Name = "Teren 2 - Donji Vakuf",
            SportType = "Košarka",
            Description = "Unutrašnji teren za košarku",
            Capacity = 10,
            PricePerHour = 25,
            SportsCenterId = 5,
            Image = image
        },
        new SportsField
        {
            Id = 102,
            Name = "Teren 1 - Sarajevo",
            SportType = "Tenis",
            Description = "Teniski teren sa tvrdom podlogom",
            Capacity = 4,
            PricePerHour = 30,
            SportsCenterId = 6,
            Image = image
        },
        new SportsField
        {
            Id = 103,
            Name = "Teren 2 - Sarajevo",
            SportType = "Fudbal",
            Description = "Umjetna trava, reflektori za noćne termine",
            Capacity = 12,
            PricePerHour = 35,
            SportsCenterId = 6,
            Image = image
        },
        new SportsField
        {
            Id = 104,
            Name = "Teren 1 - Mostar",
            SportType = "Košarka",
            Description = "Teren sa parketom i tribinama",
            Capacity = 10,
            PricePerHour = 22,
            SportsCenterId = 7,
            Image = image
        },
        new SportsField
        {
            Id = 105,
            Name = "Teren 2 - Mostar",
            SportType = "Odbojka",
            Description = "Unutrašnji teren za odbojku",
            Capacity = 8,
            PricePerHour = 20,
            SportsCenterId = 7,
            Image = image
        },
        new SportsField
        {
            Id = 106,
            Name = "Teren 1 - Tuzla",
            SportType = "Fudbal",
            Description = "Moderno opremljen fudbalski teren",
            Capacity = 14,
            PricePerHour = 28,
            SportsCenterId = 8,
            Image = image
        },
        new SportsField
        {
            Id = 107,
            Name = "Teren 2 - Tuzla",
            SportType = "Tenis",
            Description = "Teren sa zemljanom podlogom",
            Capacity = 2,
            PricePerHour = 18,
            SportsCenterId = 8,
            Image = image
        },
        new SportsField
        {
            Id = 108,
            Name = "Teren 1 - Zenica",
            SportType = "Košarka",
            Description = "Vanjski teren, odličan za ljetne termine",
            Capacity = 10,
            PricePerHour = 24,
            SportsCenterId = 9,
            Image = image
        },
        new SportsField
        {
            Id = 109,
            Name = "Teren 2 - Zenica",
            SportType = "Fudbal",
            Description = "Teren sa vještačkom travom i reflektorima",
            Capacity = 12,
            PricePerHour = 32,
            SportsCenterId = 9,
            Image = image
        });

    }

    private void SeedReservations(ModelBuilder modelBuilder)
    {
        var today = DateTime.Today;

        modelBuilder.Entity<Reservation>().HasData(
            new Reservation { Id = 201, UserId = 10, SportsFieldId = 100, StartTime = today.AddHours(10), EndTime = today.AddHours(11), TotalPrice = 20, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 202, UserId = 12, SportsFieldId = 101, StartTime = today.AddDays(1).AddHours(12), EndTime = today.AddDays(1).AddHours(13), TotalPrice = 25, Status = ReservationStatus.CANCELLED, CancellationReason = "Nevrijeme" },
            new Reservation { Id = 203, UserId = 13, SportsFieldId = 102, StartTime = today.AddHours(14), EndTime = today.AddHours(15), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 204, UserId = 14, SportsFieldId = 103, StartTime = today.AddHours(17), EndTime = today.AddHours(18), TotalPrice = 35, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 205, UserId = 11, SportsFieldId = 104, StartTime = today.AddDays(-1).AddHours(16), EndTime = today.AddDays(-1).AddHours(17), TotalPrice = 22, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 206, UserId = 12, SportsFieldId = 105, StartTime = today.AddDays(-2).AddHours(13), EndTime = today.AddDays(-2).AddHours(14), TotalPrice = 20, Status = ReservationStatus.CANCELLED, CancellationReason = "Nevrijeme" },
            new Reservation { Id = 207, UserId = 13, SportsFieldId = 106, StartTime = today.AddHours(18), EndTime = today.AddHours(19), TotalPrice = 28, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 208, UserId = 14, SportsFieldId = 107, StartTime = today.AddHours(20), EndTime = today.AddHours(21), TotalPrice = 18, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 209, UserId = 10, SportsFieldId = 108, StartTime = today.AddDays(2).AddHours(14), EndTime = today.AddDays(2).AddHours(15), TotalPrice = 24, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2010, UserId = 11, SportsFieldId = 109, StartTime = today.AddDays(1).AddHours(15), EndTime = today.AddDays(1).AddHours(16), TotalPrice = 32, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2011, UserId = 12, SportsFieldId = 100, StartTime = today.AddDays(3).AddHours(10), EndTime = today.AddDays(3).AddHours(11), TotalPrice = 20, Status = ReservationStatus.CANCELLED, CancellationReason = "Kvar na mreži" },
            new Reservation { Id = 2012, UserId = 13, SportsFieldId = 101, StartTime = today.AddDays(-3).AddHours(12), EndTime = today.AddDays(-3).AddHours(13), TotalPrice = 25, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2013, UserId = 14, SportsFieldId = 102, StartTime = today.AddDays(-1).AddHours(10), EndTime = today.AddDays(-1).AddHours(11), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2014, UserId = 10, SportsFieldId = 103, StartTime = today.AddHours(11), EndTime = today.AddHours(12), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2015, UserId = 11, SportsFieldId = 104, StartTime = today.AddDays(1).AddHours(13), EndTime = today.AddDays(1).AddHours(14), TotalPrice = 22, Status = ReservationStatus.CANCELLED, CancellationReason = "Kvar na grijanju" },
            new Reservation { Id = 2016, UserId = 12, SportsFieldId = 105, StartTime = today.AddHours(14), EndTime = today.AddHours(15), TotalPrice = 20, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2017, UserId = 13, SportsFieldId = 106, StartTime = today.AddDays(2).AddHours(17), EndTime = today.AddDays(2).AddHours(18), TotalPrice = 28, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2018, UserId = 14, SportsFieldId = 107, StartTime = today.AddDays(-1).AddHours(18), EndTime = today.AddDays(-1).AddHours(19), TotalPrice = 18, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2019, UserId = 11, SportsFieldId = 108, StartTime = today.AddHours(19), EndTime = today.AddHours(20), TotalPrice = 24, Status = ReservationStatus.CANCELLED, CancellationReason = "Nevrijeme" },
            new Reservation { Id = 2020, UserId = 12, SportsFieldId = 109, StartTime = today.AddDays(1).AddHours(20), EndTime = today.AddDays(1).AddHours(21), TotalPrice = 32, Status = ReservationStatus.FINISHED, CancellationReason = null },

            new Reservation { Id = 2021, UserId = 10, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month, 1).AddHours(9), EndTime = new DateTime(today.Year, today.Month, 1).AddHours(10), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2022, UserId = 11, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month, 5).AddHours(14), EndTime = new DateTime(today.Year, today.Month, 5).AddHours(15), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2023, UserId = 12, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month, 10).AddHours(16), EndTime = new DateTime(today.Year, today.Month, 10).AddHours(17), TotalPrice = 30, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2024, UserId = 13, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month, 15).AddHours(11), EndTime = new DateTime(today.Year, today.Month, 15).AddHours(12), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2025, UserId = 14, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month, 20).AddHours(13), EndTime = new DateTime(today.Year, today.Month, 20).AddHours(14), TotalPrice = 30, Status = ReservationStatus.CANCELLED, CancellationReason = "Otkazano" },
            new Reservation { Id = 2026, UserId = 10, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month + 1, 2).AddHours(10), EndTime = new DateTime(today.Year, today.Month + 1, 2).AddHours(11), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2027, UserId = 11, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month + 1, 8).AddHours(15), EndTime = new DateTime(today.Year, today.Month + 1, 8).AddHours(16), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2028, UserId = 12, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month - 1, 12).AddHours(9), EndTime = new DateTime(today.Year, today.Month - 1, 12).AddHours(10), TotalPrice = 30, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2029, UserId = 13, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month - 1, 18).AddHours(14), EndTime = new DateTime(today.Year, today.Month - 1, 18).AddHours(15), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2030, UserId = 14, SportsFieldId = 102, StartTime = new DateTime(today.Year, today.Month - 1, 22).AddHours(16), EndTime = new DateTime(today.Year, today.Month - 1, 22).AddHours(17), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2031, UserId = 10, SportsFieldId = 102, StartTime = new DateTime(today.Year + 1, 3, 5).AddHours(11), EndTime = new DateTime(today.Year + 1, 3, 5).AddHours(12), TotalPrice = 30, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2032, UserId = 11, SportsFieldId = 102, StartTime = new DateTime(today.Year + 1, 6, 15).AddHours(13), EndTime = new DateTime(today.Year + 1, 6, 15).AddHours(14), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2033, UserId = 12, SportsFieldId = 102, StartTime = new DateTime(today.Year - 1, 9, 25).AddHours(10), EndTime = new DateTime(today.Year - 1, 9, 25).AddHours(11), TotalPrice = 30, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2034, UserId = 13, SportsFieldId = 102, StartTime = new DateTime(today.Year - 1, 11, 30).AddHours(15), EndTime = new DateTime(today.Year - 1, 11, 30).AddHours(16), TotalPrice = 30, Status = ReservationStatus.CANCELLED, CancellationReason = "Nevrijeme" },
            new Reservation { Id = 2035, UserId = 14, SportsFieldId = 102, StartTime = new DateTime(today.Year - 1, 12, 24).AddHours(9), EndTime = new DateTime(today.Year - 1, 12, 24).AddHours(10), TotalPrice = 30, Status = ReservationStatus.PAYED, CancellationReason = null },

            new Reservation { Id = 2036, UserId = 10, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month, 3).AddHours(10), EndTime = new DateTime(today.Year, today.Month, 3).AddHours(11), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2037, UserId = 11, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month, 7).AddHours(14), EndTime = new DateTime(today.Year, today.Month, 7).AddHours(15), TotalPrice = 35, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2038, UserId = 12, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month, 12).AddHours(16), EndTime = new DateTime(today.Year, today.Month, 12).AddHours(17), TotalPrice = 35, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2039, UserId = 13, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month, 17).AddHours(11), EndTime = new DateTime(today.Year, today.Month, 17).AddHours(12), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2040, UserId = 14, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month, 21).AddHours(13), EndTime = new DateTime(today.Year, today.Month, 21).AddHours(14), TotalPrice = 35, Status = ReservationStatus.CANCELLED, CancellationReason = "Otkazano" },
            new Reservation { Id = 2041, UserId = 10, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month + 1, 4).AddHours(10), EndTime = new DateTime(today.Year, today.Month + 1, 4).AddHours(11), TotalPrice = 35, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2042, UserId = 11, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month + 1, 9).AddHours(15), EndTime = new DateTime(today.Year, today.Month + 1, 9).AddHours(16), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2043, UserId = 12, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month - 1, 14).AddHours(9), EndTime = new DateTime(today.Year, today.Month - 1, 14).AddHours(10), TotalPrice = 35, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2044, UserId = 13, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month - 1, 19).AddHours(14), EndTime = new DateTime(today.Year, today.Month - 1, 19).AddHours(15), TotalPrice = 35, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2045, UserId = 14, SportsFieldId = 103, StartTime = new DateTime(today.Year, today.Month - 1, 23).AddHours(16), EndTime = new DateTime(today.Year, today.Month - 1, 23).AddHours(17), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2046, UserId = 10, SportsFieldId = 103, StartTime = new DateTime(today.Year + 1, 4, 6).AddHours(11), EndTime = new DateTime(today.Year + 1, 4, 6).AddHours(12), TotalPrice = 35, Status = ReservationStatus.CREATED, CancellationReason = null },
            new Reservation { Id = 2047, UserId = 11, SportsFieldId = 103, StartTime = new DateTime(today.Year + 1, 7, 16).AddHours(13), EndTime = new DateTime(today.Year + 1, 7, 16).AddHours(14), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
            new Reservation { Id = 2048, UserId = 12, SportsFieldId = 103, StartTime = new DateTime(today.Year - 1, 8, 26).AddHours(10), EndTime = new DateTime(today.Year - 1, 8, 26).AddHours(11), TotalPrice = 35, Status = ReservationStatus.FINISHED, CancellationReason = null },
            new Reservation { Id = 2049, UserId = 13, SportsFieldId = 103, StartTime = new DateTime(today.Year - 1, 10, 31).AddHours(15), EndTime = new DateTime(today.Year - 1, 10, 31).AddHours(16), TotalPrice = 35, Status = ReservationStatus.CANCELLED, CancellationReason = "Nevrijeme" },
            new Reservation { Id = 2050, UserId = 14, SportsFieldId = 103, StartTime = new DateTime(today.Year - 1, 12, 25).AddHours(9), EndTime = new DateTime(today.Year - 1, 12, 25).AddHours(10), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null }
        );
    }

    private void SeedReviews(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 101, UserId = 10, SportsCenterId = 5, Content = "Sjajno iskustvo, teren je bio vrhunski pripremljen!.", Rating = 4.5m, Created = DateTime.Today.AddDays(-10) },
            new Review { Id = 102, UserId = 11, SportsCenterId = 6, Content = "Osoblje je bilo ljubazno i susretljivo. Preporučujem svima!", Rating = 5.0m, Created = DateTime.Today.AddDays(-8) },
            new Review { Id = 103, UserId = 12, SportsCenterId = 7, Content = "Odlična atmosfera i dobro održavani tereni.", Rating = 3.8m, Created = DateTime.Today.AddDays(-6) },
            new Review { Id = 104, UserId = 13, SportsCenterId = 8, Content = "Rezervacija je prošla glatko i bez ikakvih problema.", Rating = 4.2m, Created = DateTime.Today.AddDays(-4) },
            new Review { Id = 105, UserId = 14, SportsCenterId = 9, Content = "Malo skuplje, ali vrijedno svake marke..", Rating = 3.5m, Created = DateTime.Today.AddDays(-2) },
            new Review { Id = 106, UserId = 10, SportsCenterId = 6, Content = "Fantastic experience overall.", Rating = 4.8m, Created = DateTime.Today.AddDays(-1) },
            new Review { Id = 107, UserId = 11, SportsCenterId = 7, Content = "Tereni su bili čisti, ali svlačionice bi mogle biti bolje.", Rating = 4.7m, Created = DateTime.Today.AddDays(-3) },
            new Review { Id = 108, UserId = 12, SportsCenterId = 8, Content = "Kvalitet opreme je bio iznad očekivanja.", Rating = 4.0m, Created = DateTime.Today.AddDays(-7) },
            new Review { Id = 109, UserId = 13, SportsCenterId = 9, Content = "Could use better lighting at night.", Rating = 3.9m, Created = DateTime.Today.AddDays(-5) },
            new Review { Id = 1010, UserId = 14, SportsCenterId = 5, Content = "Definitivno ću se ponovo vratiti!", Rating = 5.0m, Created = DateTime.Today }
        );
    
    }

    private void SeedTeams(ModelBuilder modelBuilder)
    {
        var teamPicture = File.ReadAllBytes("teamPictureSeed.jpg");
        modelBuilder.Entity<Team>().HasData(
    new Team
    {
        Id = 101,
        Name = "Jaguars",
        Description = "Najjači futsal tim u gradu.",
        IsPublic = true,
        CaptainId = 10,
        JoinCode = null,
        Sport = Sport.FUTSAL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 102,
        Name = "Desert Foxes",
        Description = "Elitna ekipa za odbojku na pijesku.",
        IsPublic = false,
        CaptainId = 10,
        JoinCode = "JOIN2",
        Sport = Sport.BEACH_VOLLEYBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 103,
        Name = "Sky Dunkers",
        Description = "Zaljubljenici u košarku, zajedno na terenu.",
        IsPublic = true,
        CaptainId = 11,
        JoinCode = null,
        Sport = Sport.BASKETBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 104,
        Name = "Urban Hawks",
        Description = "Teniski klub za sve uzrast.",
        IsPublic = false,
        CaptainId = 11,
        JoinCode = "JOIN4",
        Sport = Sport.TENNIS,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 105,
        Name = "Volley Ninjas",
        Description = "Najbolji odbojkaški tim u gradu.",
        IsPublic = true,
        CaptainId = 12,
        JoinCode = null,
        Sport = Sport.VOLLEYBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 106,
        Name = "Handball Heroes",
        Description = "Akcija i strast prema rukometu.",
        IsPublic = false,
        CaptainId = 12,
        JoinCode = "JOIN6",
        Sport = Sport.HANDBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 107,
        Name = "Thunderballs",
        Description = "Brzina i snaga u futsalu.",
        IsPublic = true,
        CaptainId = 13,
        JoinCode = null,
        Sport = Sport.FUTSAL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 108,
        Name = "Court Kings",
        Description = "Tim za taktičku košarku",
        IsPublic = false,
        CaptainId = 13,
        JoinCode = "JOIN8",
        Sport = Sport.BASKETBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 109,
        Name = "Beach Storm",
        Description = "Vladari terena na pijesku..",
        IsPublic = true,
        CaptainId = 14,
        JoinCode = null,
        Sport = Sport.BEACH_VOLLEYBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 1010,
        Name = "Field Blazers",
        Description = "Šampioni mini fudbala.",
        IsPublic = false,
        CaptainId = 14,
        JoinCode = "JOIN10",
        Sport = Sport.MINI_FOOTBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 1011,
        Name = "The Smashers",
        Description = "Odbojkaška izvrsnost i timski duh.",
        IsPublic = true,
        CaptainId = 15,
        JoinCode = null,
        Sport = Sport.VOLLEYBALL,
        TeamPicture = teamPicture
    },
    new Team
    {
        Id = 1012,
        Name = "Net Raiders",
        Description = "Furija na rukometnom terenu.",
        IsPublic = false,
        CaptainId = 15,
        JoinCode = "JOIN12",
        Sport = Sport.HANDBALL,
        TeamPicture = teamPicture
    }
);

    }

    private void SeedUserTeams(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserTeam>().HasData(
            new UserTeam { UserId = 10, TeamId = 101, IsCaptain = true },
            new UserTeam { UserId = 10, TeamId = 102, IsCaptain = true },
            new UserTeam { UserId = 11, TeamId = 103, IsCaptain = true },
            new UserTeam { UserId = 11, TeamId = 104, IsCaptain = true },
            new UserTeam { UserId = 12, TeamId = 105, IsCaptain = true },
            new UserTeam { UserId = 12, TeamId = 106, IsCaptain = true },
            new UserTeam { UserId = 13, TeamId = 107, IsCaptain = true },
            new UserTeam { UserId = 13, TeamId = 108, IsCaptain = true },
            new UserTeam { UserId = 14, TeamId = 109, IsCaptain = true },
            new UserTeam { UserId = 14, TeamId = 1010, IsCaptain = true },
            new UserTeam { UserId = 15, TeamId = 1011, IsCaptain = true },
            new UserTeam { UserId = 15, TeamId = 1012, IsCaptain = true },
            new UserTeam { UserId = 11, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 102, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 103, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 104, IsCaptain = false },
            new UserTeam { UserId = 10, TeamId = 105, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 106, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 107, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 1011, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 109, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 101, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 104, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 104, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 104, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 104, IsCaptain = false }
        );
    }
    
    private void SeedSquads(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Squad>().HasData(
            new Squad { Id = 101, Name = "Crni Lavovi", TeamId = 101 },
            new Squad { Id = 102, Name = "Bijeli Vukovi", TeamId = 101 },

            new Squad { Id = 103, Name = "Pješčani Šampioni", TeamId = 102 },
            new Squad { Id = 104, Name = "Zlatne Zvijezde", TeamId = 102 },

            new Squad { Id = 105, Name = "Nebeski Skakači", TeamId = 103 },
            new Squad { Id = 106, Name = "Ulični Letaci", TeamId = 103 },

            new Squad { Id = 107, Name = "Teniski Majstori", TeamId = 104 },
            new Squad { Id = 108, Name = "Brzi Servisi", TeamId = 104 },

            new Squad { Id = 109, Name = "Odbojkaške Nindže", TeamId = 105 },
            new Squad { Id = 1010, Name = "Skakači", TeamId = 105 },

            new Squad { Id = 1011, Name = "Rukometni Ratnici", TeamId = 106 },
            new Squad { Id = 1012, Name = "Zidari Odbrane", TeamId = 106 },

            new Squad { Id = 1013, Name = "Munje", TeamId = 107 },
            new Squad { Id = 1014, Name = "Gromovi", TeamId = 107 },

            new Squad { Id = 1015, Name = "Dvoranski Kraljevi", TeamId = 108 },
            new Squad { Id = 1016, Name = "Taktičari", TeamId = 108 },

            new Squad { Id = 1017, Name = "Plažni Vojnici", TeamId = 109 },
            new Squad { Id = 1018, Name = "Pješčane Laste", TeamId = 109 },

            new Squad { Id = 1019, Name = "Fudbalski Osvajači", TeamId = 1010 },
            new Squad { Id = 1020, Name = "Zeleni Tereni", TeamId = 1010 },

            new Squad { Id = 1021, Name = "Odbojkaške Zvijezde", TeamId = 1011 },
            new Squad { Id = 1022, Name = "Blokeri", TeamId = 1011 },

            new Squad { Id = 1023, Name = "Mrežni Napadači", TeamId = 1012 },
            new Squad { Id = 1024, Name = "Ofanzivaši", TeamId = 1012 }
        );
    }
    
    private void SeedUserSquads(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<UserSquad>().HasData(
        // Team 101 (User 10 is captain, users 11 and 12 are members)
        new UserSquad { UserId = 10, SquadId = 101 }, // captain -> first squad
        new UserSquad { UserId = 11, SquadId = 102 }, // member -> second squad
        new UserSquad { UserId = 12, SquadId = 102 }, // member -> second squad
        new UserSquad { UserId = 15, SquadId = 102 }, // member -> second squad
        new UserSquad { UserId = 17, SquadId = 102 }, // member -> second squad
        new UserSquad { UserId = 18, SquadId = 101 }, // member -> first squad
        new UserSquad { UserId = 19, SquadId = 101 }, // member -> first squad

        // Team 102 (User 10 captain, user 13 member)
        new UserSquad { UserId = 10, SquadId = 103 }, // captain
        new UserSquad { UserId = 13, SquadId = 104 }, // member

        // Team 103 (User 11 captain, user 14 member)
        new UserSquad { UserId = 11, SquadId = 105 }, // captain
        new UserSquad { UserId = 14, SquadId = 106 }, // member

        // Team 104 (User 11 captain, no members except invalid user 15 omitted)
        new UserSquad { UserId = 11, SquadId = 107 }, // captain

        // Team 105 (User 12 captain, user 10 member)
        new UserSquad { UserId = 12, SquadId = 109 }, // captain
        new UserSquad { UserId = 10, SquadId = 1010 }, // member

        // Team 106 (User 12 captain, user 11 member)
        new UserSquad { UserId = 12, SquadId = 1011 }, // captain
        new UserSquad { UserId = 11, SquadId = 1012 }, // member

        // Team 107 (User 13 captain, user 12 member)
        new UserSquad { UserId = 13, SquadId = 1013 }, // captain
        new UserSquad { UserId = 12, SquadId = 1014 }, // member

        // Team 108 (User 13 captain, user 13 member - same user, so assign both squads)
        new UserSquad { UserId = 13, SquadId = 1015 }, // captain
        new UserSquad { UserId = 13, SquadId = 1016 }, // member (same user)

        // Team 109 (User 14 captain, no valid members except omitted UserId 15)
        new UserSquad { UserId = 14, SquadId = 1017 }, // captain

        // Team 1010 (User 14 captain, no members except omitted UserId 15)
        new UserSquad { UserId = 14, SquadId = 1019 }  // captain
    );
}

    private void SeedMatches(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Match>().HasData(
        new Match { Id = 1, TeamId = 101, MatchDate = new DateTime(2025, 7, 1, 15, 0, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 2, TeamId = 102, MatchDate = new DateTime(2025, 7, 5, 18, 30, 0), Result = "2:1", Status = MatchStatus.FINISHED },
        new Match { Id = 3, TeamId = 103, MatchDate = new DateTime(2025, 7, 10, 20, 0, 0), Result = null, Status = MatchStatus.CANCELLED },

        new Match { Id = 4, TeamId = 101, MatchDate = new DateTime(2025, 7, 15, 17, 0, 0), Result = "3:3", Status = MatchStatus.FINISHED },
        new Match { Id = 5, TeamId = 104, MatchDate = new DateTime(2025, 7, 20, 19, 45, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 6, TeamId = 105, MatchDate = new DateTime(2025, 7, 22, 16, 30, 0), Result = "1:0", Status = MatchStatus.FINISHED },
        new Match { Id = 7, TeamId = 106, MatchDate = new DateTime(2025, 7, 25, 14, 0, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 8, TeamId = 107, MatchDate = new DateTime(2025, 7, 28, 20, 0, 0), Result = "0:2", Status = MatchStatus.FINISHED },
        new Match { Id = 9, TeamId = 108, MatchDate = new DateTime(2025, 8, 1, 18, 15, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 10, TeamId = 109, MatchDate = new DateTime(2025, 8, 3, 19, 30, 0), Result = "4:1", Status = MatchStatus.FINISHED },

        new Match { Id = 11, TeamId = 1010, MatchDate = new DateTime(2025, 8, 7, 16, 0, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 12, TeamId = 1011, MatchDate = new DateTime(2025, 8, 10, 15, 45, 0), Result = "2:2", Status = MatchStatus.FINISHED },
        new Match { Id = 13, TeamId = 1012, MatchDate = new DateTime(2025, 8, 15, 17, 30, 0), Result = null, Status = MatchStatus.CANCELLED },

        new Match { Id = 14, TeamId = 101, MatchDate = new DateTime(2025, 8, 18, 19, 0, 0), Result = "1:1", Status = MatchStatus.FINISHED },
        new Match { Id = 15, TeamId = 102, MatchDate = new DateTime(2025, 8, 21, 18, 0, 0), Result = null, Status = MatchStatus.CREATED },
        new Match { Id = 16, TeamId = 103, MatchDate = new DateTime(2025, 8, 25, 20, 0, 0), Result = "0:3", Status = MatchStatus.FINISHED }
    );
}

    private void SeedComments(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>().HasData(
            new Comment { Id = 101, UserId = 10, MatchId = 2, Content = "Sjajna utakmica, baš uzbudljivo!", Created = new DateTime(2025, 7, 6, 20, 0, 0) },
            new Comment { Id = 102, UserId = 11, MatchId = 2, Content = "What a comeback in the last 10 minutes!", Created = new DateTime(2025, 7, 6, 20, 15, 0) },
            new Comment { Id = 103, UserId = 12, MatchId = 4, Content = "Ne mogu vjerovati da je završilo neriješeno.", Created = new DateTime(2025, 7, 16, 18, 30, 0) },
            new Comment { Id = 104, UserId = 13, MatchId = 4, Content = "Great effort by both teams.", Created = new DateTime(2025, 7, 16, 19, 0, 0) },
            new Comment { Id = 105, UserId = 14, MatchId = 6, Content = "Bravo za pobjedu, nastavimo ovako!", Created = new DateTime(2025, 7, 23, 10, 0, 0) },
            new Comment { Id = 106, UserId = 10, MatchId = 8, Content = "Tough game, but well played.", Created = new DateTime(2025, 7, 29, 21, 0, 0) },
            new Comment { Id = 107, UserId = 11, MatchId = 8, Content = "Izvrsni servisi danas!", Created = new DateTime(2025, 7, 29, 21, 15, 0) },
            new Comment { Id = 108, UserId = 12, MatchId = 10, Content = "Amazing teamwork and strategy.", Created = new DateTime(2025, 8, 4, 20, 0, 0) },
            new Comment { Id = 109, UserId = 13, MatchId = 10, Content = "Čestitke na visokoj pobjedi!", Created = new DateTime(2025, 8, 4, 20, 30, 0) },
            new Comment { Id = 1010, UserId = 14, MatchId = 14, Content = "Close game, both teams showed heart.", Created = new DateTime(2025, 8, 19, 20, 0, 0) }
        );
    }

    private void CreatePasswordHash(string password, out string hash, out string salt)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA256();
        var saltBytes = hmac.Key;
        var passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
        var hashBytes = hmac.ComputeHash(passwordBytes);

        hash = Convert.ToBase64String(hashBytes);
        salt = Convert.ToBase64String(saltBytes);
    }
}