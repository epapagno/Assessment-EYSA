using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public partial class FlexfieldRepSectorAccountETC : IEntityTypeConfiguration<FlexfieldRepSectorAccount>
    {
        public void Configure(EntityTypeBuilder<FlexfieldRepSectorAccount> builder)
        {
            // Generación tabla: FLEXFIELD_REP_SECTOR_ACCOUNT
            builder.ToTable("FLEXFIELD_REP_SECTOR_ACCOUNT", "REP").HasKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector, i.Account, i.Subaccount });
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.TypeOfInvestment).HasColumnName("TYPE_OF_INVESTMENT");
            builder.Property(i => i.Sector).HasColumnName("SECTOR");
            builder.Property(i => i.Account).HasColumnName("ACCOUNT");
            builder.Property(i => i.Subaccount).HasColumnName("SUBACCOUNT");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");

            //builder.HasOne(i => i.FfSector)
            //    .WithMany()
            //    .HasPrincipalKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector })
            //    .HasForeignKey(i => new { i.PaisId, i.TypeOfInvestment, i.Sector });
        }

    }
}
