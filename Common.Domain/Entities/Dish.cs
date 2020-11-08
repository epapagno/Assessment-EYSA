﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Domain.Entities
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } 
        public virtual ICollection<DishIngredient> Ingredients { get; set; }
    }
}
