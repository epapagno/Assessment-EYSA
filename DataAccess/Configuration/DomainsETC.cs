using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class DomainsETC : IEntityTypeConfiguration<Domains>
    {
        private const string TYPE_OF_INVESTMENT = "Tipos de Proyectos de Inversión - REP";
        private const string CURRENCY = "CURRENCY-REP";
        public void Configure(EntityTypeBuilder<Domains> builder)
        {
            // Generación tabla: DOMAINS
            builder.ToTable("DOMAINS", "WHOUSE").HasKey(i => new { i.PaisId, i.TypeDomain, i.DomainId });
            builder.Property(i => i.TypeDomain).HasColumnName("TYPE_DOMAIN");
            builder.Property(i => i.DomainId).HasColumnName("DOMAIN_ID");
            builder.Property(i => i.DomainDescriptionSh).HasColumnName("DOMAIN_DESCRIPTION_SH");
            builder.Property(i => i.DomainDescriptionLg).HasColumnName("DOMAIN_DESCRIPTION_LG");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.CreatedDate).HasColumnName("CREATED_DATE");
            builder.Property(i => i.ModifyBy).HasColumnName("MODIFY_BY");
            builder.Property(i => i.ModifyDate).HasColumnName("MODIFY_DATE");
            builder.Property(i => i.Orden).HasColumnName("ORDEN");

            builder.HasDiscriminator(i => i.TypeDomain)
                    .HasValue<TypeOfInvestment>(TYPE_OF_INVESTMENT);

            builder.HasDiscriminator(i => i.TypeDomain)
                    .HasValue<Currencies>(CURRENCY);
        }
    }
}
