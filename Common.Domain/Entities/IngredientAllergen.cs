using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Domain.Entities
{
    public class IngredientAllergen
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        public int AllergenId { get; set; }
        public int IngredientId { get; set; }
        public virtual Allergen Allergen { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
