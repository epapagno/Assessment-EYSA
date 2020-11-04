using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class SystemParametersETC : IEntityTypeConfiguration<SystemParameters>
    {
        public void Configure(EntityTypeBuilder<SystemParameters> builder)
        {
            // Generación tabla: SYSTEM_PARAMETERS
            builder.ToTable("SYSTEM_PARAMETERS", "WHOUSE").HasKey(i => new { i.PaisId, i.SprId });
            builder.Property(i => i.SprId).HasColumnName("SPR_ID");
            builder.Property(i => i.SprValue).HasColumnName("SPR_VALUE");
            builder.Property(i => i.SprDescription).HasColumnName("SPR_DESCRIPTION");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.SprChanged).HasColumnName("SPR_CHANGED");
            builder.Property(i => i.SprDate).HasColumnName("SPR_DATE");
            builder.Property(i => i.SprUser).HasColumnName("SPR_USER");
            builder.Property(i => i.SprModule).HasColumnName("SPR_MODULE");
            builder.Property(i => i.SprPosibleValue).HasColumnName("SPR_POSIBLE_VALUE");
            builder.Property(i => i.SprRequirement).HasColumnName("SPR_REQUIREMENT");
            builder.Property(i => i.SprNotes).HasColumnName("SPR_NOTES");
        }
    }
}
