using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class RepImpactProjectionsETC : IEntityTypeConfiguration<RepImpactProjections>
    {
        public void Configure(EntityTypeBuilder<RepImpactProjections> builder)
        {
            // Generación tabla: REP_IMPACT_PROJECTIONS
            builder.ToTable("REP_IMPACT_PROJECTIONS", "REP").HasKey(i => new { i.IdImpactProj });
            builder.Property(i => i.IdImpactProj).HasColumnName("ID_IMPACT_PROJ");
            builder.Property(i => i.RepId).HasColumnName("REP_ID");
            builder.Property(i => i.ImpactedMcd).HasColumnName("IMPACTED_MCD");
            builder.Property(i => i.McdName).HasColumnName("MCD_NAME");
            builder.Property(i => i.RepIdImpact).HasColumnName("REP_ID_IMPACT");
            builder.Property(i => i.StoreId).HasColumnName("STORE_ID");
            builder.Property(i => i.GcsImpact).HasColumnName("GCS_IMPACT");
            builder.Property(i => i.SalesImpact).HasColumnName("SALES_IMPACT");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.UpdatedDate).HasColumnName("UPDATED_DATE");
            builder.Property(i => i.UpdatedBy).HasColumnName("UPDATED_BY");
        }
    }
}
