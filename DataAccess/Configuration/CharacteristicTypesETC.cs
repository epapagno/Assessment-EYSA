using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class CharacteristicTypesETC : IEntityTypeConfiguration<CharacteristicTypes>
    {
        public void Configure(EntityTypeBuilder<CharacteristicTypes> builder)
        {
            // Generación tabla: CHARACTERISTIC_TYPES
            builder.ToTable("CHARACTERISTIC_TYPES", "CARAC").HasKey(i => new { i.PaisId, i.CharTypeId });
            builder.Property(i => i.CharTypeId).HasColumnName("CHAR_TYPE_ID");
            builder.Property(i => i.Description).HasColumnName("DESCRIPTION");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Roip).HasColumnName("ROIP");
            builder.Property(i => i.Workflow).HasColumnName("WORKFLOW");
            builder.Property(i => i.GroupLevel1).HasColumnName("GROUP_LEVEL_1");
            builder.Property(i => i.GroupLevel2).HasColumnName("GROUP_LEVEL_2");
            builder.Property(i => i.NestOtherType).HasColumnName("NEST_OTHER_TYPE");

            builder.HasMany(i => i.CharacMaster)
                .WithOne(i => i.CharacTypes)
                .HasForeignKey(i => new { i.PaisId, i.CharTypeId });
        }
    }
}
