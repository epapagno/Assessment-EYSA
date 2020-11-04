using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepStoresDatesAuditETC : IEntityTypeConfiguration<RepStoresDatesAudit>
    {
        public void Configure(EntityTypeBuilder<RepStoresDatesAudit> builder)
        {
            // Generación tabla: REP_STORES_DATES_AUDIT
            builder.ToTable("REP_STORES_DATES_AUDIT", "REP").HasKey(i => new { i.AuditId });
            builder.Property(i => i.AuditId).HasColumnName("AUDIT_ID");
            builder.Property(i => i.Id).HasColumnName("ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.ApprovedDateOld).HasColumnName("APPROVED_DATE_OLD");
            builder.Property(i => i.ApprovedDateNew).HasColumnName("APPROVED_DATE_NEW");
            builder.Property(i => i.SigningDateOld).HasColumnName("SIGNING_DATE_OLD");
            builder.Property(i => i.SigningDateNew).HasColumnName("SIGNING_DATE_NEW");
            builder.Property(i => i.GroundBreakDateOld).HasColumnName("GROUND_BREAK_DATE_OLD");
            builder.Property(i => i.GroundBreakDateNew).HasColumnName("GROUND_BREAK_DATE_NEW");
            builder.Property(i => i.OpeningApprovedDateOld).HasColumnName("OPENING_APPROVED_DATE_OLD");
            builder.Property(i => i.OpeningApprovedDateNew).HasColumnName("OPENING_APPROVED_DATE_NEW");
            builder.Property(i => i.OpeningActualDateOld).HasColumnName("OPENING_ACTUAL_DATE_OLD");
            builder.Property(i => i.OpeningActualDateNew).HasColumnName("OPENING_ACTUAL_DATE_NEW");
            builder.Property(i => i.CompletedApprovedDateOld).HasColumnName("COMPLETED_APPROVED_DATE_OLD");
            builder.Property(i => i.CompletedApprovedDateNew).HasColumnName("COMPLETED_APPROVED_DATE_NEW");
            builder.Property(i => i.CompletedActualDateOld).HasColumnName("COMPLETED_ACTUAL_DATE_OLD");
            builder.Property(i => i.CompletedActualDateNew).HasColumnName("COMPLETED_ACTUAL_DATE_NEW");
            builder.Property(i => i.ChangeOwnerDateOld).HasColumnName("CHANGE_OWNER_DATE_OLD");
            builder.Property(i => i.ChangeOwnerDateNew).HasColumnName("CHANGE_OWNER_DATE_NEW");
            builder.Property(i => i.ClosingDateOld).HasColumnName("CLOSING_DATE_OLD");
            builder.Property(i => i.ClosingDateNew).HasColumnName("CLOSING_DATE_NEW");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.RepEstado).HasColumnName("REP_ESTADO");
        }
    }
}
