using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepStoresRoiETC : IEntityTypeConfiguration<RepStoresRoi>
    {
        public void Configure(EntityTypeBuilder<RepStoresRoi> builder)
        {
            builder.ToTable("REP_STORES_ROI", "REP")
                .HasKey(i => new { i.PaisId, i.RepStoreId });

            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.RepStoreId).HasColumnName("REP_STORE_ID");
            builder.Property(i => i.Investment).HasColumnName("INVESTMENT");
            builder.Property(i => i.ROI).HasColumnName("ROI");
        }
    }
}
