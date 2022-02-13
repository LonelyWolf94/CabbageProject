using CabbageProject.BusinessLogic;
using System.Collections.Generic;

namespace CabbageProject.Data
{
    public class Data
    {
        public static List<Product> Products = new List<Product>
        {
            new Vegetable
            {
                Name = "Cabbage",
                Price = 0.4
            },
            new Product
            {
                Name = "Banana",
                Category = (int)Category.Fruits,
                Price = 0.5
            },
            new Product
            {
                Name = "Sandora",
                Category = (int)Category.Juices,
                Price = 1
            }
        };
    }
}
