using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepStoresRelatedETC : IEntityTypeConfiguration<RepStoresRelated>
    {
        public void Configure(EntityTypeBuilder<RepStoresRelated> builder)
        {
            // Generación tabla: REP_STORES_RELATED
            builder.ToTable("REP_STORES_RELATED", "REP").HasKey(i => new { i.RepId, i.ParRepId, i.PaisId });
            builder.Property(i => i.RepId).HasColumnName("REP_ID");
            builder.Property(i => i.ParRepId).HasColumnName("PAR_REP_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");

            builder.HasOne(i => i.ParRepStores)
                  .WithMany(i => i.ParRepStoresRelated)
                  .HasForeignKey(i => new { i.PaisId, ParRepId = i.ParRepId })
                  .HasPrincipalKey(i => new { i.PaisId, ParRepId = i.Id });

            builder.HasOne(i => i.RepStores)
                .WithMany(i => i.RepStoresRelated)
                .HasForeignKey(i => new { i.PaisId, RepId = i.RepId })
                .HasPrincipalKey(i => new { i.PaisId, RepId = i.Id });
        }
    }
}
