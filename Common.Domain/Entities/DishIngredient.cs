using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Domain.Entities
{
    public class DishIngredient
    {
        [Key, Column(Order =1)]
        public int DishId { get; set; }
        [Key, Column(Order = 2)]
        public int IngredientId { get; set; }
        public virtual Dish Dish { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
