using System.Collections.Generic;
using GraphTest.Data.Entites;

namespace GraphTest.Data
{
    public static class InitalData
    {
        public static List<ProductModel> CreateData()
        {
            var list=new List<ProductModel>{
                new ProductModel{
                    Id=1,
                    Name="name 1",
                    Family="family 1"
                },
                new ProductModel{
                    Id=2,
                    Name="name 2",
                    Family="family 2"
                },
                new ProductModel{
                    Id=3,
                    Name="name 3",
                    Family="family 3"
                },
            };

            return list;
        }
    }
}