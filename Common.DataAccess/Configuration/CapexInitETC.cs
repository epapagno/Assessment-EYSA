using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class CapexInitETC : IEntityTypeConfiguration<CapexInit>
    {
        
        public void Configure(EntityTypeBuilder<CapexInit> builder)
        {
            // Generación tabla: CAPEX_INIT
            builder.ToTable("CAPEX_INIT", "REP").HasKey(i => new { i.CapexIdInit });
            builder.Property(i => i.CapexIdInit).HasColumnName("CAPEX_ID_INIT");
            builder.Property(i => i.DateInit).HasColumnName("DATE_INIT");
            builder.Property(i => i.WhUser).HasColumnName("WH_USER");
            builder.Property(i => i.RepStoresId).HasColumnName("REP_STORES_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Acronym).HasColumnName("ACRONYM");
            builder.Property(i => i.TypeOfInvestment).HasColumnName("TYPE_OF_INVESTMENT");
            builder.Property(i => i.CaseNumberRest).HasColumnName("CASE_NUMBER_REST");
            builder.Property(i => i.CaseNumberCapex).HasColumnName("CASE_NUMBER_CAPEX");
            builder.Property(i => i.CaseNumberCapexAct).HasColumnName("CASE_NUMBER_CAPEX_ACT");
            builder.Property(i => i.RegionalUser).HasColumnName("REGIONAL_USER");

            builder.HasMany(i => i.CapexInitDetail)
                  .WithOne(i => i.CapexInit)
                  .HasForeignKey(i => new { i.PaisId, CapexIdInit = i.CapexIdInit })
                  .HasPrincipalKey(i => new { i.PaisId, i.CapexIdInit });

            builder.HasOne(i => i.RepStores)
                  .WithOne(i => i.CapexInit)
                  .HasPrincipalKey<CapexInit>(i => new { i.PaisId, RepStoresId = i.RepStoresId })
                  .HasForeignKey<RepStores>(i => new { i.PaisId, RepStoresId = i.Id });
        }
    }
}
