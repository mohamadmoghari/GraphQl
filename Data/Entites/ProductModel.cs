using Data.Entites;

namespace GraphTest.Data.Entites
{
    public class ProductModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public ProductEnum ProductType { get; set; }

    }
}