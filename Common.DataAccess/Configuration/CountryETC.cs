using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class CountryETC : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("WH2_COUNTRIES", "CARAC").HasKey(i => new { i.PaisId });
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Nombre).HasColumnName("NOMBRE");
            builder.Property(i => i.Abr2).HasColumnName("ABR_2");
            builder.Property(i => i.Abr3).HasColumnName("ABR_3");
            builder.Property(i => i.Implementado).HasColumnName("IMPLEMENTADO")
                .HasConversion(i => i ? "S" : "N", i => i == "S" || i == "Y");
            builder.Property(i => i.PostImp).HasColumnName("POST_IMP")
                .HasConversion(i => i ? "S" : "N", i => i == "S" || i == "Y");
            builder.Property(i => i.PaisIsoId).HasColumnName("ID_PAIS_ISO");
            builder.Property(i => i.CodeNumberId).HasColumnName("ID_CODE_NUMBER");
            builder.Property(i => i.CurrencyIsoId).HasColumnName("ID_CURRENCY_ISO");
            builder.Property(i => i.GeoDivisionId).HasColumnName("GEO_DIVISION_ID");
            builder.Property(i => i.Orden).HasColumnName("ORDEN");
        }
    }
}
