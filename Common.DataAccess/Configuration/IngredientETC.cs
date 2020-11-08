using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class IngredientETC : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)  
        {
            builder.ToTable("Ingredient").HasKey(i => new { i.Id });
            builder.Property("Id");
            builder.Property("Name");
        }
    }
}
