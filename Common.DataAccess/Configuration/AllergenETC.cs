using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class AllergenETC : IEntityTypeConfiguration<Allergen>
    {
        public void Configure(EntityTypeBuilder<Allergen> builder)  
        {
            builder.ToTable("Allergen").HasKey(i => new { i.Id });
            builder.Property("Id");
            builder.Property("Name");
        }
    }
}
