using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public partial class FlexfieldRepSectorETC : IEntityTypeConfiguration<FlexfieldRepSector>
    {
        public void Configure(EntityTypeBuilder<FlexfieldRepSector> builder)
        {
            // Generación tabla: FLEXFIELD_REP_SECTOR
            builder.ToTable("FLEXFIELD_REP_SECTOR", "REP").HasKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector });
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.TypeOfInvestment).HasColumnName("TYPE_OF_INVESTMENT");
            builder.Property(i => i.Sector).HasColumnName("SECTOR");
            builder.Property(i => i.SubCatId).HasColumnName("SUB_CAT_ID");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");

            //builder.HasMany(i => i.FfSectorAccount)
            //    .WithOne()
            //    .HasPrincipalKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector })
            //    .HasForeignKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector });
        }

    }
}
