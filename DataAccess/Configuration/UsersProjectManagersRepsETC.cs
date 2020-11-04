using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class UsersProjectManagersRepsETC : IEntityTypeConfiguration<UsersProjectManagersReps>
    {
        public void Configure(EntityTypeBuilder<UsersProjectManagersReps> builder)
        {
            builder.ToTable("PROJECT_MANAGERS_REPS", "CARAC")
                .HasKey(i => new { i.PaisId, i.Username });

            builder.HasIndex(i => new { i.PaisId, i.Username, i.RepId });
            builder.HasIndex(i => new { i.PaisId, i.Username, i.ProjectManagerId });

            builder.Property(i => i.PaisId).HasColumnName("ID_PAIS");
            builder.Property(i => i.Username).HasColumnName("USERNAME");
            builder.Property(i => i.ProjectManagerId).HasColumnName("PROJECT_MANAGER_ID");
            builder.Property(i => i.RepId).HasColumnName("REP_ID");
        }
    }
}

