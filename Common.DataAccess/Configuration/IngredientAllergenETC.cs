using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class IngredientAllergenETC : IEntityTypeConfiguration<IngredientAllergen>
    {
        public void Configure(EntityTypeBuilder<IngredientAllergen> builder)  
        {
            builder.ToTable("IngredientAllergen").HasKey(i => new { i.Id });
            builder.Property("AllergenId");
            builder.Property("IngredientId");

            builder.HasOne(i => i.Allergen)
                .WithMany(i => i.Ingredient)
                .HasForeignKey(i => i.AllergenId);

            builder.HasOne(i => i.Ingredient)
            .WithMany(i => i.Allergens)
            .HasForeignKey(i => i.IngredientId);
        }
    }
}
