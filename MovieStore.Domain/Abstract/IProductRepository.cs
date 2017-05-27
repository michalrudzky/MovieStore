using System.Collections.Generic;
using MovieStore.Domain.Entities;

namespace MovieStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
