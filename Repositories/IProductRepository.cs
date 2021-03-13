using System.Collections.Generic;
using GraphTest.Data.Entites;

namespace GraphTest.Repository
{
    public interface IProductRepository
    {
        IList<ProductModel> GetAll();
    }
}