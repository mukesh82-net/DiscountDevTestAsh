using DiscountDevTestAsh.Model;
using DiscountDevTestAsh.Repository;
using System.Linq;

namespace DiscountDevTestAsh.Services
{
    /// <summary>
    /// Cart service that mediator between repo and UI
    /// </summary>
    public class CartService : ICartService
    {

        private readonly IProductRepository _productRepository;
        private readonly ICartRepository _cartRepository;

        public CartService()
        {
            //_productRepository = new ProductRepository();
            //_cartRepository = new CartRepository();
        }

        public CartService(string repositoryType)
        {
            if (repositoryType == "Fake")
            {
                _productRepository = new FakeProductRepository();
                _cartRepository = new FakeCartRepository();
            }
        }

        /// <summary>
        /// Create new cart of the user.
        /// </summary>
        /// <returns>Cart ID</returns>
        public int CreateCartNew()
        {
            return _cartRepository.CreateCartNew();
        }

        /// <summary>
        /// Add free item to cart
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <param name="quantity">Quantity</param>
        public void AddFreeCartItem(int productID, int quantity)
        {
            try
            {
                var mProduct = _productRepository.GetProductByID(productID);
                var mLineItem = new LineItem()
                {
                    ProductID = productID,
                    Quantity = quantity,
                    LineItemType = LineItem.LineItemTypes.FreeItem
                };

                _cartRepository.AddCartItem(mLineItem);
            }
            catch (System.Exception ex)
            {
                //Log ex

                //re-throw new custom exception to User.
                throw new System.Exception("Error while processing discount to cart");
            }
        }

        /// <summary>
        /// Add new item to cart
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <param name="quantity">Quantity</param>
        public void AddCartItem(int productID, int quantity)
        {
            try
            {
                var mProduct = _productRepository.GetProductByID(productID);
                var mLineItem = new LineItem()
                {
                    ProductID = productID,
                    Quantity = quantity,
                    Price = mProduct.Price,
                    Cost = mProduct.Price * quantity
                };

                if (mProduct.IDiscount != null)
                {
                    mProduct.IDiscount.CalcDicount(mLineItem);
                }
                _cartRepository.AddCartItem(mLineItem);
            }
            catch (System.Exception ex)
            {
                //Log ex

                //re-throw new custom exception to User.
                throw new System.Exception("Error while adding item to cart");
            }

        }

        /// <summary>
        /// Check out cart
        /// </summary>
        /// <param name="cartID">CartID</param>
        /// <returns>Cart object</returns>
        public Cart CheckOutCart(int cartID)
        {
            try
            {
                Cart mCart = _cartRepository.GetCartByID(cartID);
                if (mCart.ICartDiscount != null)
                    mCart.ICartDiscount.CalcDicount(mCart, this);
                mCart.CartDiscountTotal += mCart.LineItems.Sum(s => s.Discount);
                mCart.CartTotal = mCart.LineItems.Sum(s => s.Cost);

                return mCart;
            }
            catch (System.Exception ex)
            {
                //Log ex

                //re-throw new custom exception to User.
                throw new System.Exception("Error while checking out cart");
            }
        }        
    }
}
