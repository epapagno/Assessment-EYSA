using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class UsedCharacteristicsETC : IEntityTypeConfiguration<UsedCharacteristics>
    {
        public void Configure(EntityTypeBuilder<UsedCharacteristics> builder)
        {
            builder.ToTable("USED_CHARACTERISTICS", "CARAC")
                .HasKey(i => new { i.PaisId, i.UsedCharId });

            builder.Property(i => i.CharId).HasColumnName("CHAR_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.UsedCharId).HasColumnName("USED_CHAR_ID");
            builder.Property(i => i.Modulo).HasColumnName("MODULO");
            builder.Property(i => i.Funcionalidad).HasColumnName("FUNCIONALIDAD");
            builder.Property(i => i.Dato).HasColumnName("DATO");
        }
    }
}
