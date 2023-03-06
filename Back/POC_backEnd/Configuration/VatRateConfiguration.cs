using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POC_backEnd.Models;

namespace POC_backEnd.Configuration
{
    public class VatRateConfiguration : IEntityTypeConfiguration<VatRate>
    {
        public void Configure(EntityTypeBuilder<VatRate> builder)
        {
            builder.HasKey(e => e.VatRateId)
                .HasName("PK_VatRates");

            builder.ToTable("vatrates");

            builder.Property(e => e.VatRateId).HasColumnName("VatRateId");

            builder.Property(e => e.CountryId).HasColumnName("CountryId");

            builder.Property(e => e.VatNumber)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("VatNumber");

            builder.HasOne(d => d.Country)
                .WithMany(p => p.VatRates)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_vatRates_country");

            builder.HasData
           (
            #region France
               new VatRate
               {
                   VatRateId = 1,
                   VatNumber = 5.5M,
                   CountryId = 1
               },
               new VatRate
               {
                   VatRateId = 2,
                   VatNumber = 20,
                   CountryId = 1
               },
               new VatRate
               {
                   VatRateId = 3,
                   VatNumber = 10,
                   CountryId = 1
               },
            #endregion
            #region United Kingdom
               new VatRate
               {
                   VatRateId = 4,
                   VatNumber = 5,
                   CountryId = 2
               },
               new VatRate
               {
                   VatRateId = 5,
                   VatNumber = 20,
                   CountryId = 2
               },
            #endregion
            #region Portugal
               new VatRate
               {
                   VatRateId = 6,
                   VatNumber = 6,
                   CountryId = 3
               },
               new VatRate
               {
                   VatRateId = 7,
                   VatNumber = 13,
                   CountryId = 3
               },
               new VatRate
               {
                   VatRateId = 8,
                   VatNumber = 23,
                   CountryId = 3
               },
            #endregion
            #region Spain
               new VatRate
               {
                   VatRateId = 9,
                   VatNumber = 21,
                   CountryId = 4
               },
               new VatRate
               {
                   VatRateId = 10,
                   VatNumber = 10,
                   CountryId = 4
               }
               #endregion
           );
        }

    }
}
