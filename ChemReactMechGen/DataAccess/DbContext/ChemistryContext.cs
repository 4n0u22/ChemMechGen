using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;

public class ChemistryContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Atom> Atoms { get; set; }
    public DbSet<Molecule> Molecules { get; set; }
    public DbSet<Reaction> Reactions { get; set; }

    public ChemistryContext(DbContextOptions<ChemistryContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration["SqlServerConnection"]);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var jsonOptions = new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.Preserve };

        modelBuilder.Entity<Atom>()
            .Property(a => a.ElectronLevels)
            .HasConversion(
                v => JsonSerializer.Serialize(v, jsonOptions),
                v => JsonSerializer.Deserialize<Dictionary<byte, Electron>>(v, jsonOptions) ?? new Dictionary<byte, Electron>());

        modelBuilder.Entity<Reaction>()
            .Property(r => r.Conditions)
            .HasConversion(
                v => JsonSerializer.Serialize(v, jsonOptions),
                v => JsonSerializer.Deserialize<Dictionary<string, object>>(v, jsonOptions) ?? new Dictionary<string, object>());

        modelBuilder.Entity<Molecule>()
            .HasIndex(m => m.Name)
            .IsUnique();
    }
}