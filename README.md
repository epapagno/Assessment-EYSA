# Assessment-EYSA
Api GraphQL
Dado el Plato 1 => Traer los alergenos de los ingredientes del mismo:
EX:

query{
  dish(id: 1){
    name,
    ingredients{
      ingredientId,
      ingredient{
        allergens{
          allergen{
            id,
            name
          }
        }
      }
    }
  }
}
