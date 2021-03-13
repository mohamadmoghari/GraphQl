using GraphQl.Types;
using GraphQL.Types;
using GraphTest.Repository;

namespace GraphQl
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IProductRepository repository)
        {
            Field<ListGraphType<ProductGraphType>>(
                "products",
                resolve: context => repository.GetAll());
        }
    }
}