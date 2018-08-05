using System;
using System.Collections.Generic;
using DiscountDevTestAsh.DiscountRules;
using DiscountDevTestAsh.Model;

namespace DiscountDevTestAsh.Repository
{
    /// <summary>
    /// Fake Cart repo.
    /// </summary>
    public class FakeCartRepository : ICartRepository
    {
        Cart _cart;
        
        public int CreateCartNew()
        {
            _cart = new Cart
            {
                LineItems = new List<LineItem>(),
                CartID = 101,
                ICartDiscount = new CartDiscount()
            };

            return 101;
        }

        /// <summary>
        /// Add item to cart.
        /// </summary>
        /// <param name="lineItem">LineItem object</param>
        public void AddCartItem(LineItem lineItem)
        {
            try
            {
                _cart.LineItems.Add(lineItem);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Remove item from cart.
        /// </summary>
        /// <param name="productID">productID</param>
        public void RemoveCartItem(int productID)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get Cart by ID
        /// </summary>
        /// <param name="cartID">cartID</param>
        /// <returns>Cart object</returns>
        public Cart GetCartByID(int cartID)
        {
            return _cart;
        }        
    }
}
