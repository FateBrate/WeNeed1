﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeNeed1.Service.Database;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    [DbContext(typeof(WeNeed1Context))]
    partial class WeNeed1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SquadUser", b =>
                {
                    b.Property<int>("SquadId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SquadId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("SquadUsers", (string)null);
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("MatchID");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Comments__3214EC0781169ADA");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Result")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Matches__3214EC07A0BF814F");

                    b.HasIndex("TeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("SportsFieldId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Reservat__3214EC075648B6F5");

                    b.HasIndex("SportsFieldId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(3, 2)");

                    b.Property<int>("SportsCenterId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Reviews__3214EC07061DC872");

                    b.HasIndex("SportsCenterId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__SportsCe__3214EC07013DD25E");

                    b.ToTable("SportsCenters");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("SportType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SportsCenterId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__SportsFi__3214EC075F36B8EE");

                    b.HasIndex("SportsCenterId");

                    b.ToTable("SportsFields");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Squad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Squads__3214EC07FB0D7813");

                    b.HasIndex("TeamId");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CaptainId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("JoinCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Teams__3214EC07E10714D6");

                    b.HasIndex("CaptainId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("Role")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Users__3214EC075274D685");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SquadUser", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Squad", null)
                        .WithMany()
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SquadUsers_Squads");

                    b.HasOne("WeNeed1.Service.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SquadUsers_Users");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Comment", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Match", "Match")
                        .WithMany("Comments")
                        .HasForeignKey("MatchId")
                        .IsRequired()
                        .HasConstraintName("FK__Comments__MatchI__2D27B809");

                    b.HasOne("WeNeed1.Service.Database.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Comments__UserId__2C3393D0");

                    b.Navigation("Match");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Match", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Team", "Team")
                        .WithMany("Matches")
                        .HasForeignKey("TeamId")
                        .IsRequired()
                        .HasConstraintName("FK__Matches__TeamId__29572725");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Reservation", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsField", "SportsField")
                        .WithMany("Reservations")
                        .HasForeignKey("SportsFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Reservations_SportsFields");

                    b.HasOne("WeNeed1.Service.Database.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Reservations_Users");

                    b.Navigation("SportsField");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Review", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsCenter", "SportsCenter")
                        .WithMany("Reviews")
                        .HasForeignKey("SportsCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Reviews_SportsCenters");

                    b.Navigation("SportsCenter");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsField", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsCenter", "SportsCenter")
                        .WithMany("SportsFields")
                        .HasForeignKey("SportsCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SportsFields_SportsCenters");

                    b.Navigation("SportsCenter");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Squad", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Team", "Team")
                        .WithMany("Squads")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Squads_Teams");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Team", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.User", "Captain")
                        .WithMany("Teams")
                        .HasForeignKey("CaptainId")
                        .IsRequired()
                        .HasConstraintName("FK__Teams__CaptainId__267ABA7A");

                    b.Navigation("Captain");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Match", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsCenter", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("SportsFields");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsField", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Team", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("Squads");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reservations");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
