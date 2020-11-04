using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class CharacteristicsMasterETC : IEntityTypeConfiguration<CharacteristicsMaster>
    {
        public void Configure(EntityTypeBuilder<CharacteristicsMaster> builder)
        {
            // Generación tabla: CHARACTERISTICS_MASTER
            builder.ToTable("CHARACTERISTICS_MASTER", "CARAC").HasKey(i => new { i.PaisId, i.CharId });
            builder.Property(i => i.CharId).HasColumnName("CHAR_ID");
            builder.Property(i => i.Description).HasColumnName("DESCRIPTION");
            builder.Property(i => i.ValueId).HasColumnName("VALUE_ID");
            builder.Property(i => i.ListId).HasColumnName("LIST_ID");
            builder.Property(i => i.ListOrder).HasColumnName("LIST_ORDER");
            builder.Property(i => i.CharIdn).HasColumnName("CHAR_IDN");
            builder.Property(i => i.CharTypeId).HasColumnName("CHAR_TYPE_ID");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.PmoCharacteristic).HasColumnName("PMO_CHARACTERISTIC");
            builder.Property(i => i.RoipIdField).HasColumnName("ROIP_ID_FIELD");
            builder.Property(i => i.IntegratedWithMdm).HasColumnName("INTEGRATED_WITH_MDM");
            builder.Property(i => i.CharIdAssociated).HasColumnName("CHAR_ID_ASSOCIATED");
            builder.Property(i => i.CharUsedIn).HasColumnName("CHAR_USED_IN");
            builder.Property(i => i.RequireEffectiveDate).HasColumnName("REQUIRE_EFFECTIVE_DATE");
            builder.Property(i => i.RequireWorkflow).HasColumnName("REQUIRE_WORKFLOW");
            builder.Property(i => i.RequireReport).HasColumnName("REQUIRE_REPORT");

            builder.HasOne(i => i.CharacTypes)
                .WithMany(i => i.CharacMaster)
                .HasForeignKey(i => new { i.PaisId, i.CharTypeId });

            //builder.HasOne(i => i.ListOfValues)
            //    .WithOne(i => i.CharacMaster)
            //    .HasForeignKey<ListOfValues>(i => new { i.PaisId, i.ListId })
            //    .HasPrincipalKey<CharacteristicsMaster>(i => new { i.PaisId, i.ListId });

            //builder.HasMany(i => i.LoVD)
            //   .WithOne(i => i.CharacMaster)
            //   .HasPrincipalKey(i => new { i.PaisId, i.CharId })
            //   .HasForeignKey(i => new { i.PaisId, i.ListId });
        }
    }
}
