using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class LovdCharacteristicMasterMapETC : IEntityTypeConfiguration<LovdCharacteristicMasterMap>
    {
        public void Configure(EntityTypeBuilder<LovdCharacteristicMasterMap> builder)
        {
            
            builder.ToTable("LOVD_CHARACTERISTIC_MASTER_MAP", "CARAC")
                .HasKey(i => new { i.PaisId, i.ValueListId, i.CharId });

            builder.Property(i => i.ListId).HasColumnName("LIST_ID");
            builder.Property(i => i.CharId).HasColumnName("CHAR_ID");
            builder.Property(i => i.ValueListId).HasColumnName("VALUE_LIST_ID");
            builder.Property(i => i.Description).HasColumnName("DESCRIPTION");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.PmoValueId).HasColumnName("PMO_VALUE_ID");
            builder.Property(i => i.PmoCharValueId).HasColumnName("PMO_CHAR_VALUE_ID");
            builder.Property(i => i.DescriptionRoip).HasColumnName("DESCRIPTION_ROIP");
            builder.Property(i => i.ListOrder).HasColumnName("LIST_ORDER");
            builder.Property(i => i.DescriptionShort).HasColumnName("DESCRIPTION_SHORT");
            builder.Property(i => i.ListIdFather).HasColumnName("LIST_ID_FATHER");
            builder.Property(i => i.ValueListIdFather).HasColumnName("VALUE_LIST_ID_FATHER");
            builder.Property(i => i.IsActive).HasColumnName("ACTIVE")
                .HasConversion(i => i ? "Y" : "N", i => i == "Y");
            builder.Property(i => i.PmoRelation).HasColumnName("PMO_RELATION");

            builder.HasOne(i => i.CharacteristicsMaster)
               .WithMany(i => i.LovdCharacteristicMasterMap)
               .HasForeignKey(i => new { i.PaisId, i.ListId });

            builder.HasDiscriminator(i => i.CharId)
                    .HasValue<ProvinceStates>((int)CharacteristicsMaster.UsedCharacteristicsMasterIDs.ProvinceState);

            builder.HasDiscriminator(i => i.CharId)
                    .HasValue<TypeOfDcs>((int)CharacteristicsMaster.UsedCharacteristicsMasterIDs.TypeOfDc);

            builder.HasDiscriminator(i => i.CharId)
                    .HasValue<TypeOfMccs>((int)CharacteristicsMaster.UsedCharacteristicsMasterIDs.TypeOfMcc);

        }
    }
}
