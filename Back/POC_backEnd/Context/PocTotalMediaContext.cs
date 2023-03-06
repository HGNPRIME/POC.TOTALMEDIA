using Microsoft.EntityFrameworkCore;
using POC_backEnd.Configuration;
using POC_backEnd.Models;
using System;

namespace POC_backEnd.Context;

public partial class PocTotalMediaContext : DbContext
{
    public PocTotalMediaContext(DbContextOptions<PocTotalMediaContext> options) : base(options)
    { }


    public DbSet<Country>? country { get; set; }
    public DbSet<VatRate>? vatrates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2RG7UMG;Initial Catalog=PocTotalMedia;Integrated Security=True");
        }

        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new VatRateConfiguration());
    }
}
