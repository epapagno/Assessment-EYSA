using GraphQL.Types;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.InputTypes
{
    public class AllergenInputType : InputObjectGraphType<Allergen>
    {
        public AllergenInputType()
        {
            Name = "AllergenInput";
            Field(i => i.Id);
            Field(i => i.Name);
        }
    }
}
