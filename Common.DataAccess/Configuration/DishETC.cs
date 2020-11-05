using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class DishIngredientETC : IEntityTypeConfiguration<DishIngredient>
    {
        public void Configure(EntityTypeBuilder<DishIngredient> builder)  
        {
            builder.ToTable("DishIngredient").HasKey(i => new { i.DishId, i.IngredientId});
            builder.Property("DishId");
            builder.Property("IngredientId");

            /*builder.HasOne(i => i.Dish)
                .WithOne(i => i.Ingr)
                .HasForeignKey(i => new { i.PaisId, i.CharTypeId });*/
        }
    }
}
