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
    
    public virtual DbSet<UserTeam> UserTeams { get; set; }

    public virtual DbSet<UserSquad> UsersSquad { get; set; }

    public virtual DbSet<MatchAttendance> MatchAttendances { get; set; }

    public virtual DbSet<UserSport> UserSports { get; set; }

    public virtual DbSet<SportsCenterRecommendation> SportsCenterRecommendations { get; set; }

    public virtual DbSet<SportsTeamRecommendation> SportsTeamRecommendations { get; set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=localhost;Database=WeNeed1;Trusted_Connection=True;TrustServerCertificate=True");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserTeam>()
            .HasKey(ut => new { ut.UserId, ut.TeamId });

        modelBuilder.Entity<UserTeam>()
            .HasOne(ut => ut.User)
            .WithMany(u => u.UserTeams)
            .HasForeignKey(ut => ut.UserId);

        modelBuilder.Entity<UserTeam>()
            .HasOne(ut => ut.Team)
            .WithMany(t => t.UserTeams)
            .HasForeignKey(ut => ut.TeamId);

        modelBuilder.Entity<Team>()
               .HasOne(t => t.Captain)
               .WithMany()
               .HasForeignKey(t => t.CaptainId)
               .OnDelete(DeleteBehavior.NoAction);

        // Define composite key for UserSquad
        modelBuilder.Entity<UserSquad>()
            .HasKey(us => new { us.UserId, us.SquadId });

        // Relationships
        modelBuilder.Entity<UserSquad>()
            .HasOne(us => us.User)
            .WithMany()
            .HasForeignKey(us => us.UserId);

        modelBuilder.Entity<UserSquad>()
            .HasOne(us => us.Squad)
            .WithMany(s => s.UserSquads)
            .HasForeignKey(us => us.SquadId);

        modelBuilder.Entity<MatchAttendance>()
    .HasKey(ma => new { ma.MatchId, ma.UserId });

        modelBuilder.Entity<MatchAttendance>()
            .HasOne(ma => ma.Match)
            .WithMany(m => m.MatchAttendances)
            .HasForeignKey(ma => ma.MatchId);

        modelBuilder.Entity<MatchAttendance>()
            .HasOne(ma => ma.User)
            .WithMany()
            .HasForeignKey(ma => ma.UserId);

        modelBuilder.Entity<UserSport>()
            .HasKey(us => us.Id);

        modelBuilder.Entity<UserSport>()
            .HasOne(us => us.User)
            .WithMany(u => u.UserSports)
            .HasForeignKey(us => us.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SportsCenterRecommendation>(entity =>
        {
            entity.HasOne(d => d.BaseSportsCenter)
                .WithMany(p => p.BaseRecommendations)
                .HasForeignKey(d => d.BaseSportsCenterId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.RecommendedSportsCenter)
                .WithMany(p => p.RecommendedBy)
                .HasForeignKey(d => d.RecommendedSportsCenterId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<SportsTeamRecommendation>(entity =>
        {
            entity.HasOne(d => d.BaseTeam)
                .WithMany(t => t.BaseRecommendations)
                .HasForeignKey(d => d.BaseTeamId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.RecommendedTeam)
                .WithMany(t => t.RecommendedBy)
                .HasForeignKey(d => d.RecommendedTeamId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        SeedUsers(modelBuilder);
        SeedSportCenters(modelBuilder);
        SeedSportFields(modelBuilder);
        SeedReservations(modelBuilder);
        SeedReviews(modelBuilder);
        SeedTeams(modelBuilder);
        SeedUserTeams(modelBuilder);
        SeedSquads(modelBuilder);
        SeedUserSquads(modelBuilder);
        SeedMatches(modelBuilder);
        SeedComments(modelBuilder);
        SeedUserSports(modelBuilder);
    }       
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
