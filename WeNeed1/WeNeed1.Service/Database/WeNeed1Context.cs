using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WeNeed1.Service.Database;

public partial class WeNeed1Context : DbContext
{
    public WeNeed1Context()
    {
    }

    public WeNeed1Context(DbContextOptions<WeNeed1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Match> Matches { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<SportsCenter> SportsCenters { get; set; }

    public virtual DbSet<SportsField> SportsFields { get; set; }

    public virtual DbSet<Squad> Squads { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost;Database=WeNeed1;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comments__3214EC0781169ADA");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.MatchId).HasColumnName("MatchID");

            entity.HasOne(d => d.Match).WithMany(p => p.Comments)
                .HasForeignKey(d => d.MatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comments__MatchI__2D27B809");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comments__UserId__2C3393D0");
        });

        modelBuilder.Entity<Match>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Matches__3214EC07A0BF814F");

            entity.Property(e => e.MatchDate).HasColumnType("datetime");
            entity.Property(e => e.Result).HasMaxLength(50);

            entity.HasOne(d => d.Team).WithMany(p => p.Matches)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Matches__TeamId__29572725");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservat__3214EC075648B6F5");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.SportsField).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.SportsFieldId)
                .HasConstraintName("FK_Reservations_SportsFields");

            entity.HasOne(d => d.User).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reservations_Users");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reviews__3214EC07061DC872");

            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 2)");

            entity.HasOne(d => d.SportsCenter).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.SportsCenterId)
                .HasConstraintName("FK_Reviews_SportsCenters");
        });

        modelBuilder.Entity<SportsCenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SportsCe__3214EC07013DD25E");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<SportsField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SportsFi__3214EC075F36B8EE");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PricePerHour).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SportType).HasMaxLength(50);

            entity.HasOne(d => d.SportsCenter).WithMany(p => p.SportsFields)
                .HasForeignKey(d => d.SportsCenterId)
                .HasConstraintName("FK_SportsFields_SportsCenters");
        });

        modelBuilder.Entity<Squad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Squads__3214EC07FB0D7813");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Team).WithMany(p => p.Squads)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_Squads_Teams");

            entity.HasMany(d => d.Users).WithMany(p => p.Squads)
                .UsingEntity<Dictionary<string, object>>(
                    "SquadUser",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_SquadUsers_Users"),
                    l => l.HasOne<Squad>().WithMany()
                        .HasForeignKey("SquadId")
                        .HasConstraintName("FK_SquadUsers_Squads"),
                    j =>
                    {
                        j.HasKey("SquadId", "UserId");
                        j.ToTable("SquadUsers");
                    });
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teams__3214EC07E10714D6");

            entity.Property(e => e.JoinCode).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Captain).WithMany(p => p.Teams)
                .HasForeignKey(d => d.CaptainId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Teams__CaptainId__267ABA7A");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC075274D685");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PasswordHash).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(256);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
