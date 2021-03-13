using Data.Entites;
using GraphQL.Types;

namespace GraphQl.Types
{
    public class ProductGraphEnumType:EnumerationGraphType<ProductEnum>
    {
        public ProductGraphEnumType()
        {
            Name="ProductType";
            Description="ProductType descriptions";
        }
    }
}