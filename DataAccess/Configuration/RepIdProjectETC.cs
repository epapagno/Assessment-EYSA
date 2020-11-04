using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WH.Common.Domain.Entities;

namespace WH.Common.DataAccess.Configuration
{
    public class RepIdProjectETC : IEntityTypeConfiguration<RepIdProject>
    {
        public void Configure(EntityTypeBuilder<RepIdProject> builder)
        {
            // Generación tabla: REP_ID_PROJECT
            builder.ToTable("REP_ID_PROJECT", "REP").HasKey(i => new { i.IdProject });
            builder.Property(i => i.IdProject).HasColumnName("ID_PROJECT");
            builder.Property(i => i.Associated).HasColumnName("ASSOCIATED")
                .HasConversion(i => i ? "S" : "N", i => i == "S" || i == "Y");
            builder.Property(i => i.CreationDate).HasColumnName("CREATION_DATE");
            builder.Property(i => i.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(i => i.UpdatedDate).HasColumnName("UPDATED_DATE");
            builder.Property(i => i.UpdatedBy).HasColumnName("UPDATED_BY");
        }
    }
}
