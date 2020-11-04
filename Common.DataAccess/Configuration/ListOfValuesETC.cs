using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class ListOfValuesETC : IEntityTypeConfiguration<ListOfValues>
    {
        public void Configure(EntityTypeBuilder<ListOfValues> builder)
        {
            builder.ToTable("LIST_OF_VALUES", "CARAC").HasKey(i => new { i.PaisId, i.ListId });
            builder.Property(i => i.ListId).HasColumnName("LIST_ID");
            builder.Property(i => i.Description).HasColumnName("DESCRIPTION");
            builder.Property(i => i.ValueId).HasColumnName("VALUE_ID");
            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Roip).HasColumnName("ROIP");
            builder.Property(i => i.ListIdFather).HasColumnName("LIST_ID_FATHER");
            builder.Property(i => i.CentralizedList).HasColumnName("CENTRALIZED_LIST");            
        }
    }
}
