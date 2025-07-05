using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Enums;

namespace WeNeed1.Service.Database;

public partial class WeNeed1Context : DbContext
{
     private void SeedUsers(ModelBuilder modelBuilder)
    {
        var password = "12345678";
        CreatePasswordHash(password, out string hash, out string salt);

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
                ProfilePicture = null
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
                ProfilePicture = null
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
                ProfilePicture = null
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
                ProfilePicture = null
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
                ProfilePicture = null
            },

            new User
            {
                Id = 901,
                FirstName = "Elmma",
                LastName = "Karic",
                Email = "elma.karic@gmail.com",
                UserName = "elmma",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "066666666",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 902,
                FirstName = "Dino",
                LastName = "Begovic",
                Email = "dino.begovic@gmail.com",
                UserName = "dino",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "067777777",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 900,
                FirstName = "Kasim",
                LastName = "Softic",
                Email = "lejla.softic@gmail.com",
                UserName = "kasim",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "068888888",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 903,
                FirstName = "Adnan",
                LastName = "Suljic",
                Email = "adnan.suljic@gmail.com",
                UserName = "adnann",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "069999999",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 904,
                FirstName = "Emina",
                LastName = "Celik",
                Email = "emina.celik@gmail.com",
                UserName = "eminna",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000001",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 905,
                FirstName = "Mirza",
                LastName = "Cengic",
                Email = "mirza.cengic@gmail.com",
                UserName = "mirzaa",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000002",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 906,
                FirstName = "Alma",
                LastName = "Salihovic",
                Email = "alma.salihovic@gmail.com",
                UserName = "almaa",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000003",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 907,
                FirstName = "Emirr",
                LastName = "Avdic",
                Email = "emirr.avdic@gmail.com",
                UserName = "emirr",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000004",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 908,
                FirstName = "Ajla",
                LastName = "Redzic",
                Email = "ajla.redzic@gmail.com",
                UserName = "ajlaa",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000005",
                Role = Role.MANAGER,
                ProfilePicture = null
            },
            new User
            {
                Id = 909,
                FirstName = "Tarikk",
                LastName = "Selimovic",
                Email = "tarik.selimovic@gmail.com",
                UserName = "tselimovic",
                PasswordHash = hash,
                PasswordSalt = salt,
                PhoneNumber = "061000006",
                Role = Role.MANAGER,
                ProfilePicture = null
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
                ProfilePicture = null,
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
                ProfilePicture = null,
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
                ProfilePicture = null,
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
                ProfilePicture = null,
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
                ProfilePicture = null,
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
                    ProfilePicture = null,
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
        ProfilePicture = null,
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
        ProfilePicture = null,
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
        ProfilePicture = null,
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
        ProfilePicture = null,
        Rating = 4.3
    },
        new User
        {
            Id = 20,
            FirstName = "Inas",
            LastName = "Bajrak",
            Email = "inas.bajrak@gmail.com",
            UserName = "inas",
            PasswordHash = hash,
            PasswordSalt = salt,
            PhoneNumber = "065555555",
            Role = Role.PLAYER,
            ProfilePicture = null,
            Rating = 4.3
        }
    );
    }

    private void SeedSportCenters(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SportsCenter>().HasData(
         new SportsCenter
         {
             Id = 5,
             Name = "Sportska Dvorana Bugojno",
             Street = "Zelenih Beretki 12",
             City = "Bugojno",
             Description = "Dvorana u Bugojnu",
             StartTime = new TimeSpan(10, 0, 0),
             EndTime = new TimeSpan(23, 0, 0),
             ManagerId = 5,
             Image = null
         },
            new SportsCenter
            {
                Id = 6,
                Name = "Centar za Sport Trebinje",
                Street = "Obala Kulina Bana 7",
                City = "Trebinje",
                Description = "Sportski centar u Trebinju",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 6,
                Image = null
            },
            new SportsCenter
            {
                Id = 7,
                Name = "Arena Sarajevo",
                Street = "Ivana Gorana Kovačića 6",
                City = "Sarajevo",
                Description = "Savremeni sportski kompleks u Sarajevu",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 7,
                Image = null
            },
            new SportsCenter
            {
                Id = 8,
                Name = "Sportska Arena Mostar",
                Street = "Zelenih Beretki 24",
                City = "Mostar",
                Description = "Moderna dvorana u Mostaru",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 8,
                Image = null
            },
            new SportsCenter
            {
                Id = 9,
                Name = "FitZone Zenica",
                Street = "Zelenih Beretki 66",
                City = "Zenica",
                Description = "Najmoderniji sportski centar u Zenici",
                StartTime = new TimeSpan(10, 0, 0),
                EndTime = new TimeSpan(23, 0, 0),
                ManagerId = 9,
                Image = null
            },


                new SportsCenter
                {
                    Id = 900,
                    Name = "Arena Travnik",
                    Street = "Bosanska 13",
                    City = "Travnik",
                    Description = "Sportska dvorana u Travniku",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 900
                },
                new SportsCenter
                {
                    Id = 901,
                    Name = "Dvorana Brčko",
                    Street = "Trg Mladih 21",
                    City = "Brčko",
                    Description = "Sportska hala u Brčkom",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 901
                },
                new SportsCenter
                {
                    Id = 902,
                    Name = "Sportski Centar Goražde",
                    Street = "Ribarska 5",
                    City = "Goražde",
                    Description = "Multifunkcionalni centar u Goraždu",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 902
                },
                new SportsCenter
                {
                    Id = 903,
                    Name = "Rekreativni Centar Doboj",
                    Street = "Stjepana Radića 9",
                    City = "Doboj",
                    Description = "Sportski prostor u Doboju",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 903
                },
                new SportsCenter
                {
                    Id = 904,
                    Name = "Centar Banja Luka",
                    Street = "Kralja Petra I 17",
                    City = "Banja Luka",
                    Description = "Savremeni sportski kompleks",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 904
                },
                new SportsCenter
                {
                    Id = 905,
                    Name = "Gradačac Arena",
                    Street = "Branilaca grada 3",
                    City = "Gradačac",
                    Description = "Centar za sport i rekreaciju",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 905
                },
                new SportsCenter
                {
                    Id = 906,
                    Name = "Bijeljina FitZone",
                    Street = "Njegoševa 44",
                    City = "Bijeljina",
                    Description = "Fitness i sportski centar u Bijeljini",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 906
                },
                new SportsCenter
                {
                    Id = 907,
                    Name = "Konjic Sports Hall",
                    Street = "Varda 11",
                    City = "Konjic",
                    Description = "Sportska dvorana u Konjicu",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 907
                },
                new SportsCenter
                {
                    Id = 908,
                    Name = "Bihać Sports Arena",
                    Street = "Una bb",
                    City = "Bihać",
                    Description = "Moderna sportska arena u Bihaću",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 908
                },
                new SportsCenter
                {
                    Id = 909,
                    Name = "Travnik Sports Hub",
                    Street = "Hasana Brkića 8",
                    City = "Travnik",
                    Description = "Novi centar za sport i rekreaciju",
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0),
                    ManagerId = 909
                }
            );
            
    }

    private void SeedSportFields(ModelBuilder modelBuilder)
    {
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
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
            Image = null
        },
        new SportsField
        {
            Id = 200,
            Name = "Teren 1 - Travnik",
            SportType = "Košarka",
            Description = "Natkriveni teren pogodan za sve vremenske uslove.",
            Capacity = 10,
            PricePerHour = 25,
            SportsCenterId = 900,
            Image = null
        },
        new SportsField
        {
            Id = 201,
            Name = "Teren 1 - Brčko",
            SportType = "Fudbal",
            Description = "Teren sa reflektorima i vještačkom travom.",
            Capacity = 12,
            PricePerHour = 30,
            SportsCenterId = 901,
            Image = null
        },
        new SportsField
        {
            Id = 202,
            Name = "Teren 1 - Goražde",
            SportType = "Tenis",
            Description = "Teren sa crvenom šljakom idealan za rekreativce.",
            Capacity = 4,
            PricePerHour = 20,
            SportsCenterId = 902,
            Image = null
        },
        new SportsField
        {
            Id = 203,
            Name = "Teren 1 - Doboj",
            SportType = "Odbojka",
            Description = "Teren za odbojku na pijesku, otvoreni tip.",
            Capacity = 6,
            PricePerHour = 18,
            SportsCenterId = 903,
            Image = null
        },
        new SportsField
        {
            Id = 204,
            Name = "Teren 1 - Banja Luka",
            SportType = "Košarka",
            Description = "Dvoranski teren, klimatiziran prostor.",
            Capacity = 10,
            PricePerHour = 27,
            SportsCenterId = 904,
            Image = null
        },
        new SportsField
        {
            Id = 205,
            Name = "Teren 1 - Gradačac",
            SportType = "Fudbal",
            Description = "Mini teren pogodan za futsal i treninge.",
            Capacity = 10,
            PricePerHour = 22,
            SportsCenterId = 905,
            Image = null
        },
        new SportsField
        {
            Id = 206,
            Name = "Teren 1 - Bijeljina",
            SportType = "Tenis",
            Description = "Moderno opremljeni teren sa LED osvjetljenjem.",
            Capacity = 2,
            PricePerHour = 28,
            SportsCenterId = 906,
            Image = null
        },
        new SportsField
        {
            Id = 207,
            Name = "Teren 1 - Konjic",
            SportType = "Košarka",
            Description = "Teren uz rijeku, odličan ambijent za igru.",
            Capacity = 10,
            PricePerHour = 23,
            SportsCenterId = 907,
            Image = null
        },
        new SportsField
        {
            Id = 208,
            Name = "Teren 1 - Bihać",
            SportType = "Fudbal",
            Description = "Teren sa prirodnom travom i tribinama.",
            Capacity = 14,
            PricePerHour = 35,
            SportsCenterId = 908,
            Image = null
        },
        new SportsField
        {
            Id = 209,
            Name = "Teren 1 - Travnik Hub",
            SportType = "Košarka",
            Description = "Multifunkcionalni teren u modernom ambijentu.",
            Capacity = 8,
            PricePerHour = 26,
            SportsCenterId = 909,
            Image = null
        }
        );

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
            new Reservation { Id = 2050, UserId = 14, SportsFieldId = 103, StartTime = new DateTime(today.Year - 1, 12, 25).AddHours(9), EndTime = new DateTime(today.Year - 1, 12, 25).AddHours(10), TotalPrice = 35, Status = ReservationStatus.PAYED, CancellationReason = null },
             new Reservation
             {
                 Id = 2051,
                 UserId = 10,
                 SportsFieldId = 200,
                 StartTime = new DateTime(today.Year + 1, 1, 5, 12, 0, 0),
                 EndTime = new DateTime(today.Year + 1, 1, 5, 13, 0, 0),
                 TotalPrice = 25,
                 Status = ReservationStatus.CREATED
             },
    new Reservation
    {
        Id = 2052,
        UserId = 11,
        SportsFieldId = 201,
        StartTime = new DateTime(today.Year, 9, 10, 14, 0, 0),
        EndTime = new DateTime(today.Year, 9, 10, 15, 0, 0),
        TotalPrice = 30,
        Status = ReservationStatus.PAYED
    },
    new Reservation
    {
        Id = 2053,
        UserId = 12,
        SportsFieldId = 202,
        StartTime = new DateTime(today.Year - 1, 6, 3, 17, 0, 0),
        EndTime = new DateTime(today.Year - 1, 6, 3, 18, 0, 0),
        TotalPrice = 20,
        Status = ReservationStatus.FINISHED
    },
    new Reservation
    {
        Id = 2054,
        UserId = 13,
        SportsFieldId = 203,
        StartTime = new DateTime(today.Year - 1, 11, 20, 10, 0, 0),
        EndTime = new DateTime(today.Year - 1, 11, 20, 11, 0, 0),
        TotalPrice = 18,
        Status = ReservationStatus.CANCELLED,
        CancellationReason = "Nedostatak igrača"
    },
    new Reservation
    {
        Id = 2055,
        UserId = 14,
        SportsFieldId = 204,
        StartTime = new DateTime(today.Year + 1, 3, 15, 19, 0, 0),
        EndTime = new DateTime(today.Year + 1, 3, 15, 20, 0, 0),
        TotalPrice = 27,
        Status = ReservationStatus.CREATED
    },
    new Reservation
    {
        Id = 2056,
        UserId = 14,
        SportsFieldId = 205,
        StartTime = new DateTime(today.Year, 10, 1, 9, 0, 0),
        EndTime = new DateTime(today.Year, 10, 1, 10, 0, 0),
        TotalPrice = 22,
        Status = ReservationStatus.PAYED
    },
    new Reservation
    {
        Id = 2057,
        UserId = 13,
        SportsFieldId = 206,
        StartTime = new DateTime(today.Year - 1, 5, 11, 15, 0, 0),
        EndTime = new DateTime(today.Year - 1, 5, 11, 16, 0, 0),
        TotalPrice = 28,
        Status = ReservationStatus.FINISHED
    },
    new Reservation
    {
        Id = 2058,
        UserId = 12,
        SportsFieldId = 207,
        StartTime = new DateTime(today.Year - 1, 8, 22, 13, 0, 0),
        EndTime = new DateTime(today.Year - 1, 8, 22, 14, 0, 0),
        TotalPrice = 23,
        Status = ReservationStatus.CANCELLED,
        CancellationReason = "Loše vrijeme"
    },
    new Reservation
    {
        Id = 2059,
        UserId = 11,
        SportsFieldId = 208,
        StartTime = new DateTime(today.Year + 1, 2, 8, 16, 0, 0),
        EndTime = new DateTime(today.Year + 1, 2, 8, 17, 0, 0),
        TotalPrice = 35,
        Status = ReservationStatus.CREATED
    },
    new Reservation
    {
        Id = 2060,
        UserId = 11,
        SportsFieldId = 209,
        StartTime = new DateTime(today.Year, 12, 3, 11, 0, 0),
        EndTime = new DateTime(today.Year, 12, 3, 12, 0, 0),
        TotalPrice = 26,
        Status = ReservationStatus.PAYED
    }
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
            new Review { Id = 1010, UserId = 14, SportsCenterId = 5, Content = "Definitivno ću se ponovo vratiti!", Rating = 5.0m, Created = DateTime.Today },
                new Review
                {
                    Id = 1011,
                    UserId = 15,
                    SportsCenterId = 900,
                    Content = "Vrlo čist i dobro organizovan centar.",
                    Rating = 4.6m,
                    Created = DateTime.Today.AddDays(-9)
                },
    new Review
    {
        Id = 1012,
        UserId = 10,
        SportsCenterId = 901,
        Content = "Sve je bilo odlično, osim parkinga.",
        Rating = 3.9m,
        Created = DateTime.Today.AddDays(-8)
    },
    new Review
    {
        Id = 1013,
        UserId = 11,
        SportsCenterId = 902,
        Content = "Topla preporuka za sve sportiste.",
        Rating = 4.7m,
        Created = DateTime.Today.AddDays(-7)
    },
    new Review
    {
        Id = 1014,
        UserId = 12,
        SportsCenterId = 903,
        Content = "Ljubazno osoblje i dobra oprema.",
        Rating = 4.2m,
        Created = DateTime.Today.AddDays(-6)
    },
    new Review
    {
        Id = 1015,
        UserId = 13,
        SportsCenterId = 904,
        Content = "Sve u svemu, pozitivno iskustvo.",
        Rating = 4.0m,
        Created = DateTime.Today.AddDays(-5)
    },
    new Review
    {
        Id = 1016,
        UserId = 14,
        SportsCenterId = 905,
        Content = "Malo skuplje, ali teren je fantastičan.",
        Rating = 3.8m,
        Created = DateTime.Today.AddDays(-4)
    },
    new Review
    {
        Id = 1017,
        UserId = 14,
        SportsCenterId = 906,
        Content = "Sve preporuke! Odlična organizacija.",
        Rating = 4.9m,
        Created = DateTime.Today.AddDays(-3)
    },
    new Review
    {
        Id = 1018,
        UserId = 14,
        SportsCenterId = 907,
        Content = "Zadovoljan uslugom i ambijentom.",
        Rating = 4.3m,
        Created = DateTime.Today.AddDays(-2)
    },
    new Review
    {
        Id = 1019,
        UserId = 12,
        SportsCenterId = 908,
        Content = "Tereni odlični, ali nema kafića u blizini.",
        Rating = 3.7m,
        Created = DateTime.Today.AddDays(-1)
    },
    new Review
    {
        Id = 1020,
        UserId = 11,
        SportsCenterId = 909,
        Content = "Sjajno iskustvo! Definitivno dolazim opet.",
        Rating = 5.0m,
        Created = DateTime.Today
    }
        );
    
    }

    private void SeedTeams(ModelBuilder modelBuilder)
    {
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
            City = "Mostar",
            TeamPicture = null
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
            City = "Mostar",
            TeamPicture = null
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
            City = "Travnik",
            TeamPicture = null
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
            City = "Travnik",
            TeamPicture = null
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
            City = "Sarajevo",
            TeamPicture = null
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
            City = "Sarajevo",
            TeamPicture = null
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
            City = "Sarajevo",
            TeamPicture = null
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
            City = "Zenica",
            TeamPicture = null
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
            City = "Zenica",
            TeamPicture = null
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
            City = "Tuzla",
            TeamPicture = null
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
            City = "Tuzla",
            TeamPicture = null
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
            City = "Tuzla",
            TeamPicture = null
        },
        new Team
        {
            Id = 1013,
            Name = "Futsal Wolves",
            Description = "Strastveni tim futsal entuzijasta.",
            IsPublic = true,
            CaptainId = 10,
            JoinCode = null,
            Sport = Sport.FUTSAL,
            City = "Mostar",
            TeamPicture = null
        },
        new Team
        {
            Id = 1014,
            Name = "Sand Blazers",
            Description = "Dominacija na pijesku.",
            IsPublic = false,
            CaptainId = 10,
            JoinCode = "JOIN14",
            Sport = Sport.BEACH_VOLLEYBALL,
            City = "Mostar",
            TeamPicture = null
        },
        new Team
        {
            Id = 1015,
            Name = "Airball Masters",
            Description = "Visoko leteći košarkaški tim.",
            IsPublic = true,
            CaptainId = 11,
            JoinCode = null,
            Sport = Sport.BASKETBALL,
            City = "Travnik",
            TeamPicture = null
        },
        new Team
        {
            Id = 1016,
            Name = "Net Aces",
            Description = "Stručnjaci za teniske duele.",
            IsPublic = false,
            CaptainId = 11,
            JoinCode = "JOIN16",
            Sport = Sport.TENNIS,
            City = "Travnik",
            TeamPicture = null
        },
        new Team
        {
            Id = 1017,
            Name = "Volley Kings",
            Description = "Vladari mreže u Sarajevu.",
            IsPublic = true,
            CaptainId = 12,
            JoinCode = null,
            Sport = Sport.VOLLEYBALL,
            City = "Sarajevo",
            TeamPicture = null
        },
        new Team
        {
            Id = 1018,
            Name = "Handball Titans",
            Description = "Nepobjedivi rukometni tim.",
            IsPublic = false,
            CaptainId = 12,
            JoinCode = "JOIN18",
            Sport = Sport.HANDBALL,
            City = "Sarajevo",
            TeamPicture = null
        },
        new Team
        {
            Id = 1019,
            Name = "Futsal Tornado",
            Description = "Brzi napadi i čvrsta odbrana.",
            IsPublic = true,
            CaptainId = 13,
            JoinCode = null,
            Sport = Sport.FUTSAL,
            City = "Sarajevo",
            TeamPicture = null
        },
        new Team
        {
            Id = 1020,
            Name = "Basket Blitz",
            Description = "Eksplozivan stil igre pod obručima.",
            IsPublic = false,
            CaptainId = 13,
            JoinCode = "JOIN20",
            Sport = Sport.BASKETBALL,
            City = "Zenica",
            TeamPicture = null
        },
        new Team
        {
            Id = 1021,
            Name = "Sand Kings",
            Description = "Specijalisti za beach volley turnire.",
            IsPublic = true,
            CaptainId = 14,
            JoinCode = null,
            Sport = Sport.BEACH_VOLLEYBALL,
            City = "Zenica",
            TeamPicture = null
        },
        new Team
        {
            Id = 1022,
            Name = "Mini Football Force",
            Description = "Neprekidna akcija na malim terenima.",
            IsPublic = false,
            CaptainId = 14,
            JoinCode = "JOIN22",
            Sport = Sport.MINI_FOOTBALL,
            City = "Tuzla",
            TeamPicture = null
        },
        new Team
        {
            Id = 1023,
            Name = "VolleyStorm",
            Description = "Grmljavina na mreži.",
            IsPublic = true,
            CaptainId = 15,
            JoinCode = null,
            Sport = Sport.VOLLEYBALL,
            City = "Tuzla",
            TeamPicture = null
        },
        new Team
        {
            Id = 1024,
            Name = "Throwmasters",
            Description = "Tim s najoštrijim napadima.",
            IsPublic = false,
            CaptainId = 15,
            JoinCode = "JOIN24",
            Sport = Sport.HANDBALL,
            City = "Tuzla",
            TeamPicture = null
        },
         new Team
         {
             Id = 9000,
             Name = "Team Alfa",
             Description = "Tim s najoštrijim napadima.",
             IsPublic = true,
             CaptainId = 20,
             JoinCode = null,
             Sport = Sport.BEACH_VOLLEYBALL,
             City = "Mostar",
             TeamPicture = null
         },

        new Team
        {
            Id = 9001,
            Name = "Team Beta",
            Description = "Tim s najoštrijim napadima.",
            IsPublic = true,
            CaptainId = 16,
            JoinCode = null,
            Sport = Sport.BASKETBALL,
            City = "Tuzla",
            TeamPicture = null
        },

        new Team
        {
            Id = 9002,
            Name = "Team Gama",
            Description = "Tim s najoštrijim napadima.",
            IsPublic = true,
            CaptainId = 13,
            JoinCode = null,
            Sport = Sport.BASKETBALL,
            City = "Zenica",
            TeamPicture = null
        },

        new Team
        {
            Id = 9003,
            Name = "Team Delta",
            Description = "Tim s najoštrijim napadima.",
            IsPublic = true,
            CaptainId = 11,
            JoinCode = null,
            Sport = Sport.BASKETBALL,
            City = "Tuzla",
            TeamPicture = null
        },

        new Team
        {
            Id = 9004,
            Name = "Team Zeta",
            Description = "Tim s najoštrijim napadima.",
            IsPublic = true,
            CaptainId = 11,
            JoinCode = null,
            Sport = Sport.TENNIS,
            City = "Tuzla",
            TeamPicture = null
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
            new UserTeam { UserId = 19, TeamId = 104, IsCaptain = false },
            new UserTeam { UserId = 10, TeamId = 1013, IsCaptain = true },
            new UserTeam { UserId = 10, TeamId = 1014, IsCaptain = true },
            new UserTeam { UserId = 11, TeamId = 1015, IsCaptain = true },
            new UserTeam { UserId = 11, TeamId = 1016, IsCaptain = true },
            new UserTeam { UserId = 12, TeamId = 1017, IsCaptain = true },
            new UserTeam { UserId = 12, TeamId = 1018, IsCaptain = true },
            new UserTeam { UserId = 13, TeamId = 1019, IsCaptain = true },
            new UserTeam { UserId = 13, TeamId = 1020, IsCaptain = true },
            new UserTeam { UserId = 14, TeamId = 1021, IsCaptain = true },
            new UserTeam { UserId = 14, TeamId = 1022, IsCaptain = true },
            new UserTeam { UserId = 15, TeamId = 1023, IsCaptain = true },
            new UserTeam { UserId = 15, TeamId = 1024, IsCaptain = true },

            new UserTeam { UserId = 11, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 1013, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 1013, IsCaptain = false },

            new UserTeam { UserId = 11, TeamId = 1014, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 1015, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 1016, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 1017, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 1018, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 1019, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 1020, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 1021, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 1022, IsCaptain = false },
            new UserTeam { UserId = 10, TeamId = 1023, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 1024, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 9000, IsCaptain = false },
            new UserTeam { UserId = 20, TeamId = 9000, IsCaptain = true },

            new UserTeam { UserId = 15, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 20, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 9001, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 9001, IsCaptain = true },

            new UserTeam { UserId = 16, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 20, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 15, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 9002, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 9002, IsCaptain = true },

            new UserTeam { UserId = 17, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 19, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 16, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 20, TeamId = 9003, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 9003, IsCaptain = true },

            new UserTeam { UserId = 16, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 14, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 17, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 12, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 20, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 18, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 13, TeamId = 9004, IsCaptain = false },
            new UserTeam { UserId = 11, TeamId = 9004, IsCaptain = true }
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
            new Squad { Id = 1024, Name = "Ofanzivaši", TeamId = 1012 },
              new Squad { Id = 1025, Name = "Crvene Strijele", TeamId = 1013 },
        new Squad { Id = 1026, Name = "Zlatni Orlovi", TeamId = 1013 },

        new Squad { Id = 1027, Name = "Ledeni Tigrovi", TeamId = 1014 },
        new Squad { Id = 1028, Name = "Sivi Vjetrovi", TeamId = 1014 },

        new Squad { Id = 1029, Name = "Plavi Talasi", TeamId = 1015 },
        new Squad { Id = 1030, Name = "Vatreni Klizači", TeamId = 1015 },

        new Squad { Id = 1031, Name = "Sjene Ulice", TeamId = 1016 },
        new Squad { Id = 1032, Name = "Noćni Jahači", TeamId = 1016 },

        new Squad { Id = 1033, Name = "Tihi Ubice", TeamId = 1017 },
        new Squad { Id = 1034, Name = "Brze Strele", TeamId = 1017 },

        new Squad { Id = 1035, Name = "Bijeli Medvjedi", TeamId = 1018 },

        new Squad { Id = 1036, Name = "Leteći Zmajevi", TeamId = 1019 },
        new Squad { Id = 1037, Name = "Plameni Šampioni", TeamId = 1019 },

        new Squad { Id = 1038, Name = "Graditelji Igre", TeamId = 1020 },
        new Squad { Id = 1039, Name = "Zlatni Asovi", TeamId = 1020 },

        new Squad { Id = 1040, Name = "Timski Strijelci", TeamId = 1021 },

        new Squad { Id = 1041, Name = "Munjeviti Servisi", TeamId = 1022 },

        new Squad { Id = 1042, Name = "Lavlje Srce", TeamId = 1023 },
        new Squad { Id = 1043, Name = "Nezaustavljivi", TeamId = 1023 },

        new Squad { Id = 1044, Name = "Taktički Umovi", TeamId = 1024 }
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
        new Match { Id = 16, TeamId = 103, MatchDate = new DateTime(2025, 8, 25, 20, 0, 0), Result = "0:3", Status = MatchStatus.FINISHED },
        new Match { Id = 17, TeamId = 1013, MatchDate = new DateTime(2025, 9, 1, 15, 0, 0), Result = "2:2", Status = MatchStatus.FINISHED },
        new Match { Id = 18, TeamId = 1013, MatchDate = new DateTime(2025, 9, 5, 17, 30, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 19, TeamId = 1014, MatchDate = new DateTime(2025, 9, 7, 18, 0, 0), Result = "1:0", Status = MatchStatus.FINISHED },
        new Match { Id = 20, TeamId = 1014, MatchDate = new DateTime(2025, 9, 10, 19, 15, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 21, TeamId = 1015, MatchDate = new DateTime(2025, 9, 12, 16, 45, 0), Result = "0:0", Status = MatchStatus.FINISHED },
        new Match { Id = 22, TeamId = 1015, MatchDate = new DateTime(2025, 9, 15, 20, 0, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 23, TeamId = 1016, MatchDate = new DateTime(2025, 9, 17, 18, 30, 0), Result = "4:2", Status = MatchStatus.FINISHED },
        new Match { Id = 24, TeamId = 1016, MatchDate = new DateTime(2025, 9, 20, 17, 0, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 25, TeamId = 1017, MatchDate = new DateTime(2025, 9, 22, 19, 30, 0), Result = "3:1", Status = MatchStatus.FINISHED },
        new Match { Id = 26, TeamId = 1017, MatchDate = new DateTime(2025, 9, 25, 20, 0, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 27, TeamId = 1018, MatchDate = new DateTime(2025, 9, 27, 15, 0, 0), Result = "2:4", Status = MatchStatus.FINISHED },
        new Match { Id = 28, TeamId = 1018, MatchDate = new DateTime(2025, 9, 30, 18, 45, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 29, TeamId = 1019, MatchDate = new DateTime(2025, 10, 2, 19, 0, 0), Result = "1:1", Status = MatchStatus.FINISHED },
        new Match { Id = 30, TeamId = 1019, MatchDate = new DateTime(2025, 10, 5, 20, 0, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 31, TeamId = 1020, MatchDate = new DateTime(2025, 10, 7, 17, 15, 0), Result = "0:2", Status = MatchStatus.FINISHED },
        new Match { Id = 32, TeamId = 1020, MatchDate = new DateTime(2025, 10, 10, 18, 30, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 33, TeamId = 1021, MatchDate = new DateTime(2025, 10, 12, 19, 45, 0), Result = "3:0", Status = MatchStatus.FINISHED },
        new Match { Id = 34, TeamId = 1021, MatchDate = new DateTime(2025, 10, 15, 17, 30, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 35, TeamId = 1022, MatchDate = new DateTime(2025, 10, 17, 18, 0, 0), Result = "2:2", Status = MatchStatus.FINISHED },
        new Match { Id = 36, TeamId = 1022, MatchDate = new DateTime(2025, 10, 20, 19, 0, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 37, TeamId = 1023, MatchDate = new DateTime(2025, 10, 22, 20, 15, 0), Result = "5:1", Status = MatchStatus.FINISHED },
        new Match { Id = 38, TeamId = 1023, MatchDate = new DateTime(2025, 10, 25, 20, 45, 0), Result = null, Status = MatchStatus.CREATED },

        new Match { Id = 39, TeamId = 1024, MatchDate = new DateTime(2025, 10, 27, 16, 0, 0), Result = "1:3", Status = MatchStatus.FINISHED },
        new Match { Id = 40, TeamId = 1024, MatchDate = new DateTime(2025, 10, 30, 17, 45, 0), Result = null, Status = MatchStatus.CREATED }
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

    private void SeedUserSports(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserSport>().HasData(
            new UserSport { Id = 1, UserId = 10, Sport = Sport.FOOTBALL },
            new UserSport { Id = 2, UserId = 10, Sport = Sport.BASKETBALL },
            new UserSport { Id = 3, UserId = 10, Sport = Sport.TENNIS },

            new UserSport { Id = 4, UserId = 11, Sport = Sport.VOLLEYBALL },
            new UserSport { Id = 5, UserId = 11, Sport = Sport.FOOTBALL },

            new UserSport { Id = 6, UserId = 12, Sport = Sport.MINI_FOOTBALL },

            new UserSport { Id = 7, UserId = 13, Sport = Sport.HANDBALL },
            new UserSport { Id = 8, UserId = 13, Sport = Sport.BASKETBALL },
            new UserSport { Id = 9, UserId = 13, Sport = Sport.TENNIS },

            new UserSport { Id = 10, UserId = 14, Sport = Sport.FOOTBALL },
            new UserSport { Id = 11, UserId = 14, Sport = Sport.BEACH_VOLLEYBALL },

            new UserSport { Id = 12, UserId = 15, Sport = Sport.BASKETBALL },

            new UserSport { Id = 13, UserId = 16, Sport = Sport.FUTSAL },
            new UserSport { Id = 14, UserId = 16, Sport = Sport.TENNIS },
            new UserSport { Id = 15, UserId = 16, Sport = Sport.HANDBALL },

            new UserSport { Id = 16, UserId = 17, Sport = Sport.FOOTBALL },
            new UserSport { Id = 17, UserId = 17, Sport = Sport.FUTSAL },

            new UserSport { Id = 18, UserId = 18, Sport = Sport.VOLLEYBALL },

            new UserSport { Id = 19, UserId = 19, Sport = Sport.BASKETBALL },
            new UserSport { Id = 20, UserId = 19, Sport = Sport.MINI_FOOTBALL }
        );
    }

    private void SeedMatchAttendances(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MatchAttendance>().HasData(
            new MatchAttendance { MatchId = 2, UserId = 10, IsAttending = true },
            new MatchAttendance { MatchId = 2, UserId = 11, IsAttending = true },

            new MatchAttendance { MatchId = 4, UserId = 10, IsAttending = true },
            new MatchAttendance { MatchId = 4, UserId = 12, IsAttending = true },

            new MatchAttendance { MatchId = 6, UserId = 12, IsAttending = true },
            new MatchAttendance { MatchId = 6, UserId = 13, IsAttending = true },

            new MatchAttendance { MatchId = 8, UserId = 13, IsAttending = true },
            new MatchAttendance { MatchId = 8, UserId = 14, IsAttending = true },

            new MatchAttendance { MatchId = 10, UserId = 14, IsAttending = true },
            new MatchAttendance { MatchId = 10, UserId = 15, IsAttending = true },

            new MatchAttendance { MatchId = 12, UserId = 15, IsAttending = true },
            new MatchAttendance { MatchId = 12, UserId = 11, IsAttending = true },

            new MatchAttendance { MatchId = 14, UserId = 10, IsAttending = true },
            new MatchAttendance { MatchId = 14, UserId = 15, IsAttending = true },

            new MatchAttendance { MatchId = 16, UserId = 12, IsAttending = true },
            new MatchAttendance { MatchId = 16, UserId = 13, IsAttending = true }
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