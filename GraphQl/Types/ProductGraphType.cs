using GraphQL.Types;
using GraphTest.Data.Entites;

namespace GraphQl.Types
{
    public class ProductGraphType:ObjectGraphType<ProductModel>
    {
        public ProductGraphType()
        {
            Field(t=>t.Id,type:typeof(IdGraphType));
            Field(t=>t.Name,type:typeof(StringGraphType));
            Field(t=>t.Family,type:typeof(StringGraphType));
        }
    }
}