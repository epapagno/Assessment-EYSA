using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class DishIngredientETC : IEntityTypeConfiguration<DishIngredient>
    {
        public void Configure(EntityTypeBuilder<DishIngredient> builder)  
        {
            builder.ToTable("DishIngredient").HasKey(i => new { i.DishId, i.IngredientId });

            builder.HasOne(i => i.Dish)
                .WithMany(i => i.Ingredients)
                .HasForeignKey(i => i.DishId);

            builder.HasOne(i => i.Ingredient)
            .WithMany(i => i.Dishes)
            .HasForeignKey(i => i.IngredientId);
        }
    }
}
