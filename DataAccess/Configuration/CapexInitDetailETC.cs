using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class CapexInitDetailETC : IEntityTypeConfiguration<CapexInitDetail>
    {
        public void Configure(EntityTypeBuilder<CapexInitDetail> builder)
        {
            // Generación tabla: CAPEX_INIT_DETAIL
            builder.ToTable("CAPEX_INIT_DETAIL", "REP").HasKey(i => new { i.CapexIdInit, i.RepStoresId });
            builder.Property(i => i.CapexIdInit).HasColumnName("CAPEX_ID_INIT");
            builder.Property(i => i.RepStoresId).HasColumnName("REP_STORES_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");

            builder.HasOne(i => i.CapexInit)
                  .WithMany(i => i.CapexInitDetail)
                  .HasForeignKey(i => new { i.PaisId, Id = i.CapexIdInit })
                  .HasPrincipalKey(i => new { i.PaisId, i.CapexIdInit });
        }
    }
}
