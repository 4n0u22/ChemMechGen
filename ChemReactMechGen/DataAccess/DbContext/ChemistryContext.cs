using System.Collections.Generic;
using System.Reflection.Emit;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;


public class ChemistryContext : DbContext
{
    public DbSet<Atom> Atoms { get; set; }
    public DbSet<Molecule> Molecules { get; set; }
    public DbSet<Reaction> Reactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }

    protected override void OnModelCreating(ModuleBuilder modelBuilder)
    {
        modelBuilder.Entity<Atom>()
            .Property(a => a.ElectronLevels)
            .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<int, Electron>>(v));
        
        modelBuilder.Entity<Reaction>()
            .Property(r => r.Conditions)
            .HasConversion(
                v => JsonConvert.SerializeObject(v),
                v => JsonConvert.DeserializeObject<Dictionary<string, object>>(v));
    }
}
