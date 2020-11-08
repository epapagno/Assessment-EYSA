using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Common.Domain.Entities;

namespace Common.DataAccess.Configuration
{
    public class DishETC : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)  
        {
            builder.ToTable("Dish").HasKey(i => new { i.Id});
            builder.Property("Id");
            builder.Property("Name");
        }
    }
}
