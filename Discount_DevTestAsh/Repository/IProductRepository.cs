using DiscountDevTestAsh.Model;
using System.Collections.Generic;

namespace DiscountDevTestAsh.Repository
{
    /// <summary>
    /// Product Repository
    /// </summary>
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void RemoveProduct(int productID);
        List<Product> GetAllProduct();
        Product GetProductByID(int productID);
    }
}
