using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using theaterlaak.Models;

namespace theaterlaak.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }

    public DbSet<Boeking> Boekingen { get; set; } = default!;
    public DbSet<Donatie> Donaties { get; set; } = default!;
    public DbSet<Gelegenheid> Gelegenheden { get; set; } = default!;
    public DbSet<Groep> Groepen { get; set; } = default!;
    // public DbSet<Klant> Klanten { get; set; } = default!;
    public DbSet<Ticket> Tickets { get; set; } = default!;
    public DbSet<Voorstelling> Voorstellingen { get; set; } = default!;
    public DbSet<Zaal> Zalen { get; set; } = default!;
    public DbSet<Zitplaats> Zitplaatsen { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // modelBuilder.Entity<Post>()
        //     .HasOne(p => p.Blog)
        //     .WithMany(b => b.Posts);
        modelBuilder.Entity<Boeking>()
            .HasOne(b => b.zaal)
            .WithMany(z => z.Boekingen);

        modelBuilder.Entity<Gelegenheid>()
            .HasOne(g => g.zaal)
            .WithMany(z => z.Gelegenheden);

        modelBuilder.Entity<Gelegenheid>()
            .HasOne(g => g.voorstelling)
            .WithMany(v => v.Gelegenheden);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.voorstelling)
            .WithMany(v => v.Tickets);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.zitplaats)
            .WithMany(z => z.Tickets);

        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.zaal)
            .WithMany(z => z.Tickets);

        modelBuilder.Entity<Zitplaats>()
            .HasOne(z => z.zaal)
            .WithMany(za => za.Zitplaatsen);
    }
}

