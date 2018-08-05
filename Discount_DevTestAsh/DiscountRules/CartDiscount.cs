using DiscountDevTestAsh.Model;
using DiscountDevTestAsh.Services;

namespace DiscountDevTestAsh.DiscountRules
{
    /// <summary>
    /// Calculate cart discount
    /// </summary>
    class CartDiscount : ICartDiscount
    {
        /// <summary>
        /// Calculate cart discount: add free item if cart item count is 10 or more.
        /// </summary>
        /// <param name="cart">Cart object</param>
        /// <param name="cartService">CartService object</param>
        public void CalcDicount(Cart cart, ICartService cartService)
        {
            try
            {
                //Rule: add free item if count is 10 or more.
                if (cart.LineItems.Count >= 10)
                {                    
                    cartService.AddFreeCartItem(10, 1);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
