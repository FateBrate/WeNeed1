﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeNeed1.Service.Database;

#nullable disable

namespace WeNeed1.Service.Migrations
{
    [DbContext(typeof(WeNeed1Context))]
    [Migration("20241104230939_newmig")]
    partial class newmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SquadUser", b =>
                {
                    b.Property<int>("SquadsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("SquadsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("SquadUser");
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
                        .HasColumnType("datetime2");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("datetime2");

                    b.Property<int>("SportsFieldId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SportsCenterId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SportsCenters");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SportType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SportsCenterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Squads");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CaptainId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("JoinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sport")
                        .HasColumnType("int");

                    b.HasKey("Id");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.UserTeam", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCaptain")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("UserTeams");
                });

            modelBuilder.Entity("SquadUser", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Squad", null)
                        .WithMany()
                        .HasForeignKey("SquadsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeNeed1.Service.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Comment", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Match", "Match")
                        .WithMany("Comments")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeNeed1.Service.Database.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Match", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Team", "Team")
                        .WithMany("Matches")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Reservation", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsField", "SportsField")
                        .WithMany("Reservations")
                        .HasForeignKey("SportsFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeNeed1.Service.Database.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SportsField");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Review", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsCenter", "SportsCenter")
                        .WithMany("Reviews")
                        .HasForeignKey("SportsCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SportsCenter");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.SportsField", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.SportsCenter", "SportsCenter")
                        .WithMany("SportsFields")
                        .HasForeignKey("SportsCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SportsCenter");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Squad", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Team", "Team")
                        .WithMany("Squads")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.Team", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.User", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Captain");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.UserTeam", b =>
                {
                    b.HasOne("WeNeed1.Service.Database.Team", "Team")
                        .WithMany("UserTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeNeed1.Service.Database.User", "User")
                        .WithMany("UserTeams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
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

                    b.Navigation("UserTeams");
                });

            modelBuilder.Entity("WeNeed1.Service.Database.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reservations");

                    b.Navigation("UserTeams");
                });
#pragma warning restore 612, 618
        }
    }
}