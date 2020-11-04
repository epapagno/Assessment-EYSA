using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class ProcesosTibcoWhETC : IEntityTypeConfiguration<ProcesosTibcoWh>
    {

        public void Configure(EntityTypeBuilder<ProcesosTibcoWh> builder)
        {
            // Generación tabla: PROCESOS_TIBCO_WH
            builder.ToTable("PROCESOS_TIBCO_WH", "WHOUSE").HasKey(i => new { i.PaisId, i.IdProcesoTibco });
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.IdProcesoTibco).HasColumnName("ID_PROCESO_TIBCO");
            builder.Property(i => i.Integrado).HasColumnName("INTEGRADO")
                .HasConversion(i => i ? "S" : "N", i => i == "Y" || i == "S");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreatedDate).HasColumnName("CREATED_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
        }
    }
}
