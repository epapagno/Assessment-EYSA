# Assessment-EYSA
(La base es un proyecto que yo ya habia hecho hace un año aproximadamente)
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

Los Common son aquellos proyectos base que utilizaremos en cada orquestador. No hace falta que sea necesariamente GraphQL sino mas bien la presentacion puede ser de cualquier tipo de servicio. 

La idea es que con los valores devueltos articular el objeto recibido con la informacion que nos interesa averiguar.
Esta preaparado para que se puede serguir trabajando en el servicio, escalando en base a la informacion que se requiera.
