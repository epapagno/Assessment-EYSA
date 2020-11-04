using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class StoreCharacteristicsETC : IEntityTypeConfiguration<StoreCharacteristics>
    {
        public void Configure(EntityTypeBuilder<StoreCharacteristics> builder)
        {
            // Generación tabla: STORE_CHARACTERISTICS
            builder.ToTable("STORE_CHARACTERISTICS", "CARAC").HasKey(i => new { i.PaisId, i.StoreId, i.CharId });
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.CharId).HasColumnName("CHAR_ID");
            builder.Property(i => i.Value).HasColumnName("VALUE");
            builder.Property(i => i.ValueListId).HasColumnName("VALUE_LIST_ID");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.DateFrom).HasColumnName("DATE_FROM");
            builder.Property(i => i.ValueWorkflow).HasColumnName("VALUE_WORKFLOW");
            builder.Property(i => i.ValueListIdWorkflow).HasColumnName("VALUE_LIST_ID_WORKFLOW");
            builder.Property(i => i.DateFromWorkflow).HasColumnName("DATE_FROM_WORKFLOW");
            builder.Property(i => i.StartWorkflow).HasColumnName("START_WORKFLOW");

            builder.HasOne(i => i.CharacteristicsMaster)
               .WithMany(i => i.StoreCharacteristics)
               .HasPrincipalKey(i=> new { i.PaisId, i.CharId })
               .HasForeignKey(i => new { i.PaisId, i.CharId });
        }
    }
}
