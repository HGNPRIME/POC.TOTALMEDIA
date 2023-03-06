using Microsoft.EntityFrameworkCore;
using POC_backEnd.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace POC_backEnd.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            
            builder.ToTable("country");

            builder.Property(e => e.CountryId).HasColumnName("CountryId");

            builder.Property(e => e.CountryName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CountryName");
            builder.HasData
           (
               new Country
               {
                   CountryId = 1,
                   CountryName = "France"
                   
               },
               new Country
               {
                   CountryId = 2,
                   CountryName = "United Kingdom"

               },
               new Country
               {
                   CountryId = 3,
                   CountryName = "Portugal"

               },
               new Country
               {
                   CountryId = 4,
                   CountryName = "Spain"

               }
           );
        }
    }
}
