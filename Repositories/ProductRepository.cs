using System.Collections.Generic;
using GraphTest.Data;
using GraphTest.Data.Entites;

namespace GraphTest.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IList<ProductModel> GetAll()
        {
            return InitalData.CreateData();
        }
    }
}