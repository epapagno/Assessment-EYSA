using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class LogProcessTibcoRepETC : IEntityTypeConfiguration<LogProcessTibcoRep>
    {
        public void Configure(EntityTypeBuilder<LogProcessTibcoRep> builder)
        {
            // Generación tabla: LOG_PROCESS_TIBCO_REP
            builder.ToTable("LOG_PROCESS_TIBCO_REP", "REP").HasKey(i => new { i.ProcessNumber });
            builder.Property(i => i.ProcessNumber).HasColumnName("PROCESS_NUMBER");
            builder.Property(i => i.ProcessStatus).HasColumnName("PROCESS_STATUS");
            builder.Property(i => i.Acronym).HasColumnName("ACRONYM");
            builder.Property(i => i.IdRep).HasColumnName("ID_REP");
            builder.Property(i => i.ErrorId).HasColumnName("ERROR_ID");
            builder.Property(i => i.Interfaz).HasColumnName("INTERFAZ");
            builder.Property(i => i.InstanceId).HasColumnName("INSTANCE_ID");
            builder.Property(i => i.Observaciones).HasColumnName("OBSERVACIONES");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreatedDate).HasColumnName("CREATED_DATE");
            builder.Property(i => i.CaseNumberCapexAct).HasColumnName("CASE_NUMBER_CAPEX_ACT");
        }
    }
}
