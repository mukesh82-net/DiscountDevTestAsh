using System;
using System.Collections.Generic;
using System.Linq;
using DiscountDevTestAsh.DiscountRules;
using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.Repository
{
    /// <summary>
    /// Fake  product repo.
    /// </summary>
    public class FakeProductRepository : IProductRepository
    {
        List<Product> _products = new List<Product>();

        public FakeProductRepository()
        {
            _products.Add(new Product() { ProductID = 1, Name = "Flat_1", Price = 100, IDiscount = new FlatDiscount() });
            _products.Add(new Product() { ProductID = 2, Name = "Perc_2", Price = 200, IDiscount = new PercetageDiscount() });
            _products.Add(new Product() { ProductID = 3, Name = "AAA_3", Price = 300 });
            _products.Add(new Product() { ProductID = 4, Name = "Flat_4", Price = 400, IDiscount = new FlatDiscount() });
            _products.Add(new Product() { ProductID = 5, Name = "Group_5", Price = 500, IDiscount = new GroupDiscount() });
            _products.Add(new Product() { ProductID = 6, Name = "AAA_6", Price = 600 });
            _products.Add(new Product() { ProductID = 7, Name = "AAA_7", Price = 700 });
            _products.Add(new Product() { ProductID = 8, Name = "Perc_8", Price = 800, IDiscount = new PercetageDiscount() });
            _products.Add(new Product() { ProductID = 9, Name = "Group_9", Price = 900, IDiscount = new GroupDiscount() });
            _products.Add(new Product() { ProductID = 10, Name = "AAA_10", Price = 1000 });
        }

        /// <summary>
        /// Add product to Repo.
        /// </summary>
        /// <param name="product">product object</param>
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Remove product by ProductID
        /// </summary>
        /// <param name="productID">productID</param>
        public void RemoveProduct(int productID)
        {
            try
            {
                var mProduct = _products.Where(c => c.ProductID == productID).FirstOrDefault();
                _products.Remove(mProduct);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get all product
        /// </summary>
        /// <returns>List of Product</returns>
        public List<Product> GetAllProduct()
        {
            return _products;
        }

        /// <summary>
        /// Get product by ID
        /// </summary>
        /// <param name="productID">productID</param>
        /// <returns>Project object</returns>
        public Product GetProductByID(int productID)
        {
            try
            {
                return _products.Where(c => c.ProductID == productID).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
