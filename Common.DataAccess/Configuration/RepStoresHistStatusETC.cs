using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class RepStoresHistStatusETC : IEntityTypeConfiguration<RepStoresHistStatus>
    {
        public void Configure(EntityTypeBuilder<RepStoresHistStatus> builder)
        {
            // Generación tabla: REP_STORES_HIST_STATUS
            builder.ToTable("REP_STORES_HIST_STATUS", "REP").HasKey(i => new { i.IdStatus });
            builder.Property(i => i.IdStatus).HasColumnName("ID_STATUS");
            builder.Property(i => i.RepId).HasColumnName("REP_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.RepStatusNew).HasColumnName("REP_STATUS_NEW");
            builder.Property(i => i.RepStatusOld).HasColumnName("REP_STATUS_OLD");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");

            builder.HasOne(i => i.RepStores)
                 .WithOne(i => i.RepStoresHistStatus)
                 .HasForeignKey<RepStoresHistStatus>(i => new { i.PaisId, Id = i.RepId })
                 .HasPrincipalKey<RepStores>(i => new { i.PaisId, RepId = i.Id });
        }
    }
}
